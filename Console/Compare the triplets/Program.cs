using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace Compare_the_triplets
{
class Program
{

    // Complete the compareTriplets function below.
    static List<int> compareTriplet(List<int> a, List<int> b)
    {
            List<int> m = new List<int>();
            int h = 0, y = 0;
            for (int x = 0; x < a.Count; x++)
            {
                if (a[x] > b[x])
                {
                    h++;
                }
                else if (a[x] < b[x])
                {
                    y++;
                }
            }
            m.Add(h);
            m.Add(y);
            return m;

        }

        static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplet(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

}


