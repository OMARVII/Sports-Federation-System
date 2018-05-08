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
    /// Interaction logic for display_team.xaml
    /// </summary>
    public partial class display_team : Window
    {
        public display_team()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (adminoptions.disp == true)
            {
                displayOptions z = new displayOptions();
                z.Show();
                this.Close();
            }
            else
            {
                searchoptions so = new searchoptions();
                so.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            if (names.Text == "")
            {
                List<string> Name = new List<string>();
                List<string> coachname = new List<string>();
                List<int> results = new List<int>();
                List<string> type = new List<string>();
                List<string> club = new List<string>();

                for (int i = 0; i < Containers.Team_list.Count; i++)
                {
                    Name.Add(Containers.Team_list[i].getTeam());

                    coachname.Add(Containers.Team_list[i].getcoachname());
                    results.Add(Containers.Team_list[i].Gettotalresults());
                    type.Add(Containers.Team_list[i].getage());
                    club.Add(Containers.Team_list[i].getClubName());

                }
                listBox.ItemsSource = Name;
                listBox1.ItemsSource = coachname;
                listBox2.ItemsSource = results;
                listBox3.ItemsSource = type;
               listBox4.ItemsSource = club;



            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            bool available = false;
            if (names.Text == "")
            {
                MessageBox.Show("Please fill the required information");
            }
            else
            {
                List<string> Name = new List<string>();
                List<string> coachname = new List<string>();
                List<int> results = new List<int>();
                List<string> type = new List<string>();
                List<string> club = new List<string>();


                for (int i = 0; i < Containers.Team_list.Count; i++)
                {
                    if (Containers.Team_list[i].getTeam() == names.Text)
                    {
                        available = true;
                        Name.Add(Containers.Team_list[i].getTeam());
                        coachname.Add(Containers.Team_list[i].getcoachname());
                        results.Add(Containers.Team_list[i].Gettotalresults());
                        type.Add(Containers.Team_list[i].getage());
                        club.Add(Containers.Team_list[i].getClubName());

                    }

                }
                if (available == false)
                {
                    MessageBox.Show("No available team!");

                }
                else
                {
                    listBox.ItemsSource = Name;
                    listBox1.ItemsSource = coachname;
                    listBox2.ItemsSource = results;
                    listBox3.ItemsSource = type;
                    listBox4.ItemsSource = club;

                }
            }
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions a = new adminoptions();
            a.Show();
            this.Close();
        }
    }
}
