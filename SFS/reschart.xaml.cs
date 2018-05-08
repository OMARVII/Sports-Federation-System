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
    public partial class reschart : Window
    {
        public SeriesCollection Data { get; set; }
        public List<string> Labels { get; set; }
        public reschart()
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

            Dictionary<string, float> clubs = new Dictionary<string, float>();
            Dictionary<string, int> championshipFrequency = new Dictionary<string, int>();

            if (textBox.Text == "")
            {
                MessageBox.Show("Enter Data !");
            }
            else
            {
                for (int i = 0; i < Containers.Club_list.Count; i++)
                {
                    for (int j = 0; j < Containers.Club_list[i].champList.Count; j++)
                    {

                        if (textBox.Text == Containers.Club_list[i].champList[j].getName())
                        {
                            available = true;


                            if (clubs.ContainsKey((Containers.Club_list[i].getClubName())))
                            {
                                clubs[Containers.Club_list[i].getClubName()] = Containers.Club_list[i].champList[j].Getresults();
                            }
                            else
                            {
                                clubs.Add(Containers.Club_list[i].getClubName(), Containers.Club_list[i].champList[j].Getresults());
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
                new LineSeries { Values = new ChartValues<float>(clubs.Values) }
            };

                    Labels = new List<string>(clubs.Keys);


                    MainChart.Series = Data;
                    HorizontalAxis.Labels = Labels;
                }
            }
        }
    }
}
