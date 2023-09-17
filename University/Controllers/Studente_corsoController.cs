using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DAL;

namespace University.Controllers
{
    internal class Studente_corsoController
    {
        public IConfiguration? configurazione;

        public Studente_corsoController()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);

            configurazione = builder.Build();
        }

        public void stampaElencoStud_corso()
        {
            Studente_corsoDAL stud_corsDal = new Studente_corsoDAL(configurazione);

            List<Studente_corsoDAL> elenco_studente_courso = stud_corsDal.findAll();
            foreach (Studente_corsoDAL item in elenco_studente_courso)
            {
                Console.WriteLine(item);
            }
        }
    }
}
}
