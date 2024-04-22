using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Documento
    {
        public Documento(string titolo, int anno, string settore, bool stato, double scaffale, string autore, string codiceIdentificativo)
        {
            Titolo = titolo;
            Anno = anno;
            Settore = settore;
            Stato = stato;
            Scaffale = scaffale;
            Autore = autore;
            CodiceIdentificativo = codiceIdentificativo;
        }

        public string CodiceIdentificativo { set; get; }
        public string Titolo { set; get; }
        public int Anno { set; get; }
        public string Settore { set; get; }
        public bool Stato { set; get; }
        public double Scaffale { set; get; }
        public string Autore { set; get; }

    }
}
