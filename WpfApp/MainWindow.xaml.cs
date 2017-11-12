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
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Goodbay");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name;
            string email;
            string password;
            int error=0;
            if (Name.Text != "" && eMail.Text != "" && Password.Text != "" && Confirm_password.Text != "")
            {
                name = Name.Text;
                email = eMail.Text;
                password = Password.Text;
                if (!Regex.IsMatch(email, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MessageBox.Show("Enter a valid email");
                    error++;
                    eMail.Text = "";
                    eMail.Focus();
                }

                else if (password.Length > 15 || password.Length < 6)
                {
                    MessageBox.Show("Password must have at least 6 chars and  not more 15");
                    error++;
                }
                else if (password != Confirm_password.Text)
                {
                    MessageBox.Show("Confirm password is not match");
                    error++;
                }



                if (error == 0)
                {
                    SqlConnection conect = new SqlConnection("Data Source = MARIAZHUKOVA; Initial Catalog = ForWPFapp; Integrated Security = True");
                    conect.Open();
                    SqlCommand cmd = new SqlCommand("insert into dbo.UsersData(UserName,eMail,Password)values('" + name + "','" + email + "','" + password + "')", conect);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conect.Close();
                    MessageBox.Show("You have Registered successfully.");
                    Reset();
                }
            }
            else MessageBox.Show("Please fill all filds");
            Name.Focus();

        }

        private void Reset()
        {
            Name.Clear();
            eMail.Clear();
            Password.Clear();
            Confirm_password.Clear();
            Name.Focus();
        }
    }
}
