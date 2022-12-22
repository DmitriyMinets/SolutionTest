using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5
{
    internal class DerivedClassTwo : DerivedClass
    {
        private int _id;
        public DerivedClassTwo(string name, string lastName, int age,int id) 
            : base(name, lastName, age)
        {
            _id = id;
        }

        public override void ShowField()
        {
            base.ShowField();
            Console.WriteLine($"Идентификационный номер - {_id}");
        }
    }
}
