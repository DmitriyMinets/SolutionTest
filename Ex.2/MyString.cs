using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2
{
    internal class MyString
    {
        private string _value;

        public MyString()
        {
        }

        public MyString(string value)
        {
            _value = value;
        }

        public void Revers()
        {
            for(int i = 1; i < _value.Length + 1; i++)
            {
                Console.Write(_value[^i]);
            }
        }
    }
}
