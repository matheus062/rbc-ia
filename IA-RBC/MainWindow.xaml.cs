using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace IA_RBC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public ObservableCollection<RbcCase> data { get; set; }

        public List<double> Weights { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            aleatoria();
            this.Weights = new List<double> { 1.0, 0.2, 0.5, 1.0, 0.8, 0.5 };
        }

        ObservableCollection<RbcCase> Database = new ObservableCollection<RbcCase>()
        {
            new RbcCase(10, "Nathan", "Gênio"),
            new RbcCase(10, "Matheus", "Top"),
            new RbcCase(10, "Ries", "Foda")
        };

        private void aleatoria()
        {
            database.ItemsSource = this.Database;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditWeight popUp = new EditWeight(this.Weights);
            popUp.Show();
        }
    }

}
