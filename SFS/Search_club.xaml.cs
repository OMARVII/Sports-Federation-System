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
    /// Interaction logic for Search_club.xaml
    /// </summary>
    public partial class Search_club : Window
    {
        public Search_club()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Club> find_Club = new List<Club>();
            if (textBox.Text == "")
            {
                MessageBox.Show("Please fill the required information");
            }
            for (int i = 0; i < Containers.Club_list.Count; i++)
            {
                if (Containers.Club_list[i].getClubName() == textBox.Text)
                {
                    find_Club.Add(Containers.Club_list[i]);
                }

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
