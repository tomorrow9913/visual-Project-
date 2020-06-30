namespace visual_project_20193156
{
    partial class InGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InGame));
            this.record_score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.now_score = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.speed_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.size_label = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameOver_msg = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.게임종료xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // record_score
            // 
            this.record_score.AutoSize = true;
            this.record_score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.record_score.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.record_score.Location = new System.Drawing.Point(659, 125);
            this.record_score.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.record_score.Name = "record_score";
            this.record_score.Size = new System.Drawing.Size(51, 15);
            this.record_score.TabIndex = 0;
            this.record_score.Text = "4 Point";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(610, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Record";
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Canvas.Location = new System.Drawing.Point(26, 45);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(500, 500);
            this.Canvas.TabIndex = 6;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(610, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Now";
            // 
            // now_score
            // 
            this.now_score.AutoSize = true;
            this.now_score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.now_score.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.now_score.Location = new System.Drawing.Point(659, 202);
            this.now_score.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.now_score.Name = "now_score";
            this.now_score.Size = new System.Drawing.Size(51, 15);
            this.now_score.TabIndex = 9;
            this.now_score.Text = "4 Point";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 485);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "Speed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(612, 463);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "Size:";
            // 
            // speed_label
            // 
            this.speed_label.AutoSize = true;
            this.speed_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.speed_label.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.speed_label.Location = new System.Drawing.Point(658, 482);
            this.speed_label.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(85, 15);
            this.speed_label.TabIndex = 16;
            this.speed_label.Text = "gameSpeed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("NanumGothicExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(610, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Game Info";
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.size_label.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.size_label.Location = new System.Drawing.Point(658, 460);
            this.size_label.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(69, 15);
            this.size_label.TabIndex = 14;
            this.size_label.Text = "map_size";
            // 
            // GameOver_msg
            // 
            this.GameOver_msg.AutoSize = true;
            this.GameOver_msg.BackColor = System.Drawing.SystemColors.Control;
            this.GameOver_msg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameOver_msg.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GameOver_msg.Location = new System.Drawing.Point(615, 293);
            this.GameOver_msg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.GameOver_msg.Name = "GameOver_msg";
            this.GameOver_msg.Size = new System.Drawing.Size(247, 44);
            this.GameOver_msg.TabIndex = 20;
            this.GameOver_msg.Text = "Game Over\r\nEnter로 새 게임을 시작.";
            this.GameOver_msg.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.게임종료xToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 게임종료xToolStripMenuItem
            // 
            this.게임종료xToolStripMenuItem.Name = "게임종료xToolStripMenuItem";
            this.게임종료xToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.게임종료xToolStripMenuItem.Text = "게임종료(&x)";
            this.게임종료xToolStripMenuItem.Click += new System.EventHandler(this.게임종료xToolStripMenuItem_Click);
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 572);
            this.Controls.Add(this.GameOver_msg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.speed_label);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.size_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.now_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.record_score);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InGame";
            this.Text = "SnakeGame-20193156";
            this.Load += new System.EventHandler(this.InGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label record_score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label now_score;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label speed_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label GameOver_msg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 게임종료xToolStripMenuItem;
    }
}