﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg_Lista_clases_2020.Clases
{
    public class ListaPersonas
    {
        public Persona[] personas { get; set; }  /*Propiedad de la persona*/

        private void Redimensionar() /*Método Redimensionar*/
        {
            if (personas == null)
            {

                personas = new Persona[1];

            }
            else
            {

                Persona[] ArregloAuxiliar = new Persona[personas.Length + 1];

                for (int contador = 0; contador < personas.Length; contador++)
                {
                    ArregloAuxiliar[contador] = personas[contador];
                }

                personas = ArregloAuxiliar;

            }
        }

        public bool AddPersona(string Nombre, string Año)
        {

            Persona persona = new Persona();

            persona.Nombre = Nombre;


            persona.AñoNacimiento = Convert.ToInt32(Año);

            bool resp = persona.Validar();

            if (resp)
            {

                Redimensionar(); /* Este método se utiliza para agregar cierta cantidad 
                                  * de elementos establecidos por el usuario */
               
                personas[personas.Length - 1] = persona;

            }
            return resp;


        }
        
        public string ToStringFiltrado(int añoMinimo)
        {
            string Resp = "";

            Resp = "Lista: \r\n";

            foreach (Persona elemento in personas)
            {

                if (elemento.AñoNacimiento >= añoMinimo)
                {
                
                    Resp = Resp + elemento.AñoNacimiento.ToString() + " - " + elemento.Nombre + "\r\n";

                }
            }

            return Resp;

            //Lblista.Text = "Lista: \r\n";
            //foreach (Persona elemento in Lista.personas)
            //{
            //    Lblista.Text = Lblista.Text + elemento.AñoNacimiento + " - " + elemento.Nombre + "\r\n";
            //}

        }

    }



}





