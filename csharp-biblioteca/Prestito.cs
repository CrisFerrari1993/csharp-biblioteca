using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Prestito
    {
        public Prestito(string dataInizio, string dataFine, Documento documentoPrestato, Utenti utentePrestito)
        {
            DataInizio = dataInizio;
            DataFine = dataFine;
            this.documentoPrestato = documentoPrestato;
            UtentePrestito = utentePrestito;
        }

        public string DataInizio { get; set; }
        public string DataFine { get; set; }
        public Documento documentoPrestato { get; set; }
        public Utenti UtentePrestito { get; set; }
    }
}
