using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Visitor : IVisitor
    {

        public int edades { get; set; }
        public Persona mayor {get; set; }

        public void VisitarEdad (Node node)
        {
            foreach (Node nodo in node.Children)
            {
                this.edades = this.edades + nodo.Persona.Edad;
                nodo.AceptarEdad(this);
            }
        }

        public void VisitarMayor (Node node)
        {
            foreach (Node nodo in node.Children)
            {
                if (nodo.Persona.Edad > this.mayor.Edad)
                {
                    this.mayor = nodo.Persona;
                }

                nodo.AceptarMayor(this);
            }
        }

        
    }
}