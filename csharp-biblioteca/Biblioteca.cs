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

        //funzione per creare user
        public void GeneraUtenti()
        {
            Utenti utente1 = new Utenti("Ferrari", "Cristopher", "cristopher@mail.it", "uiopERTY", "3338974657");
            Utenti utente2 = new Utenti("Bianchi", "Lucaa", "lucabianchi@mail.it", "TYUIghj", "3338974456");
            Utenti utente3 = new Utenti("Verdi", "Antonio", "antonioverdi@mail.it", "uiopERTY", "3338974132");
            Utenti utente4 = new Utenti("Rossi", "Pino", "redpinus@mail.it", "uydsauRTY", "3338476457");
            utentiLista.Add(utente1);
            utentiLista.Add(utente2);
            utentiLista.Add(utente3);
            utentiLista.Add(utente4);
        }
        public void GetAllDocuments()
        {
            foreach (Documento doc in documentiLista)
            {
                Console.WriteLine("Titolo : " + doc.Titolo + " - Codice : " + doc.CodiceIdentificativo);
            }
            Console.WriteLine();
        }

        public void checkDocument()
        {
            Console.WriteLine("inserisci il Titolo o il Codice Prodotto");
            string ToSearch = Console.ReadLine();

            foreach (Documento doc in documentiLista)
            {

                if (doc.Titolo == ToSearch || doc.CodiceIdentificativo == ToSearch)
                {
                    if (doc.Stato)
                    {
                        Console.WriteLine("Titolo : " + doc.Titolo + " - Codice : " + doc.CodiceIdentificativo);
                        Console.WriteLine("Sei Registrato 1 - Si  2 - NO");
                        int risposta = Convert.ToInt32(Console.ReadLine());

                        switch (risposta)
                        {
                            case 1:
                                GetUtente(doc);
                                break;
                            default:
                                RegistraUtente();
                                Console.Write("Data Inizio : ");
                                string inizio = Console.ReadLine();
                                Console.Write("Data Fine : ");
                                string fine = Console.ReadLine();
                                Prestito prestito = new Prestito(inizio, fine, doc, utentiLista[utentiLista.Count() - 1]);
                                prestitiLista.Add(prestito);
                                doc.Stato = false;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Documento momentaneamente non disponibile premi invio uscire");
                        return;
                    }

                }
            }
        }

        public void GetUtente(Documento doc)
        {
            Console.Write("Cognome : ");
            string cognome = Console.ReadLine();
            Console.Write("Nome : ");
            string nome = Console.ReadLine();

            foreach (Utenti item in utentiLista)
            {
                if (nome == item.Nome && cognome == item.Cognome)
                {
                    Console.Write("Data Inizio : ");
                    string inizio = Console.ReadLine();
                    Console.Write("Data Fine : ");
                    string fine = Console.ReadLine();
                    Prestito prestito = new Prestito(inizio, fine, doc, item);
                    prestitiLista.Add(prestito);
                    doc.Stato = false;
                }
            }
        }

        public void GetPrestito()
        {
            foreach (Prestito item in prestitiLista)
            {  
                Console.WriteLine(item.UtentePrestito.Cognome + " " + item.UtentePrestito.Nome + " ha preso in prestito " + item.documentoPrestato.Titolo);               
            }
        }
    }
}
