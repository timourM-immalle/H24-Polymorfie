using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace H24
{
    class RndVierkant : Vierkant
    {
        private Random rndPositie = new Random();
        private Rectangle rect = new Rectangle();

        public RndVierkant() : base(0, 0)
        {

        }

        protected override void MaakVierkant()
        {
            base.MaakVierkant();
            rect.Fill = new SolidColorBrush(Colors.Red);
        }

        public override void TonenOp(Canvas tekenCanvas)
        {
            //Geef voor dit ZEKER de Width- en Height-properties aan canvas mee:
            int x = rndPositie.Next((int)tekenCanvas.Width);
            int y = rndPositie.Next((int)tekenCanvas.Height);

            rect.Margin = new Thickness(x, y, 0, 0);

            base.TonenOp(tekenCanvas);
        }
    }
}
