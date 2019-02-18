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

namespace ProiectCinema
{
    /// <summary>
    /// Interaction logic for WindowSala.xaml
    /// </summary>
    public partial class WindowSala : Window
    {
        SolidColorBrush mybluebrush = new SolidColorBrush(Color.FromRgb(0x33, 0x99, 0xCC));
        public List<int> locuriselectate = new List<int>();
        public WindowSala()
        {
            List<int> locuriocupate = new List<int>();

            locuriocupate.Add(10);
            locuriocupate.Add(1);
            locuriocupate.Add(3);
            bool steag = false;

            InitializeComponent();
            for (int i = 1; i < 46; i++)
            {
                steag = false;
                for (int j = 0; j < locuriocupate.Count; j++)
                    if (i == locuriocupate[j])
                        steag = true;

                if (steag == true)

                    gridlocuri.Children.Add(btndes(i));

                else
                    gridlocuri.Children.Add(btn(i));
            }
        }
        Button btn(int i)
        {
            Button b = new Button();
            b.Content = i.ToString();
            b.Width = 40;
            b.Height = 40;
            Thickness margin = b.Margin;
            margin.Bottom = 10;
            margin.Left = 2;
            b.Margin = margin;
            b.Background = mybluebrush;
            b.Click += Button_Click;
            return b;
        }
        Button btndes(int i)
        {
            Button b = new Button();
            b.Content = i.ToString();
            b.Width = 40;
            b.Height = 40;
            Thickness margin = b.Margin;
            margin.Bottom = 10;
            margin.Left = 2;
            b.Margin = margin;

            b.IsEnabled = false;
            return b;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button loc = sender as Button;
            if (loc.Background == mybluebrush)
            {
                loc.Background = Brushes.Green;
                locuriselectate.Add(Convert.ToInt32(loc.Content.ToString()));
            }

            else
            {
                loc.Background = mybluebrush;
                locuriselectate.Remove(Convert.ToInt32(loc.Content.ToString()));
            }
        }

        private void rezervare(object sender, RoutedEventArgs e)
        {
            string locuri = "";
            for (int i = 0; i < locuriselectate.Count; i++)
            {

                locuri = locuri + " " + locuriselectate[i].ToString();
            }
            MessageBox.Show("ati rezervat locurile :" + locuri);
        }
    }
}
