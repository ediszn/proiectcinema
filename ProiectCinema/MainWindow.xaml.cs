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

            filmeStack.Children.Add(new myControl1(variabile.film1,Loggeduser));
            filmeStack.Children.Add(new myControl1(variabile.film2,Loggeduser));
            filmeStack.Children.Add(new myControl1(variabile.film3,Loggeduser));
            filmeStack.Children.Add(new myControl1(variabile.film4,Loggeduser));
            filmeStack.Children.Add(new myControl1(variabile.film5,Loggeduser));
            filmeStack.Children.Add(new myControl1(variabile.film6,Loggeduser));
            filmeStack.Children.Add(new myControl1(variabile.film7,Loggeduser));
            filmeStack.Children.Add(new myControl1(variabile.film8,Loggeduser));

            //  afisajfilmeMW(variabile.film4);

        }

        //private void afisajfilmeMW(string title)
        //{
        //    using (SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\" + variabile.serverName + "; Initial Catalog=" + variabile.dBName + "; Integrated Security=True"))
        //    {
        //        string query1 = "SELECT afis FROM filmeMainWindow WHERE numeFilm = '"+title+"'";

        //        if (sqlCon.State == System.Data.ConnectionState.Closed)
        //            sqlCon.Open();
        //        SqlCommand sqlCmd = new SqlCommand(query1, sqlCon);
        //        SqlDataReader reader = sqlCmd.ExecuteReader();
        //        reader.Read();
        //        byte[] img = (byte[])(reader[0]);
        //        MemoryStream ms = new MemoryStream(img);
        //        var imageSource = new BitmapImage();
        //        imageSource.BeginInit();
        //        imageSource.StreamSource = ms;
        //        imageSource.EndInit();
        //        Afis1.Source = imageSource;
        //        reader.Close();

        //        string query2 = "SELECT descriere FROM filmeMainWindow WHERE numeFilm = '"+title+"'";
        //        if (sqlCon.State == System.Data.ConnectionState.Closed)
        //            sqlCon.Open();
        //        SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
        //        SqlDataReader reader2 = sqlCmd2.ExecuteReader();
        //        reader2.Read();
        //        Desc1.Text = reader2[0].ToString();
        //        reader2.Close();

        //    }
        //}

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
