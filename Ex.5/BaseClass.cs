using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5
{
    internal class BaseClass
    {
        private string _name;
        private string _lastName;

        public BaseClass(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }

        public virtual void ShowField()
        {
            Console.WriteLine($"Имя - {_name}\nФамилия - {_lastName}");
        }
    }
}
