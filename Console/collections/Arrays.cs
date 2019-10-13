using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    class Arrays
    {
        public void Arreglo1()
        {
            ArrayList al = new ArrayList();
            al.Add(null);
            al.Add("String");
            al.Add(1);
            al.Add(null);
            al.Add("String");
            al.Add(1);
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
        }
    }
}
