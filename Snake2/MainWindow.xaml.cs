using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Snake2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SnakeGame game = new();
        DispatcherTimer timer = new();
        
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int CasellaX = (int)canvas.ActualWidth / SnakeGame.X_SIZE;
            int CasellaY = (int)canvas.ActualHeight / SnakeGame.Y_SIZE;
            Ellipse ellipse = new()
            {
                Fill = Brushes.Black,
                Width = CasellaX,
                Height = CasellaY
            };
            canvas.Children.Add(ellipse);
            Canvas.SetTop(ellipse, CasellaY*game.CapSerp.Y);
            Canvas.SetLeft(ellipse, CasellaX * game.CapSerp.X);
        }

        private void canvas_KeyDown(object sender, KeyEventArgs e)
        {
            game.Moure();
        }
    }
}
