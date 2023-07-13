using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyList<T>
    {
        T[] _array;
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            T[] _temparray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _temparray.Length; i++)
            {
                _array[i] = _temparray[i];
            }
            _array[_array.Length - 1] = item;
        }
    }
   

}
