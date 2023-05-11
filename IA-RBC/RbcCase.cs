using System;
using System.Collections.Generic;
using System.Text;

namespace IA_RBC
{
    class RbcCase
    {

        public RbcCase(int campo1, string campo2, string campo3)
        {
            this.Campo1 = campo1;
            this.Campo2 = campo2;
            this.Campo3 = campo3;
        }

        public int Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }

    }
}
