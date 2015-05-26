using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPF_Chess.Core;

namespace WPF_Chess.Component
{
    class BoardCanvas : Canvas
    {
        private const int GRID_SIZE = 50;

        private List<Visual> _visuals = new List<Visual>();

        protected override int VisualChildrenCount
        {
            get
            {
                return _visuals.Count;
            }
        }

        protected override Visual GetVisualChild(int index)
        {
            return _visuals[index];
        }

        public void AddVisual(Visual visual)
        {
            _visuals.Add(visual);

            base.AddVisualChild(visual);
            base.AddLogicalChild(visual);
        }

        public void AddPiece(Piece piece)
        {
            DrawingVisual v = new DrawingVisual();
            using (var dc = v.RenderOpen())
            {
                dc.DrawImage(
                    piece.Image,
                    new Rect(
                        new Point(piece.Position.X * GRID_SIZE, piece.Position.Y * GRID_SIZE),
                        new Size(GRID_SIZE, GRID_SIZE)
                        ));
            }
            AddVisual(v);
        }

        public void RemoveVisual(Visual visual)
        {
            _visuals.Remove(visual);

            base.RemoveVisualChild(visual);
            base.RemoveLogicalChild(visual);
        }
    }
}
