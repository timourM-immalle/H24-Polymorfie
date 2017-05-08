using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace H24
{
    public abstract class Vorm
    {
        protected int x;
        protected int y;
        protected int grootte = 75;
        protected SolidColorBrush brush = new SolidColorBrush(Colors.Black);
    }
}
