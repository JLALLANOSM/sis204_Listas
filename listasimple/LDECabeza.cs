using System;
using System.Collections.Generic;
using System.Text;

namespace ListaSimple
{
    class LDECabeza
    {
        public NodoCabeza cabeza;
        public NodoDoble primero;
        public NodoDoble ultimo;

        private bool vacia()
        {
            if(cabeza == null)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
        void crearCabeza()
        {
            cabeza = new NodoCabeza();
            cabeza.cantElementos = 0;
            cabeza.Enlace = null;
        }

        public void insertar(int info)
        {
            NodoDoble p;

            if (vacia())
            {
                crearCabeza();
                primero = new NodoDoble();
                primero.Info = info;
                primero.EnlaceDer = null;
                primero.EnlaceIzq = null;
                ultimo = primero;
                cabeza.cantElementos++;
                cabeza.Enlace = primero;
            }
            else
            {
                p = new NodoDoble();
                p.Info = info;
                p.EnlaceDer = null;
                p.EnlaceIzq = ultimo;
                ultimo.EnlaceDer = p;
                ultimo = p;
                cabeza.cantElementos++;
            }
        }
    }
}
