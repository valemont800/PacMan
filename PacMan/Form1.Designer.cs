namespace PacMan
{
    partial class title
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(title));
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.life1Picture = new System.Windows.Forms.PictureBox();
            this.life2Picture = new System.Windows.Forms.PictureBox();
            this.life3Picture = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.titleName = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.life1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Yellow;
            this.titleLabel.Location = new System.Drawing.Point(229, 159);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 42);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.ForeColor = System.Drawing.Color.Yellow;
            this.subtitleLabel.Location = new System.Drawing.Point(229, 352);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(328, 94);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // life1Picture
            // 
            this.life1Picture.Location = new System.Drawing.Point(50, 587);
            this.life1Picture.Name = "life1Picture";
            this.life1Picture.Size = new System.Drawing.Size(39, 38);
            this.life1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1Picture.TabIndex = 2;
            this.life1Picture.TabStop = false;
            // 
            // life2Picture
            // 
            this.life2Picture.Location = new System.Drawing.Point(111, 587);
            this.life2Picture.Name = "life2Picture";
            this.life2Picture.Size = new System.Drawing.Size(42, 38);
            this.life2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2Picture.TabIndex = 3;
            this.life2Picture.TabStop = false;
            // 
            // life3Picture
            // 
            this.life3Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.life3Picture.Location = new System.Drawing.Point(174, 587);
            this.life3Picture.Name = "life3Picture";
            this.life3Picture.Size = new System.Drawing.Size(42, 38);
            this.life3Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3Picture.TabIndex = 4;
            this.life3Picture.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(280, 569);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(202, 56);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleName
            // 
            this.titleName.BackColor = System.Drawing.Color.Transparent;
            this.titleName.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleName.ForeColor = System.Drawing.Color.Yellow;
            this.titleName.Location = new System.Drawing.Point(229, 187);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(328, 94);
            this.titleName.TabIndex = 6;
            this.titleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chooseLabel
            // 
            this.chooseLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabel.Location = new System.Drawing.Point(45, 159);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(276, 236);
            this.chooseLabel.TabIndex = 8;
            this.chooseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chooseLabel.Visible = false;
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.Transparent;
            this.easyButton.Enabled = false;
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.ForeColor = System.Drawing.Color.White;
            this.easyButton.Location = new System.Drawing.Point(483, 138);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(118, 42);
            this.easyButton.TabIndex = 9;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Visible = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.Color.Transparent;
            this.mediumButton.Enabled = false;
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.ForeColor = System.Drawing.Color.White;
            this.mediumButton.Location = new System.Drawing.Point(483, 257);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(118, 42);
            this.mediumButton.TabIndex = 10;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Visible = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.Transparent;
            this.hardButton.Enabled = false;
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.ForeColor = System.Drawing.Color.White;
            this.hardButton.Location = new System.Drawing.Point(483, 376);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(118, 42);
            this.hardButton.TabIndex = 11;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Visible = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.life3Picture);
            this.Controls.Add(this.life2Picture);
            this.Controls.Add(this.life1Picture);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "title";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PacMan";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.life1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox life1Picture;
        private System.Windows.Forms.PictureBox life2Picture;
        private System.Windows.Forms.PictureBox life3Picture;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
    }
}

