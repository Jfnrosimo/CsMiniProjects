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

namespace ListView
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
            lvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();
            txtEntry.Focus();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //Using only on single selection
            //int index = lvEntries.SelectedIndex;

            //Using object on single collection
            //object item = lvEntries.SelectedItem;

            //Using multiple selection
            var items = lvEntries.SelectedItems;

            var result = MessageBox.Show($"Are you sure you want to delete: {items.Count} ?", "Delete", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var itemList = new ArrayList(items);
                foreach (var item in itemList)
                {
                    lvEntries.Items.Remove(item);
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}
