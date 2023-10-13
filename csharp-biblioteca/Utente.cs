using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Utente
    {

        public string? Cognome { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? RecapitoTelefonico { get; set; }

        public Utente(string Cognome, string Nome, string Password, string RecapitoTelefonico)
        {
            this.Cognome = Cognome; 
            this.Nome = Nome;
            this.Email = GeneratoreEmail();
            this.Password = Password;
            this.RecapitoTelefonico = RecapitoTelefonico;
        }

        public string GeneratoreEmail()
        {
            return $"{this.Nome}{this.Cognome}@gmail.com";
        }
    }
}
