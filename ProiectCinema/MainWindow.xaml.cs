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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string uservar;
        public MainWindow(string _text)
        {
            InitializeComponent();
            this.DataContext = this;
            this.uservar = _text;
        }
        public string Loggeduser
        {
            get { return uservar; }
            set { uservar = value; }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to log out?", "Cinema IESC", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    LoginScreen dashboard = new LoginScreen();
                    dashboard.Show();
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }
    }
}
