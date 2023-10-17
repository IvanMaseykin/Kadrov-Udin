using Kadrov_Udin.WinFolder;
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

namespace Kadrov_Udin
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Entrance_Click(object sender, RoutedEventArgs e)
        {
            PresArea presArea = new PresArea();
            presArea.Show();
            Close();
        }

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            WinReg winReg = new WinReg();
            winReg.Show();
            Close();
        }
    }
}
