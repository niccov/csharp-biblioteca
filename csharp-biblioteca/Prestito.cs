using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Prestito
    {
        public Utente Utente { get; set; }
        public Documento Documento { get; set; }
        public DateTime DataInizioPrestito { get; set; }
        public DateTime DataFinePrestito { get; set; }

        public Prestito(Utente utente, Documento documento, DateTime dataInizioPrestito, DateTime dataFinePrestito)
        {
            Utente = utente;
            Documento = documento;
            DataInizioPrestito = dataInizioPrestito;
            DataFinePrestito = dataFinePrestito;
        }
    }
}
