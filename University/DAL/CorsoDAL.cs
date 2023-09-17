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
    internal class CorsoDAL : IDal<Corso>
    {
        private string? stringaConnessione;

        public CorsoDAL(IConfiguration? config)
        {
            if (config != null)
                stringaConnessione = config.GetConnectionString("DatabaseLocale");
        }

        public bool create(Corso obj)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Corso> findAll()
        {
            List<Corso> elencoCorso = new List<Corso>();

            using (SqlConnection connessione = new SqlConnection(stringaConnessione))
            {
                string query = "SELECT corsoID, numeroCorso, nomeCorso, modulo, crediti FROM corso;";
                SqlCommand command = new SqlCommand(query, connessione);

                connessione.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Corso cours = new Corso()
                    {
                        corsoID = Convert.ToInt32(reader[0]),
                        numeroCorso = Convert.ToInt32(reader[1]),
                        nomeCorso = reader[2].ToString(),
                        modulo = reader[3].ToString(),
                        crediti = Convert.ToInt32(reader[4])
                    };


                    elencoCorso.Add(cours);
                }

                connessione.Close();
            }

            return elencoCorso;
        }

        public Corso findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(Corso obj)
        {
            throw new NotImplementedException();
        }

        public bool update(Corso obj)
        {
            throw new NotImplementedException();
        }
    }
}

