using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        public override void TonenOp(Canvas tekencanvas)
        {

        }
    }
}
