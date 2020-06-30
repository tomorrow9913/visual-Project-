using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using visual_project_20193156.Properties;

namespace visual_project_20193156
{
    public partial class InGame : Form
    {
        private List<Cell> Snake = new List<Cell>();
        private Cell apple = new Cell();

        string GetText;
        int size;
        int speed;

        public InGame(string ParentsText)
        {
            InitializeComponent();

            // setting 값 불러오기
            this.GetText = ParentsText;
        }


        // 정보 입력 & 게임 초기 세팅
        private void InGame_Load(object sender, EventArgs e)
        {
            // 세팅 가져오기
            string[] setting = GetText.Split('/');

            this.size = int.Parse(setting[0]);
            this.speed = int.Parse(setting[1]);

            // 출력
            size_label.Text = size.ToString() + " x " + size.ToString();

            switch (speed)
            {
                case 0: speed_label.Text = "느림"; break;
                case 1: speed_label.Text = "보통"; break;
                case 2: speed_label.Text = "빠름"; break;
            }

            // 게임 세팅
            new gameSetting(speed, size);

            gameTimer.Interval = 1000 / (gameSetting.Speed);
            gameTimer.Tick += updateScreen;
            gameTimer.Start();

            // 게임 시작
            startGame();
        }

        private void updateScreen(object sender, EventArgs e)
        {
            if (gameSetting.GameOver == true)
            {
                // 게임 재시작 전까지 대기
                if (Input.KeyPress(Keys.Enter)) startGame();
            }
            else
            {
                // 방향 전환
                if (Input.KeyPress(Keys.Right) && gameSetting.directions != Directions.Left)
                {
                    gameSetting.directions = Directions.Right;
                }
                else if (Input.KeyPress(Keys.Left) && gameSetting.directions != Directions.Right)
                {
                    gameSetting.directions = Directions.Left;
                }
                else if (Input.KeyPress(Keys.Up) && gameSetting.directions != Directions.Down)
                {
                    gameSetting.directions = Directions.Up;
                }
                else if (Input.KeyPress(Keys.Down) && gameSetting.directions != Directions.Up)
                {
                    gameSetting.directions = Directions.Down;
                }

                // 뱀 이동
                moveSnake();
            }
            Canvas.Invalidate();
        }

        private void moveSnake()
        {
            // 꼬리부터 그림
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                // 머리 일때
                if (i == 0)
                {
                    // 현재 이동 방향에 따라 방향 전환
                    switch (gameSetting.directions)
                    {
                        case Directions.Right: Snake[i].x++; break;
                        case Directions.Left: Snake[i].x--; break;
                        case Directions.Up: Snake[i].y--; break;
                        case Directions.Down: Snake[i].y++; break;
                    }

                    // 맵의 끝 확인
                    int maxPositionX = Canvas.Size.Width / gameSetting.Width;
                    int maxPositionY = Canvas.Size.Height / gameSetting.Height;

                    // 만약 끝을 넘어가면 반대 벽으로 이동.
                    if (Snake[i].x < 0) Snake[i].x = maxPositionX;
                    else if (Snake[i].x > maxPositionX) Snake[i].x = 0;
                    if (Snake[i].y < 0) Snake[i].y = maxPositionY;
                    else if (Snake[i].y > maxPositionY) Snake[i].y = 0;

                    // 뱀에게 부딛혔는지 확인
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[0].x == Snake[j].x && Snake[0].y == Snake[j].y) die();
                    }

                    // apple 획득 확인
                    if (Snake[0].x == apple.x && Snake[0].y == apple.y) eat();
                }
                else
                {
                    // 뱀 앞으로 이동
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }
        }

        private void startGame()
        {
            // 초기화
            GameOver_msg.Visible = false;

            Snake.Clear();

            Snake.Add(new Cell { x = 10, y = 5 });
            for (int i = 0; i < 3; i++) Snake.Add(
                new Cell { x = Snake[Snake.Count - 1].x, y = Snake[Snake.Count - 1].y }
            );

            gameSetting.Score = 4;
            now_score.Text = gameSetting.Score.ToString() + " Points";
            gameSetting.directions = Directions.Down;
            gameSetting.GameOver = false;

            // 사과 생성
            genApple();
        }

        private void genApple()
        {
            // 생성 범위 지정
            int maxPositionX = Canvas.Size.Width / gameSetting.Width;
            int maxPositionY = Canvas.Size.Height / gameSetting.Height;

            Random rand = new Random();
            apple = new Cell { x = rand.Next(0, maxPositionX), y = rand.Next(0, maxPositionY) };
        }

        private void eat()
        {
            // 몸 길이 증가
            Cell body = new Cell
            {
                x = Snake[Snake.Count - 1].x,
                y = Snake[Snake.Count - 1].y
            };
            Snake.Add(body);

            // 점수 표기 변경
            gameSetting.Score++;
            now_score.Text = gameSetting.Score.ToString() + " Points";

            // 사과 재생성
            genApple();
        }

        private void die()
        {
            gameSetting.GameOver = true;
        }

        private void InGame_KeyDown(object sender, KeyEventArgs e)
        {
            // 해당 키가 눌렸다고 체크
            Input.changeState(e.KeyCode, true);
        }

        private void InGame_KeyUp(object sender, KeyEventArgs e)
        {
            // 체크 해제
            Input.changeState(e.KeyCode, false);
        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (gameSetting.GameOver == false)
            {
                Brush snakeColor = Brushes.Green;

                for (int i = 0; i < Snake.Count; i++)
                {
                    canvas.FillRectangle(snakeColor,
                                new Rectangle(
                                    Snake[i].x * gameSetting.Width,
                                    Snake[i].y * gameSetting.Height,
                                    gameSetting.Width-1, gameSetting.Height-1
                                ));
                    canvas.FillRectangle(Brushes.Red,
                                new Rectangle(
                                    apple.x * gameSetting.Width,
                                    apple.y * gameSetting.Height,
                                    gameSetting.Width-1, gameSetting.Height-1
                                ));
                }
            }
            else
            {
                // 현재 기록 가져오기
                string[] recordPoint = record_score.Text.Split(' ');
                
                // 기록 경신시 업데이트
                if (gameSetting.Score > int.Parse(recordPoint[0]))
                    record_score.Text = gameSetting.Score.ToString() + " Points";

                // 게임오버 상태 메시지 출력
                now_score.Text = "Game Over";
                GameOver_msg.Visible = true;
            }
        }

        private void 게임종료xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "게임종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit();
        }
    }
}
