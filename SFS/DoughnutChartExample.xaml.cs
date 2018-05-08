using System;
using System.Linq;
using System.Windows;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.IO;

namespace SFS
{
    public partial class DoughnutChartExample : Window
    {
        public DoughnutChartExample()
        {
            InitializeComponent();


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
                departmentSalaries[department] = departmentFrequency[department];
            }

            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "HR",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(departmentFrequency["HR"]) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Coach",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(departmentFrequency["Coach"]) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Accounting",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(departmentFrequency["Accounting"]) },
                    DataLabels = true
                },

            };
 
            //adding values or series will update and animate the chart automatically
            //SeriesCollection.Add(new PieSeries());
            //SeriesCollection[0].Values.Add(5);
 
            DataContext = this;
        }
 
        public SeriesCollection SeriesCollection { get; set; }
 
        private void UpdateAllOnClick(object sender, RoutedEventArgs e)
        {
            var r = new Random();
 
            foreach (var series in SeriesCollection)
            {
                foreach (var observable in series.Values.Cast<ObservableValue>())
                {
                    observable.Value = r.Next(0, 10);
                }
            }
        }
 
        private void AddSeriesOnClick(object sender, RoutedEventArgs e)
        {
            var r = new Random();
            var c = SeriesCollection.Count > 0 ? SeriesCollection[0].Values.Count : 5;
            
            var vals = new ChartValues<ObservableValue>();
 
            for (var i = 0; i < c; i++)
            {
                vals.Add(new ObservableValue(r.Next(0, 10)));
            }
 
            SeriesCollection.Add(new PieSeries
            {
                Values = vals
            });
        }
 
        private void RemoveSeriesOnClick(object sender, RoutedEventArgs e)
        {
            if (SeriesCollection.Count > 0)
                SeriesCollection.RemoveAt(0);
        }
 
        private void AddValueOnClick(object sender, RoutedEventArgs e)
        {
            var r = new Random();
            foreach (var series in SeriesCollection)
            {
                series.Values.Add(new ObservableValue(r.Next(0, 10)));
            }
        }
 
        private void RemoveValueOnClick(object sender, RoutedEventArgs e)
        {
            foreach (var series in SeriesCollection)
            {
                if (series.Values.Count > 0)
                    series.Values.RemoveAt(0);
            }
        }
 
        private void RestartOnClick(object sender, RoutedEventArgs e)
        {
            Chart.Update(true, true);
        }

        private void Chart_Loaded(object sender, RoutedEventArgs e)
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