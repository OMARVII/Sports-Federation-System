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
    /// Interaction logic for Display_Championshsips.xaml
    /// </summary>
    public partial class Display_Championshsips : Window
    {
        public Display_Championshsips()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            bool check = false;
            for (int i = 0; i < Containers.championship_list.Count; i++)
            {
                if (Containers.championship_list[i].getName() == textBox.Text)
                {
                    check = true;
                    break;
                }
            }
            if (textBox.Text == "")
            {
                MessageBox.Show("Please fill required information !");
            }
            else if (check == false)
            {
                MessageBox.Show("No ChampionShips Available In This Place  !");
            }
            else
            {
                List<string> name = new List<string>();
                List<string> place = new List<string>();
                List<string> type = new List<string>();
                List<string> senior = new List<string>();

                for (int i = 0; i < Containers.championship_list.Count; i++)
                {
                   
                     if (Containers.championship_list[i].getName() == textBox.Text)
                    {
                        name.Add(Containers.championship_list[i].getName());
                        place.Add(Containers.championship_list[i].GetPlace());
                        type.Add(Containers.championship_list[i].Gettype());
                        senior.Add(Containers.championship_list[i].getSenior());
                    }


                }
                listBox.ItemsSource = name;
                listBox1.ItemsSource = type;
                listBox2.ItemsSource = place;
                listBox3.ItemsSource = senior;
            }
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
        if (textBox.Text == "")
        {
            List<string> name = new List<string>();
            List<string> place = new List<string>();
            List<string> type = new List<string>();
            List<string> senior = new List<string>();
            for (int i = 0; i < Containers.championship_list.Count; i++)
            {
                name.Add(Containers.championship_list[i].getName());
                place.Add(Containers.championship_list[i].GetPlace());
                type.Add(Containers.championship_list[i].Gettype());
                senior.Add(Containers.championship_list[i].getSenior());
            }
            listBox.ItemsSource = name;
            listBox1.ItemsSource = type;
            listBox2.ItemsSource = place;
            listBox3.ItemsSource = senior;

        }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(adminoptions.disp==true|| adminoptionNotification.disp==true)
            {
           displayOptions z = new displayOptions();
                z.Show();
            this.Close();
            }
           else if(adminoptions.search==true|| adminoptionNotification.search == true)
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

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            adminoptions a = new adminoptions();
            a.Show();
            this.Close();
        }
    }
}
