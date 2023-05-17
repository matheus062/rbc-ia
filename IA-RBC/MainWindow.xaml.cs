using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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

namespace IA_RBC
{
    public partial class MainWindow : Window
    {
        //public ObservableCollection<RbcCase> data { get; set; }

        public List<double> Weights { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            InitializeDataset();
            this.Weights = new List<double> { 1.0, 0.2, 0.5, 1.0, 0.8, 0.5 };
        }

        ObservableCollection<RbcCase> Database = new ObservableCollection<RbcCase>();
        ObservableCollection<RbcResult> RbcResults = new ObservableCollection<RbcResult>();

        private void InitializeDataset()
        {
            using (var reader = new StreamReader(@"songs.csv"))
            {
                List<string> listA = new List<string>();
                ObservableCollection<RbcCase> database = new ObservableCollection<RbcCase>();
                var header = reader.ReadLine().Split(';');

                while (!reader.EndOfStream)
                {
                    var song = reader.ReadLine().Split(';');
                    database.Add(new RbcCase(
                        song[0],
                        song[1],
                        Convert.ToDouble(song[2], CultureInfo.InvariantCulture),
                        Convert.ToDouble(song[3], CultureInfo.InvariantCulture),
                        Convert.ToDouble(song[4], CultureInfo.InvariantCulture),
                        Convert.ToDouble(song[5], CultureInfo.InvariantCulture),
                        Convert.ToDouble(song[6], CultureInfo.InvariantCulture),
                        Convert.ToInt16(song[7])
                    ));
                }

                int count = 1;
                foreach (var item in database)
                {
                    RbcCase rbc = new RbcCase(item.Nome, item.Artista, item.Energia, item.Barulho, item.Acustica, item.Positividade, item.Dancavel, item.Lancamento, count++);
                    this.Database.Add(rbc);
                }
            }
            // TODO > Alterar para GridView
            database.ItemsSource = this.Database;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditWeight popUp = new EditWeight(this.Weights);
            popUp.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<RbcResult> listaSimilaridade = this.CalcularSimilaridade(database.SelectedIndex);
            this.RbcResults = new ObservableCollection<RbcResult>(listaSimilaridade);
            result.ItemsSource = this.RbcResults;
        }

        public List<RbcResult> CalcularSimilaridade(int index)
        {
            if (index == -1) index = 0;

            List<RbcResult> lista = new List<RbcResult>();
            RbcCase escolha = this.Database[index];

            double[,] tabelaAnos = {
                { 1, 0.2, 0, 0, 0},
                { 0.2, 1, 0.6, 0, 0},
                { 0, 0.6, 1, 0.6, 0.2},
                { 0, 0, 0.6, 1, 0.8},
                { 0, 0, 0.2, 0.8, 1},
            };


            for (int i = 0; i < this.Database.Count; i++)
            {
                if (i == index) continue;

                var comparar = this.Database[i];
                RbcResult result = new RbcResult();
                int ano1 = (comparar.Lancamento > 2000) ? 0 :
                    (comparar.Lancamento > 2011) ? 1 :
                    (comparar.Lancamento > 2016) ? 2 :
                    (comparar.Lancamento > 2021) ? 3 : 4;
                int ano2 = (escolha.Lancamento > 2000) ? 0 :
                    (escolha.Lancamento > 2011) ? 1 :
                    (escolha.Lancamento > 2016) ? 2 :
                    (escolha.Lancamento > 2021) ? 3 : 4;
                result.Index = i;
                result.Nome = escolha.Nome;
                result.SimEnergia = (1 - Math.Abs(comparar.Energia - escolha.Energia) / 0.72);
                result.SimBarulho = (1 - Math.Abs(comparar.Barulho - escolha.Barulho) / 11.38);
                result.SimAcustica = (1 - Math.Abs(comparar.Acustica - escolha.Acustica) / 0.94);
                result.SimPositividade = (1 - Math.Abs(comparar.Positividade - escolha.Positividade) / 0.91);
                result.SimDancavel = (1 - Math.Abs(comparar.Dancavel - escolha.Dancavel) / 0.56);
                result.SimLancamento = tabelaAnos[ano1, ano2];
                result.CasoAnalisado = this.Database[index];
                result.SimTotal = Math.Round((((
                        (result.SimEnergia * this.Weights[0]) +
                        (result.SimBarulho * this.Weights[1]) +
                        (result.SimAcustica * this.Weights[2]) +
                        (result.SimPositividade * this.Weights[3]) +
                        (result.SimDancavel * this.Weights[4]) +
                        (result.SimLancamento * this.Weights[5])
                ) / this.Weights.Sum()) * 100), 2, MidpointRounding.AwayFromZero); ;
                lista.Add(result);
            }

            lista.Sort((x, y) => (x.SimTotal.CompareTo(y.SimTotal)) * -1);

            return lista;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var result = (RbcResult)button.DataContext;
            //RbcCase caso = result.CasoAnalisado;

            var popup = new PopupInfo(result);
            popup.Owner = this;
            popup.ShowDialog();
        }
    }

}
