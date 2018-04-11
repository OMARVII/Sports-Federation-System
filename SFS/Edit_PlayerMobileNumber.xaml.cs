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
    /// Interaction logic for Edit_PlayerMobileNumber.xaml
    /// </summary>
    public partial class Edit_PlayerMobileNumber : Window
    {
        public Edit_PlayerMobileNumber()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Edit_Player ep = new Edit_Player();
            ep.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "" || mobilee.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
            else if (textBox1.Text == mobilee.Text)
            {
                MessageBox.Show("Please enter a diffrent Mobile Number!");
                textBox1.Clear();
                mobilee.Clear();
            }
            else
            {
                for (int i = 0; i < Containers.Player_list.Count; i++)
                {
                    if (Containers.Player_list[i].getId().ToString() == Enter_ID.playerid)
                    {
                        Containers.Player_list[i].setmobile(mobilee.Text);
                    }

                }
                MessageBox.Show("Done Changes");
            }

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
