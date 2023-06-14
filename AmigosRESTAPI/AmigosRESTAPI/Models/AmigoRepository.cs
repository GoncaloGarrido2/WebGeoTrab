using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AmigosRESTAPI.Models {
    public class AmigoRepository : IAmigoRepository {
        public IEnumerable<Utilizador> GetAll() {

            List<Utilizador> utilizadores = new List<Utilizador>();

            using (NpgsqlConnection connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["NomeDaConexao"].ConnectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Utilizador";
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);

                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Utilizador utilizador = new Utilizador();
                    utilizador.Id = reader.GetInt32(0);
                    utilizador.Nome = reader.GetString(1);
                    utilizador.DataNascimento = reader.GetDateTime(2);
                    utilizador.IdLocalizacao = reader.GetInt32(3);

                    utilizadores.Add(utilizador);
                }

                reader.Close();
            }

            Utilizador[] vResponse = new Utilizador[utilizadores.Count];

            return vResponse;
        }
        public IEnumerable<Utilizador> GetAll(int pId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=ts_AppAmigos;User Id=postgres;Password=1234;"))
            {
                connection.Open();

                string sql = "SELECT * FROM Utilizador WHERE id=@id";
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", pId);

                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Utilizador utilizador = new Utilizador();
                    utilizador.Id = reader.GetInt32(0);
                    utilizador.Nome = reader.GetString(1);
                    utilizador.DataNascimento = reader.GetDateTime(2);
                    utilizador.IdLocalizacao = reader.GetInt32(3);

                    reader.Close();

                    Utilizador[] vResponse = new Utilizador[1];

                    vResponse[0] = utilizador;
                    return vResponse;
                }
                else
                {
                    reader.Close();

                    return null;
                }
            }

            
        }
        public IEnumerable<Utilizador> GetAll(int id, string nome, string dataNascimento)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["NomeDaConexao"].ConnectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Utilizador (idLocalizacao, Nome, DataNascimento) VALUES (@idLocalizacao, @nome, @dataNascimento)";
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                command.Parameters.AddWithValue("@idLocalizacao", id);
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@dataNascimento", dataNascimento);

                command.ExecuteNonQuery();
            }
            return new Utilizador[0];
        }
    }
}