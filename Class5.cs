using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_28_4
{
    internal class Prestito
    {
        public string Numero {  get; set; }
        public DateTime Da {  get; set; }
        public  DateTime Al { get; set; }
        public Utente Utente { get; set; }
        public Documento Documento { get; set; }
    }
}
