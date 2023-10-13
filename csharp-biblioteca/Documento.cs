using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public abstract class Documento
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Genere { get; set; }
        public int Scaffale { get; set; }
        public string Autore { get; set; }

        public Documento(string titolo, int anno, string genere, int scaffale, string autore)
        {
            Codice = $"{titolo[0].ToString().ToUpper()}-{GenRandom()}";
            Titolo = titolo;
            Anno = anno;
            Genere = genere;
            Scaffale = scaffale;
            Autore = autore;
        }

        public override string ToString()
        {
            return $"Document ${this.Codice}:\n" +
                $"\t-Title: {this.Titolo}\n" +
                $"\t-Year: {this.Anno}\n" +
                $"\t-Author: {this.Autore}\n";
        }

        public virtual int GenRandom()
        {
            int min = 1;
            int max = 1000;

            int numeroRandom = Random.Shared.Next(min, max);

            return numeroRandom;
        }

    }
}
