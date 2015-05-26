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

using WPF_Chess.Common;
using WPF_Chess.Core;

namespace WPF_Chess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Chessboard _game = new Chessboard();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            _game.Init();
            var pieces = _game.Pieces;

            foreach (var piece in pieces)
            {
                DrawingVisual v = new DrawingVisual();
                using (var dc = v.RenderOpen())
                {
                    dc.DrawImage(
                        piece.Image,
                        new Rect(
                            new Point((piece.Position.X - 1) * 50, (piece.Position.Y - 1) * 50),
                            new Size(50, 50)
                            ));
                }
                boardSurface.AddPieces(v);
            }
        }
    }
}
