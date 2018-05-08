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
    /// Interaction logic for Display_Coaches.xaml
    /// </summary>
    public partial class Display_Coaches : Window
    {
        public Display_Coaches()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            bool check = false;
            for (int i = 0; i < Containers.Coach_list.Count; i++)
            {
                if(Containers.Coach_list[i].getId()==textBox.Text)
                {
                    check = true;
                    break;
                }
            }
                if (textBox.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
              else if(check == false)
            {
                MessageBox.Show("Wrong ID !");
            }
            else
            {
                List<string> name = new List<string>();
                List<int> results = new List<int>();
                for (int i = 0; i < Containers.Coach_list.Count; i++)
                {
                    if (Containers.Coach_list[i].getId() == textBox.Text)
                    {
                        name.Add(Containers.Coach_list[i].getName());
                        results.Add(Containers.Coach_list[i].getResult());
                    }
                }
                listBox.ItemsSource = results;
                listBox_Copy.ItemsSource = name;
            }
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            List<string> name = new List<string>();
            List<int> results = new List<int>();
            for (int i = 0; i < Containers.Coach_list.Count; i++)
            {
                    name.Add(Containers.Coach_list[i].getName());
                    results.Add(Containers.Coach_list[i].getResult());
               
            }
            listBox.ItemsSource = results;
            listBox_Copy.ItemsSource = name;
        }
    




        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (adminoptions.disp == true)
            {
                displayOptions z = new displayOptions();
                z.Show();
                this.Close();
            }
            else
            {
                searchoptions so = new searchoptions();
                so.Show();
                this.Close();
            }

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}