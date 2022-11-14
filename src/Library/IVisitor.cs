using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public interface IVisitor
    {
        public void VisitarEdad(Node node);
        public void VisitarMayor(Node node);
    }
}