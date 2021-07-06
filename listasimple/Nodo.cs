using System;
using System.Collections.Generic;
using System.Text;

namespace ListaSimple
{
    class Nodo
    {
        private int info;
        private Nodo enlace;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        public Nodo Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }
    }
}
