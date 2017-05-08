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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 40;
            rect.Height = 25.5;
            rect.Fill = new SolidColorBrush(Colors.Red);
            rect.Margin = new Thickness(250, 250, 0, 0);
            canvas.Children.Add(rect);
        }
    }
}
