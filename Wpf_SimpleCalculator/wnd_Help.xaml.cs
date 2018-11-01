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

namespace Wpf_SimpleCalculator
{
    /// <summary>
    /// Interaction logic for wnd_Help.xaml
    /// </summary>
    public partial class wnd_Help : Window
    {
        public wnd_Help()
        {
            InitializeComponent();
        }

        private void txtBox_Help_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_NotHelpful_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
