using System;
using System.Collections.Generic;
using System.Data;
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
                string query2 = "SELECT dataOra FROM difuzareFilme WHERE numeFilm = '" + title + "'";
                List<string> a = new List<string>();

                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
                SqlDataReader reader1 = sqlCmd1.ExecuteReader();
                reader1.Read();
                byte[] img = (byte[])(reader1[0]);
                MemoryStream ms = new MemoryStream(img);
                var imageSource = new BitmapImage();
                imageSource.BeginInit();
                imageSource.StreamSource = ms;
                imageSource.EndInit();
                Sursa = imageSource;
                Desc = reader1[2].ToString() + "\n\n" + reader1[1].ToString();
                Trailer = reader1[3].ToString();
                reader1.Close();

                SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    a.Add(dr[0].ToString());
                }
                Date1 = a[0];
                Date2 = a[1];
                Date3 = a[2];



            }
        }

        public string Date1
        {
            get { return (string)GetValue(Date1Property); }
            set { SetValue(Date1Property, value); }
        }

        public static readonly DependencyProperty Date1Property = DependencyProperty.Register("Date1", typeof(string), typeof(myControl1), new PropertyMetadata(null));
        public string Date2
        {
            get { return (string)GetValue(Date2Property); }
            set { SetValue(Date2Property, value); }
        }

        public static readonly DependencyProperty Date2Property = DependencyProperty.Register("Date2", typeof(string), typeof(myControl1), new PropertyMetadata(null));
        public string Date3
        {
            get { return (string)GetValue(Date3Property); }
            set { SetValue(Date3Property, value); }
        }

        public static readonly DependencyProperty Date3Property = DependencyProperty.Register("Date3", typeof(string), typeof(myControl1), new PropertyMetadata(null));

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

        private void BookButton_Click(object sender, RoutedEventArgs e)
        {
            WindowSala dashboard = new WindowSala();
            dashboard.ShowDialog();
            
        }


    }
}
