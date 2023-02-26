using System.Windows;
using WinForms = System.Windows.Forms; //Initialize winforms/ use alias to avoid abiguity

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
            dialog.InitialDirectory = "C:\\Users\\Admin\\Downloads";
            dialog.ShowDialog();
            WinForms.DialogResult dialogResult = dialog.ShowDialog();

            if(dialogResult == WinForms.DialogResult.OK)
            {
                string folder = dialog.SelectedPath;
            }
            else
            {
                
            }

        }

        
    }
}
