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
    /// Interaction logic for TeamChampionShipsQuery.xaml
    /// </summary>
    public partial class TeamChampionShipsQuery : Window
    {
        public static string name = "";
        public static string place = "";
        public TeamChampionShipsQuery()
        {
            InitializeComponent();
        }

        bool available = false;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "" || places.Text == "")
            {
                MessageBox.Show("Please fill required data !");
            }
            else
            {
                name = textBox.Text;
                place = places.Text;

                for (int i = 0; i < Containers.championship_list.Count; i++)
                {
                    if (Containers.championship_list[i].getName() == textBox.Text)
                    {
                        available = true;
                        ChampionshipTeamsDatagrid ct = new ChampionshipTeamsDatagrid();
                        ct.Show();
                        this.Close();
                    }

                  
                  
                }
                if (available == false)
                {
                    MessageBox.Show("Championship not available !");

                }
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
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}
