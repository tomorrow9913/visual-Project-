using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_project_20193156
{
    public enum Directions
    {
        Left,
        Right,
        Up,
        Down
    };
    class gameSetting
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static bool GameOver { get; set; }
        public static Directions directions { get; set; }

        public gameSetting(int speed, int size)
        {
            Width = 500 / size;
            Height = 500 / size;
            Score = 4;
            GameOver = false;
            directions = Directions.Down;

            Speed = 20;
            switch (speed)
            {
                case 0: Speed -= 5; break;
                case 2: Speed += 5; break;
            }
        }
    }

}
