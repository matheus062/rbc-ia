using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace IA_RBC
{
    /// <summary>
    /// Lógica interna para EditWeight.xaml
    /// </summary>
    public partial class EditWeight : Window
    {
        public EditWeight(List<double> Weights)
        {
            InitializeComponent();
            energia.Text = Weights[0].ToString();
            barulho.Text = Weights[1].ToString();
            acustica.Text = Weights[2].ToString();
            positividade.Text = Weights[3].ToString();
            dancavel.Text = Weights[4].ToString();
            lancamento.Text = Weights[5].ToString();
        }

    }
}
