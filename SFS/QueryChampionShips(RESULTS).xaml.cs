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
    /// Interaction logic for QueryChampionShips_RESULTS_.xaml
    /// </summary>
    public partial class QueryChampionShips_RESULTS_ : Window
    {
        public QueryChampionShips_RESULTS_()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == ""|| Min_Res.IsChecked==false && Max_res.IsChecked == false)
            {
                MessageBox.Show("Please Enter Valid Data !");
            }
            else
            {




                if (Max_res.IsChecked == true)
                {
                    float maxscore = -1;
                    string maxname = "";
                    List<Club> l = Containers.Club_list;
                    for (int z = 0; z < l.Count; z++)
                    {
                        for (int m = 0; m < l[z].champList.Count; m++)
                        {
                            if (l[z].champList[m].Getresults() > maxscore && textBox.Text == l[z].champList[m].getName())
                            {
                                maxscore = l[z].champList[m].Getresults();
                                maxname = l[z].getClubName();
                            }
                        }
                    }
                    MessageBox.Show(maxname + maxscore.ToString());

                }
                else if (Min_Res.IsChecked == true)
                {
                    float maxscore = 10000000;

                    string maxname = "";
                    List<Club> l = Containers.Club_list;
                    for (int z = 0; z < l.Count; z++)
                    {
                        for (int m = 0; m < l[z].champList.Count; m++)
                        {
                            if (l[z].champList[m].Getresults() < maxscore && textBox.Text == l[z].champList[m].getName())
                            {
                                maxscore = l[z].champList[m].Getresults();
                                maxname = l[z].getClubName();
                            }
                        }
                    }
                    if (maxscore == 10000000 || maxscore == -1)
                    {
                        MessageBox.Show("Results Not available !");

                    }
                    else
                    {
                        MessageBox.Show(maxname + maxscore.ToString());
                    }
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

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            adminoptions ap = new adminoptions();
            ap.Show();
            this.Close();
        }
    }
}

