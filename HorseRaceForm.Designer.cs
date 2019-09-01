namespace HorseRace
{
    partial class HorseRaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RaceTrack = new System.Windows.Forms.Panel();
            this.HorseRed = new System.Windows.Forms.PictureBox();
            this.HorseGreen = new System.Windows.Forms.PictureBox();
            this.HorseBlue = new System.Windows.Forms.PictureBox();
            this.HorseGrey = new System.Windows.Forms.PictureBox();
            this.track = new System.Windows.Forms.PictureBox();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.labelHorse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownHorse = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBet = new System.Windows.Forms.NumericUpDown();
            this.btnBetsPlace = new System.Windows.Forms.Button();
            this.label_better3 = new System.Windows.Forms.Label();
            this.label_better2 = new System.Windows.Forms.Label();
            this.label_better1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.betDesc = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.beginRace = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RaceTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorseRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseGrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track)).BeginInit();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHorse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).BeginInit();
            this.SuspendLayout();
            // 
            // RaceTrack
            // 
            this.RaceTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RaceTrack.Controls.Add(this.HorseRed);
            this.RaceTrack.Controls.Add(this.HorseGreen);
            this.RaceTrack.Controls.Add(this.HorseBlue);
            this.RaceTrack.Controls.Add(this.HorseGrey);
            this.RaceTrack.Controls.Add(this.track);
            this.RaceTrack.Dock = System.Windows.Forms.DockStyle.Left;
            this.RaceTrack.Location = new System.Drawing.Point(0, 0);
            this.RaceTrack.Name = "RaceTrack";
            this.RaceTrack.Size = new System.Drawing.Size(932, 681);
            this.RaceTrack.TabIndex = 0;
            // 
            // HorseRed
            // 
            this.HorseRed.BackColor = System.Drawing.Color.White;
            this.HorseRed.Image = global::HorseRace.Properties.Resources.HorseRed;
            this.HorseRed.Location = new System.Drawing.Point(3, 533);
            this.HorseRed.Name = "HorseRed";
            this.HorseRed.Size = new System.Drawing.Size(100, 100);
            this.HorseRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HorseRed.TabIndex = 7;
            this.HorseRed.TabStop = false;
            // 
            // HorseGreen
            // 
            this.HorseGreen.BackColor = System.Drawing.Color.White;
            this.HorseGreen.Image = global::HorseRace.Properties.Resources.HorseGreen;
            this.HorseGreen.Location = new System.Drawing.Point(3, 376);
            this.HorseGreen.Name = "HorseGreen";
            this.HorseGreen.Size = new System.Drawing.Size(100, 100);
            this.HorseGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HorseGreen.TabIndex = 6;
            this.HorseGreen.TabStop = false;
            // 
            // HorseBlue
            // 
            this.HorseBlue.BackColor = System.Drawing.Color.White;
            this.HorseBlue.Image = global::HorseRace.Properties.Resources.HorseBlue;
            this.HorseBlue.Location = new System.Drawing.Point(3, 203);
            this.HorseBlue.Name = "HorseBlue";
            this.HorseBlue.Size = new System.Drawing.Size(100, 100);
            this.HorseBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HorseBlue.TabIndex = 5;
            this.HorseBlue.TabStop = false;
            // 
            // HorseGrey
            // 
            this.HorseGrey.BackColor = System.Drawing.Color.White;
            this.HorseGrey.Image = global::HorseRace.Properties.Resources.HorseGray;
            this.HorseGrey.Location = new System.Drawing.Point(3, 36);
            this.HorseGrey.Name = "HorseGrey";
            this.HorseGrey.Size = new System.Drawing.Size(100, 100);
            this.HorseGrey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HorseGrey.TabIndex = 4;
            this.HorseGrey.TabStop = false;
            // 
            // track
            // 
            this.track.BackColor = System.Drawing.Color.White;
            this.track.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track.Location = new System.Drawing.Point(0, 0);
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(930, 679);
            this.track.TabIndex = 0;
            this.track.TabStop = false;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.exitBtn);
            this.controlsPanel.Controls.Add(this.labelHorse);
            this.controlsPanel.Controls.Add(this.label1);
            this.controlsPanel.Controls.Add(this.numericUpDownHorse);
            this.controlsPanel.Controls.Add(this.numericUpDownBet);
            this.controlsPanel.Controls.Add(this.btnBetsPlace);
            this.controlsPanel.Controls.Add(this.label_better3);
            this.controlsPanel.Controls.Add(this.label_better2);
            this.controlsPanel.Controls.Add(this.label_better1);
            this.controlsPanel.Controls.Add(this.radioButton3);
            this.controlsPanel.Controls.Add(this.radioButton2);
            this.controlsPanel.Controls.Add(this.radioButton1);
            this.controlsPanel.Controls.Add(this.betDesc);
            this.controlsPanel.Controls.Add(this.title);
            this.controlsPanel.Controls.Add(this.beginRace);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsPanel.Location = new System.Drawing.Point(932, 0);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(332, 681);
            this.controlsPanel.TabIndex = 1;
            this.controlsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlsPanel_Paint);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(224, 644);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(94, 34);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // labelHorse
            // 
            this.labelHorse.AutoSize = true;
            this.labelHorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorse.Location = new System.Drawing.Point(142, 262);
            this.labelHorse.Name = "labelHorse";
            this.labelHorse.Size = new System.Drawing.Size(45, 16);
            this.labelHorse.TabIndex = 13;
            this.labelHorse.Text = "Horse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bet";
            // 
            // numericUpDownHorse
            // 
            this.numericUpDownHorse.Location = new System.Drawing.Point(199, 262);
            this.numericUpDownHorse.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownHorse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHorse.Name = "numericUpDownHorse";
            this.numericUpDownHorse.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHorse.TabIndex = 11;
            this.numericUpDownHorse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBet
            // 
            this.numericUpDownBet.Location = new System.Drawing.Point(40, 262);
            this.numericUpDownBet.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownBet.Name = "numericUpDownBet";
            this.numericUpDownBet.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownBet.TabIndex = 10;
            // 
            // btnBetsPlace
            // 
            this.btnBetsPlace.Location = new System.Drawing.Point(9, 306);
            this.btnBetsPlace.Name = "btnBetsPlace";
            this.btnBetsPlace.Size = new System.Drawing.Size(316, 59);
            this.btnBetsPlace.TabIndex = 9;
            this.btnBetsPlace.Text = "Place Bets";
            this.btnBetsPlace.UseVisualStyleBackColor = true;
            this.btnBetsPlace.Click += new System.EventHandler(this.BtnBetsPlace_Click);
            // 
            // label_better3
            // 
            this.label_better3.Location = new System.Drawing.Point(10, 195);
            this.label_better3.Name = "label_better3";
            this.label_better3.Size = new System.Drawing.Size(235, 13);
            this.label_better3.TabIndex = 8;
            this.label_better3.Text = "Jashan  hasn\'t placed a bet";
            this.label_better3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_better2
            // 
            this.label_better2.Location = new System.Drawing.Point(10, 173);
            this.label_better2.Name = "label_better2";
            this.label_better2.Size = new System.Drawing.Size(235, 13);
            this.label_better2.TabIndex = 7;
            this.label_better2.Text = "Nav hasn\'t placed a bet";
            this.label_better2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_better1
            // 
            this.label_better1.Location = new System.Drawing.Point(10, 151);
            this.label_better1.Name = "label_better1";
            this.label_better1.Size = new System.Drawing.Size(235, 13);
            this.label_better1.TabIndex = 6;
            this.label_better1.Text = "Amrit  hasn\'t placed a bet";
            this.label_better1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_better1.Click += new System.EventHandler(this.Label_better1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Location = new System.Drawing.Point(17, 120);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(125, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Jashan has 50 bucks";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(17, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = " Nav has 50 bucks";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(17, 73);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Amrit has 50 bucks";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // betDesc
            // 
            this.betDesc.AutoSize = true;
            this.betDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betDesc.Location = new System.Drawing.Point(13, 49);
            this.betDesc.Name = "betDesc";
            this.betDesc.Size = new System.Drawing.Size(127, 20);
            this.betDesc.TabIndex = 2;
            this.betDesc.Text = "Minimum Bet: 5$";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(7, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(73, 31);
            this.title.TabIndex = 1;
            this.title.Text = "Bets";
            // 
            // beginRace
            // 
            this.beginRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginRace.Location = new System.Drawing.Point(9, 472);
            this.beginRace.Name = "beginRace";
            this.beginRace.Size = new System.Drawing.Size(313, 67);
            this.beginRace.TabIndex = 0;
            this.beginRace.Text = "BEGIN RACE";
            this.beginRace.UseVisualStyleBackColor = true;
            this.beginRace.Click += new System.EventHandler(this.BeginRace_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // HorseRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.RaceTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HorseRaceForm";
            this.Text = "Form1";
            this.RaceTrack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HorseRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseGrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHorse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RaceTrack;
        private System.Windows.Forms.PictureBox HorseRed;
        private System.Windows.Forms.PictureBox HorseGreen;
        private System.Windows.Forms.PictureBox HorseBlue;
        private System.Windows.Forms.PictureBox HorseGrey;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button beginRace;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label betDesc;
        private System.Windows.Forms.Label label_better3;
        private System.Windows.Forms.Label label_better2;
        private System.Windows.Forms.Label label_better1;
        private System.Windows.Forms.Button btnBetsPlace;
        private System.Windows.Forms.Label labelHorse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownHorse;
        private System.Windows.Forms.NumericUpDown numericUpDownBet;
        private System.Windows.Forms.PictureBox track;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exitBtn;
    }
}

