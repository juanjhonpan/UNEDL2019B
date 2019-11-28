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

namespace TVP2doParcial
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        public Result(ArrayList Lista)
        {
            int contP=0;
            for(int i=0; i < Lista.Count;i++)
            {
                contP++;
            }
            string p = contP.ToString();

            InitializeComponent();
            lblPT.Text = "La cantidad total de palabras es de: "+p;
            ArrayList palabrasRepetidas = new ArrayList();
            string comprobar = "";
            String[] List = new string[Lista.Count];
            
            for(int i = 0; i < Lista.Count; i++)
            {
                List[i] = Lista[i].ToString();
            }

           
            int contPR=0;
            Boolean repetido = false;
            for (int i = 0; i < Lista.Count;i++) 
            {
                contPR = 0; 
                repetido = false; 
                comprobar = List[i];
                for(int j = i+1; j<List.Length ; j++)
                {
                    if (comprobar.Equals(List[j])) 
                    {
                        contPR++; 
                        List[j] = "";
                        repetido = true;
                    }

                }

                if (comprobar != "")
                {
                    if (repetido == true)
                    {
                        lbPR.Items.Add(" La palabra " + List[i] + " se repite: " + contPR.ToString() + " veces");

                    }
                }

            }

        }

        private void Result_Load(object sender, EventArgs e)
        {

        }

        private void lbPR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPR_Click(object sender, EventArgs e)
        {

        }

        private void lblPT_Click(object sender, EventArgs e)
        {

        }
    }
}
