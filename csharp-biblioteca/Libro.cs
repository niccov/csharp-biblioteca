using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Libro : Documento
    {
        public int Pagine { get; private set; }

        public Libro(string titolo, int anno, string genere, int scaffale, string autore) : base(titolo, anno, genere, scaffale, autore)
        {
            Pagine = GenRandom();
        }

        public override int GenRandom()
        {
            int min = 60;
            int max = 1000;
            int numeroRandom = Random.Shared.Next(min, max);

            return numeroRandom;
        }
    }
}
