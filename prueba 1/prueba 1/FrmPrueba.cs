﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_1
{
    public partial class FormInicial : Form
    {

       
        string PrimerVariable = "Leandro";

        public FormInicial()
        {
            string SegundaVarible = "¿Que tal?";
            InitializeComponent();
            label1.Text = "Hola" + " " + PrimerVariable + " " + SegundaVarible ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string TercerVariable = "¿Como te va?";

            label1.Text = "Hola" + PrimerVariable + TercerVariable; //+ SegundaVariable ;(No se puede usar en este ambito por la vida de las variables)
        }
    } 
}
       


        

       

       

       