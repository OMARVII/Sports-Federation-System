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
    /// Interaction logic for typech.xaml
    /// </summary>
    public partial class typech : Window
    {
        public typech()
        {
            InitializeComponent();
        }


        bool available = false;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Championships> l = Containers.championship_list;
            List<string> Ttype = new List<string>();
            List<string> Tplace = new List<string>();
            List<string> Tname = new List<string>();
            List<string> Tage = new List<string>();

            if (typee.Text == "")
            {
                MessageBox.Show("Please Choose An Option !");
            }
            else{
                for (int i = 0; i < Containers.championship_list.Count; i++)
                {


                    if (l[i].Gettype() == typee.Text)
                    { available = true;
                        Ttype.Add(l[i].Gettype());
                        Tplace.Add(l[i].GetPlace());
                        Tname.Add(l[i].getName());
                        Tage.Add(l[i].getSenior());

                    }

                }
                if (available == false)
                {
                    MessageBox.Show("Type is not available !");
                }
                else
                {
                    listBox.ItemsSource = Ttype;
                    listBox1.ItemsSource = Tplace;
                    listBox2.ItemsSource = Tname;
                    listBox3.ItemsSource = Tage;
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
        
  

