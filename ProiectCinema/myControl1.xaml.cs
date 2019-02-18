using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
    /// Interaction logic for myControl1.xaml
    /// </summary>
    public partial class myControl1 : UserControl
    {

        public myControl1(string param)
        {
            InitializeComponent();

            afisajfilmeMW(param);
        }

        private void afisajfilmeMW(string title)
        {

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\" + variabile.serverName + "; Initial Catalog=" + variabile.dBName + "; Integrated Security=True"))
            {
                string query1 = "SELECT afis, descriere, numeFilm, trailer FROM filmeMainWindow WHERE numeFilm = '" + title + "'";

                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand(query1, sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                reader.Read();
                byte[] img = (byte[])(reader[0]);
                MemoryStream ms = new MemoryStream(img);
                var imageSource = new BitmapImage();
                imageSource.BeginInit();
                imageSource.StreamSource = ms;
                imageSource.EndInit();
                Sursa = imageSource;
            //    reader.Close();

            //    string query2 = "SELECT descriere FROM filmeMainWindow WHERE numeFilm = '" + title + "'";
            //    if (sqlCon.State == System.Data.ConnectionState.Closed)
            //        sqlCon.Open();
            //    SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
            //    SqlDataReader reader2 = sqlCmd2.ExecuteReader();
            //    reader2.Read();
                Desc = reader[2].ToString() + "\n\n" + reader[1].ToString();

                Trailer = reader[3].ToString();
                reader.Close();
            }
        }

        public string Trailer
        {
            get { return (string)GetValue(TrailerProperty);  }
            set { SetValue(TrailerProperty, value);  }
        }

        public static readonly DependencyProperty TrailerProperty = DependencyProperty.Register("Trailer", typeof(string), typeof(myControl1), new PropertyMetadata(null));

        public BitmapImage Sursa
        {
            get { return (BitmapImage)GetValue(SursaProperty); }
            set { SetValue(SursaProperty, value); }
        }

        public static readonly DependencyProperty SursaProperty = DependencyProperty.Register("Sursa", typeof(BitmapImage), typeof(myControl1), new PropertyMetadata(null));

        public string Desc
        {
            get { return (string)GetValue(DescProperty); }
            set { SetValue(DescProperty, value); }
        }

        public static readonly DependencyProperty DescProperty = DependencyProperty.Register("Desc", typeof(string), typeof(myControl1), new PropertyMetadata(null));

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }


    }
}
