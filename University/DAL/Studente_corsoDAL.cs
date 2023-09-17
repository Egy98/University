using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;

namespace University.DAL
{
    internal class Studente_corsoDAL : IDal<Studente_corso>
    {
        private string? stringaConnessione;

        public Studente_corsoDAL(IConfiguration? config)
        {
            if (config != null)
                stringaConnessione = config.GetConnectionString("DatabaseLocale");
        }
        public bool create(Studente_corso obj)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Studente_corso> findAll()
        {
            List<Studente_corso> elenco_studente_courso = new List<Studente_corso>();

            using (SqlConnection connessione = new SqlConnection(stringaConnessione))
            {
                string query = "SELECT studenteRIF, corsoRIF FROM studente_corso;";
                SqlCommand command = new SqlCommand(query, connessione);

                connessione.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Studente_corso student_cours = new Studente_corso()
                    {
                        studenteRIF = Convert.ToInt32(reader[0]),
                        corsoRIF = Convert.ToInt32(reader[1]),
                     };


                    elenco_studente_courso.Add(student_cours);
                }

                connessione.Close();
            }

            return elenco_studente_courso;
        }

        public Studente_corso findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(Studente_corso obj)
        {
            throw new NotImplementedException();
        }

        public bool update(Studente_corso obj)
        {
            throw new NotImplementedException();
        }
    }
    
}
