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
    internal class StudenteDAL : IDal<Studente>
    {
        private string? stringaConnessione;

        public StudenteDAL(IConfiguration? config)
        {
            if (config != null)
                stringaConnessione = config.GetConnectionString("DatabaseLocale");
        }
        public bool create(Studente obj)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Studente> findAll()
        {
            List<Studente> elencoStudente = new List<Studente>();

            using (SqlConnection connessione = new SqlConnection(stringaConnessione))
            {
                string query = "SELECT codiceID, matricola, nome, cognome, dataNascita, codFiscale FROM studente;";
                SqlCommand command = new SqlCommand(query, connessione);

                connessione.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Studente student = new Studente()
                    {
                        codiceID = Convert.ToInt32(reader[0]),
                        matricola = reader[1].ToString(),
                        nome = reader[2].ToString(),
                        cognome = reader[3].ToString(),
                        dataNascita = Convert.ToDateTime(reader[4]),
                        codFiscale = reader[5].ToString()
                    };


                    elencoStudente.Add(student);
                }

                connessione.Close();
            }

            return elencoStudente;
        }

        public Studente findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(Studente obj)
        {
            throw new NotImplementedException();
        }

        public bool update(Studente obj)
        {
            throw new NotImplementedException();
        }
    }
}
