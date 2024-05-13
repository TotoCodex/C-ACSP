using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FormsTestACS
{
    public class DB
    {
        public static MySqlConnection mysqlConnection;
        public static MySqlCommand mysqlCommand;

        public static string ConnectionString { get; } = @"Server=localhost;Database=acsp;Uid=root;Pwd=;";

        static DB()
        {
            mysqlConnection = new MySqlConnection(ConnectionString);

            mysqlCommand = new MySqlCommand(ConnectionString);
            mysqlCommand.CommandType = System.Data.CommandType.Text; // el tipo de comando que envío (texto)
            mysqlCommand.Connection = mysqlConnection; // envío la consulta
        }
        

        public static void InsertUsuario(Usuario usuario)
        {
            try
            {
                mysqlConnection.Open();
                mysqlCommand.Parameters.Clear();
                var query = $"INSERT INTO `proyecto-acsp`  (Name,Age,User,Password,DNI) " +
                            $"VALUES (@Name, @Age, @User, @Password, @DNI)";

                mysqlCommand.CommandText = query;

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    
                    command.Parameters.Add(new MySqlParameter("Name", MySqlDbType.Text) { Value = usuario.Name });
                    command.Parameters.Add(new MySqlParameter("Age", MySqlDbType.Int64) { Value = usuario.Age });
                    command.Parameters.Add(new MySqlParameter("User", MySqlDbType.Text) { Value = usuario.User });
                    command.Parameters.Add(new MySqlParameter("Password", MySqlDbType.Text) { Value = usuario.Password });
                    command.Parameters.Add(new MySqlParameter("DNI", MySqlDbType.Int64) { Value = usuario.Dni });



                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                mysqlConnection.Close();
            }
        }

        public static string SelectDB() {
            
            List<Usuario> usuarios = new List<Usuario>();
            string listadeUsuarios;
            try
            {
                mysqlConnection.Open();
                mysqlCommand.Parameters.Clear();
                var query = $"SELECT ID, Name,Age,User,Password,DNI FROM `proyecto-acsp`"; 
                           

                mysqlCommand.CommandText = query;

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))

                {
                    using (MySqlDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            while (reader.Read()) {
                                string name = reader.GetString("Name");
                                int age = reader.GetInt32("Age");
                                string user = reader.GetString("User");
                                string password = reader.GetString("Password");
                                int dni = reader.GetInt32("DNI");
                                Usuario person = new Usuario(name, age, user, password, dni);
                                usuarios.Add(person);
                            }
                        }
                       
                    
                    
                    
                    }
                    listadeUsuarios = JsonConvert.SerializeObject(usuarios);


                }
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                mysqlConnection.Close();
            }
            return listadeUsuarios;
        }
        public static void UpdateDatagrid( int dni,string user, string password)
        {
            try
            {
                mysqlConnection.Open();
                var query = $"UPDATE `proyecto-acsp` SET  User = '{user}', Password = '{password}'  WHERE DNI = '{dni}' ";

                mysqlCommand.CommandText = query;
                
                mysqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                mysqlConnection.Close();
            }


        }
        public static void Delete(string DNI)
        {

            try
            {
                mysqlConnection.Open();
                var query = $"DELETE FROM proyecto_sube WHERE Dni='{DNI}' ";

                mysqlCommand.CommandText = query;
                mysqlCommand.ExecuteNonQuery();


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                mysqlConnection.Close();
            }


        }
  

        

    }
}

