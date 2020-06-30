using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_project_20193156
{
    public partial class setting : Form
    {
        public string settingVal;
        public string PassValue
        {
            get { return this.settingVal; }
            set { this.settingVal = value; }
        }

        public int size = 35;
        public int speed = 1;

        private int beforeSpeed;
        private int beforeSize;

        public setting()
        {
            InitializeComponent();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            switch (beforeSpeed = speedControler.Value)
            {
                case 0: nowSpeed.Text = "느림"; nowSpeed2.Text = "느림"; break;
                case 1: nowSpeed.Text = "보통"; nowSpeed2.Text = "보통"; break;
                case 2: nowSpeed.Text = "빠름"; nowSpeed2.Text = "빠름"; break;
            }

            if (size2020.Checked) { nowSize.Text = "20 x 20"; beforeSize = 20; }
            if (size3535.Checked) { nowSize.Text = "35 x 35"; beforeSize = 35; }
            if (size5050.Checked) { nowSize.Text = "50 x 50"; beforeSize = 50; }

        }

        private void set_Click(object sender, EventArgs e)
        {
            PassValue = size.ToString() + "/"+ speed.ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            size = beforeSize;
            speed = beforeSpeed;
            PassValue = size.ToString() + "/" + speed.ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void speedControler_Scroll(object sender, EventArgs e)
        {
            switch (speedControler.Value)
            {
                case 0: nowSpeed.Text = "느림"; nowSpeed2.Text = "느림"; speed = 0; break;
                case 1: nowSpeed.Text = "보통"; nowSpeed2.Text = "보통"; speed = 1; break;
                case 2: nowSpeed.Text = "빠름"; nowSpeed2.Text = "빠름"; speed = 2; break;
            }
        }

        private void size2020_CheckedChanged(object sender, EventArgs e)
        {
            nowSize.Text = "20 x 20";
            size = 20;
        }

        private void size2525_CheckedChanged(object sender, EventArgs e)
        {
            nowSize.Text = "35 x 35";
            size = 25;
        }

        private void size5050_CheckedChanged(object sender, EventArgs e)
        {
            nowSize.Text = "50 x 50";
            size = 50;
        }
    }
}
