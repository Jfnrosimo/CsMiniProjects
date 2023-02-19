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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToolBar
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(myTextBox.Text == "")
            {
                MessageBox.Show("Text is empty!");
            }
            else
            {
                myTextBox.Text = "";
                MessageBox.Show("Text has been deleted!");
            }
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cbox = (ComboBox)sender;
            ComboBoxItem cbItem = (ComboBoxItem)cbox.SelectedItem;
            string newFontSize = (string)cbItem.Content;

            int temp;
            if(Int32.TryParse(newFontSize, out temp)) 
            { 
                if(myTextBox != null)
                {
                    myTextBox.FontSize= temp;
                }
            }
        }
    }
}
