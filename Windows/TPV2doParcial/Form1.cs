using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
1. Describa en sus propias palabras el concepto de colecciones (collections) y cuales tipos existen.
R= este puede manejar varios valores de diferentes series, y hay dos tipos los cuales son generic collections y non-generic collections
2.Defina a que se refiere el concepto de código no seguro y que se necesita para implementarlo.
R=a que se va a manejar fuera del control del recolector de basura y se necesita los apuntadores para usarse-
3.Mencione al menos tres clases que se utilizan en l/o y proporcione brevemente la idea central de las mismas.

4. Explique la diferencia entre los siguientes códigos en csharp
a. Console. Writeline ("resultado: (*ptr) ");
b. Console.WriteLine("resultado: ((int)ptr)");
R= en el cual en uno se esta casteando solo en lo que son los valores reales y el otro es mas global
5.Mencione al menos tres caracteristicas de las excepciones (Exceptions).
R=1 en que en una aplicacion tiene que anticipar
2 en que un error por parte del exterior no se puede anticipar
3 y en que el tiempo es mas dificil anticiparces 
6.En Java, mencione y describa los tres tipos de excepciones.
R= el primero seria java.io.FileNotFoundException
el segundo seria java.io.IOError
y el tercero NullPointerException
7. Explique brevemente a que se refiere con directivas para preprocesador y que se necesita para usarlas.
R= es el que le da las instrucciones al compilador para que este pueda procesar antes de este empieze con su propia compilacion.
8. Explique las diferencias entre ArrayList, Sorted List Hash Table.
R=el Arraylist puede almacenar cualquier tipo de dato y no se define el tamaño
en el sorted list este acomoda los datos automaticamente de manera ascendete
y en el hast table recupera los valores utilizados por las llaves.
9. Describa las para que sirven StreamReader y StreamWriter
R= estos funcionan para poder que la escritura y la lectura puedan volver en bytes de caracteres.
10. Explique el funcionamiento del algoritmo Quicksort
R= este va a dividir en 2 la estrutura y este ordena cada mitad recursivamente.
11. En Java, explique cuál es la diferencia entre System.out, System.in y System.err
R= la primera es para tener una salida estandar, el segundo sirve para tener una entrada estandar, y el tercero tener un error estandar
12. Explique cuáles son las ventajas de utilizar "generic collections"
R= en que este puede almacenar cualquier tipo de elemento, y este se impacta el rendimiento en su uso.
13 Desarrolle en C#, un programa en Windows Forms llamado TPV2doParcial que permita crear un
archivo, lo lea y permita escribir en el. El programa debe permitir la captura de una lista de palabras
y al finalizar la captura, debe reportar la cantidad total de palabras, las palabras repetidas y la
cantidad de ocurrencias. Capture las excepciones necesarias. Al terminar, suba su codigo a su
repositorio y escriba el SHA correspondiente en el examen
 */

namespace TPV2doParcial
{

    public partial class Form1 : Form
    {
        ArrayList Lista = new ArrayList();
        ArrayList Lista2 = new ArrayList();
        int u=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cadena ;
            cadena = boxName.Text;
            for (int l = 0; l < Lista.Count; l++)
            {
                if (Lista.Contains(cadena))
                {
                    u = u + 1;
                    Lista2.Add(cadena);
                    MessageBox.Show("caca");
                    break;
                }
            }
            Lista.Add(cadena);
            MessageBox.Show("agregado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nenas "+Lista.IndexOf(0));
            int m = 0;
            m = Lista.Count - u;
            label2.Text = "estas son la cantidad de palabras totales: " + Lista.Count;
            label1.Text = "estas son las palabras totales repetidas: "+u;
            label3.Text = "estas son las palabras ocurrentes: " + m;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
