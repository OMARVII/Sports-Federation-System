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
    }
}
