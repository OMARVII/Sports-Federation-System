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
using System.Xml;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Data;
namespace SFS
{
    /// <summary>
    /// Interaction logic for playersfiltration.xaml
    /// </summary>
    public partial class playersfiltration : Window
    {
        public playersfiltration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform mq = new mainqueryform();
            mq.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            List<Player> l = Containers.Player_list;
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = i + 1; j < l.Count; j++)
                {
                    if (l[i].get_results() < l[j].get_results()) 
                    {
                        Player tmp = l[i];
                        l[i] = l[j];
                        l[j] = tmp;
                    }
                }
            }
            
           


            List<string> pname = new List<string>();
            List<int> presult = new List<int>();
            List<string> pgender = new List<string>();
            List<string> page = new List<string>();


            for (int k = 0; k < 5; k++)
            {
                if (l[k].getGender() == "Male")
                {
                    l[k].setbonus(1000);

                }
            }
            for (int k = 0; k < 5; k++)
            {
                if (l[k].getGender() == "Female")
                {
                    l[k].setbonus(1000);

                   
                }
            }
            if (File.Exists("Players.xml"))
            {
                File.Delete("Players.xml");
            }

            for (int j = 0; j < Containers.Player_list.Count; j++)
            {
                Containers.write_Player(Containers.Player_list[j]);

            }
           

            
            if (male.IsChecked == true)
            {
                for (int i = 0; i < l.Count; i++)
                {
                    if (l[i].getGender() == "Male")
                    {
                        pname.Add(l[i].getName());
                        presult.Add(l[i].get_results());
                        pgender.Add(l[i].getGender());
                        if (l[i].ageCalculator() >= 18)
                        {
                            page.Add("Senior");
                        }
                        else
                            page.Add("Junior");

                    }

                }
            }
            else if (female.IsChecked == true)
            {
                for (int i = 0; i < l.Count; i++)
                {
                    if (l[i].getGender() == "Female")
                    {


                        pname.Add(l[i].getName());
                        presult.Add(l[i].get_results());
                        pgender.Add(l[i].getGender());
                        if (l[i].ageCalculator() >= 18)
                        {
                            page.Add("Senior");
                        }
                        else
                            page.Add("Junior");

                    }

                }
            }
            else
            {
                MessageBox.Show("Please Choose An Option !");
            }



                    listBox.ItemsSource = pname;
                    listBox1.ItemsSource = presult;
                    listBox3.ItemsSource = pgender;
                    listBox2.ItemsSource = page;

                
           
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
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
