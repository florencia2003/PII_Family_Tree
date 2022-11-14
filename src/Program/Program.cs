using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Flor", 11);
            Persona p2 = new Persona("Fede", 10);
            Persona p3 = new Persona("Merce", 10);
            Persona p4 = new Persona("Alexis", 10);
            Persona p5 = new Persona("Nancy", 10);
            Persona p6 = new Persona("Santiago", 10);
            Persona p7 = new Persona("Isolina", 10);
            Persona p8 = new Persona("Ramiro", 10);


            Node n1 = new Node(p1);
            Node n2 = new Node(p2);
            Node n3 = new Node(p3);
            Node n4 = new Node(p4);
            Node n5 = new Node(p5);
            Node n6 = new Node(p6);
            Node n7 = new Node(p7);
            Node n8 = new Node(p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n8);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí

            Visitor VisitarEdad = new Visitor();
            n1.AceptarEdad(VisitarEdad);
            Console.WriteLine($"Suma edades: {VisitarEdad.edades}");

            Visitor VisitarMayor = new Visitor();
            n1.AceptarMayor(VisitarMayor);
            Console.WriteLine($"El mayor es: {VisitarMayor.mayor.Nombre}");

        }
    }
}
