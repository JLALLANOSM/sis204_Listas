using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSimple
{
    class LSECircular
    {
        public Nodo primero = null;
        public Nodo ultimo = null;

        public bool vacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }
        public void insertarDelante(int info)
        {
            Nodo p; //creamos una variable de tipo nodo 
            p = new Nodo(); //creamos un nuevo nodo y asignams a p
            p.Info = info;
            p.Enlace = p;
            //preguntamos si lse esta vacia 
            if (vacia())
            {
                //-> si, primero y ultimo son lo mismo 
                primero = p;
                ultimo = p;
            }
            else
            {

                p.Enlace = primero; //p apunta a primero  
                primero = p;//primero toma el valor de p
                ultimo.Enlace = p;
            }
        }

        //metodo o funcion para insertar por dentras de la lista
        public void insertarDetras(int info)
        {
            Nodo p;
            p = new Nodo();
            p.Info = info;
            p.Enlace = p;

            if (vacia())
            {
                primero = p;
                ultimo = p;
            }
            else
            {
                ultimo.Enlace = p;
                ultimo = p;
                ultimo.Enlace = primero;
                
            }

        }
        //metodo para insertar ordenadamente  
        public void inserOrdenadamenteAsc(int info)
        {
            Nodo p, q, s;
            bool terminar;

            p = new Nodo();
            p.Info = info;
            p.Enlace = p;
            if (vacia())
            {
                primero = p;
                ultimo = p;
            }
            else
            {
                q = primero;
                s = primero;
                terminar = false;
                do
                {
                    if(q.Info < info)
                    {
                        terminar = true;
                    }
                    else
                    {
                        s = q;
                        q = q.Enlace;
                    }
                } while ((q != primero) && (!terminar));

                
                if (q == s)
                {
                    p.Enlace = q;
                    ultimo.Enlace = p;
                    primero = p;
                }
                else
                {
                    s.Enlace = p;
                    p.Enlace = q;
                    if (q == primero)
                    {
                        ultimo = p;
                    }
                }    
            }

        }

        //eliminar toda la lista
        public void eliminar()
        {
            if (vacia())
            {
                MessageBox.Show("Lista Vacia...");
            }
            else
            {
                primero = null;
                ultimo = null;

            }
        }

        //metodo eliminar un dato especifico 
        public void eliminarDato(int info)
        {
            Nodo p, q;
            bool terminar;

            if (vacia())
            {
                MessageBox.Show("La lista esta vacía!!");
            }
            else
            {
                q = primero;
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
                        p = p.Enlace;
                    }
                } while ((p != primero) && (!terminar));
                

                if (p.Info == info)
                {
                    if (primero == ultimo)
                    {
                        primero = null;
                        return;
                    }
                       

                    if (p == primero)
                    {
                        primero = primero.Enlace;
                        ultimo.Enlace = primero;
                    }
                    else if (p == ultimo)
                    {
                            q.Enlace = p.Enlace;
                            ultimo = q;
                    }
                    else
                    {
                        q.Enlace = p.Enlace;
                    }
                }
                else
                {
                    MessageBox.Show("Valor a eliminar no encontrado");
                        
                }             

            }
            return;
        }
    }       
}
