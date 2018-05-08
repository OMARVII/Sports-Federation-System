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
    /// Interaction logic for ChampionshipTeamsDatagrid.xaml
    /// </summary>
    public partial class ChampionshipTeamsDatagrid : Window
    {
        public ChampionshipTeamsDatagrid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TeamChampionShipsQuery tc = new TeamChampionShipsQuery();
            tc.Show();
            this.Close();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, int> sett = new Dictionary<string, int>();
            List<string> team_names = new List<string>();
            List<int> team_res = new List<int>();
            for (int i = 0; i < Containers.Player_list.Count; i++)
            {
                List<Player> l = Containers.Player_list;
                for (int j = 0; j < l[i].champion.Count; j++)
                {
                    if (l[i].champion[j].getName() == TeamChampionShipsQuery.name)
                    {

                        if (sett.ContainsKey(l[i].get_teamname()))
                        {
                            sett[l[i].get_teamname()] += l[i].champion[j].Getresults();
                        }
                        else
                            sett.Add(l[i].get_teamname(), l[i].champion[j].Getresults());
                    }
                }

            }
            List<string> team_name = new List<string>();
            List<int> team_int = new List<int>();
            for (int i = 0; i < sett.Count; i++)
            {
                
                
                   team_int.Add( sett.ElementAt(i).Value);
                    team_name.Add( sett.ElementAt(i).Key);
                
            }
            listBox.ItemsSource = team_name;
            listBox1.ItemsSource = team_int;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            adminoptions op = new adminoptions();
            op.Show();
            this.Close();
        }
    }
}
