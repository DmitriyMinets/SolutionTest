using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5
{
    internal class DerivedClass : BaseClass
    {
        private int _age;
        public DerivedClass(string name, string lastName, int age) 
            : base(name, lastName)
        {
            _age = age;
        }

        public override void ShowField()
        {
            base.ShowField();
            Console.WriteLine($"Возраст - {_age}");
        }
    }
}
