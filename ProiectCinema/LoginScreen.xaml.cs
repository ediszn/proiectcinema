using System;
using System.Collections.Generic;
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
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void OpCTxtBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.Opacity = 1;
            
        }
        private void OpCTxtBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if(txtBox.Text == "")
                txtBox.Opacity = 0.6;
        }
        private void OpCPassBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            PasswordBox passBox = sender as PasswordBox;
            passBox.Opacity = 1;

        }
        private void OpCPassBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            PasswordBox passBox = sender as PasswordBox;
            if (passBox.Password.ToString() == "")
                passBox.Opacity = 0.6;
        }


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\" + variabile.serverName + "; Initial Catalog=" + variabile.dBName + "; Integrated Security=True"))
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                String query = "SELECT COUNT(*) FROM " + variabile.usertable + " WHERE username=@username AND password=@password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@username", UserTxtBox.Text);
                sqlCmd.Parameters.AddWithValue("@password", PassTxtBox.Password.ToString());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MainWindow dashboard = new MainWindow(UserTxtBox.Text);
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    if (UserTxtBox.Text == "" || PassTxtBox.Password.ToString() == "")
                        MessageBox.Show("Please enter a valid username and password.");
                    else
                        MessageBox.Show("Username or password is incorrect!");
                }
            }
        }

        private void RegisterText_Click(object sender, RoutedEventArgs e)
        {
            RegisterScreen dashboard = new RegisterScreen();
            dashboard.ShowDialog();
        }
    }
}
