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
using System.Xml;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Data;

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
                bool clubbl = false;
                for (int i = 0; i < Containers.Club_list.Count; i++)
                {
                    if (Teamname.Text == Containers.Club_list[i].getClubName())
                    {
                        clubbl = true;
                    }

                }
                if (clubbl == false)
                {
                    MessageBox.Show("Club doesn't exist ! ");
                }
                else
                {
                    for (int i = 0; i < Containers.Player_list.Count; i++)
                    {
                        if (Containers.Player_list[i].getId().ToString() == Enter_ID.playerid)
                        {

                            Containers.Player_list[i].setclubName(Teamname.Text);
                        }
                    }
                    if (File.Exists("Players.xml"))
                    {
                        File.Delete("Players.xml");
                    }

                    for (int i = 0; i < Containers.Player_list.Count; i++)
                    {
                        Containers.write_Player(Containers.Player_list[i]);

                    }
                    MessageBox.Show("Changes Done");


                }
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Edit_Player p = new Edit_Player();
            p.Show();
            this.Close();
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}
