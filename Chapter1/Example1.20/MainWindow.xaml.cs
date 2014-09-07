using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Example1._20
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

        private async void OnButtonClick(object sender, RoutedEventArgs e)
        {
            var httpClient = new HttpClient();
            var content = await httpClient.GetStringAsync("http://www.microsoft.com").ConfigureAwait(false);

            // Throws an exception because the ConfigureAwait is set to false and 
            // the this.ResultTextBox.Text is not executed on the UI thread
            this.ResultTextBox.Text = content;
        }
    }
}
