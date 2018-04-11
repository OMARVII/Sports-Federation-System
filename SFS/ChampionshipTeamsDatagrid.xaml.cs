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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TeamChampionShipsQuery ts = new TeamChampionShipsQuery();
            ts.Show();
            this.Close();
        }
    }
}
