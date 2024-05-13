using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsTestACS
{
    public abstract class Person
    {
        private string _name;
        private int _age;
        private int _dni;

        protected Person(string name, int age, int dni)
        {
            _name = name;
            _age = age;
            _dni = dni;
        }

        public string Name { 
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

    }
}
