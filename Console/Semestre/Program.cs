using System;

namespace Semestre
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the array of two elements.
            int[][] arr = new int[8][];
            string alumno="";

            // Initialize the elements.
            for(int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("cuantos alumnos tiene el "+(i+1)+" semestre: ");
                alumno = Console.ReadLine();
                arr[i] = new int[Convert.ToInt32(alumno)];
            }
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < arr[i].GetLength(0);j++)
                {
                    Console.WriteLine("dame la calificacion de "+(i+1)+" del "+(j+1)+" alumno: ");
                    alumno = Console.ReadLine();
                    arr[i][j] = Convert.ToInt32(alumno);
                }
            }
            // Display the array elements.
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Semestre({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("el alumno "+(j+1)+" su calificacion es de: {0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
