using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using System.Windows;
using System.Windows.Media;

namespace IA_RBC
{
    public class PopupInfo : Window
    {
        public PopupInfo(RbcResult result)
        {
            // caso.Nome = "Detalhes da Musica";
            //Width = 300;
            //Height = 150;            

            // ...

            string hexColor = "#FF003A7B"; // Exemplo de cor vermelha
            string hexColorText = "#ffffff"; // Exemplo de cor vermelha

            BrushConverter converter = new BrushConverter();
            Brush brush = (Brush)converter.ConvertFromString(hexColor);
            Brush brushText = (Brush)converter.ConvertFromString(hexColorText);

            // Agora você pode aplicar a cor de fundo em um controle
            this.Background = brush;
            SizeToContent = SizeToContent.WidthAndHeight;

            var stackPanel = new StackPanel();
            stackPanel.Margin = new Thickness(10);

            var nomeLabel = new Label();
            nomeLabel.Foreground = brushText;
            nomeLabel.Content = "Nome: " + result.CasoAnalisado.Nome;
            stackPanel.Children.Add(nomeLabel);

            var totalLabel = new Label();
            totalLabel.Content = "Total: " + result.SimTotal;
            totalLabel.Foreground = brushText;
            stackPanel.Children.Add(totalLabel);

            var energiaLabel = new Label();
            energiaLabel.Foreground = brushText;
            energiaLabel.Content = "Energia: " + result.SimEnergia;
            stackPanel.Children.Add(energiaLabel);

            
            var barulhoLabel = new Label();
            barulhoLabel.Foreground = brushText;
            barulhoLabel.Content = "Barulho: " + result.SimBarulho;
            stackPanel.Children.Add(barulhoLabel);
            
            var acusticaLabel = new Label();
            acusticaLabel.Foreground = brushText;
            acusticaLabel.Content = "Acustica: " + result.SimAcustica;
            stackPanel.Children.Add(acusticaLabel);
            
            var positividadeLabel = new Label();
            positividadeLabel.Foreground = brushText;
            positividadeLabel.Content = "Positividade: " + result.SimPositividade;
            stackPanel.Children.Add(positividadeLabel);
            
            var dancavelLabel = new Label();
            dancavelLabel.Foreground = brushText;
            dancavelLabel.Content = "Dançavel: " + result.SimDancavel;
            stackPanel.Children.Add(dancavelLabel);
            
            var lancamentoLabel = new Label();
            lancamentoLabel.Foreground = brushText;
            lancamentoLabel.Content = "Lançamento: " + result.SimLancamento;
            stackPanel.Children.Add(lancamentoLabel);

            Content = stackPanel;
        }
    }
}

