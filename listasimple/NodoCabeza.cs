using System;
using System.Collections.Generic;
using System.Text;

namespace ListaSimple
{
    class NodoCabeza
    {
        public int cantElementos;
        NodoDoble enlace;

        public int CantElementos
        {
            get { return cantElementos; }
            set { cantElementos = value; }
        }

        public NodoDoble Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }
    }
}
