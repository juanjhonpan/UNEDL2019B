using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace collections
{
    class MasArrays
    {
        public void Sorted()
        {
            SortedList sl = new SortedList();
            sl.Add(1, "valor 1");
            sl.Add(2, "valor 5");
            sl.Add(3, "valor 3");
            ICollection llaves = sl.Keys;
            foreach(var k in llaves)
            {
                Console.WriteLine("llave: "+k +"valor: "+sl[k]);
            }
        }
    }
}
