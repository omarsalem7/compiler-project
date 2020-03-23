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

namespace Scanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String input;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void submit_click(object sender, RoutedEventArgs e)
        {

            input = textbox.Text;

            TableLexeme l = new TableLexeme(input);
            l.Show();

        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}