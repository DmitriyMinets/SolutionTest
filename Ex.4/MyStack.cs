using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._4
{
    internal class MyStack
    {
        private int[] _items;

        private int counter;


        public MyStack(int lenghtArray = 4)
        {
            _items = new int[lenghtArray];
        }

        private bool IsEmpty()
        {
            return counter == 0;
        }

        public void Push(int item)
        {
            if (counter >= _items.Length)
                Array.Resize(ref _items, _items.Length * 2);
            _items[counter] = item;
            counter++;
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Стек пуст");
            counter--;
            int result = _items[counter];
            _items[counter] = default;
            return result;
        }

    }
}
