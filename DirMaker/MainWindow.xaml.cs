using Microsoft.Win32;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DirMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string filepath = null;
        private string rootFolderPath = null;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_SelectFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Text Files (.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                this.filepath = openFileDialog.FileName;
                lbl_StatusMessage.Content = "Selected input file: " + openFileDialog.SafeFileName;

            }
        }

        private void btn_goProcedure_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_SelectRoot_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.ShowDialog();
            if (dialog.SelectedPath != "")
            {
                rootFolderPath = dialog.SelectedPath;
            }
            
        }
    }
}
