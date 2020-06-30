namespace visual_project_20193156
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_howToPlay = new System.Windows.Forms.Button();
            this.btn_gameStart = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.문제보고BugReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Snake Game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_howToPlay
            // 
            this.btn_howToPlay.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_howToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_howToPlay.Font = new System.Drawing.Font("TSILoveYou", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_howToPlay.ForeColor = System.Drawing.Color.Black;
            this.btn_howToPlay.Location = new System.Drawing.Point(162, 305);
            this.btn_howToPlay.Name = "btn_howToPlay";
            this.btn_howToPlay.Size = new System.Drawing.Size(160, 69);
            this.btn_howToPlay.TabIndex = 2;
            this.btn_howToPlay.Text = "게임 방법";
            this.btn_howToPlay.UseVisualStyleBackColor = false;
            this.btn_howToPlay.Click += new System.EventHandler(this.btn_howToPlay_Click);
            // 
            // btn_gameStart
            // 
            this.btn_gameStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_gameStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gameStart.Font = new System.Drawing.Font("TSILoveYou", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_gameStart.ForeColor = System.Drawing.Color.Black;
            this.btn_gameStart.Location = new System.Drawing.Point(328, 305);
            this.btn_gameStart.Name = "btn_gameStart";
            this.btn_gameStart.Size = new System.Drawing.Size(160, 69);
            this.btn_gameStart.TabIndex = 3;
            this.btn_gameStart.Text = "게임 시작";
            this.btn_gameStart.UseVisualStyleBackColor = false;
            this.btn_gameStart.Click += new System.EventHandler(this.btn_gameStart_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_setting.Font = new System.Drawing.Font("TSILoveYou", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_setting.ForeColor = System.Drawing.Color.Black;
            this.btn_setting.Location = new System.Drawing.Point(494, 305);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(160, 69);
            this.btn_setting.TabIndex = 4;
            this.btn_setting.Tag = "btn_setting";
            this.btn_setting.Text = "설정";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectInfoToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.projectToolStripMenuItem.Text = "Project (&P)";
            // 
            // projectInfoToolStripMenuItem
            // 
            this.projectInfoToolStripMenuItem.Name = "projectInfoToolStripMenuItem";
            this.projectInfoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.projectInfoToolStripMenuItem.Text = "프로젝트 정보 (Project Info)";
            this.projectInfoToolStripMenuItem.Click += new System.EventHandler(this.projectInfoToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.문제보고BugReportToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpHToolStripMenuItem.Text = "Help (&H)";
            // 
            // 문제보고BugReportToolStripMenuItem
            // 
            this.문제보고BugReportToolStripMenuItem.Name = "문제보고BugReportToolStripMenuItem";
            this.문제보고BugReportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.문제보고BugReportToolStripMenuItem.Text = "문제 보고 (Bug report)";
            this.문제보고BugReportToolStripMenuItem.Click += new System.EventHandler(this.문제보고BugReportToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(138, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(575, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "EasterEgg C# 생각보다 어려운것 같습니다!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_gameStart);
            this.Controls.Add(this.btn_howToPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SnakeGame-20193156";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_howToPlay;
        private System.Windows.Forms.Button btn_gameStart;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 문제보고BugReportToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

