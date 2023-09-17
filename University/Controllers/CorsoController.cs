using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DAL;

namespace University.Controllers
{
    internal class CorsoController
    {
        public IConfiguration? configurazione;

        public CorsoController()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);

            configurazione = builder.Build();
        }

        public void stampaElencoCorso()
        {
            CorsoDAL corsDal = new CorsoDAL(configurazione);

            List<CorsoDAL> elenco = corsDal.findAll();
            foreach (CorsoDAL item in elenco)
            {
                Console.WriteLine(item);
            }
        }
    }
}
