using ProductEvolutionV1._3.Core;
using ProductEvolutionV1._3.Core.Site;
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

namespace ProductEvolutionV1._3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ParserWorker<string[]> parserWorker;
        public MainWindow()
        {
            InitializeComponent();

            parserWorker = new ParserWorker<string[]>(new SiteParser());
            parserWorker.OnCompleted += ParserWorker_OnCompleted;
            parserWorker.OnNewData += ParserWorker_OnNewData;
        }

        private void ParserWorker_OnNewData(object arg1, string[] arg2)
        {
            for (int i = 0; i < arg2.Length; i++)
            {
                ListBoxResult.Items.Add(arg2[i]);
            }
        }

        private void ParserWorker_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            parserWorker.ParserSettings = new SiteSettings(EnterTextBox.Text);
            parserWorker.Start();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ProfilMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
