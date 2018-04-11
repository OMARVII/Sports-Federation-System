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
    /// Interaction logic for Add__Team.xaml
    /// </summary>
    public partial class Add__Team : Window
    {
        public Add__Team()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string sen;
            int x = 0;
            string Results = x.ToString();
            if (Senior.IsChecked == true)
                sen = "Yes";
            else sen = "No";

            if (Name.Text == "" || (Senior.IsChecked ==false&&junior.IsChecked==false) )
            {
                MessageBox.Show("Please fill the required information !");
            }
             else if (!File.Exists("Teams.xml"))
            {
                XmlTextWriter document = new XmlTextWriter("Teams.xml", Encoding.UTF8);

                document.Formatting = Formatting.Indented;
                document.WriteStartDocument();
                document.WriteStartElement("Teams");
                document.WriteStartElement("Team");

                document.WriteStartElement("Team_Name");
                document.WriteString(Name.Text);
                document.WriteEndElement();

                document.WriteStartElement("Senior");
                document.WriteString(sen);
                document.WriteEndElement();

                document.WriteStartElement("Results");
                document.WriteString(Results);
                document.WriteEndElement();

                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndDocument();

                document.Close();

                MessageBox.Show("Team Successfuly added.");
            }
            else

            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Teams.xml");

                XmlNode team = doc.CreateElement("Team");

                XmlNode team_Name = doc.CreateElement("Team_Name");
                team_Name.InnerText = Name.Text;
                team.AppendChild(team_Name);

                XmlNode senior = doc.CreateElement("Senior");
                senior.InnerText = sen;
                team.AppendChild(senior);

                XmlNode res = doc.CreateElement("Results");
                res.InnerText = Results;
                team.AppendChild(res);

                doc.DocumentElement.AppendChild(team);
                doc.Save("Teams.xml");

                MessageBox.Show("Team Successfuly added.");
            }
           
           
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Add_Options aa = new Add_Options();
            aa.Show();
        }

        private void Results_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
