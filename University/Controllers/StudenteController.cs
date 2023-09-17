using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DAL;
using University.Models;

namespace University.Controllers
{
    internal class StudenteController
    {
        public IConfiguration? configurazione;

        public StudenteController()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);

            configurazione = builder.Build();
        }

        public void stampaElencoStudente()
        {
            StudenteDAL stud = new StudenteDAL(configurazione);

            List<StudenteDAL> elencoStudente = stud.findAll();
            foreach (StudenteDAL item in elencoStudente)
            {
                Console.WriteLine(item);
            }
        }
    }
}
