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
using System.Windows.Shapes;

namespace AttendanceSystem
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            txtDashboard.MouseLeftButtonDown += new MouseButtonEventHandler(txtDashboard_MouseLeftButtonDown);
        }

        public void btnLogout(object sender, RoutedEventArgs e)
        {

        }

        private void txtDashboard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            EmployeeRegistration win1 = new EmployeeRegistration();
            win1.Show();
        }
    }
}
