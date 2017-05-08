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

namespace H24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTekenen_Click(object sender, RoutedEventArgs e)
        {
            Vorm cirkel = new Cirkel(40, 40);
            Vorm vierkant = new Vierkant(180, 180);
            List<Vorm> groepke = new List<Vorm>();

            canvas.Children.Clear();

            groepke.Add(cirkel);
            groepke.Add(vierkant);

            foreach (Vorm vormke in groepke)
            {
                vormke.TonenOp(canvas);
            }
        }

        private void btnAndersTekenen_Click(object sender, RoutedEventArgs e)
        {
            Vorm cirkel = new Cirkel(50, 50);
            Vorm vierkant = new Vierkant(200, 200);
            List<Vorm> groepke = new List<Vorm>();

            canvas.Children.Clear();

            foreach (Vorm vormke in groepke)
            {
                if (vormke is Cirkel)
                {
                    //Cirkel cirkelke = (Cirkel)vormke;
                    cirkel.TonenOp(canvas);
                }

                if (vormke is Vierkant)
                {
                    //Vierkant vierkantje = (Vierkant)vormke;
                    vierkant.TonenOp(canvas);
                }
            }
        }
    }
}
