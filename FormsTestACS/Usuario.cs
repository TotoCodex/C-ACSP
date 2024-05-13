using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FormsTestACS
{
    public class Usuario : Person

    {
        
        private string _user;
        private string _password;
       

        public Usuario( string name, int age, string user, string password, int dni):base( name, age, dni) //cada vez que instancie el objeto Usuario le voy a pasar los valores que paso isntanciando por acá 
        {
            
            
            _user = user;
            _password = password;
            
        }
        public string User
        {
            get { return _user; }
            set { _user = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public List<Usuario> listadeUsuarios(Usuario usuario) {
            List<Usuario> listaUsuarios = new List<Usuario>();


            listaUsuarios.Add(usuario);
            return listaUsuarios;
        }
        public void SerializarJson(List<Usuario>lista) {

            string json = JsonConvert.SerializeObject(lista);
            Console.WriteLine(json);
        }
    }
}




