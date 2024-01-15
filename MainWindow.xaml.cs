using Microsoft.Win32;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void Zapisz(object sender, RoutedEventArgs e)
        {
           
            if (!File.Exists("E:\\plik.txt"))
            {
                StreamWriter sw = File.CreateText("E:\\plik.txt");
                
                sw.Close();
            }
            File.AppendAllText("E:\\plik.txt", text_box.Text);
          
             
        }

        private object FileCreateText(string v, FileMode open, FileAccess readWrite)
        {
            throw new NotImplementedException();
            var File = FileCreateText("E:\\plik.txt", FileMode.Open, FileAccess.ReadWrite);
            
        }

        private void Usun(object sender, RoutedEventArgs e)
        {
            File.Delete("E:\\plik.txt");
        }
        private void Otworz(object sender, RoutedEventArgs e)
        {
           OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == true)
            {
                text_box.Text = File.ReadAllText(fileDialog.FileName);
            }

        }

        private void Więcej(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {

        }
    }
    }

