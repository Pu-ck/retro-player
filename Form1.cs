using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Drawing.Text;

namespace RetroPlayer
{
    public partial class Form1 : Form
    {
        private bool isFavourite = false;
        private bool isPlaying = false;
        private bool isStopped = false;
        private bool isLooped = false;
        private bool isRandom = false;
        private bool mouseDown;

        private Point lastLocation;

        private string filePath = "favourite_list.txt";
        private string currentTrackPath;

        private int currentTrack = 0;
        private int nextIndex = 0;

        CancellationTokenSource tokenSource = new CancellationTokenSource();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            clock.Interval = 1000;
            clock.Enabled = true;
        }

        // Loading Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set default cover art 
            pictureBoxCoverArt.Image = Image.FromFile("cover_art.jpg");

            // Add favourite tracks form .txt file at startup 
            foreach (string line in System.IO.File.ReadLines(filePath))
            {
                // Add track to listbox with favourite tracks 
                string item = Path.GetFileName(line).Replace(".wav", "");
                listBoxFavouriteTracks.Items.Add(item);
            }

            // Set first track on favourite tracks listbox as default
            try
            {
                listBoxFavouriteTracks.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        // Drawing labels: date, time and current track length
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            labelDateTime.Text = currentTime.ToString();
            DateTime trackRunTime = new DateTime();

            // Draw time of currently played track
            if (isPlaying == true)
            {
                labelTrackCurrentTime.Text = trackRunTime.AddSeconds(currentTrack).ToString("mm:ss");
                currentTrack++;
            }
            else if (isPlaying == false)
            {
                currentTrack = 0;
                labelTrackCurrentTime.Text = "00:00";
                labelTrackTime.Text = "00:00";
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        // Main method for playing audio files
        private void PlayAudio(bool fromButtonClick, int index, bool fromFavourites = false)
        {
            ListBox choosenListbox = listBoxTracksList;
            string trackPath = "";

            // Choose listbox 
            if (fromFavourites == false)
            {
                trackPath = folderBrowserDialog1.SelectedPath;
                choosenListbox = listBoxTracksList;
            }
            else if (fromFavourites == true)
            {
                if (listBoxFavouriteTracks.Items.Count > 0)
                {
                    int selectedIndex = listBoxFavouriteTracks.SelectedIndex;
                    var linesRead = File.ReadLines(filePath);
                    int line = 0;

                    foreach (var lineRead in linesRead)
                    {
                        if (line == selectedIndex)
                        {
                            trackPath = lineRead;
                            trackPath = Path.GetDirectoryName(trackPath);
                            choosenListbox = listBoxFavouriteTracks;
                        }
                        line++;
                    }
                }
            }

            // Local method - play by play/stop button click or listbox item double click
            async void PlayChoosen()
            {
                var trackList = choosenListbox.Items.Cast<String>().ToList();
                index = choosenListbox.SelectedIndex;

                // Iterate over tracks in choosen listbox 
                foreach (var track in trackList.Skip(index))
                {
                // Do while loop didn't work good in this case and only goto provided a good enough solution without writing too much code
                loop:
                    player.SoundLocation = trackPath + "\\" + track + ".wav";

                    try
                    {
                        player.Play();
                    }
                    catch (FileNotFoundException)
                    {
                        break;
                    }

                    currentTrackPath = trackPath + "\\" + track + ".wav";
                    labelTrackName.Visible = true;
                    labelTrackName.Text = "Now playing: " + track;
                    buttonPlay.Text = "☻";

                    buttonAddToFavourite.Visible = true;

                    // Check if track is added to favourite 
                    if (File.Exists(filePath))
                    {
                        using (StreamReader sr = File.OpenText(filePath))
                        {
                            if (File.ReadAllText(filePath).Contains(currentTrackPath))
                            {
                                buttonAddToFavourite.ForeColor = Color.Red;
                                isFavourite = true;
                                sr.Close();
                            }
                            else
                            {
                                buttonAddToFavourite.ForeColor = Color.FromArgb(255, 192, 255);
                                isFavourite = false;
                                sr.Close();
                            }
                        }
                    }

                    // Calculate audio file byte rate to determine track length
                    byte[] allBytes = File.ReadAllBytes(trackPath + "\\" + track + ".wav");
                    int byteRate = BitConverter.ToInt32(new[] { allBytes[28], allBytes[29], allBytes[30], allBytes[31] }, 0);

                    // Draw track length
                    TimeSpan time = TimeSpan.FromSeconds((allBytes.Length - 8) / byteRate);
                    string trackLength = time.ToString(@"mm\:ss");
                    labelTrackTime.Text = trackLength;

                    // Cancel task if stop button is pressed
                    try
                    {
                        await Task.Delay(((allBytes.Length - 8) / byteRate) * 1000, tokenSource.Token);
                    }
                    catch (TaskCanceledException)
                    {
                        break;
                    }

                    // Highlight another track on list when it's played
                    if (isLooped == false)
                    {
                        try
                        {
                            index = choosenListbox.Items.IndexOf(track);
                            choosenListbox.SelectedIndex = index + 1;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            break;
                        }
                    }

                    labelTrackCurrentTime.Text = "00:00";
                    labelTrackTime.Text = "00:00";
                    currentTrack = 0;

                    // Go to next iteration or loop/break current iteration
                    if (isLooped == true)
                    {
                        goto loop;
                    }
                    else if (isRandom == true)
                    {
                        break;
                    }
                }

                buttonAddToFavourite.Visible = false;
                labelTrackName.Visible = false;
                labelTrackName.Text = "";
                buttonPlay.Text = "☺";
                isPlaying = false;

                // Play random track
                if (isRandom == true && isStopped == false && tokenSource.IsCancellationRequested == false)
                {
                    Random rand = new Random();
                    int offset = rand.Next(-index, choosenListbox.Items.Count - index);

                    if (fromFavourites == true)
                    {
                        ChangeTrack(offset, choosenListbox, true);
                    }
                    else if (fromFavourites == false)
                    {
                        ChangeTrack(offset, choosenListbox);
                    }
                }
            }

            // Play track by play/stop button
            if (choosenListbox.Items.Count > 0 && isPlaying == false && fromButtonClick == true && choosenListbox.SelectedIndex >= 0)
            {
                isPlaying = true;
                isStopped = false;
                PlayChoosen();
            }
            // Play track by listbox item double click
            else if (fromButtonClick == false)
            {
                // Cancel current task if new track is played by double click
                tokenSource.Cancel();
                tokenSource.Dispose();
                tokenSource = new CancellationTokenSource();

                isPlaying = true;
                isStopped = false;

                labelTrackCurrentTime.Text = "00:00";
                labelTrackTime.Text = "00:00";
                currentTrack = 0;
                PlayChoosen();
            }
            // Stop playback
            else if (choosenListbox.Items.Count > 0 && isPlaying == true && fromButtonClick == true)
            {
                // Cancel current task
                tokenSource.Cancel();
                tokenSource.Dispose();
                tokenSource = new CancellationTokenSource();

                player.Stop();
                isPlaying = false;
                isStopped = true;

                labelTrackName.Visible = false;
                labelTrackName.Text = "";
                buttonPlay.Text = "☺";

                buttonAddToFavourite.Visible = false;
            }
        }

        // Choose directory with audio files
        private void buttonBrowseTracks_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                listBoxTracksList.Items.Clear();

                string trackPath = folderBrowserDialog1.SelectedPath;
                DirectoryInfo directory = new DirectoryInfo(trackPath);

                // Add .wav files to list box 
                foreach (var file in directory.GetFiles("*.wav"))
                {
                    listBoxTracksList.Items.Add(file.Name.Replace(".wav", ""));
                }

                // Set cover art, from directory or default
                pictureBoxCoverArt.Image = Image.FromFile("cover_art.jpg");
                foreach (var file in directory.GetFiles("*.jpg"))
                {
                    try
                    {
                        pictureBoxCoverArt.Image = Image.FromFile(file.ToString());
                    }
                    catch
                    {
                        pictureBoxCoverArt.Image = Image.FromFile("cover_art.jpg");
                    }
                }
                foreach (var file in directory.GetFiles("*.png"))
                {
                    try
                    {
                        pictureBoxCoverArt.Image = Image.FromFile(file.ToString());
                    }
                    catch
                    {
                        pictureBoxCoverArt.Image = Image.FromFile("cover_art.jpg");
                    }
                }

                // Set first track as default  
                try
                {
                    listBoxTracksList.SelectedIndex = 0;
                }
                catch
                {
                }
            }
        }

        // Play track from current list by play/stop button
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            // Play track from standard list
            if (listBoxTracksList.Visible == true)
            {
                PlayAudio(true, 0);
            }
            // Play track from favourite list
            else if (listBoxFavouriteTracks.Visible == true)
            {
                PlayAudio(true, 0, true);
            }
        }

        // Play track from current list by double click
        private void listBoxTracksList_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxTracksList.Items.Count > 0 && listBoxTracksList.SelectedIndex >= 0 && listBoxTracksList.Visible == true)
            {
                isStopped = true;
                PlayAudio(false, 0);
            }
        }

        // Play track from favourite list by double click
        private void listBoxFavouriteTracks_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxFavouriteTracks.Items.Count > 0 && listBoxFavouriteTracks.SelectedIndex >= 0 && listBoxFavouriteTracks.Visible == true)
            {
                isStopped = true;
                PlayAudio(false, 0, true);
            }
        }

        // Change track to next or previous one from the current listbox
        private void ChangeTrack(int direction, ListBox listbox, bool from_favourites = false)
        {
            tokenSource.Cancel();
            tokenSource.Dispose();
            tokenSource = new CancellationTokenSource();

            player.Stop();

            labelTrackCurrentTime.Text = "00:00";
            labelTrackTime.Text = "00:00";
            currentTrack = 0;

            nextIndex = listbox.SelectedIndex + direction;

            try
            {
                listbox.SelectedIndex = listbox.SelectedIndex + direction;
                if (listbox.SelectedIndex < 0)
                {
                    listbox.SelectedIndex = 0;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
            }

            if (from_favourites == false)
            {
                PlayAudio(true, nextIndex);
            }
            else if (from_favourites == true)
            {
                PlayAudio(true, nextIndex, true);
            }
        }

        // Next track button click event
        private void buttonNextTrack_Click(object sender, EventArgs e)
        {
            // Play track from standard listbox
            if (listBoxTracksList.Visible == true)
            {
                ChangeTrack(1, listBoxTracksList);
            }
            // Play track from favourite listbox
            else if (listBoxFavouriteTracks.Visible == true)
            {
                ChangeTrack(1, listBoxFavouriteTracks, true);
            }
        }

        // Previous track button click event
        private void buttonPreviousTrack_Click(object sender, EventArgs e)
        {
            // Play track from standard listbox
            if (listBoxTracksList.Visible == true)
            {
                ChangeTrack(-1, listBoxTracksList);
            }
            // Play track from favourite listbox
            else if (listBoxFavouriteTracks.Visible == true)
            {
                ChangeTrack(-1, listBoxFavouriteTracks, true);
            }
        }

        // Loop playback
        private void buttonLoop_Click(object sender, EventArgs e)
        {
            if (isLooped == false)
            {
                isLooped = true;
                buttonLoop.ForeColor = Color.White;
            }
            else
            {
                isLooped = false;
                buttonLoop.ForeColor = Color.FromArgb(255, 192, 255);
            }
        }

        // Randomize playback
        private void buttonPlayRandom_Click(object sender, EventArgs e)
        {
            if (isRandom == false)
            {
                isRandom = true;
                buttonPlayRandom.ForeColor = Color.White;
            }
            else if (isRandom == true)
            {
                isRandom = false;
                buttonPlayRandom.ForeColor = Color.FromArgb(255, 192, 255);
            }
        }

        // Add track to favourite
        private void buttonAddToFavourite_Click(object sender, EventArgs e)
        {
            if (isFavourite == false)
            {
                isFavourite = true;
                buttonAddToFavourite.ForeColor = Color.Red;
                ModifyFavourite(currentTrackPath, true);
            }
            else
            {
                isFavourite = false;
                buttonAddToFavourite.ForeColor = Color.FromArgb(255, 192, 255);
                ModifyFavourite(currentTrackPath, false);
            }
        }

        // Add track path to favourite.txt file 
        private void ModifyFavourite(string trackPath, bool add)
        {
            string item;

            if (!File.Exists(filePath))
            {
                File.CreateText(filePath);
            }

            // Add track to listbox with favourite tracks 
            if (add == true)
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    if (File.ReadAllText(filePath).Contains(trackPath))
                    {
                        sr.Close();
                    }
                    else
                    {
                        sr.Close();
                        using (StreamWriter sw = File.AppendText(filePath))
                        {
                            sw.WriteLine(trackPath);
                            item = Path.GetFileName(trackPath).Replace(".wav", "");
                            listBoxFavouriteTracks.Items.Add(item);
                        }
                    }
                }
            }
            // Remove track from listbox with favourite tracks 
            else if (add == false)
            {
                string oldFile;
                string appended = "";
                StreamReader sr = File.OpenText(filePath);
                while ((oldFile = sr.ReadLine()) != null)
                {
                    if (!oldFile.Contains(trackPath))
                    {
                        appended += oldFile + Environment.NewLine;
                    }
                    else
                    {
                        item = Path.GetFileName(trackPath).Replace(".wav", "");
                        listBoxFavouriteTracks.Items.Remove(item);

                        try
                        {
                            listBoxFavouriteTracks.SelectedIndex = 0;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            break;
                        }
                    }
                }
                sr.Close();
                File.WriteAllText(filePath, appended);
            }
        }

        // Switch between listboxes
        private void buttonSwitchListbox_Click(object sender, EventArgs e)
        {
            if (listBoxTracksList.Visible == true)
            {
                listBoxFavouriteTracks.Visible = true;
                listBoxTracksList.Visible = false;
                buttonRemoveTrack.Visible = true;
                buttonSwitchListbox.Text = "♫";
            }
            else if (listBoxTracksList.Visible == false)
            {
                try
                {
                    listBoxFavouriteTracks.SelectedIndex = 0;
                }
                catch (ArgumentOutOfRangeException)
                {
                }
                listBoxFavouriteTracks.Visible = false;
                buttonRemoveTrack.Visible = false;
                listBoxTracksList.Visible = true;
                buttonSwitchListbox.Text = "♥";
            }
        }

        // Remove track from listbox with favourite tracks and update favourite_list.txt
        private void buttonRemoveTrack_Click(object sender, EventArgs e)
        {
            if (listBoxFavouriteTracks.Items.Count > 0 && listBoxFavouriteTracks.SelectedIndex >= 0)
            {
                int selectedIndex = listBoxFavouriteTracks.SelectedIndex;
                listBoxFavouriteTracks.Items.RemoveAt(selectedIndex);

                StreamReader sr = File.OpenText(filePath);

                string appended = "";
                string oldFile;
                int line = 0;

                while ((oldFile = sr.ReadLine()) != null)
                {
                    if (line != selectedIndex)
                    {
                        appended += oldFile + Environment.NewLine;
                    }
                    else
                    {
                    }
                    line++;
                }
                sr.Close();

                File.WriteAllText(filePath, appended);

                try
                {
                    listBoxFavouriteTracks.SelectedIndex = 0;
                }
                catch (ArgumentOutOfRangeException)
                {
                }

                buttonAddToFavourite.ForeColor = Color.FromArgb(255, 192, 255);
                isFavourite = false;
            }
        }

        // Key events
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.MediaPlayPause)
            {
                // Play track from standard listbox
                if (listBoxTracksList.Visible == true)
                {
                    PlayAudio(true, 0);
                }
                // Play track from favourite listbox
                else if (listBoxFavouriteTracks.Visible == true)
                {
                    PlayAudio(true, 0, true);
                }
            }
            if (e.KeyData == Keys.MediaNextTrack)
            {
                // Play track from standard listbox
                if (listBoxTracksList.Visible == true)
                {
                    ChangeTrack(1, listBoxTracksList);
                }
                // Play track from favourite listbox
                else if (listBoxFavouriteTracks.Visible == true)
                {
                    ChangeTrack(1, listBoxFavouriteTracks, true);
                }
            }
            if (e.KeyData == Keys.MediaPreviousTrack)
            {
                // Play track from standard listbox
                if (listBoxTracksList.Visible == true)
                {
                    ChangeTrack(-1, listBoxTracksList);
                }
                // Play track from favourite listbox
                else if (listBoxFavouriteTracks.Visible == true)
                {
                    ChangeTrack(-1, listBoxFavouriteTracks, true);
                }
            }
        }

        // Mouse events - dragging window
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        // Exit application
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize application
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Visual events for controls
        #region Visual events for controls
        private void buttonAddToFavourite_MouseHover(object sender, EventArgs e)
        {
            if (isFavourite == false)
            {
                buttonAddToFavourite.ForeColor = Color.Red;
            }
        }

        private void buttonAddToFavourite_MouseLeave(object sender, EventArgs e)
        {
            if (isFavourite == false)
            {
                buttonAddToFavourite.ForeColor = Color.FromArgb(255, 192, 255);
            }
        }

        private void buttonLoop_MouseHover(object sender, EventArgs e)
        {
            if (isLooped == false)
            {
                buttonLoop.ForeColor = Color.White;
            }
        }

        private void buttonLoop_MouseLeave(object sender, EventArgs e)
        {
            if (isLooped == false)
            {
                buttonLoop.ForeColor = Color.FromArgb(255, 192, 255);
            }
        }

        private void buttonPlayRandom_MouseHover(object sender, EventArgs e)
        {
            if (isRandom == false)
            {
                buttonPlayRandom.ForeColor = Color.White;
            }
        }

        private void buttonPlayRandom_MouseLeave(object sender, EventArgs e)
        {
            if (isRandom == false)
            {
                buttonPlayRandom.ForeColor = Color.FromArgb(255, 192, 255);
            }
        }
        private void buttonPlay_MouseHover(object sender, EventArgs e)
        {
            buttonPlay.ForeColor = Color.White;
        }

        private void buttonPlay_MouseLeave(object sender, EventArgs e)
        {
            buttonPlay.ForeColor = Color.FromArgb(255, 192, 255);
        }

        private void buttonNextTrack_MouseHover(object sender, EventArgs e)
        {
            buttonNextTrack.ForeColor = Color.White;
        }

        private void buttonNextTrack_MouseLeave(object sender, EventArgs e)
        {
            buttonNextTrack.ForeColor = Color.FromArgb(255, 192, 255);
        }

        private void buttonPreviousTrack_MouseHover(object sender, EventArgs e)
        {
            buttonPreviousTrack.ForeColor = Color.White;
        }

        private void buttonPreviousTrack_MouseLeave(object sender, EventArgs e)
        {
            buttonPreviousTrack.ForeColor = Color.FromArgb(255, 192, 255);
        }
        #endregion
    }
}