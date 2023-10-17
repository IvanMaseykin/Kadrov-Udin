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

namespace Kadrov_Udin.WinFolder
{
    /// <summary>
    /// Логика взаимодействия для PresArea.xaml
    /// </summary>
    public partial class PresArea : Window
    {
        public PresArea()
        {
            InitializeComponent();
        }

        private void leaveAcc_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
