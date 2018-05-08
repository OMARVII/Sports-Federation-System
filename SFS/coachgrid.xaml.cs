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
    /// Interaction logic for coachgrid.xaml
    /// </summary>
    public partial class coachgrid : Window
    {
        public coachgrid()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
              List<Coach> l =Containers.Coach_list;
          for (int i = 0; i < l.Count; i++)
          {
              for (int j = i + 1; j < l.Count; j++)
              {
                  if (l[i].getResult()< l[j].getResult())
                  {
                      Coach tmp = l[i];
                     l[i] = l[j];
                      l[j] = tmp;
                  }
              }
      }

        

            List<string> tname = new List<string>();
List<int> tresult = new List<int>();
            

                for (int i = 0; i<l.Count; i++)
                {
                    tname.Add(l[i].getName());
                    tresult.Add(l[i].getResult());
                }

            
          
            listBox.ItemsSource = tname;
                listBox1.ItemsSource = tresult;
            textBox.Text = tname[0];

        }
    
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform mq = new mainqueryform();
            mq.Show();
            this.Close();
        }
    }
}
