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
    /// Interaction logic for Add_Employee.xaml
    /// </summary>
    public partial class Add_Employee : Window
    {
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            string gender;
            string med;
            string bou;
            string avail;
            if (Male.IsChecked == true)
                gender = "Male";
            else gender = "Female";
            if (Yes.IsChecked == true)
                med = "Yes";
            else med = "No";
            if (Yes2.IsChecked == true)
                bou = "Yes";
            else bou = "No";

            if (Yes3.IsChecked == true)
                avail = "Yes";
            else avail = "No";

            if (!File.Exists("Employees.xml"))
            {
                XmlTextWriter document = new XmlTextWriter("Employees.xml", Encoding.UTF8);

                document.Formatting = Formatting.Indented;
                document.WriteStartDocument();
                document.WriteStartElement("Employees");
                document.WriteStartElement("Employee");
                document.WriteStartElement("Employee_Name");
                document.WriteString(Name.Text);
                document.WriteEndElement();

                document.WriteStartElement("Employee_ID");
                document.WriteString(ID.Text);
                document.WriteEndElement();

                document.WriteStartElement("Mobile_Number");
                document.WriteString(number.Text);
                document.WriteEndElement();

                document.WriteStartElement("Gender");
                document.WriteString(gender);
                document.WriteEndElement();

                document.WriteStartElement("Medical_Form");
                document.WriteString(med);
                document.WriteEndElement();

                document.WriteStartElement("Salary");
                document.WriteString(Salary.Text);
                document.WriteEndElement();

                document.WriteStartElement("Bonus");
                document.WriteString(bou);
                document.WriteEndElement();

                document.WriteStartElement("Employement_Date");
                document.WriteString(Emplyedate.Text);
                document.WriteEndElement();

                document.WriteStartElement("Date_of_birth");
                document.WriteString(Date.Text);
                document.WriteEndElement();

                document.WriteStartElement("Available");
                document.WriteString(avail);
                document.WriteEndElement();

                document.WriteStartElement("Department");
                document.WriteString(Department.Text);
                document.WriteEndElement();

                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndDocument();

                document.Close();
            }
            else

            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Employees.xml");

                XmlNode employee = doc.CreateElement("Employee");

                XmlNode Employee_Name = doc.CreateElement("Employee_Name");
                Employee_Name.InnerText = Name.Text;
                employee.AppendChild(Employee_Name);

                XmlNode employee_id = doc.CreateElement("Employee_ID");
                employee_id.InnerText = ID.Text;
                employee.AppendChild(employee_id);

                XmlNode MobileNum = doc.CreateElement("Mobile_Number");
                MobileNum.InnerText = number.Text;
                employee.AppendChild(MobileNum);

                XmlNode Genderr = doc.CreateElement("Gender");
                Genderr.InnerText = gender;
                employee.AppendChild(Genderr);

                XmlNode Medical = doc.CreateElement("Medical_Form");
                Medical.InnerText = med;
                employee.AppendChild(Medical);

                XmlNode salary = doc.CreateElement("Salary");
                salary.InnerText = Salary.Text;
                employee.AppendChild(salary);

                XmlNode bonus = doc.CreateElement("Bonus");
                bonus.InnerText = bou;
                employee.AppendChild(bonus);

                XmlNode Employementdate = doc.CreateElement("Employement_Date");
                Employementdate.InnerText = Emplyedate.Text;
                employee.AppendChild(Employementdate);

                XmlNode dateofbirth = doc.CreateElement("Date_of_birth");
                dateofbirth.InnerText = Date.Text;
                employee.AppendChild(dateofbirth);

                XmlNode avaliable = doc.CreateElement("Available");
                avaliable.InnerText = avail;
                employee.AppendChild(avaliable);

                doc.DocumentElement.AppendChild(employee);
                doc.Save("Employees.xml");
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Chooose cccc = new Chooose();
            cccc.Show();
        }
    }
    }

