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
    /// Interaction logic for Edit_PlayerMediacalForm.xaml
    /// </summary>
    public partial class Edit_PlayerMediacalForm : Window
    {
        public Edit_PlayerMediacalForm()
        {
            InitializeComponent();
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Edit_Player ep = new Edit_Player();
            ep.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            bool med = false;
            if (yes.IsChecked == true)
                med = true;
            if ((yes.IsChecked == true) && (no.IsChecked == true))
                MessageBox.Show("Please fill the required information !");

            else
            {
                for (int i = 0; i < Containers.Player_list.Count; i++)
                {
                    if (Containers.Player_list[i].getId().ToString() == Enter_ID.playerid)
                    {
                        Containers.Player_list[i].setMedicalReport(med);

                    }

                }
                MessageBox.Show("Done Changes");
            }




            MessageBox.Show("Done Change");
        }
    }
}
