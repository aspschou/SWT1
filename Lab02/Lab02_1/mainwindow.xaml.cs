using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab02_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
            
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(Tal2.Text);
            int b = Convert.ToInt32(Tal3.Text);
            Tal3.Height += 1;
            Tal1.Text = (a + b).ToString();
            //int a = Convert.Tal1.Text(first.text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string str;
            string[] tokens;
            char[] separators = {','};
            string tempString = "";

            FileStream fs = new FileStream(@"C:\Users\Rasmus\Desktop\deltagerliste.csv", FileMode.Open, FileAccess.Read);

            /* alt for while-loop
            string[] lines = File.ReadAllLines(@"C:\Users\Rasmus\Desktop\Deltagerlist.csv");
            foreach (var line in lines)
            {
                tokens = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            }*/
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            str = sr.ReadLine(); // Don't show the first line with headings

            while ((str = sr.ReadLine()) != null)
            {
                str = str.Replace("\"", string.Empty);
                
                tokens = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                tokens[1] = tokens[1] + new string(' ', 25 - tokens[1].Length);

                //tempString = String.Format("{0} {1,50} {2,50}", tokens[1], tokens[0], tokens[2]); // Old format
                tempString = $"{tokens[1],-25} {tokens[0],-25} {tokens[2]}";
                LBXDeltagerliste.Items.Add(tempString);
            }

            fs.Close();
            sr.Close();
        }
    }
}
