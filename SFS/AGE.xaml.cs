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
    /// Interaction logic for AGE.xaml
    /// </summary>
    public partial class AGE : Window
    {
        public AGE()
        {
            InitializeComponent();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void age1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Player> l = Containers.Player_list;
              for (int i = 0; i < l.Count; i++)
              {
                  for (int j = i + 1; j < l.Count; j++)
                  {
                      if( l[i].ageCalculator() > l[i].ageCalculator())
                      {
                          Player temp = l[i];
                          l[i] = l[j];
                         l[j] = temp;
                      }
                  }
              }
              List<Player> juniors = new List<Player>();
              List<Player> seniors = new List<Player>();
              for(int i=0;i<l.Count;i++)
              {
                  if(l[i].ageCalculator()>=18)
                  {
                      seniors.Add(l[i]);
                  }
                  else
                  {
                      juniors.Add(l[i]);
                  }
              }
            List<int> tage = new List<int>();
            List<string> tname = new List<string>();
            List<string> ttname = new List<string>();
            if (age1.Text == "")
            {
                MessageBox.Show("Please select a choice !");
            }
              else  if (age1.Text == "SENIOR")
            {

                for (int i = 0; i < seniors.Count; i++)
                {
                    tage.Add(seniors[i].ageCalculator());
                    tname.Add(seniors[i].getName());
                    ttname.Add(seniors[i].get_teamname());

                }

            }
            else
            {
                for (int i = 0; i < juniors.Count; i++)
                {
                    tage.Add(juniors[i].ageCalculator());
                    tname.Add(juniors[i].getName());
                    ttname.Add(juniors[i].get_teamname());

                }
            }
            listBox.ItemsSource = tname;
                listBox1.ItemsSource = tage;
            listBox2.ItemsSource = ttname;


        }

        private void ages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            mainqueryform o = new mainqueryform();
            o.Show();
            this.Close();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            adminoptions a = new adminoptions();
            a.Show();
            this.Close();
        }
    }
}

   
