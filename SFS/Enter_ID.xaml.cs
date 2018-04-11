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
    /// Interaction logic for Enter_ID.xaml
    /// </summary>
   
    public partial class Enter_ID : Window
    {
        public static string playerid;
        public Enter_ID()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
           /* for(int i=0;i<players.count;i++)
            {
                if(players[i].ID==id.Text)
                {
                    players.remove(players[i]);
                }
            }*/
            MessageBox.Show("Successfuly Deleted");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Edit_Delete ed = new Edit_Delete();
            ed.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
              playerid=id.Text;
        Edit_Player p=new Edit_Player();
            p.Show();
        }
    }
}
