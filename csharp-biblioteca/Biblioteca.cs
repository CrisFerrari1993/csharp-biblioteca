﻿using System;
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
        //funzione che prende il prestito
        public void GetPrestito()
        {
            Console.Write("Inserisci il cognome: ");
            string cognome = Console.ReadLine();
            Console.Write("Inserisci il nome: ");
            string nome = Console.ReadLine();

            foreach (Prestito item in prestitiLista)
            {
                if (nome == item.UtentePrestito.Nome && cognome == item.UtentePrestito.Cognome)
                {
                    Console.WriteLine($"{item.UtentePrestito.Cognome} {item.UtentePrestito.Nome} ha preso in prestito {item.documentoPrestato.Titolo}");
                }
            }
        }

        //funzione che prende i dati dell'utente
        public void GetUtente(Documento doc)
        {
            Console.Write("Inserisci il cognome: ");
            string cognome = Console.ReadLine();
            Console.Write("Inserisci il nome: ");
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
        //funzione che controlla i documenti
        public void controllaDoc()
        {
            Console.WriteLine("Inserisci il titolo o il codice del prodotto");
            string cerca = Console.ReadLine();

            foreach(Documento documento in documentiLista) 
            {
                if(documento.Titolo == cerca || documento.CodiceIdentificativo == cerca)
                {
                    if(documento.Stato)
                    {
                        Console.WriteLine($"Titolo: {documento.Titolo} - Codice: {documento.CodiceIdentificativo}");
                        Console.WriteLine("Sei registrato? (SI/1 NO/2)");
                        int risposta = int.Parse(Console.ReadLine());
                        
                        switch(risposta)
                        {
                            case 1:
                                GetUtente(documento);
                                break;
                            default:
                                RegistraUtente();
                                Console.Write("Data Inizio : ");
                                string inizio = Console.ReadLine();
                                Console.Write("Data Fine : ");
                                string fine = Console.ReadLine();
                                Prestito prestito = new Prestito(inizio, fine, documento, utentiLista[utentiLista.Count() - 1]);
                                prestitiLista.Add(prestito);
                                documento.Stato = false;
                                break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Documento non disponibile");
                        return;
                    }
                }
            }
        }
    }
}
