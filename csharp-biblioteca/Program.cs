namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DVD dvd1 = new("Pulp Fiction", 1999, "Azione", 5, "Quentin Tarantino"); 
            DVD dvd2 = new("The wolf of Wall Street", 2013, "Commedia", 73, "Denis Thampton");
            DVD dvd3 = new("Un weekend da bamboccioni", 2010, "Commedia", 42, "Dennis Dugan");
            Libro libro1 = new("Ti prendo e ti porto via", 2008, "Romanzo", 7, "Niccolò Ammaniti");
            Libro libro2 = new("Il silenzio dell'onda", 2010, "Romanzo", 12, "Gianrico Carofiglio");
            Libro libro3 = new("Attack on Titan", 2005, "Manga", 22, "Hajime Isayama");

            Utente utente1 = new("Franco", "Lippi", "F2ha2g81", "3337895642");
            Utente utente2 = new("Piero", "Leoni", "6IF4S2qA", "3457862341");
            Utente utente3 = new("Cristiano", "Pieni", "22D4fgPo", "3298609374");
            Utente utente4 = new("Giulia", "Pepoli", "P9O87gs2", "3119231275");
            Utente utente5 = new("Marco", "Uvini", "Xb2V5M99", "3469890824");


            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AggiungiUtente(utente1);
            biblioteca.AggiungiUtente(utente2);
            biblioteca.AggiungiUtente(utente3);
            biblioteca.AggiungiDocumento(dvd1);
            biblioteca.AggiungiDocumento(dvd1);
            biblioteca.AggiungiDocumento(dvd2);
            biblioteca.RegistroPrestiti(utente2, dvd1, DateTime.Now, DateTime.Now.AddDays(5));

            var documentoCercato = biblioteca.RicercaPrestitoPerCodice(dvd3.Codice);
            Console.WriteLine(documentoCercato);



            foreach (var x in biblioteca.Documenti)
            {
                Console.WriteLine(x);
            }

        }
    }
}