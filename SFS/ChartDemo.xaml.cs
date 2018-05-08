using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace SFS
{
    /// <summary>
    /// Interaction logic for ChartDemo.xaml
    /// </summary>
    public partial class ChartDemo : Window
    {
        public SeriesCollection Data { get; set; }
        public List<string> Labels { get; set; }

        public ChartDemo()
        {
            // Demo Data
            if (File.Exists("Employees.xml"))
            {
                Containers.Read_Employees();
            }

            Dictionary<string, float> departmentSalaries = new Dictionary<string, float>();
            Dictionary<string, int> departmentFrequency = new Dictionary<string, int>();

            // Initializing Each Department Accumulative Salary
            foreach (Employee employee in Containers.Employee_list)
            {
                if (departmentSalaries.ContainsKey(employee.GetDepartment()))
                {
                    departmentSalaries[employee.GetDepartment()] += employee.getSalary();
                    departmentFrequency[employee.GetDepartment()]++;
                }
                else
                {
                    departmentSalaries.Add(employee.GetDepartment(), employee.getSalary());
                    departmentFrequency.Add(employee.GetDepartment(), 1);
                }
            }

            // Calculating the Median of the Salaries
            List<string> Keys = new List<string>(departmentSalaries.Keys);
            foreach (string department in Keys)
            {
                departmentSalaries[department] /= departmentFrequency[department];
            }

            Data = new SeriesCollection
            {
                new LineSeries { Values = new ChartValues<float>(departmentSalaries.Values) }
            };

            Labels = new List<string>(departmentSalaries.Keys);

            InitializeComponent();
            MainChart.Series = Data;
            HorizontalAxis.Labels = Labels;
        }

        private void MainChart_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            statistics s = new statistics();
            s.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions a = new adminoptions();
            a.Show();
            this.Close();
        }
    }
}
