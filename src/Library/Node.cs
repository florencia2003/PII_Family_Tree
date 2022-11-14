using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;
        public Persona Persona;

        private List<Node> children = new List<Node>();

        public ReadOnlyCollection<Node> Children 
        { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Persona persona)
        {
            this.Persona = persona;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void AceptarEdad (Visitor visitor)
        {
            visitor.VisitarEdad(this);
        }

        public void AceptarMayor (Visitor visitor)
        {
            visitor.VisitarMayor(this);
        }



    }
        
    
}
