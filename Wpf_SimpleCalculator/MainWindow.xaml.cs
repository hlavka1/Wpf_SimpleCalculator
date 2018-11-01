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

namespace Wpf_SimpleCalculator
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

        private void radBtn_NotDrunk_Checked(object sender, RoutedEventArgs e)
        {
            //show not drunk message
            MessageBox.Show("How boring!");
        }

        private void radBtn_Drunk_Checked(object sender, RoutedEventArgs e)
        {
            //show drunk messge
           // MessageBox.Show("You should not be drunk calculating Sober up and try again");
            wnd_DrunkMessage wnd_DrunkMessage = new wnd_DrunkMessage();
            wnd_DrunkMessage.ShowDialog();
        }

        private void btn_Calculate_Click(object sender, RoutedEventArgs e)
        {
            //if (radBtn_Drunk.Checked == true)
            //{
            //    MessageBox.Show("You should not be drunk calculating Sober up and try again");

            //}

            //else
            //{
            //    MessageBox.Show("How boring!");
            //}
            txtBox_TotalDrunks.Text = (int.Parse(txtBox_DrunksPerBus.Text) * int.Parse(txtBox_NumberOfBuses.Text)).ToString();
        }

        private void btn_Help_Click(object sender, RoutedEventArgs e)
        {
              // MessageBox.Show("Help Me!");
            wnd_Help wnd_Help = new wnd_Help();

        
          
           // wnd_Help.GetWindow(wnd_Help);

            wnd_Help.ShowDialog();
        }
    }
}
