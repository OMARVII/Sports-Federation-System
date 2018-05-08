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
    /// Interaction logic for PlayersInEachTeamQuery.xaml
    /// </summary>
    public partial class PlayersInEachTeamQuery : Window
    {
        public static string team_name = "";
        public PlayersInEachTeamQuery()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (names.Text == "")
            {
                MessageBox.Show("Please Enter valid Team Name ");
            }
            else
            {
                team_name = names.Text;
                List<Player> filtered = new List<Player>();
                for (int i = 0; i < Containers.Player_list.Count(); i++)
                {
                    if (Containers.Player_list[i].get_teamname() == names.Text)
                    {
                        filtered.Add(Containers.Player_list[i]);
                    }
                }
                PlayersInEachTeamDG d = new PlayersInEachTeamDG();
                d.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform mq = new mainqueryform();
            mq.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions ap = new adminoptions();
            ap.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            adminoptions ap = new adminoptions();
            ap.Show();
            this.Close();
        }
    }
}
