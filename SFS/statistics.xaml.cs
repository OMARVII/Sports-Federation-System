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
    /// Interaction logic for statistics.xaml
    /// </summary>
    public partial class statistics : Window
    {
        public statistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            adminoptions a = new adminoptions();
            a.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions a = new adminoptions();
            a.Show();
            this.Close();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (choose.Text == "")
            {
                MessageBox.Show("Please Choose An Option !");
            }
            else if(choose.Text == "Salaries")
            {
                ChartDemo ch = new ChartDemo();
                ch.Show();
                this.Close();

            }
            else if (choose.Text == "Departments")
            {
                DoughnutChartExample don = new DoughnutChartExample();
                don.Show();
                this.Close();

            }
            else if (choose.Text == "Player Results")
            {
                PlayersChart p = new PlayersChart();
                p.Show();
                this.Close();

            }
            else if (choose.Text == "Club Results")
            {
                reschart r = new reschart();
                r.Show();
                this.Close();

            }



        }
    }
}
