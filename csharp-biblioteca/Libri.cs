using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Libri : Documento
    {
        public Libri(string titolo, int anno, string settore, bool stato, double scaffale, string autore, string ISBN, int numeroDiPagine) : base(titolo, anno, settore, stato, scaffale, autore, ISBN)
        {
            NumeroDiPagine = numeroDiPagine;
        }

        public int NumeroDiPagine { set; get; }
    }
}
