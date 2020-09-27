using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTerceiroBimestrePT
{
    class Torcedor
    {
        public String Nome { get; set; }
        public String Apelido { get; set; }
        public String Time { get; set; }
        public Double Nota { get; set; }
        public DateTime DataNasc { get; set; }

        public override string ToString()
        {
            return "Nome:" + Nome + ", " +
                   "Apelido:" + Apelido + ", " +
                   "Time do coração:" + Time + ", " +
                   "Nota do time:" + Nota + ", " +
                   "Data de nascimento:" + DataNasc;
        }
    }
}
