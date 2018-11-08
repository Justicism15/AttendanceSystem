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
    /// Interaction logic for EmployeeRegistration.xaml
    /// </summary>
    public partial class EmployeeRegistration : Window
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }

          public void btnSave(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save Successful!");
            this.Close();
        }

        public void btnCancel(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result =
             MessageBox.Show("Stop Operation?",
            "Cancel", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                this.Close();
            }
            else
            {
                // Do something  
            }
        }
    
    }
}
