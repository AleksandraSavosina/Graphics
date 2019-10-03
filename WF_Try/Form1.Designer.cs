namespace WF_Try
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changeColor = new System.Windows.Forms.Button();
            this.BlackWhite = new System.Windows.Forms.Button();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.Gray = new System.Windows.Forms.Button();
            this.buttonNoRed = new System.Windows.Forms.Button();
            this.MedianFilter = new System.Windows.Forms.Button();
            this.Noise = new System.Windows.Forms.Button();
            this.GaussFilter = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuPicture = new System.Windows.Forms.MenuStrip();
            this.pictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Blur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            this.menuPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // changeColor
            // 
            this.changeColor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.changeColor.Location = new System.Drawing.Point(474, 86);
            this.changeColor.Name = "changeColor";
            this.changeColor.Size = new System.Drawing.Size(94, 37);
            this.changeColor.TabIndex = 3;
            this.changeColor.Text = "Invert";
            this.changeColor.UseVisualStyleBackColor = false;
            this.changeColor.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // BlackWhite
            // 
            this.BlackWhite.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BlackWhite.Location = new System.Drawing.Point(674, 87);
            this.BlackWhite.Name = "BlackWhite";
            this.BlackWhite.Size = new System.Drawing.Size(94, 35);
            this.BlackWhite.TabIndex = 4;
            this.BlackWhite.Text = "Black/White";
            this.BlackWhite.UseVisualStyleBackColor = false;
            this.BlackWhite.Click += new System.EventHandler(this.BlackWhite_Click);
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxRed.Location = new System.Drawing.Point(12, 286);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(142, 93);
            this.pictureBoxRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRed.TabIndex = 8;
            this.pictureBoxRed.TabStop = false;
            this.pictureBoxRed.Click += new System.EventHandler(this.pictureBoxRed_Click);
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxGreen.Location = new System.Drawing.Point(160, 286);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(142, 93);
            this.pictureBoxGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGreen.TabIndex = 9;
            this.pictureBoxGreen.TabStop = false;
            this.pictureBoxGreen.Click += new System.EventHandler(this.pictureBoxGreen_Click);
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxBlue.Location = new System.Drawing.Point(308, 286);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(142, 93);
            this.pictureBoxBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBlue.TabIndex = 10;
            this.pictureBoxBlue.TabStop = false;
            this.pictureBoxBlue.Click += new System.EventHandler(this.pictureBoxBlue_Click);
            // 
            // Gray
            // 
            this.Gray.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Gray.Location = new System.Drawing.Point(574, 86);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(94, 35);
            this.Gray.TabIndex = 11;
            this.Gray.Text = "Gray";
            this.Gray.UseVisualStyleBackColor = false;
            this.Gray.Click += new System.EventHandler(this.Gray_Click);
            // 
            // buttonNoRed
            // 
            this.buttonNoRed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonNoRed.Location = new System.Drawing.Point(474, 129);
            this.buttonNoRed.Name = "buttonNoRed";
            this.buttonNoRed.Size = new System.Drawing.Size(94, 37);
            this.buttonNoRed.TabIndex = 12;
            this.buttonNoRed.Text = "NoRed";
            this.buttonNoRed.UseVisualStyleBackColor = false;
            this.buttonNoRed.Click += new System.EventHandler(this.buttonNoRed_Click);
            // 
            // MedianFilter
            // 
            this.MedianFilter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MedianFilter.Location = new System.Drawing.Point(574, 342);
            this.MedianFilter.Name = "MedianFilter";
            this.MedianFilter.Size = new System.Drawing.Size(94, 37);
            this.MedianFilter.TabIndex = 13;
            this.MedianFilter.Text = "MedianFilter";
            this.MedianFilter.UseVisualStyleBackColor = false;
            this.MedianFilter.Click += new System.EventHandler(this.MedianFilter_Click);
            // 
            // Noise
            // 
            this.Noise.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Noise.Location = new System.Drawing.Point(474, 286);
            this.Noise.Name = "Noise";
            this.Noise.Size = new System.Drawing.Size(94, 37);
            this.Noise.TabIndex = 16;
            this.Noise.Text = "Noise";
            this.Noise.UseVisualStyleBackColor = false;
            this.Noise.Click += new System.EventHandler(this.Noise_Click);
            // 
            // GaussFilter
            // 
            this.GaussFilter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GaussFilter.Location = new System.Drawing.Point(474, 342);
            this.GaussFilter.Name = "GaussFilter";
            this.GaussFilter.Size = new System.Drawing.Size(94, 37);
            this.GaussFilter.TabIndex = 17;
            this.GaussFilter.Text = "GaussFilter";
            this.GaussFilter.UseVisualStyleBackColor = false;
            this.GaussFilter.Click += new System.EventHandler(this.GaussFilter_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar.Location = new System.Drawing.Point(12, 422);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(438, 23);
            this.progressBar.TabIndex = 19;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // menuPicture
            // 
            this.menuPicture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pictureToolStripMenuItem});
            this.menuPicture.Location = new System.Drawing.Point(0, 0);
            this.menuPicture.Name = "menuPicture";
            this.menuPicture.Size = new System.Drawing.Size(844, 24);
            this.menuPicture.TabIndex = 20;
            this.menuPicture.Text = "menuPicture";
            // 
            // pictureToolStripMenuItem
            // 
            this.pictureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.pictureToolStripMenuItem.Name = "pictureToolStripMenuItem";
            this.pictureToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.pictureToolStripMenuItem.Text = "Picture";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Blur
            // 
            this.Blur.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Blur.Location = new System.Drawing.Point(674, 342);
            this.Blur.Name = "Blur";
            this.Blur.Size = new System.Drawing.Size(94, 37);
            this.Blur.TabIndex = 21;
            this.Blur.Text = "Blur";
            this.Blur.UseVisualStyleBackColor = false;
            this.Blur.Click += new System.EventHandler(this.Blur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 552);
            this.Controls.Add(this.Blur);
            this.Controls.Add(this.menuPicture);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.GaussFilter);
            this.Controls.Add(this.Noise);
            this.Controls.Add(this.MedianFilter);
            this.Controls.Add(this.buttonNoRed);
            this.Controls.Add(this.Gray);
            this.Controls.Add(this.pictureBoxBlue);
            this.Controls.Add(this.pictureBoxGreen);
            this.Controls.Add(this.pictureBoxRed);
            this.Controls.Add(this.BlackWhite);
            this.Controls.Add(this.changeColor);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPicture;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            this.menuPicture.ResumeLayout(false);
            this.menuPicture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button changeColor;
        private System.Windows.Forms.Button BlackWhite;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.Button Gray;
        private System.Windows.Forms.Button buttonNoRed;
        private System.Windows.Forms.Button MedianFilter;
        private System.Windows.Forms.Button Noise;
        private System.Windows.Forms.Button GaussFilter;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuPicture;
        private System.Windows.Forms.ToolStripMenuItem pictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button Blur;
        //private System.ComponentModel.BackgroundWorker backgroundWorker1;
        //private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

