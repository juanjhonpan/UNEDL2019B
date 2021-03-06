﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final_Taller
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnEdicion_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            dtmEjecucion.Enabled = true;
            dtnNacimiento.Enabled = true;
            txtCantidad.Enabled = true;
            txtSaldo.Enabled = true;
            rbConsulta.Enabled = true;
            rbDeposito.Enabled = true;
            rbFemenino.Enabled = true;
            rbMasculino.Enabled = true;
            rbOtro.Enabled = true;
            rbRetiro.Enabled = true;
            rtbDireccion.Enabled = true;
            btnCancelar.Enabled = true;
            btnEjecutar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            dtmEjecucion.Enabled = false;
            dtnNacimiento.Enabled = false;
            txtCantidad.Enabled = false;
            txtSaldo.Enabled = false;
            rbConsulta.Enabled = false;
            rbDeposito.Enabled = false;
            rbFemenino.Enabled = false;
            rbMasculino.Enabled = false;
            rbOtro.Enabled = false;
            rbRetiro.Enabled = false;
            rtbDireccion.Enabled = false;
            btnCancelar.Enabled = false;
            btnEjecutar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            String Nombre = txtNombre.Text;
            String Apellido = txtApellido.Text;
            String FN = dtnNacimiento.Text;
            String Direccion = rtbDireccion.Text;
            String Sexo = "";
            if (rbFemenino.Checked == true)
            {
                Sexo = "Femenino";
            }
            else if (rbMasculino.Checked == true)
            {
                Sexo = "Masculino";
            }
            else if (rbOtro.Checked == true)
            {
                Sexo = "Otro";
            }

            String Cantidad = txtCantidad.Text;
            String Movimiento = "";
            if (rbDeposito.Checked == true)
            {
                Movimiento = "Deposito";
            }
            else if (rbRetiro.Checked == true)
            {
                Movimiento = "Retiro";
            }
            else if (rbConsulta.Checked == true)
            {
                Movimiento = "Consulta";
            }





            String registro = Nombre + "," + Apellido + "," + FN + "," + Direccion + "," + Sexo + "," + Cantidad + "," + Movimiento;

            StreamWriter Escribir = new StreamWriter(@"C:\Users\badop\UNEDL2019B\Console\Examen_final_Taller\Registro.txt");
            try
            {
                Escribir.WriteLine(registro);
            }
            catch
            {
                MessageBox.Show("error");

            }
            Escribir.Close();
        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemenino.Checked == true)
            {
                rbMasculino.Checked = false;
                rbOtro.Checked = false;
            }
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMasculino.Checked == true)
            {
                rbFemenino.Checked = false;
                rbOtro.Checked = false;
            }
        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOtro.Checked == true)
            {
                rbFemenino.Checked = false;
                rbMasculino.Checked = false;
            }
        }

        private void rbDeposito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDeposito.Checked == true)
            {
                rbConsulta.Checked = false;
                rbRetiro.Checked = false;
            }
        }

        private void rbRetiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRetiro.Checked == true)
            {
                rbConsulta.Checked = false;
                rbDeposito.Checked = false;
            }
        }

        private void rbConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConsulta.Checked == true)
            {
                rbRetiro.Checked = false;
                rbDeposito.Checked = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtCantidad.Text = "";
            txtNombre.Text = "";
            txtSaldo.Text = "";
            rbConsulta.Checked = false;
            rbDeposito.Checked = false;
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbOtro.Checked = false;
            rbRetiro.Checked = false;
            rtbDireccion.Text = "";
        }
    }
}
