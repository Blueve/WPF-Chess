using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_Chess.Component
{
    class BoardCanvas : Canvas
    {
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

        public void AddPieces(Visual visual)
        {
            _visuals.Add(visual);

            base.AddVisualChild(visual);
            base.AddLogicalChild(visual);
        }

        public void RemoveVisual(Visual visual)
        {
            _visuals.Remove(visual);

            base.RemoveVisualChild(visual);
            base.RemoveLogicalChild(visual);
        }
    }
}
