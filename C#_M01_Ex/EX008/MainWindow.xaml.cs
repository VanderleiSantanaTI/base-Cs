using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace EX008
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            int ini, fim;
            int.TryParse(txtini.Text, out ini);
            int.TryParse(txtFim.Text, out fim);
            
            Random gerador = new Random();
            int num = gerador.Next(ini, fim+1);

            lblSorteio.Visibility = Visibility.Visible;

            lblSorteio.Content = $"Sortendo entre {ini} e {fim}... ";
            await Task.Delay(2000);

            lblSorteio.Content = $"Sorteio o valor {num}";

            
        }
    }
}
