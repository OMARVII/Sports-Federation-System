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
    /// Interaction logic for adminlogin.xaml
    /// </summary>
    public partial class adminlogin : Window
    {
        public static bool admin = false;
        public adminlogin()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            bool valid = false;

            for (int i = 0; i < Containers.Admin_list.Count; i++)
            {
                if (Containers.Admin_list[i].getusername() == textBox.Text && Containers.Admin_list[i].getuserPassword() == passwordBox.Password)
                {
                    MessageBox.Show("Login Successfuly!");
                   
                        adminoptions optionform = new adminoptions();
                        optionform.Show();

                    admin = true;
                    this.Close();
                    valid = true;
                    break;
                }
            }
            if (!valid)
                MessageBox.Show("Wrong User-name or Password!");

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Loginas l = new Loginas();
            l.Show();
            this.Close();
        }
    }
}
