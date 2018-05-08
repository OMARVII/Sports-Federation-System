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
    /// Interaction logic for mainqueryform.xaml
    /// </summary>
    public partial class mainqueryform : Window
    {
        public mainqueryform()
        {
            InitializeComponent();
        }

        private void QueryOptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void QueryBotton_Click(object sender, RoutedEventArgs e)
        {
            if (QueryOptions.Text == "")
            {
                MessageBox.Show("Please Choose A Query !");
            }
             else if (QueryOptions.Text == "Employee's Salaries")
            {
                SalaryQuery s = new SalaryQuery();
                s.Show();
                this.Close();

            }
            else if (QueryOptions.Text == "Search by championship name")
            {
                searchbyname sn = new searchbyname();
                sn.Show();
                this.Close();

            }
            else if (QueryOptions.Text == "Players Filtration")
            {
                playersfiltration p = new playersfiltration();
                p.Show();
                this.Close();

            }
            else if (QueryOptions.Text == "Players In Specific teams")
            {
                PlayersInEachTeamQuery pl = new PlayersInEachTeamQuery();
                pl.Show();
                this.Close();

            }
            else if (QueryOptions.Text == "Employees in Specifc Department")
            {
                EmployeesDepartmentQuery eq = new EmployeesDepartmentQuery();
                eq.Show();
                this.Close();

            }
            else if (QueryOptions.Text == "Employment date")
            {
                EmploymentdurationQuery eq = new EmploymentdurationQuery();
                eq.Show();
                this.Close();

            }
            else if (QueryOptions.Text == "ChampionShips Results")
            {
                QueryChampionShips_RESULTS_ qr = new QueryChampionShips_RESULTS_();
                qr.Show();
                this.Close();

            }
            else if (QueryOptions.Text == "Teams in Specific ChampionShip")
            {
                TeamChampionShipsQuery s = new TeamChampionShipsQuery();
                s.Show();
                this.Close();

            }

            else if (QueryOptions.Text == "Players Age")
            {
                AGE s = new AGE();
                s.Show();
                this.Close();


            }
            else if (QueryOptions.Text == "Coach with highest Score")
            {
                coachgrid cg = new coachgrid();
                cg.Show();
                this.Close();

            }
            else if (QueryOptions.Text == "Best Sponores Deal")
            {
                Bsponsor bs = new Bsponsor();
                bs.Show();
                this.Close();

            }
            else if (QueryOptions.Text == "ChampionShips in Specific Place")
            {
                placech ch = new placech();
                ch.Show();
                this.Close();

            }
            else if (QueryOptions.Text == "Championship Type")
            {
                typech tch = new typech();
                tch.Show();
                this.Close();

            }
            else if(QueryOptions.Text == "Employee's Age"){
                employees_age ee = new employees_age();
                ee.Show();
                this.Close();

            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            adminoptions op = new adminoptions();
            op.Show();
            this.Close();

        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

