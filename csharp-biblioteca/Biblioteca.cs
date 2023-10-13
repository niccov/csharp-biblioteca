using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Biblioteca
    {
        public List<Utente> Utenti { get; set; }
        public Dictionary<string, Documento> Documenti { get; set; }
        public List<Prestito> Prestiti { get; set; }

        public Biblioteca()
        {
            Documenti = new Dictionary<string, Documento>();
            Utenti = new List<Utente>();
            Prestiti = new List<Prestito>();
        }

        public void AggiungiDocumento(Documento documento)
        {
            Documenti.Add(documento.Codice, documento);
        }

        public void AggiungiUtente(Utente utente)
        {
            Utenti.Add(utente);
        }
        public void AggiungiPrestito(Prestito loan)
        {
            Prestiti.Add(loan);
        }

        public void RegistroPrestiti(Utente utente, Documento documento, DateTime dataInizioPrestito, DateTime dataFinePrestito)
        {
            if (!Utenti.Contains(utente))
            {
                Console.WriteLine("L'utente non è registrato");
                return;
            }

            if (!Documenti.ContainsKey(documento.Codice))
            {
                Console.WriteLine("Documento non disponibile");
                return;
            }

            foreach (var key in Prestiti)
            {
                if (key.Documento == documento && key.DataFinePrestito >= key.DataInizioPrestito) 
                {
                    Console.WriteLine("Il documento è ancora in prestito");
                    return;
                }
            }

            var prestito = new Prestito(utente, documento, dataInizioPrestito, dataFinePrestito);
            Prestiti.Add(prestito);

            Console.WriteLine("Prestisto registrato con successo!");

        }

        public List<Prestito> RicercaPrestitoPerNome(string nome, string cognome)
        {
            var UtentePrestitoRicercato = Prestiti.FindAll(prestito => prestito.Utente.Nome.ToLower() == nome.ToLower() && prestito.Utente.Cognome.ToLower() == cognome.ToLower());
            return UtentePrestitoRicercato;

        }

        public Documento RicercaPrestitoPerCodice(string codice)
        {
            var codiceTrovato = Documenti[codice];
            return codiceTrovato;

        }

        public List<Documento> RicercaDocumentiPerTitolo(string titolo)
        {
            List<Documento> documentoTrovato = new List<Documento>();

            var listaDocumenti = Documenti.Values;

            foreach (var doc in listaDocumenti)
            {
                if (doc.Titolo == titolo)
                {
                    documentoTrovato.Add(doc);
                }
            }

            return documentoTrovato;

        }

    }
}
