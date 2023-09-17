using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Studente
    {
        public int codiceID { get; set; }
        public string? matricola { get; set; }
        public string? nome { get; set; }
        public string? cognome { get; set; }
        public DateTime dataNascita { get; set; }
        public string? codFiscale { get; set; }
    }
}
