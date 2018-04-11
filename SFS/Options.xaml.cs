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
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Add_Options ao = new Add_Options();
            ao.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Edit_Delete ed = new Edit_Delete();
            ed.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Edit_Delete ed = new Edit_Delete();
            ed.Show();
        }
    }
}
