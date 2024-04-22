using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Biblioteca
    {
        // Creo liste per utenti, documenti e prestiti
        public List<Utenti> utentiLista = new List<Utenti>();
        public List<Documento> documentiLista = new List<Documento>();
        public List<Prestito> prestitiLista = new List<Prestito>();

        // funzione per registrare utente
        public void RegistraUtente()
        {
            Console.WriteLine("Registrati");
            Console.Write("Inserisci il tuo congnome: ");
            string cognome = Console.ReadLine();
            Console.Write("Inserisci il tuo nome: ");
            string nome = Console.ReadLine();
            Console.Write("Inserisci la tua email: ");
            string email = Console.ReadLine();
            Console.Write("Inserisci la tua password: ");
            string password = Console.ReadLine();
            Console.Write("Inserisci il tuo recapito telefonico: ");
            string recapitoTelefonico = Console.ReadLine();

            Utenti utenti = new Utenti(cognome, nome, email, password, recapitoTelefonico);
            utentiLista.Add(utenti);
        }
    }
}
