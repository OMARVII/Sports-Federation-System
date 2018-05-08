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
    /// Interaction logic for Add_Options.xaml
    /// </summary>
    public partial class Add_Options : Window
    {
        public Add_Options()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (choose.Text == "")
            {
                MessageBox.Show("Please Choose An Option");
            }
               else  if (choose.Text == "Employee")
            {
                if (employeelogin.empid == true)
                {
                    MessageBox.Show("You are not alowed to add employee");
                }
                else
                {
                    Add_Employee ee = new Add_Employee();
                    ee.Show();
                    this.Close();
                }
            }
            else if (choose.Text == "Player")
            {
                Add_Player p = new Add_Player();
                p.Show();
                this.Close();
            }
            else if (choose.Text == "Club")
            {
                Add_Club c = new Add_Club();
                c.Show();
                this.Close();
            }
            else if (choose.Text == "Team")
            {
                Add__Team t = new Add__Team();
                t.Show();
                this.Close();
            }
            else if (choose.Text == "Championship")
            {
                Add_Championship cc = new Add_Championship();
                cc.Show();
                this.Close();
            }
            
        }

        private void choose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}
