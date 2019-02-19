using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace ProiectCinema
{
    /// <summary>
    /// Interaction logic for BookingWindow.xaml
    /// </summary>
    public partial class RaportWindow : Window
    {

        public RaportWindow()
        {
            DataContext = this;

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

            string filmsucces = "";
            for (int i = 0; i < listafilme.Count; i++)
            {
                int a = 0;
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\" + variabile.serverName + "; Initial Catalog=ProiectCinema; Integrated Security=True"))
                {
                    string query1 = "SELECT loc FROM rezervari WHERE numeFilm = '" + listafilme[i] + "'";
                    if (sqlCon.State == System.Data.ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
                    SqlDataAdapter da = new SqlDataAdapter(sqlCmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        a++;
                    }
                    filmsucces += listafilme[i] + " has " + a.ToString() + " seats booked \n";

                }
            }
            RezBind = filmsucces;

            InitializeComponent();
        }
        public string RezBind
        {
            get { return (string)GetValue(RezBindProperty); }
            set { SetValue(RezBindProperty, value); }
        }
        public static readonly DependencyProperty RezBindProperty = DependencyProperty.Register("RezBind", typeof(string), typeof(myControl1), new PropertyMetadata(null));
    }
}
