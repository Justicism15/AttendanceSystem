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
using System.ComponentModel;


namespace AttendanceSystem
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

        public void btnLogin(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text.ToString();
            string password = txtPassword.Password.ToString();

            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Login Successful!");
                Dashboard win1 = new Dashboard();
                win1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login Details!");
                txtUsername.Text = "";
                txtPassword.Password= "";
            }
        }
    }
}
