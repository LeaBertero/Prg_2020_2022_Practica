﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFor
{
    public partial class FrmClave : Form
    {
        string contraseña = "Hola";

        public FrmClave()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtClave.Text != contraseña)
            {
                if (TxtClave.Text != contraseña)
                {
                    MessageBox.Show("clave incorrecta");
                    TxtClave.Clear();
                    TxtClave.Focus();
                    return;
                }
                else
                {
                    TxtClave.Clear();
                    EjemploFor EjemploFor = new EjemploFor();
                    EjemploFor.ShowDialog();

                }
            }
        }
    }
}