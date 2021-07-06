using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ListaSimple
{
    class ListaDobleEnlazada
    {
        public NodoDoble primero;
        public NodoDoble ultimo;

        //Metodos
        private bool vacia()
        {
            if(primero == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        
        public void insertar(int x)
        {
            NodoDoble p;
            if (vacia())
            {
                primero = new NodoDoble();
                primero.Info = x;
                primero.EnlaceDer= null;
                primero.EnlaceIzq = null;
                ultimo = primero;
            }
            else
            {
                p = new NodoDoble();
                p.Info = x;
                p.EnlaceDer = null;
                p.EnlaceIzq = ultimo;
                ultimo.EnlaceDer = p;
                ultimo = p;             
            }
        }
        public int contarMult7()
        {
            int cont = 0;
            NodoDoble p ;
            p = primero;
            while (p != null)
            {
                p = p.EnlaceDer;
                //p.Info;
                if(p == null)
                {
                    return cont;
                }
                else
                {
                    if ((p.Info) % 7 == 0)
                    {
                        cont++;
                    }
                }
                /**/
            }
            return cont;
            //MessageBox.Show("Num Mult 7 = "+cont);
        }

        public void eliminar(int x)
        {
            NodoDoble p, q, r;
            if (vacia())
                MessageBox.Show("La lista esta vacía!!");
            else
            {
                p = primero;
                while (p != null && p.Info != x)
                    p = p.EnlaceDer;

                if (p == null)
                    MessageBox.Show("El elemento no existe ");
                else
                {
                    if (p == primero)
                    {
                        MessageBox.Show("El elemento a Eliminar es: " + p.Info);
                        if (primero.EnlaceDer != null)
                        {
                            primero = primero.EnlaceDer;
                            primero.EnlaceIzq = null;
                        }
                        else
                        {
                            primero = null;
                        }
                        p.EnlaceDer = null;
                        p.EnlaceIzq = null;
                        p = null;
                    }
                    else
                    {
                        MessageBox.Show("El elemento encontrado es: " + p.Info);
                        q = p.EnlaceDer;
                        r = p.EnlaceIzq;
                        if (q != null)
                        {
                            r.EnlaceDer = q;
                            q.EnlaceIzq = r;
                        }
                        else
                        {
                            r.EnlaceDer = null;
                        }
                        p.EnlaceDer = null;
                        p.EnlaceIzq = null;
                        p = null;
                    }
                }
            }
        }

        //Insertar Ordenado
        public void InserOrdenadoAsc(int x)
        {
            NodoDoble p, q, r;
            if (vacia())
            {
                primero = new NodoDoble();
                primero.Info = x;
                primero.EnlaceDer = null;
                primero.EnlaceIzq = null;
            }
            else
            {
                if(x < primero.Info)
                {
                    p = new NodoDoble();
                    p.Info = x;
                    p.EnlaceDer = null;
                    p.EnlaceIzq = primero;
                    primero.EnlaceIzq = p;
                    primero = p;
                }
                else
                {
                    r = primero;
                    q = primero.EnlaceDer;
                    while( q != null && x > q.Info)
                    {
                        r = q;
                        q = q.EnlaceDer;
                    }
                    if(q == null)
                    {
                        p = new NodoDoble();
                        p.Info = x;
                        p.EnlaceDer = null;
                        p.EnlaceIzq = r;
                        r.EnlaceDer = p;
                        ultimo = p;
                    }
                    else
                    {
                        p = new NodoDoble();
                        p.Info = x;
                        r.EnlaceDer = p;
                        p.EnlaceIzq = r;
                        p.EnlaceDer = q;
                        q.EnlaceIzq = p;
                    }
                }
            }
        }
    }
}
