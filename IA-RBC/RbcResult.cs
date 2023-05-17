using System;
using System.Collections.Generic;
using System.Text;

namespace IA_RBC
{
    public class RbcResult
    {

        public int Index { get; set; }
        public double SimTotal { get; set; }
        public double SimEnergia { get; set; }
        public double SimBarulho { get; set; }
        public double SimAcustica { get; set; }
        public double SimPositividade { get; set; }
        public double SimDancavel { get; set; }
        public double SimLancamento { get; set; }
        public RbcCase CasoAnalisado { get; set; }

    }
}
