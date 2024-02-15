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

namespace Golovchenko_WPF
{
    /// <summary>
    /// Логика взаимодействия для ManagingStaff.xaml
    /// </summary>
    public partial class ManagingStaff : Window
    {
        public ManagingStaff()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            NewStaff addingStaff = new NewStaff();
            addingStaff.Show();
            Close();
        }
    }
}
