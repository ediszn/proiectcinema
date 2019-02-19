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
    public partial class AdminWindow : Window
    {
        string uservar;
        public AdminWindow(string _text)
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

        private void AddMovie_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\" + variabile.serverName + "; Initial Catalog=ProiectCinema; Integrated Security=True"))
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                String query = "SELECT COUNT(*) FROM filmeMainWindow WHERE numeFilm=@numeFilm";
                SqlCommand sqlCmd1 = new SqlCommand(query, sqlCon);
                sqlCmd1.CommandType = System.Data.CommandType.Text;
                sqlCmd1.Parameters.AddWithValue("@numeFilm", NameTextBox.Text);
                int count = Convert.ToInt32(sqlCmd1.ExecuteScalar());
                if (count == 1)
                    MessageBox.Show("Movie already exists!");
                else
                {
                    byte[] images = null;
                    FileStream Stream = new FileStream(ImageTextBox.Text.Trim(), FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Stream);
                    images = brs.ReadBytes((int)Stream.Length);

                    string query1 = "INSERT INTO filmeMainWindow(numeFilm,descriere,afis,trailer)VALUES(@numeFilm,@descriere,@images,@trailer)";

                    SqlCommand sqlCmd2 = new SqlCommand(query1, sqlCon);
                    sqlCmd2.Parameters.AddWithValue("@numeFilm", NameTextBox.Text.Trim());
                    sqlCmd2.Parameters.AddWithValue("@descriere", DescTextBox.Text.Trim());
                    sqlCmd2.Parameters.AddWithValue("@trailer", TrailerTextBox.Text.Trim());
                    sqlCmd2.Parameters.Add(new SqlParameter("@images", images));
                    sqlCmd2.ExecuteNonQuery();

                    MessageBox.Show("Movie added!");
                }
            }
        }

        private void Raport_Click(object sender, RoutedEventArgs e)
        {
            RaportWindow dashraport = new RaportWindow();
            dashraport.ShowDialog();

        }
    }
    
}
