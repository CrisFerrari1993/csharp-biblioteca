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

        //creazione funzione per generare libri e dvd
        public void GeneraDocumenti()
        {
            //Libri
            Libri ichiQHachiYon = new Libri("1Q84", 2009, "Thriller", true, 10.12f, "Harui Murakami", "13D2324AD4", 653);
            documentiLista.Add(ichiQHachiYon);
            Libri norWood = new Libri("Norvegian Wood", 1987, "Romantico", true, 13.22f, "Harui Murakami", "13D2324AD1", 410);
            documentiLista.Add(norWood);
            Libri uccelloCheGiraLeViti = new Libri("L'uccello che girava le viti del mondo", 1994, "Romanzo", true, 8.12f, "Harui Murakami", "13D2324AD4", 522);
            documentiLista.Add(uccelloCheGiraLeViti);

            //DvD
            DvD cenerentola = new DvD("cenerentola", 1996, "animazione", true, 15.14f, "Lorenzo Rossi", "235F78G2F3", 70);
            documentiLista.Add(cenerentola);
            DvD biancaneve = new DvD("biancaneve", 1996, "animazione", true, 15.14f, "Lorenzo Rossi", "234DA79NK7", 70);
            documentiLista.Add(biancaneve);
            DvD godzilla = new DvD("godzilla", 1996, "animazione", false, 15.14f, "Lorenzo Rossi", "87A6FG76T9", 70);
            documentiLista.Add(godzilla);
        }
    }
}
