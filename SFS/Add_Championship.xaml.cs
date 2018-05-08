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
                sen = "Senior";
            else sen = "Junior";
            bool found = false;
            if (type.Text == "" || (Senior.IsChecked == false && junior.IsChecked == false) || place.Text == ""|| name.Text=="")
            {
                MessageBox.Show("Please fill the required information !");
            }
            else
            {

                for (int i = 0; i < Containers.championship_list.Count; i++)
                {
                    if ((type.Text == Containers.championship_list[i].Gettype())&& (place.Text == Containers.championship_list[i].GetPlace())&&(sen == Containers.championship_list[i].getSenior())&&(name.Text == Containers.championship_list[i].getName()))
                    {
                        found = true;
                    }
                }
                if (found == true)
                {
                    MessageBox.Show("Championship Already Exists !");
                   
                }
                else
                {
                    Championships added = new Championships(place.Text, type.Text, sen, name.Text);
                    Containers.championship_list.Add(added);
                    if (!File.Exists("Championships.xml"))
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

                        document.WriteStartElement("Name");
                        document.WriteString(name.Text);
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

                        XmlNode Championshipp = doc.CreateElement("Championship");

                        XmlNode typee = doc.CreateElement("Type_of_Championship");
                        typee.InnerText = type.Text;
                        Championshipp.AppendChild(typee);

                        XmlNode placee = doc.CreateElement("Place_of_Championship");
                        placee.InnerText = place.Text;
                        Championshipp.AppendChild(placee);

                        XmlNode senior = doc.CreateElement("Senior");
                        senior.InnerText = sen;
                        Championshipp.AppendChild(senior);



                        XmlNode na = doc.CreateElement("Name");
                        na.InnerText = name.Text;
                        Championshipp.AppendChild(na);

                        doc.DocumentElement.AppendChild(Championshipp);
                        doc.Save("Championships.xml");

                        MessageBox.Show("Championship Successfuly Added.");
                    }
                }
            }
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            Add_Options cccc = new Add_Options();
            cccc.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            adminoptions a = new adminoptions();
            a.Show();
            this.Close();
        }
    }
}
