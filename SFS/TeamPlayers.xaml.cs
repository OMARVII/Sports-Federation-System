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
    /// Interaction logic for TeamPlayers.xaml
    /// </summary>
    public partial class TeamPlayers : Window
    {
        public TeamPlayers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            bool check = false;
            for (int i = 0; i < Containers.Player_list.Count; i++)
            {
                if (Containers.Player_list[i].getName() == textBox.Text)
                {
                    check = true;
                    break;
                }
            }
            if (textBox.Text == "")
            {
                MessageBox.Show("Please fill the required information");
            }
            else if (check==false)
            {
                MessageBox.Show("Please enter valid name");
            }

            else
            {
                List<string> tname = new List<string>();
                List<string> tteam = new List<string>();
                List<float> bonus = new List<float>();

                for (int i = 0; i < Containers.Player_list.Count; i++)
                {
                    if (Containers.Player_list[i].getName() == textBox.Text)
                    {
                        tname.Add(Containers.Player_list[i].getName());
                        tteam.Add(Containers.Player_list[i].get_teamname());
                        bonus.Add(Containers.Player_list[i].getBonus());

                    }

                }
                listBox.ItemsSource = tname;
                listBox1.ItemsSource = tteam;
                listBox2.ItemsSource = bonus;

            }


        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            List<string> tteam = new List<string>();
            List<string> tname = new List<string>();
            List<float> bonus= new List<float>();



            for (int i = 0; i < Containers.Player_list.Count; i++)
            {
               
               
                    tname.Add(Containers.Player_list[i].getName());
                tteam.Add(Containers.Player_list[i].get_teamname());
                bonus.Add(Containers.Player_list[i].getBonus());


            }
            listBox.ItemsSource = tname;
            listBox1.ItemsSource = tteam;
            listBox2.ItemsSource = bonus;

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(adminoptions.disp==true)
            {
displayOptions d = new displayOptions();
            d.Show();
            this.Close();
            }
            else if (adminoptions.search==true)
            {
                searchoptions sp = new searchoptions();
                sp.Show();
            }
            
        }
    }
    }
    
