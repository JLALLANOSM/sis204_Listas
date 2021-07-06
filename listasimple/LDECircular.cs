using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSimple
{
    class LDECircular
    {
        public NodoDoble primero;
        public NodoDoble ultimo;

        //Metodos
        private bool vacia()
        {
            if (primero == null)
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
                primero.EnlaceDer = primero;
                primero.EnlaceIzq = primero;
                ultimo = primero;
            }
            else
            {
                p = new NodoDoble();
                p.Info = x;
                p.EnlaceDer = primero;
                p.EnlaceIzq = ultimo;
                ultimo.EnlaceDer = p;
                ultimo = p;
                primero.EnlaceIzq = ultimo;
            }
        }
        public int contarMult7()
        {
            int cont = 0;
            NodoDoble p;
            p = primero;
            while (p != null)
            {
                p = p.EnlaceDer;
                //p.Info;
                if (p == null)
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

        public void eliminarDato(int info)
        {
            NodoDoble p, q, r;
            bool terminar;
            if (vacia())
                MessageBox.Show("La lista esta vacía!!");
            else
            {
                p = primero;
                terminar = false;
                do
                {
                    if (p.Info == info)
                    {
                        terminar = true;
                    }
                    else
                    {
                        q = p;
                        p = p.EnlaceDer;
                    }

                } while ((p != primero) && (!terminar));
                

                if (p == null)
                    MessageBox.Show("El elemento no existe ");
                else
                {
                    if (p == primero)
                    {
                        MessageBox.Show("El elemento a Eliminar es: " + p.Info);
                        MessageBox.Show("El elemento a Eliminar es: " + p.EnlaceDer);
                        if (primero.EnlaceDer != p)//duda...............
                        {
                            primero = primero.EnlaceDer;
                            primero.EnlaceIzq = ultimo;
                        }
                        else
                        {
                            primero = p;
                            primero = null;
                            return;
                            
                        }
                        /*p.EnlaceDer = primero;
                        p.EnlaceIzq = primero;
                        p = primero;*/
                    }
                    else
                    {
                        MessageBox.Show("El elemento encontrado es: " + p.Info);
                        q = p.EnlaceDer;
                        r = p.EnlaceIzq;
                        if (q != primero)
                        {
                            r.EnlaceDer = q;
                            q.EnlaceIzq = r;
                        }
                        else
                        {
                            r.EnlaceDer = primero;
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
                if (x < primero.Info)
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
                    while (q != null && x > q.Info)
                    {
                        r = q;
                        q = q.EnlaceDer;
                    }
                    if (q == null)
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
        
        
        public bool Vacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void insertarDelante(int x)
        {
            NodoDoble p;
            if(Vacia())
            {
                primero = new NodoDoble();
                primero.Info = x;
                primero.EnlaceDer = primero;
                primero.EnlaceIzq = null;
                ultimo = primero;
            }
            else
            {
                p = new NodoDoble();
                p.Info = x;
                p.EnlaceDer = primero;
                p.EnlaceIzq = ultimo;
                ultimo.EnlaceDer = p;
                ultimo = p;
                primero.EnlaceIzq = ultimo;
            }
        }

        public void eliminar(int x)
        {
            NodoDoble p, q, r;
            if (Vacia())
                MessageBox.Show("La lista esta vacía, no se puede eliminar el elemento");
            else
            {
                p = primero;
                while (p != null && p.Info != x)
                    p = p.EnlaceDer;

                if (p == null)
                    MessageBox.Show("El elemento no existe en la lista");
                else
                {
                    if (p == primero)
                    {
                        MessageBox.Show("El elemento encontrado es: " + p.Info);
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
                            q.EnlaceIzq = r;
                            r.EnlaceDer = q;
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
    }
}
