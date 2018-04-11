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
            
            if (QueryOptions.Text == "Employee's Salaries")
            {
                SalaryQuery s = new SalaryQuery();
                s.Show();
            }
            else if(QueryOptions.Text == "Players In Specific teams")
            {
                PlayersInEachTeamQuery pl = new PlayersInEachTeamQuery();
                pl.Show();
                
            }
            else if(QueryOptions.Text== "Employees in Specifc Department")
            {
                EmployeesDepartmentQuery eq = new EmployeesDepartmentQuery();
                eq.Show();
               
            }
            else if(QueryOptions.Text== "Employment date")
            {
                EmploymentdurationQuery eq = new EmploymentdurationQuery();
                eq.Show();
            }
            else if(QueryOptions.Text== "ChampionShips Results")
            {
                QueryChampionShips_RESULTS_ qr = new QueryChampionShips_RESULTS_();
                qr.Show();

            }
            else if(QueryOptions.Text== "Teams in Specific ChampionShip")
            {
                TeamChampionShipsQuery s = new TeamChampionShipsQuery();
                s.Show();
                
            }

            this.Close();
        }
    }
}
