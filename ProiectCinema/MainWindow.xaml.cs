using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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

            List<string> listafilme = new List<string>();

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\" + variabile.serverName + "; Initial Catalog=ProiectCinema; Integrated Security=True"))
            {
                string query1 = "SELECT numeFilm FROM filmeMainWindow";

                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    listafilme.Add(Convert.ToString(dr[0]));
                }
            }

            for(int i = 0; i < listafilme.Count(); i++)
            {
                filmeStack.Children.Add(new myControl1(listafilme[i], Loggeduser));
            }
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
        private void RezervationsButton_Click(object sender, RoutedEventArgs e)
        {
             BookingWindow dashboard = new BookingWindow(Loggeduser);
             dashboard.ShowDialog();
        }
    }
}
