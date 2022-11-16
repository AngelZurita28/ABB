using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EDD_Tarea3
{
    class NodoABB
    {
        public int dato { get; set; }
        public NodoABB izquierdo { get; set; }
        public NodoABB derecho { get; set; }

        public NodoABB(int dato)
        {
            this.dato = dato;
            this.izquierdo = null;
            this.derecho = null;
        }
    }
}
