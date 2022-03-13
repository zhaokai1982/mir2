namespace AutoPatcher
{
    partial class AMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMain));
            this.ImageLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FileLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.InterfaceTimer = new System.Windows.Forms.Timer(this.components);
            this.SourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageLinkLabel
            // 
            this.ImageLinkLabel.AutoSize = true;
            this.ImageLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(4, 0);
            this.ImageLinkLabel.Location = new System.Drawing.Point(484, 154);
            this.ImageLinkLabel.Name = "ImageLinkLabel";
            this.ImageLinkLabel.Size = new System.Drawing.Size(29, 19);
            this.ImageLinkLabel.TabIndex = 2;
            this.ImageLinkLabel.Text = "MIR2";
            this.ImageLinkLabel.UseCompatibleTextRendering = true;
            this.ImageLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ImageLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "运行状态:";
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Location = new System.Drawing.Point(79, 156);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(71, 12);
            this.ActionLabel.TabIndex = 4;
            this.ActionLabel.Text = "检查文件...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 206);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(501, 10);
            this.progressBar1.TabIndex = 5;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(438, 238);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 21);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(12, 238);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 21);
            this.PlayButton.TabIndex = 7;
            this.PlayButton.Text = "开始";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(81, 175);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(29, 12);
            this.SizeLabel.TabIndex = 9;
            this.SizeLabel.Text = "Idle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "总大小:";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(81, 191);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(29, 12);
            this.FileLabel.TabIndex = 11;
            this.FileLabel.Text = "Idle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "处理文件:";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(448, 187);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(29, 12);
            this.SpeedLabel.TabIndex = 13;
            this.SpeedLabel.Text = "Idle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "速度:";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 223);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(501, 10);
            this.progressBar2.TabIndex = 14;
            // 
            // InterfaceTimer
            // 
            this.InterfaceTimer.Enabled = true;
            this.InterfaceTimer.Interval = 50;
            this.InterfaceTimer.Tick += new System.EventHandler(this.InterfaceTimer_Tick);
            // 
            // SourceLinkLabel
            // 
            this.SourceLinkLabel.AutoSize = true;
            this.SourceLinkLabel.Location = new System.Drawing.Point(430, 265);
            this.SourceLinkLabel.Name = "SourceLinkLabel";
            this.SourceLinkLabel.Size = new System.Drawing.Size(83, 12);
            this.SourceLinkLabel.TabIndex = 15;
            this.SourceLinkLabel.TabStop = true;
            this.SourceLinkLabel.Text = "www.mir23.top";
            this.SourceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceLinkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoPatcher.Properties.Resources.C_Mir1;
            this.pictureBox1.InitialImage = global::AutoPatcher.Properties.Resources.C_Mir1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 283);
            this.Controls.Add(this.SourceLinkLabel);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ActionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageLinkLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AMain";
            this.Text = "Auto Patcher";
            this.Load += new System.EventHandler(this.AMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel ImageLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer InterfaceTimer;
        private System.Windows.Forms.LinkLabel SourceLinkLabel;
    }
}

