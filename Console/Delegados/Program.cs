using System;

public delegate int delegado(int[] x);

namespace Delegados
{
    class Program
    {
        static int suma;
        static int promedio;
        static int Mayor;
        //este es una suma
        public static int Suma(int[] Num) 
        {
            for (int x = 0; x < 5; x++)
            {
                suma = suma+Num[x];
            }
            return suma;
        }
        //este es una Promedio
        public static int Promedio(int[] Num)
        {
            for (int x = 0; x < 5; x++)
            {
                promedio = promedio+Num[x];
            }
            promedio = promedio / 5;
            return promedio;
        }
        public static int NumMayor(int[] Num) //NÚMERO MAYOR
        {
            Array.Sort(Num);
            Mayor = Num[4];
            return Mayor;
        }
        public static int GetSuma()
        {
            return suma;
        }
        public static int GetPromedio()
        {
            return promedio;
        }
        public static int GetNumMayor()
        {
            return Mayor;
        }
        static void Main(string[] args)
        {
            delegado Pd = new delegado(Suma);
            delegado Sd = new delegado(Promedio);
            delegado Td = new delegado(NumMayor);

            int[] Numeros = new int[5];
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Dame el "+(x+1)+" numero entero: ");
                Numeros[x] = int.Parse(Console.ReadLine());
            }
            Pd(Numeros);
            Sd(Numeros);
            Td(Numeros);
            Console.WriteLine("La sumatoria total de los numeros es de:" + GetSuma());
            Console.WriteLine("El promedio de los cinco numeros es:" + GetPromedio());
            Console.WriteLine("El numero mayor de los cinco numeros es:" + GetNumMayor());
        }
    }
}
