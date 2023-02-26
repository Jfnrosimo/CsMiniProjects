using System.Windows;
using Winforms = System.Windows.Forms; //Initialize winforms to avoid abiguity

namespace DialogBoxFunc
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

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            WinForms.FolderBrowserDialog dialog = new WinForms.FolderBrowserDialog();
            dialog.ShowDialog();

            //Ambiguity issue on winforms and WPF
            MessageBox.Show();
        }

        
    }
}
