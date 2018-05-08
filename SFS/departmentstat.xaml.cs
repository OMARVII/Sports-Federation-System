using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace SFS
{
    /// <summary>
    /// Interaction logic for departmentstat.xaml
    /// </summary>
    public partial class departmentstat : Window
    {public SeriesCollection Data { get; set; }
        public List<string> Labels { get; set; }
        public departmentstat()
        {
            if (File.Exists("Employees.xml"))
            {
                Containers.Read_Employees();
            }
            Dictionary<string, float> departmentSalaries = new Dictionary<string, float>();
            Dictionary<string, int> departmentFrequency = new Dictionary<string, int>();

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
                List<string> Keys = new List<string>(departmentSalaries.Keys);
                foreach (string department in Keys)
                {
                    departmentSalaries[department] = departmentFrequency[department];
                }

                Data = new SeriesCollection
            {
                new LineSeries { Values = new ChartValues<float>(departmentSalaries.Values) }
            };

                Labels = new List<string>(departmentSalaries.Keys);

                InitializeComponent();
                dep.Series = Data;
                horizontalAxis.Labels = Labels;
            }
        }
        private void dep_Loaded(object sender, RoutedEventArgs e)
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
