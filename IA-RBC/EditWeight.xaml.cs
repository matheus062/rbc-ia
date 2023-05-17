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
using System.Reflection.Metadata.Ecma335;
using System.Collections;
using System.Linq;

namespace IA_RBC
{
    /// <summary>
    /// Lógica interna para EditWeight.xaml
    /// </summary>
    public partial class EditWeight : Window
    {
        public List<double> Weights { get; set; }

        public EditWeight(List<double> Weights)
        {
            InitializeComponent();
            this.Weights = Weights;
            UpdateStatus();
        }

        public void UpdateStatus()
        {
            energia.Text = this.Weights[0].ToString();
            barulho.Text = this.Weights[1].ToString();
            acustica.Text = this.Weights[2].ToString();
            positividade.Text = this.Weights[3].ToString();
            dancavel.Text = this.Weights[4].ToString();
            lancamento.Text = this.Weights[5].ToString();
        }

        private void energiaUp_Click(object sender, RoutedEventArgs e)
        {
            if (this.Weights[0] < 1.0)
            {
                this.Weights[0] = Math.Round(this.Weights[0] + 0.1, 1, MidpointRounding.AwayFromZero);
            }
            UpdateStatus();
        }

        private void energiaDown_Click(object sender, RoutedEventArgs e)
        {
            if (this.Weights[0] > 0.0)
            {
                this.Weights[0] = Math.Round(this.Weights[0] - 0.1, 1, MidpointRounding.AwayFromZero);
            }
            UpdateStatus();
        }

        private void barulhoUp_Click(object sender, RoutedEventArgs e)
        {
            if (this.Weights[1] < 1.0)
            {
                this.Weights[1] = Math.Round(this.Weights[1] + 0.1, 1, MidpointRounding.AwayFromZero);
            }
            UpdateStatus();
        }

        private void barulhoDown_Click(object sender, RoutedEventArgs e)
        {
            if (this.Weights[1] > 0.0)
            {
                this.Weights[1] = Math.Round(this.Weights[1] - 0.1, 1, MidpointRounding.AwayFromZero);
            }
            UpdateStatus();
        }

        private void acusticaUp_Click(object sender, RoutedEventArgs e)
        {
            if (this.Weights[2] < 1.0)
            {
                this.Weights[2] = Math.Round(this.Weights[2] + 0.1, 1, MidpointRounding.AwayFromZero);
            }
            UpdateStatus();
        }

        private void acusticaDown_Click(object sender, RoutedEventArgs e)
        {
            if (this.Weights[2] > 0.0)
            {
                this.Weights[2] = Math.Round(this.Weights[2] - 0.1, 1, MidpointRounding.AwayFromZero);
            }
            UpdateStatus();
        }

        private void positividadeUp_Click(object sender, RoutedEventArgs e)
        {
            if (this.Weights[3] < 1.0)
            {
                this.Weights[3] = Math.Round(this.Weights[3] + 0.1, 1, MidpointRounding.AwayFromZero);
            }
            UpdateStatus();
        }

        private void positividadeDown_Click(object sender, RoutedEventArgs e)
        {
            if (this.Weights[3] > 0.0)
            {
                this.Weights[3] = Math.Round(this.Weights[3] - 0.1, 1, MidpointRounding.AwayFromZero);
            }
            UpdateStatus();
        }

        private void dancavelUp_Click(object sender, RoutedEventArgs e)
        {
            if (this.Weights[4] < 1.0)
            {
                this.Weights[4] = Math.Round(this.Weights[4] + 0.1, 1, MidpointRounding.AwayFromZero);
            }
            UpdateStatus();
        }

        private void dancavelDown_Click(object sender, RoutedEventArgs e)
        {
            if (this.Weights[4] > 0.0)
            {
                this.Weights[4] = Math.Round(this.Weights[4] - 0.1, 1, MidpointRounding.AwayFromZero);
            }
            UpdateStatus();
        }

        private void lancamentoUp_Click(object sender, RoutedEventArgs e)
        {
            if (this.Weights[5] < 1.0)
            {
                this.Weights[5] = Math.Round(this.Weights[5] + 0.1, 1, MidpointRounding.AwayFromZero);
            }
            UpdateStatus();
        }

        private void lancamentoDown_Click(object sender, RoutedEventArgs e)
        {
            if (this.Weights[5] > 0.0)
            {
                this.Weights[5] = Math.Round(this.Weights[5] - 0.1, 1, MidpointRounding.AwayFromZero);
            }
            UpdateStatus();
        }
    }
}
