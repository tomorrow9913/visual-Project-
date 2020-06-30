namespace visual_project_20193156
{
    partial class setting
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
            this.Setting_tabControl = new System.Windows.Forms.TabControl();
            this.Speed = new System.Windows.Forms.TabPage();
            this.nowSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.speedControler = new System.Windows.Forms.TrackBar();
            this.settig_mapSize = new System.Windows.Forms.TabPage();
            this.size5050 = new System.Windows.Forms.RadioButton();
            this.size3535 = new System.Windows.Forms.RadioButton();
            this.size2020 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.set = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.nowSpeed2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nowSize = new System.Windows.Forms.Label();
            this.Setting_tabControl.SuspendLayout();
            this.Speed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedControler)).BeginInit();
            this.settig_mapSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // Setting_tabControl
            // 
            this.Setting_tabControl.Controls.Add(this.Speed);
            this.Setting_tabControl.Controls.Add(this.settig_mapSize);
            this.Setting_tabControl.Location = new System.Drawing.Point(14, 67);
            this.Setting_tabControl.Name = "Setting_tabControl";
            this.Setting_tabControl.SelectedIndex = 0;
            this.Setting_tabControl.Size = new System.Drawing.Size(459, 300);
            this.Setting_tabControl.TabIndex = 0;
            // 
            // Speed
            // 
            this.Speed.Controls.Add(this.nowSpeed);
            this.Speed.Controls.Add(this.label4);
            this.Speed.Controls.Add(this.label3);
            this.Speed.Controls.Add(this.label2);
            this.Speed.Controls.Add(this.speedControler);
            this.Speed.Location = new System.Drawing.Point(4, 22);
            this.Speed.Name = "Speed";
            this.Speed.Padding = new System.Windows.Forms.Padding(3);
            this.Speed.Size = new System.Drawing.Size(451, 274);
            this.Speed.TabIndex = 0;
            this.Speed.Text = "속도 설정";
            this.Speed.UseVisualStyleBackColor = true;
            // 
            // nowSpeed
            // 
            this.nowSpeed.AutoSize = true;
            this.nowSpeed.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nowSpeed.Location = new System.Drawing.Point(21, 192);
            this.nowSpeed.Name = "nowSpeed";
            this.nowSpeed.Size = new System.Drawing.Size(0, 21);
            this.nowSpeed.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "현재 속도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "빠름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "느림";
            // 
            // speedControler
            // 
            this.speedControler.LargeChange = 2;
            this.speedControler.Location = new System.Drawing.Point(49, 24);
            this.speedControler.Maximum = 2;
            this.speedControler.Name = "speedControler";
            this.speedControler.Size = new System.Drawing.Size(325, 45);
            this.speedControler.TabIndex = 0;
            this.speedControler.Value = 1;
            this.speedControler.Scroll += new System.EventHandler(this.speedControler_Scroll);
            // 
            // settig_mapSize
            // 
            this.settig_mapSize.Controls.Add(this.size5050);
            this.settig_mapSize.Controls.Add(this.size3535);
            this.settig_mapSize.Controls.Add(this.size2020);
            this.settig_mapSize.Location = new System.Drawing.Point(4, 22);
            this.settig_mapSize.Name = "settig_mapSize";
            this.settig_mapSize.Padding = new System.Windows.Forms.Padding(3);
            this.settig_mapSize.Size = new System.Drawing.Size(451, 274);
            this.settig_mapSize.TabIndex = 1;
            this.settig_mapSize.Text = "맵 크기";
            this.settig_mapSize.UseVisualStyleBackColor = true;
            // 
            // size5050
            // 
            this.size5050.AutoSize = true;
            this.size5050.Location = new System.Drawing.Point(23, 183);
            this.size5050.Name = "size5050";
            this.size5050.Size = new System.Drawing.Size(62, 16);
            this.size5050.TabIndex = 2;
            this.size5050.TabStop = true;
            this.size5050.Text = "50 x 50";
            this.size5050.UseVisualStyleBackColor = true;
            this.size5050.CheckedChanged += new System.EventHandler(this.size5050_CheckedChanged);
            // 
            // size3535
            // 
            this.size3535.AutoSize = true;
            this.size3535.Checked = true;
            this.size3535.Location = new System.Drawing.Point(23, 118);
            this.size3535.Name = "size3535";
            this.size3535.Size = new System.Drawing.Size(62, 16);
            this.size3535.TabIndex = 1;
            this.size3535.TabStop = true;
            this.size3535.Text = "35 x 35";
            this.size3535.UseVisualStyleBackColor = true;
            this.size3535.CheckedChanged += new System.EventHandler(this.size2525_CheckedChanged);
            // 
            // size2020
            // 
            this.size2020.AutoSize = true;
            this.size2020.Location = new System.Drawing.Point(23, 57);
            this.size2020.Name = "size2020";
            this.size2020.Size = new System.Drawing.Size(62, 16);
            this.size2020.TabIndex = 0;
            this.size2020.TabStop = true;
            this.size2020.Text = "20 x 20";
            this.size2020.UseVisualStyleBackColor = true;
            this.size2020.CheckedChanged += new System.EventHandler(this.size2020_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D2Coding", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "설정 (Setting)";
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(501, 89);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(117, 43);
            this.set.TabIndex = 2;
            this.set.Text = "적용 (&S)";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(648, 89);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(117, 43);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "취소 (&C)";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // nowSpeed2
            // 
            this.nowSpeed2.AutoSize = true;
            this.nowSpeed2.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nowSpeed2.Location = new System.Drawing.Point(36, 391);
            this.nowSpeed2.Name = "nowSpeed2";
            this.nowSpeed2.Size = new System.Drawing.Size(0, 21);
            this.nowSpeed2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "현재 속도";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "설정 크기";
            // 
            // nowSize
            // 
            this.nowSize.AutoSize = true;
            this.nowSize.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nowSize.Location = new System.Drawing.Point(179, 391);
            this.nowSize.Name = "nowSize";
            this.nowSize.Size = new System.Drawing.Size(0, 21);
            this.nowSize.TabIndex = 7;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nowSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nowSpeed2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.set);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Setting_tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "setting";
            this.Text = "setting";
            this.Load += new System.EventHandler(this.setting_Load);
            this.Setting_tabControl.ResumeLayout(false);
            this.Speed.ResumeLayout(false);
            this.Speed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedControler)).EndInit();
            this.settig_mapSize.ResumeLayout(false);
            this.settig_mapSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Setting_tabControl;
        private System.Windows.Forms.TabPage Speed;
        private System.Windows.Forms.TabPage settig_mapSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label nowSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar speedControler;
        private System.Windows.Forms.RadioButton size5050;
        private System.Windows.Forms.RadioButton size3535;
        private System.Windows.Forms.RadioButton size2020;
        private System.Windows.Forms.Label nowSpeed2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nowSize;
    }
}