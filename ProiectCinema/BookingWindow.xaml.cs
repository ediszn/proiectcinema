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
    public partial class BookingWindow : Window
    {

        string paramuser;
        public BookingWindow(string paramuser)
        {
            this.paramuser = paramuser;
            DataContext = this;
            
            List<string> filmesiora = new List<string>();

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\" + variabile.serverName + "; Initial Catalog=" + variabile.dBName + "; Integrated Security=True"))
            {
                string query1 = "SELECT numeFilm, dataOra, loc FROM rezervari WHERE username = '" + paramuser + "'";
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string fso = dr[0].ToString() + " " + dr[1].ToString();
                    if(!filmesiora.Contains(fso))
                    {
                        filmesiora.Add(fso);
                        
                    }
                }

                string rez = "";
                for(int i = 0; i < filmesiora.Count(); i++)
                {
                    string locuriocupate = "";
                    foreach (DataRow dr in dt.Rows)
                    {
                        string fso = dr[0].ToString() + " " + dr[1].ToString();

                        if(fso == filmesiora[i])
                        {
                            locuriocupate = locuriocupate + " " + (Convert.ToString(dr[2]));
                        }
                    }
                    rez += filmesiora[i] + " " + locuriocupate + "\n";
                }

                RezBind = rez;
            }

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
