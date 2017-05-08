using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace H24
{
    class Cirkel : Vorm
    {
        private Ellipse ell;

        public Cirkel(int beginX, int beginY)
        {
            x = beginX;
            y = beginY;

            MaakCirkel();
        }

        private void MaakCirkel()
        {
            ell = new Ellipse();
            ell.Width = grootte;
            ell.Height = ell.Width;
            ell.Stroke = brush;
            ell.Margin = new Thickness(x, y, 0, 0);
        }

        public override void TonenOp(Canvas tekencanvas)
        {
            tekencanvas.Children.Add(ell);
        }
    }
}
