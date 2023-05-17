using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace IA_RBC
{
    [Serializable]
    public class RbcCase
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public double Energia { get; set; }
        public double Barulho { get; set; }
        public double Acustica { get; set; }
        public double Positividade { get; set; }
        public double Dancavel { get; set; }
        public int Lancamento { get; set; }

        public RbcCase(string nome, string artista, double energia, double barulho, double acustica, double positividade, double dancavel, int lancamento)
        {
            this.Nome = nome;
            this.Artista = artista;
            this.Energia = energia;
            this.Barulho = barulho;
            this.Acustica = acustica;
            this.Positividade = positividade;
            this.Dancavel = dancavel;
            this.Lancamento = lancamento;
        }
    }
}
