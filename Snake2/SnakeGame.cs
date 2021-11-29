using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snake2
{
    class SnakeGame
    {
        public enum DireccioSnake {Amunt,Dreta,Avall,Esquerra }
        public const int X_SIZE = 5;
        public const int Y_SIZE = 5;

        Point capSerp = new(X_SIZE / 2, Y_SIZE / 2);
        public Point CapSerp { get => capSerp; set => capSerp = value; }

        public DireccioSnake Direccio { get; set; } = DireccioSnake.Avall;

        public void Moure()
        {
            capSerp.Y++;
        }
    }
}
