using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace H24
{
    public class Vierkant : Vorm
    {
        private Rectangle rect;

        public Vierkant(int beginX, int beginY)
        {
            x = beginX;
            y = beginY;

            MaakVierkant();
        }

        private void MaakVierkant()
        {
            rect = new Rectangle();
            rect.Width = grootte;
            rect.Height = rect.Width;
            rect.Stroke = brush;
            rect.Margin = new Thickness(x, y, 0, 0);
        }

        public override void TonenOp(Canvas tekencanvas)
        {
            tekencanvas.Children.Add(rect);
        }
    }
}
