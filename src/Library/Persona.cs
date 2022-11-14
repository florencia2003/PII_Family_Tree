using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona
    {

        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = Edad; 
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }

    }
}