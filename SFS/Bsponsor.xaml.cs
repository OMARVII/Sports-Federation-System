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
    /// Interaction logic for Bsponsor.xaml
    /// </summary>
    public partial class Bsponsor : Window
    {
        public static int best_sponsor = 0;
        public Bsponsor()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            List<Sponsers> x =Containers.Sponsor_list;
            for (int i = 0; i < x.Count; i++)
            {
                for (int j = i + 1; j < x.Count; j++)
                {
                    if (x[i].GetSponsor_price() < x[j].GetSponsor_price())
                    {
                        Sponsers tmp = x[i];
                        x[i] = x[j];
                        x[j] = tmp;
                    }
                }
        }
            List<string> tName = new List<string>();
            List<int> tprice = new List<int>();
            List<int> tindex = new List<int>();


            for (int i = 0; i < x.Count; i++)
            {
                tindex.Add(i+1);
                tName.Add(x[i].GetSponser_name());
                tprice.Add(x[i].GetSponsor_price());
            }



            listBox.ItemsSource = tName;
            listBox1.ItemsSource = tprice;
            listBox2.ItemsSource = tindex;
            textBox.Text = tName[0];
            best_sponsor = tprice[0];

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform m = new mainqueryform();
            m.Show();
            this.Close();
        }
    }
}
