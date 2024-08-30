using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listid
{
    internal class Class2
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }

        public Inimene() { }
        public Inineme(string nimi) {
            Nimi = nimi;
        }
        public Inineme(string nimi, int vanus = 2)
        {
            Nimi = nimi;
            Vanus = vanus;
        }

    }
}
