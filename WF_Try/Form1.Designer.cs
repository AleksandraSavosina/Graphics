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
            this.upload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changeColor = new System.Windows.Forms.Button();
            this.BlackWhite = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.Gray = new System.Windows.Forms.Button();
            this.buttonNoRed = new System.Windows.Forms.Button();
            this.NoNoise = new System.Windows.Forms.Button();
            this.Noise = new System.Windows.Forms.Button();
            this.Glass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // upload
            // 
            this.upload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.upload.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.upload.Location = new System.Drawing.Point(474, 43);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(137, 37);
            this.upload.TabIndex = 0;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
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
            // Save
            // 
            this.Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Save.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Save.Location = new System.Drawing.Point(631, 43);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(137, 37);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
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
            // NoNoise
            // 
            this.NoNoise.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NoNoise.Location = new System.Drawing.Point(474, 342);
            this.NoNoise.Name = "NoNoise";
            this.NoNoise.Size = new System.Drawing.Size(94, 37);
            this.NoNoise.TabIndex = 13;
            this.NoNoise.Text = "NoNoise";
            this.NoNoise.UseVisualStyleBackColor = false;
            this.NoNoise.Click += new System.EventHandler(this.NoNoise_Click);
            // 
            // Noise
            // 
            this.Noise.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Noise.Location = new System.Drawing.Point(574, 342);
            this.Noise.Name = "Noise";
            this.Noise.Size = new System.Drawing.Size(94, 37);
            this.Noise.TabIndex = 16;
            this.Noise.Text = "Noise";
            this.Noise.UseVisualStyleBackColor = false;
            this.Noise.Click += new System.EventHandler(this.Noise_Click);
            // 
            // Glass
            // 
            this.Glass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Glass.Location = new System.Drawing.Point(474, 385);
            this.Glass.Name = "Glass";
            this.Glass.Size = new System.Drawing.Size(94, 37);
            this.Glass.TabIndex = 17;
            this.Glass.Text = "Glass";
            this.Glass.UseVisualStyleBackColor = false;
            this.Glass.Click += new System.EventHandler(this.Glass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 552);
            this.Controls.Add(this.Glass);
            this.Controls.Add(this.Noise);
            this.Controls.Add(this.NoNoise);
            this.Controls.Add(this.buttonNoRed);
            this.Controls.Add(this.Gray);
            this.Controls.Add(this.pictureBoxBlue);
            this.Controls.Add(this.pictureBoxGreen);
            this.Controls.Add(this.pictureBoxRed);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.BlackWhite);
            this.Controls.Add(this.changeColor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.upload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button changeColor;
        private System.Windows.Forms.Button BlackWhite;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.Button Gray;
        private System.Windows.Forms.Button buttonNoRed;
        private System.Windows.Forms.Button NoNoise;
        private System.Windows.Forms.Button Noise;
        private System.Windows.Forms.Button Glass;
    }
}

