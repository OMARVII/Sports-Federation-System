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
    /// Interaction logic for placech.xaml
    /// </summary>
    public partial class placech : Window
    {
        public placech()
        {
            InitializeComponent();
        }

        bool available = false;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            List<Championships> l = Containers.championship_list;
            List<string> ttype = new List<string>();
            List<string> tplace = new List<string>();
            List<string> tname = new List<string>();
            if (comboBox.Text == "")
            {
                MessageBox.Show("Choose An Option !");
            }
            else
            {
                for (int i = 0; i < Containers.championship_list.Count; i++)
                {
                    
                    if (l[i].GetPlace() == comboBox.Text)
                    {
                        available = true;
                        ttype.Add(l[i].Gettype());
                        tplace.Add(l[i].GetPlace());
                        tname.Add(l[i].getName());
                        
                    }

                }
                 if(available==false)
                    {
                    MessageBox.Show("No available data in this place !");

                }

                listBox.ItemsSource = ttype;
                listBox1.ItemsSource = tplace;
                listBox2.ItemsSource = tname;
                
            } 
            
          

        } 
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform mq = new mainqueryform();
            mq.Show();
            this.Close();

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
    }

