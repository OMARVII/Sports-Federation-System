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
    /// Interaction logic for PlayersInEachTeamDG.xaml
    /// </summary>
    public partial class PlayersInEachTeamDG : Window
    {
        public PlayersInEachTeamDG()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            PlayersInEachTeamQuery pq = new PlayersInEachTeamQuery();
            pq.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            List<string> filtered_name = new List<string>();
            List<string> filtered_ID = new List<string>();
            List<string> filtered_Mob = new List<string>();
            for (int i = 0; i < Containers.Player_list.Count(); i++)
            {
                if (Containers.Player_list[i].get_teamname() == PlayersInEachTeamQuery.team_name)
                {
                    filtered_name.Add(Containers.Player_list[i].getName());
                    filtered_ID.Add(Containers.Player_list[i].getId());
                    filtered_Mob.Add(Containers.Player_list[i].getmobile());

                }
            }
            if (filtered_name.Count == 0)
            {
                MessageBox.Show("No Players In This Team");
            }
            else
            {
                listBox.ItemsSource = filtered_name;
                listBox1.ItemsSource = filtered_ID;
                listBox2.ItemsSource = filtered_Mob;
            }
        }

        private void PlayersInEachTeamdataG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            adminoptions op = new adminoptions();
            op.Show();
            this.Close();
        }
    }
}
