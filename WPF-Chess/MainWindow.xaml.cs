﻿using System;
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
        private Game _game = new Game();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            Player p1 = new Player(Piece.Side.Black);
            Player p2 = new Player(Piece.Side.White);
            _game.Start(p1, p2);
            var pieces = _game.Pieces;

            foreach (var piece in pieces)
            {
                boardSurface.AddPiece(piece);
            }
        }
    }
}
