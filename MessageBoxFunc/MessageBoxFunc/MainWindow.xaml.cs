using Microsoft.Win32;
using System.Windows;

namespace MessageBoxFunc
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

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you Agree?", "You pressed fire",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if(result == MessageBoxResult.Yes)
            {
                tbInfo.Text = "Agreed";
            }
            else
            {
                tbInfo.Text = "Not Agreed";
            }
        }

        private void btnFire2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            //Filter files on file dialogs
            fileDialog.Filter = "PDF files | *.pdf";

            //Set the initial directory
            fileDialog.InitialDirectory = "C:\\Users\\Admin\\Downloads";

            //Set dialog box title
            fileDialog.Title = "Please pick your pdf file/s";

            //Allow selecting multiple files
            fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();

            if(success == true)
            {
                string path = fileDialog.FileName;

                //For filename only
                string fileName = fileDialog.SafeFileName;

                tbInfo2.Text = "This is the path: " +path +" | " +"This is the filename only: " +fileName;

                //For multiple files
                //string[] paths = fileDialog.FileNames;
                //string[] fileNames = fileDialog.SafeFileNames;


            }
            else
            {

            }


        }
    }
}
