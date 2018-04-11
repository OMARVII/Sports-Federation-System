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
    /// Interaction logic for Add_Championship.xaml
    /// </summary>
    public partial class Add_Championship : Window
    {
        public Add_Championship()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            string sen;
            if (Senior.IsChecked == true)
                sen = "Yes";
            else sen = "No";

            if (type.Text == "" || (Senior.IsChecked == false && junior.IsChecked == false) || result.Text == ""||place.Text=="")
            {
                MessageBox.Show("Please fill the required information !");
            }
           else  if (!File.Exists("Championships.xml"))
            {
                XmlTextWriter document = new XmlTextWriter("Championships.xml", Encoding.UTF8);

                document.Formatting = Formatting.Indented;
                document.WriteStartDocument();
                document.WriteStartElement("Championships");
                document.WriteStartElement("Championship");

                document.WriteStartElement("Type_of_Championship");
                document.WriteString(type.Text);
                document.WriteEndElement();

                document.WriteStartElement("Place_of_Championship");
                document.WriteString(place.Text);
                document.WriteEndElement();

                document.WriteStartElement("Senior");
                document.WriteString(sen);
                document.WriteEndElement();

                document.WriteStartElement("Results");
                document.WriteString(result.Text);
                document.WriteEndElement();

                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndDocument();

                document.Close();

                MessageBox.Show("Championship Successfuly Added.");
            }
            else

            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Championships.xml");

                XmlNode Championshipp = doc.CreateElement("Championships");

                XmlNode typee = doc.CreateElement("Type_of_Championship");
                typee.InnerText = type.Text;
                Championshipp.AppendChild(typee);

                XmlNode placee = doc.CreateElement("Place_of_Championship");
                placee.InnerText = place.Text;
                Championshipp.AppendChild(placee);

                XmlNode senior = doc.CreateElement("Senior");
                senior.InnerText = sen;
                Championshipp.AppendChild(senior);

                XmlNode res = doc.CreateElement("Results");
                res.InnerText = result.Text;
                Championshipp.AppendChild(res);

                doc.DocumentElement.AppendChild(Championshipp);
                doc.Save("Championships.xml");

                MessageBox.Show("Championship Successfuly Added.");
            }
           
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Add_Options cccc = new Add_Options();
            cccc.Show();
        }
    }
}
