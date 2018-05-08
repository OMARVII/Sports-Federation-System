using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace SFS
{
    /// <summary>
    /// Interaction logic for departmentstat.xaml
    /// </summary>
    public partial class PlayersChart : Window
    {
        public SeriesCollection Data { get; set; }
        public List<string> Labels { get; set; }
        public PlayersChart()
        {
            InitializeComponent();
        }

        private void MainChart_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            statistics s = new statistics();
            s.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions a = new adminoptions();
            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            bool available = false;
            Dictionary<string, float> players = new Dictionary<string, float>();
            if (textBox.Text == "")
            {
                MessageBox.Show("Enter Data !");
            }
            else
            {
                for (int i = 0; i < Containers.Player_list.Count; i++)
                {
                    for (int j = 0; j < Containers.Player_list[i].champion.Count; j++)
                    {
                        if (Containers.Player_list[i].champion[j].getName() == textBox.Text)
                        {
                            available = true;
                            if (players.ContainsKey((Containers.Player_list[i].getName())))
                            {
                                players[Containers.Player_list[i].getName()] = Containers.Player_list[i].champion[j].Getresults();
                            }
                            else
                            {
                                players.Add(Containers.Player_list[i].getName(), Containers.Player_list[i].champion[j].Getresults());
                            }

                        }
                    }
                }

                if (available == false)
                {
                    MessageBox.Show("Enter valid championship!");
                }
                else
                {
                    Data = new SeriesCollection
            {
                new LineSeries { Values = new ChartValues<float>(players.Values) }
            };

                    Labels = new List<string>(players.Keys);

                    MainChart.Series = Data;
                    HorizontalAxis.Labels = Labels;

                }
            }
        }
    }
}