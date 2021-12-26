﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Operadores
{
    public partial class Calculadora : Form
    {


        public Calculadora()
        {
            InitializeComponent();
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void BtnSuma_Click_1(object sender, EventArgs e)
        {

            decimal Numero1;
            decimal Numero2;
            decimal Resultado;

            try
            {
                Numero1 = Convert.ToDecimal(TxtSum1.Text);
                Numero2 = Convert.ToDecimal(TxtSum2.Text);

                Resultado = Numero1 + Numero2;

                LblResSuma.Text = (Resultado).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar dos numeros para sumar");
            }
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            decimal Numero1;
            decimal Numero2;
            decimal Resultado;

            try
            {
                Numero1 = Convert.ToDecimal(TxtRes1.Text);
                Numero2 = Convert.ToDecimal(TxtRes2.Text);

                Resultado = Numero1 - Numero2;

                LblResResta.Text = (Resultado).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar dos numeros para restar");
            }
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            decimal Numero1;
            decimal Numero2;
            decimal Resultado;

            try
            {
                Numero1 = Convert.ToDecimal(TxtMult1.Text);
                Numero2 = Convert.ToDecimal(TxtMult2.Text);

                Resultado = Numero1 * Numero2;

                LblResMult.Text = (Resultado).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar dos numeros para multiplicar");
            }


        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            decimal Numero1;
            decimal Numero2;
            decimal Resultado;

            try
            {

                Numero1 = Convert.ToDecimal(TxtDiv1.Text);
                Numero2 = Convert.ToDecimal(TxtDiv2.Text);

                Resultado = Numero1 / Numero2;

                LblResDiv.Text = (Resultado).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar dos numeros para Dividir");
            }
        }


                
    }
}
               



               



                





        

            


            
            
