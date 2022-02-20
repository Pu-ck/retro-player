
namespace RetroPlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonBrowseTracks = new System.Windows.Forms.Button();
            this.buttonPreviousTrack = new System.Windows.Forms.Button();
            this.buttonNextTrack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxFavouriteTracks = new System.Windows.Forms.ListBox();
            this.listBoxTracksList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTrackName = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxCoverArt = new System.Windows.Forms.PictureBox();
            this.labelTrackCurrentTime = new System.Windows.Forms.Label();
            this.labelTrackTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoop = new System.Windows.Forms.Button();
            this.buttonPlayRandom = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddToFavourite = new System.Windows.Forms.Button();
            this.buttonSwitchListbox = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRemoveTrack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverArt)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Black;
            this.buttonPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Px437 IBM BIOS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonPlay.Location = new System.Drawing.Point(226, 385);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(49, 45);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "☺";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            this.buttonPlay.MouseLeave += new System.EventHandler(this.buttonPlay_MouseLeave);
            this.buttonPlay.MouseHover += new System.EventHandler(this.buttonPlay_MouseHover);
            // 
            // buttonBrowseTracks
            // 
            this.buttonBrowseTracks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonBrowseTracks.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonBrowseTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseTracks.Font = new System.Drawing.Font("Px437 IBM BIOS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowseTracks.Location = new System.Drawing.Point(479, 390);
            this.buttonBrowseTracks.Name = "buttonBrowseTracks";
            this.buttonBrowseTracks.Size = new System.Drawing.Size(47, 27);
            this.buttonBrowseTracks.TabIndex = 5;
            this.buttonBrowseTracks.Text = ":\\";
            this.buttonBrowseTracks.UseVisualStyleBackColor = false;
            this.buttonBrowseTracks.Click += new System.EventHandler(this.buttonBrowseTracks_Click);
            // 
            // buttonPreviousTrack
            // 
            this.buttonPreviousTrack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPreviousTrack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonPreviousTrack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonPreviousTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousTrack.Font = new System.Drawing.Font("Px437 IBM BIOS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreviousTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonPreviousTrack.Location = new System.Drawing.Point(180, 390);
            this.buttonPreviousTrack.Name = "buttonPreviousTrack";
            this.buttonPreviousTrack.Size = new System.Drawing.Size(40, 35);
            this.buttonPreviousTrack.TabIndex = 7;
            this.buttonPreviousTrack.Text = "←";
            this.buttonPreviousTrack.UseVisualStyleBackColor = true;
            this.buttonPreviousTrack.Click += new System.EventHandler(this.buttonPreviousTrack_Click);
            this.buttonPreviousTrack.MouseLeave += new System.EventHandler(this.buttonPreviousTrack_MouseLeave);
            this.buttonPreviousTrack.MouseHover += new System.EventHandler(this.buttonPreviousTrack_MouseHover);
            // 
            // buttonNextTrack
            // 
            this.buttonNextTrack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonNextTrack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonNextTrack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonNextTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextTrack.Font = new System.Drawing.Font("Px437 IBM BIOS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNextTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonNextTrack.Location = new System.Drawing.Point(281, 390);
            this.buttonNextTrack.Name = "buttonNextTrack";
            this.buttonNextTrack.Size = new System.Drawing.Size(40, 35);
            this.buttonNextTrack.TabIndex = 6;
            this.buttonNextTrack.Text = "→";
            this.buttonNextTrack.UseVisualStyleBackColor = true;
            this.buttonNextTrack.Click += new System.EventHandler(this.buttonNextTrack_Click);
            this.buttonNextTrack.MouseLeave += new System.EventHandler(this.buttonNextTrack_MouseLeave);
            this.buttonNextTrack.MouseHover += new System.EventHandler(this.buttonNextTrack_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.listBoxFavouriteTracks);
            this.panel1.Controls.Add(this.listBoxTracksList);
            this.panel1.Location = new System.Drawing.Point(479, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 325);
            this.panel1.TabIndex = 15;
            // 
            // listBoxFavouriteTracks
            // 
            this.listBoxFavouriteTracks.BackColor = System.Drawing.Color.Black;
            this.listBoxFavouriteTracks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFavouriteTracks.Font = new System.Drawing.Font("Px437 IBM BIOS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxFavouriteTracks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBoxFavouriteTracks.FormattingEnabled = true;
            this.listBoxFavouriteTracks.Location = new System.Drawing.Point(3, 3);
            this.listBoxFavouriteTracks.Name = "listBoxFavouriteTracks";
            this.listBoxFavouriteTracks.Size = new System.Drawing.Size(408, 299);
            this.listBoxFavouriteTracks.TabIndex = 1;
            this.listBoxFavouriteTracks.Visible = false;
            this.listBoxFavouriteTracks.DoubleClick += new System.EventHandler(this.listBoxFavouriteTracks_DoubleClick);
            // 
            // listBoxTracksList
            // 
            this.listBoxTracksList.BackColor = System.Drawing.Color.Black;
            this.listBoxTracksList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTracksList.Font = new System.Drawing.Font("Px437 IBM BIOS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTracksList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBoxTracksList.FormattingEnabled = true;
            this.listBoxTracksList.Location = new System.Drawing.Point(3, 3);
            this.listBoxTracksList.Name = "listBoxTracksList";
            this.listBoxTracksList.Size = new System.Drawing.Size(408, 299);
            this.listBoxTracksList.TabIndex = 0;
            this.listBoxTracksList.DoubleClick += new System.EventHandler(this.listBoxTracksList_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(375, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 325);
            this.panel2.TabIndex = 16;
            // 
            // labelTrackName
            // 
            this.labelTrackName.Font = new System.Drawing.Font("Px437 IBM BIOS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrackName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelTrackName.Location = new System.Drawing.Point(79, 21);
            this.labelTrackName.Name = "labelTrackName";
            this.labelTrackName.Size = new System.Drawing.Size(675, 27);
            this.labelTrackName.TabIndex = 3;
            this.labelTrackName.Visible = false;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Px437 IBM BIOS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelDateTime.Location = new System.Drawing.Point(479, 469);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(97, 15);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "label2";
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // pictureBoxCoverArt
            // 
            this.pictureBoxCoverArt.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoverArt.Image")));
            this.pictureBoxCoverArt.Location = new System.Drawing.Point(79, 59);
            this.pictureBoxCoverArt.Name = "pictureBoxCoverArt";
            this.pictureBoxCoverArt.Size = new System.Drawing.Size(340, 322);
            this.pictureBoxCoverArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverArt.TabIndex = 8;
            this.pictureBoxCoverArt.TabStop = false;
            // 
            // labelTrackCurrentTime
            // 
            this.labelTrackCurrentTime.AutoSize = true;
            this.labelTrackCurrentTime.Font = new System.Drawing.Font("Px437 IBM BIOS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrackCurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelTrackCurrentTime.Location = new System.Drawing.Point(162, 433);
            this.labelTrackCurrentTime.Name = "labelTrackCurrentTime";
            this.labelTrackCurrentTime.Size = new System.Drawing.Size(72, 13);
            this.labelTrackCurrentTime.TabIndex = 9;
            this.labelTrackCurrentTime.Text = "00:00";
            // 
            // labelTrackTime
            // 
            this.labelTrackTime.AutoSize = true;
            this.labelTrackTime.Font = new System.Drawing.Font("Px437 IBM BIOS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrackTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelTrackTime.Location = new System.Drawing.Point(266, 433);
            this.labelTrackTime.Name = "labelTrackTime";
            this.labelTrackTime.Size = new System.Drawing.Size(72, 13);
            this.labelTrackTime.TabIndex = 10;
            this.labelTrackTime.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Px437 IBM BIOS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(240, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "-";
            // 
            // buttonLoop
            // 
            this.buttonLoop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLoop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoop.Font = new System.Drawing.Font("Px437 IBM BIOS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLoop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLoop.Location = new System.Drawing.Point(379, 390);
            this.buttonLoop.Name = "buttonLoop";
            this.buttonLoop.Size = new System.Drawing.Size(40, 35);
            this.buttonLoop.TabIndex = 12;
            this.buttonLoop.Text = "↔";
            this.buttonLoop.UseVisualStyleBackColor = true;
            this.buttonLoop.Click += new System.EventHandler(this.buttonLoop_Click);
            this.buttonLoop.MouseLeave += new System.EventHandler(this.buttonLoop_MouseLeave);
            this.buttonLoop.MouseHover += new System.EventHandler(this.buttonLoop_MouseHover);
            // 
            // buttonPlayRandom
            // 
            this.buttonPlayRandom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPlayRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonPlayRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonPlayRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayRandom.Font = new System.Drawing.Font("Px437 IBM BIOS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlayRandom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonPlayRandom.Location = new System.Drawing.Point(79, 390);
            this.buttonPlayRandom.Name = "buttonPlayRandom";
            this.buttonPlayRandom.Size = new System.Drawing.Size(40, 35);
            this.buttonPlayRandom.TabIndex = 13;
            this.buttonPlayRandom.Text = "¿";
            this.buttonPlayRandom.UseVisualStyleBackColor = true;
            this.buttonPlayRandom.Click += new System.EventHandler(this.buttonPlayRandom_Click);
            this.buttonPlayRandom.MouseLeave += new System.EventHandler(this.buttonPlayRandom_MouseLeave);
            this.buttonPlayRandom.MouseHover += new System.EventHandler(this.buttonPlayRandom_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(860, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(54, 325);
            this.panel3.TabIndex = 16;
            // 
            // buttonAddToFavourite
            // 
            this.buttonAddToFavourite.BackColor = System.Drawing.Color.Black;
            this.buttonAddToFavourite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddToFavourite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonAddToFavourite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonAddToFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToFavourite.Font = new System.Drawing.Font("Px437 IBM BIOS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddToFavourite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAddToFavourite.Location = new System.Drawing.Point(30, 8);
            this.buttonAddToFavourite.Name = "buttonAddToFavourite";
            this.buttonAddToFavourite.Size = new System.Drawing.Size(43, 45);
            this.buttonAddToFavourite.TabIndex = 17;
            this.buttonAddToFavourite.Text = "♥";
            this.buttonAddToFavourite.UseVisualStyleBackColor = false;
            this.buttonAddToFavourite.Visible = false;
            this.buttonAddToFavourite.Click += new System.EventHandler(this.buttonAddToFavourite_Click);
            this.buttonAddToFavourite.MouseLeave += new System.EventHandler(this.buttonAddToFavourite_MouseLeave);
            this.buttonAddToFavourite.MouseHover += new System.EventHandler(this.buttonAddToFavourite_MouseHover);
            // 
            // buttonSwitchListbox
            // 
            this.buttonSwitchListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSwitchListbox.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSwitchListbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitchListbox.Font = new System.Drawing.Font("Px437 IBM BIOS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSwitchListbox.Location = new System.Drawing.Point(532, 390);
            this.buttonSwitchListbox.Name = "buttonSwitchListbox";
            this.buttonSwitchListbox.Size = new System.Drawing.Size(47, 27);
            this.buttonSwitchListbox.TabIndex = 18;
            this.buttonSwitchListbox.Text = "♥";
            this.buttonSwitchListbox.UseVisualStyleBackColor = false;
            this.buttonSwitchListbox.Click += new System.EventHandler(this.buttonSwitchListbox_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonMinimize.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Px437 IBM BIOS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinimize.Location = new System.Drawing.Point(760, 21);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(47, 27);
            this.buttonMinimize.TabIndex = 19;
            this.buttonMinimize.Text = "-";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Px437 IBM BIOS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(813, 21);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(47, 27);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "x";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRemoveTrack
            // 
            this.buttonRemoveTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonRemoveTrack.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonRemoveTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveTrack.Font = new System.Drawing.Font("Px437 IBM BIOS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveTrack.Location = new System.Drawing.Point(813, 390);
            this.buttonRemoveTrack.Name = "buttonRemoveTrack";
            this.buttonRemoveTrack.Size = new System.Drawing.Size(47, 27);
            this.buttonRemoveTrack.TabIndex = 21;
            this.buttonRemoveTrack.Text = "↓";
            this.buttonRemoveTrack.UseVisualStyleBackColor = false;
            this.buttonRemoveTrack.Visible = false;
            this.buttonRemoveTrack.Click += new System.EventHandler(this.buttonRemoveTrack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(901, 516);
            this.Controls.Add(this.buttonRemoveTrack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonSwitchListbox);
            this.Controls.Add(this.buttonAddToFavourite);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPlayRandom);
            this.Controls.Add(this.buttonLoop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTrackTime);
            this.Controls.Add(this.labelTrackCurrentTime);
            this.Controls.Add(this.pictureBoxCoverArt);
            this.Controls.Add(this.buttonPreviousTrack);
            this.Controls.Add(this.buttonNextTrack);
            this.Controls.Add(this.buttonBrowseTracks);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelTrackName);
            this.Controls.Add(this.buttonPlay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "Form1";
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonBrowseTracks;
        private System.Windows.Forms.Button buttonPreviousTrack;
        private System.Windows.Forms.Button buttonNextTrack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTrackName;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.PictureBox pictureBoxCoverArt;
        private System.Windows.Forms.Label labelTrackCurrentTime;
        private System.Windows.Forms.Label labelTrackTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoop;
        private System.Windows.Forms.Button buttonPlayRandom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBoxTracksList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAddToFavourite;
        private System.Windows.Forms.Button buttonSwitchListbox;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxFavouriteTracks;
        private System.Windows.Forms.Button buttonRemoveTrack;
    }
}

