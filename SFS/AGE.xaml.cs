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
               
              for (int i = 0; i < Containers.Player_list.Count; i++)
              {
                  for (int j = i + 1; j < Containers.Player_list.Count; j++)
                  {
                      if (Containers.Player_list[i].ageCalculator() > Containers.Player_list[j].ageCalculator())
                      {
                          Player temp = Containers.Player_list[i];
                          Containers.Player_list[i] = Containers.Player_list[j];
                          Containers.Player_list[j] = temp;
                      }
                  }
              }
              List<Player> juniors = new List<Player>();
              List<Player> seniors = new List<Player>();
              for(int i=0;i<Containers.Player_list.Count;i++)
              {
                  if(Containers.Player_list[i].ageCalculator()>=18)
                  {
                      seniors.Add(Containers.Player_list[i]);
                  }
                  else
                  {
                      juniors.Add(Containers.Player_list[i]);
                  }
              }
        }
    }
}

   
