using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace visual_project_20193156
{
    public partial class Form1 : Form
    {
        // 이스터에그 활성화 전용
        int easterEgg = 0;

        // 게임 세팅 기본값
        string settingValue = "35/1";

        // 설정 값 보관을 위해 미리 만들어둠
        private setting settingPage = new setting();
        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 프로젝트 정보 표시
        private void projectInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versoin: 0.0.1 beta\nAuthor: Jeong MinGyu\nStudent ID: 20193156", "Project Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 버그 리프트 깃허브 이슈 페이지로 연결
        private void 문제보고BugReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/tomorrow9913/visual-Project/issues");
        }

        // 세팅 호출시 세팅창으로 연결
        private void btn_setting_Click(object sender, EventArgs e)
        {
            // 설정 창으로 창 전환 효과
            this.Visible = false;
            
            // 꺼지면 다시 화면 보이게 하기
            DialogResult result = settingPage.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Visible = true;
            }
            
            // 세팅 값 저장
            settingValue = settingPage.PassValue;

            
        }
        private void btn_gameStart_Click(object sender, EventArgs e)
        {
            // 창 전환
            this.Visible = false;
            
            // 게임 실행 및 설정값 전송
            InGame game = new InGame(settingValue);
            game.ShowDialog();
        }

        private void btn_howToPlay_Click(object sender, EventArgs e)
        {
            Form2 howToplay = new Form2();
            howToplay.Show();
        }


        // 이스터에그 실행
        private void label1_Click(object sender, EventArgs e)
        {
            if (++easterEgg == 20)
            {
                this.BackColor = Color.Red;
            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (++easterEgg == 20)
            {
                this.BackColor = Color.Red;
            }
        }
    }
}
