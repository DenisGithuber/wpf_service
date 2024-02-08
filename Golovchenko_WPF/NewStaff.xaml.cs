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
    /// Логика взаимодействия для NewStaff.xaml
    /// </summary>
    public partial class NewStaff : Window
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void btn_AddStaff(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сотрудник добавлен!");
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();

            Close();
        }
    }
}
