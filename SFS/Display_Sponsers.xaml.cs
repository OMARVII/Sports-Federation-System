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
    /// Interaction logic for Display_Sponsers.xaml
    /// </summary>
    public partial class Display_Sponsers : Window
    {
        public Display_Sponsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            bool check = false;
            for (int i = 0; i < Containers.Sponsor_list.Count; i++)
            {
                if (Containers.Sponsor_list[i].GetSponser_name() == textBox.Text)
                {
                    check = true;
                    break;
                }
            }
            if (textBox.Text == "")
            {
                MessageBox.Show("Please fill the required information");
            }
            else if(check==false)
            {
                MessageBox.Show("Please enter valid sponser name !");
            }
            List<string> sponser_name = new List<string>();
           // List<int> contractdate = new List<int>();
            List<int> price = new List<int>();

            for (int i = 0; i < Containers.Sponsor_list.Count; i++)
            {
                if (Containers.Sponsor_list[i].GetSponser_name() == textBox.Text)
                {
                    sponser_name.Add(Containers.Sponsor_list[i].GetSponser_name());
                    //contractdate.Add(Containers.Sponsor_list[i].GetContract_date());
                    price.Add(Containers.Sponsor_list[i].GetSponsor_price());
                }
                listBox.ItemsSource = sponser_name;
             //   listBox1.ItemsSource = contractdate;
                listBox3.ItemsSource = price;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
            {
                List<string> sponser_name = new List<string>();
                List<int> contractdate = new List<int>();
                List<int> price = new List<int>();

                for (int i = 0; i < Containers.Sponsor_list.Count; i++)
                {
                    sponser_name.Add(Containers.Sponsor_list[i].GetSponser_name());
                    //contractdate.Add(Containers.Sponsor_list[i].GetContract_date());
                    price.Add(Containers.Sponsor_list[i].GetSponsor_price());
                }
                listBox.ItemsSource = sponser_name;
                //listBox1.ItemsSource = contractdate;
                listBox3.ItemsSource = price;
            }
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

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}