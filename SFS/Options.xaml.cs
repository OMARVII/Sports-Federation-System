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

namespace SFS
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
          InitializeComponent();
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            Add_Options ao = new Add_Options();
            ao.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Enter_ID ed = new Enter_ID();
            ed.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Enter_ID ed = new Enter_ID();
            ed.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Loginas lgn = new Loginas();
            lgn.Show();
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform mq = new mainqueryform();
            mq.Show();
            this.Close();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            displayOptions dp = new displayOptions();
            dp.Show();
            this.Close();

        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            searchoptions os = new searchoptions();
            os.Show();
            this.Close();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Loginas lgn = new Loginas();
            lgn.Show();
            this.Close();
        }
    }
}
