using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SortedListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if(keyTxt.Text == "" && valueTxt.Text == "")
            {
                MessageBox.Show("Please insert Key & Value Data.");
            }
            else if(keyTxt.Text != "" && valueTxt.Text == "")
            {
                MessageBox.Show("Please insert Key Data.");
            }
            else if(keyTxt.Text == "" && valueTxt.Text != "")
            {
                MessageBox.Show("Please insert Value Data.");
            }
            else
            {
                string outPut = "";
                ICollection collection = sortedList.Keys;

                sortedList.Add(keyTxt.Text,valueTxt.Text);
                keyTxt.Clear();
                valueTxt.Clear();
                foreach (string key in collection)
                {
                    outPut = outPut + sortedList[key].ToString() + "\n";
                }
                MessageBox.Show(outPut);
            }
        }
    }
}
