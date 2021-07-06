using System;
using System.Collections.Generic;
using System.Text;

namespace ListaSimple
{
    class NodoDoble
    {
        private int info;
        private NodoDoble enlaceIzq;
        private NodoDoble enlaceDer;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        public NodoDoble EnlaceIzq
        {
            get { return enlaceIzq; }
            set { enlaceIzq = value; }
        }
        public NodoDoble EnlaceDer
        {
            get { return enlaceDer; }
            set { enlaceDer = value; }
        }
    }
}
