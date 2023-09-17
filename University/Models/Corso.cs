using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Corso
    {
        public int corsoID { get; set; }
        public int numeroCorso { get; set; }
        public string? nomeCorso { get; set; }
        public string? modulo { get; set; }
        public int crediti { get; set; }

    }
}
