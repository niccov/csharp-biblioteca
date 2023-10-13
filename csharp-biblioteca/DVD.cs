using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class DVD : Documento
    {
        public int Durata { get; set; }

        public DVD(string titolo, int anno, string genere, int scaffale, string autore) : base(titolo, anno, genere, scaffale, autore)
        {
            Durata = GenRandom();
        }

        public override int GenRandom()
        {
            // Generate a random number between 80 and 1000
            int min = 30;
            int max = 200;
            int numeroRandom = Random.Shared.Next(min, max);

            return numeroRandom;
        }
    }
}
