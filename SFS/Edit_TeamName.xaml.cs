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
    /// Interaction logic for Edit_TeamName.xaml
    /// </summary>
    public partial class Edit_TeamName : Window
    {
        public Edit_TeamName()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Teamname.Text == "")
                MessageBox.Show("Please fill the required information !");

            else
            {
                for (int i = 0; i < Containers.Player_list.Count; i++)
                {
                    if (Containers.Player_list[i].getId().ToString() == Enter_ID.playerid)
                    {

                        Containers.Player_list[i].set_teamname(Teamname.Text);
                    }
                }
                MessageBox.Show("Done Changes");
            }

        }
    }
}
