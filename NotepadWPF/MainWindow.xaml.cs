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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using System.Windows.Forms;

namespace NotepadWPF
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

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialogOpen = new OpenFileDialog();
            dialogOpen.Title = "Open file...";
            dialogOpen.Filter = "Text files(*.txt)|*.txt |Document files(*.doc, *.docx)|*.doc;*.docx |All files(*.*)|*.*";
            if (dialogOpen.ShowDialog() == true )   //System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(dialogOpen.FileName, FileMode.Open))
                {
                    TextRange textRange = new TextRange(MainRichTbx.Document.ContentStart, MainRichTbx.Document.ContentEnd);
                    textRange.Load(fileStream, DataFormats.Text);
                }
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialogSave = new SaveFileDialog();
            dialogSave.Title = "Save file...";
            //dialogSave.Filter = "Text files(*.txt)|*.txt |Document files(*.doc, *.docx)|*.doc;*.docx |All files(*.*)|*.*";
            if (dialogSave.ShowDialog() == true)
            {
                using (FileStream fileStream = new FileStream(dialogSave.FileName, FileMode.Create))
                {
                    TextRange textRange = new TextRange(MainRichTbx.Document.ContentStart, MainRichTbx.Document.ContentEnd);
                    textRange.Save(fileStream, DataFormats.Text);
                }            
            }
        }

        private void SaveAs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Font_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Background_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MaximizeWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BoldButton_Checked(object sender, RoutedEventArgs e)
        {
            //MainRichTbx
        }

        private void BoldButton_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void ItalicButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ItalicButton_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void WrapText_Checked(object sender, RoutedEventArgs e)
        {
           // MainRichTbx   Nie ma takiej wlasciwosci jak TextWrapping w RichTextBox
        }

        private void WrapText_Unchecked(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
