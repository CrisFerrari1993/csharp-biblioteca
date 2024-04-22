using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class DvD : Documento
    {
        public DvD(string titolo, int anno, string settore, bool stato, double scaffale, string autore, string numeroSeriale, float durata) : base(titolo, anno, settore, stato, scaffale, autore, numeroSeriale)
        {
            Durata = durata;
        }

        public float Durata { set; get; }
    }
}
