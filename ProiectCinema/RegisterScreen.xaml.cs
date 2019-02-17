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
    /// Interaction logic for RegisterScreen.xaml
    /// </summary>
    public partial class RegisterScreen : Window
    {
        public RegisterScreen()
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
            if (txtBox.Text == "")
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
        private void OpCPassCBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            PasswordBox passBox = sender as PasswordBox;
            passBox.Opacity = 1;

        }
        private void OpCPassCBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            PasswordBox passBox = sender as PasswordBox;
            if (passBox.Password.ToString() == "")
                passBox.Opacity = 0.6;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\" + variabile.serverName + "; Initial Catalog=" + variabile.dBName + "; Integrated Security=True"))
            {
                if (UserTxtBoxR.Text == "" || PassTxtBoxR.Password.ToString() == "")
                    MessageBox.Show("Please enter a valid username and password.");
                else if (PassTxtBoxR.Password.ToString() != ConfirmPassBox.Password.ToString())
                    MessageBox.Show("Passwords do not match!");
                else
                {
                    if (sqlCon.State == System.Data.ConnectionState.Closed)
                        sqlCon.Open();

                    String query = "SELECT COUNT(*) FROM " + variabile.usertable + " WHERE username=@username";
                    SqlCommand sqlCmd1 = new SqlCommand(query, sqlCon);
                    sqlCmd1.CommandType = System.Data.CommandType.Text;
                    sqlCmd1.Parameters.AddWithValue("@username", UserTxtBoxR.Text);
                    int count = Convert.ToInt32(sqlCmd1.ExecuteScalar());
                    if (count == 1)
                        MessageBox.Show("Username already taken!");
                    else
                    {
                        SqlCommand sqlCmd = new SqlCommand("userAdd", sqlCon);
                        sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@username", UserTxtBoxR.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@password", PassTxtBoxR.Password.ToString().Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Registration succesful!");
                        this.Close();
                    }
                }
            }
        }
    }
}
