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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("Championships.xml"))
            {
                Containers.Read_Championships();
            }
            if (File.Exists("Players.xml"))
            {
                Containers.Read_Players();
            }
            if (File.Exists("Employees.xml"))
            {
                Containers.Read_Employees();
            }
            if (File.Exists("Clubs.xml"))
            {
                Containers.Read_Clubs();
            }
            if (File.Exists("Teams.xml"))
            {
                Containers.Read_Teams();
            }
            if (File.Exists("Coaches.xml"))
            {
                Containers.Read_Coach();
            }
            if (File.Exists("Results.xml"))
            {
                Containers.read_players_results();
            }
            if (File.Exists("Sponsers.xml"))
            {
                Containers.Read_Sponsor();
            }
            if (File.Exists("Admins.xml"))
            {
                Containers.Read_Admin();
            }
            if (File.Exists("Expenses.xml"))
            {
                Expense.read_expense();
            }
            if (File.Exists("Counter1.xml"))
            {
                Containers.Read_count1();
            }
            if (File.Exists("Counter2.xml"))
            {
                Containers.Read_count2();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Loginas lag = new Loginas();
            lag.Show();
            this.Close();

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Loginas lag = new Loginas();
            lag.Show();
            this.Close();
        }
    }
}
