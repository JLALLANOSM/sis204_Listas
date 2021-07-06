using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ListaSimple
{
    //listas simplemente enelazada y circular 
    class ListaSimpleEnlazada
    {
        public Nodo primero = null;
        public Nodo ultimo = null;
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
        //metodo insertar por delante 
        public void insertarDelante(int info)
        {
            Nodo p; //creamos una variable de tipo nodo 
            p = new Nodo(); //creamos un nuevo nodo y asignams a p
            p.Info = info;  
            p.Enlace = null;
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
            }
        }

        //metodo o funcion para insertar por dentras de la lista
        public void insertarDetras(int info)
        {
            Nodo p;
            p = new Nodo();
            p.Info = info;
            p.Enlace = null;

            if (vacia())
            {
                primero = p;
                ultimo = p;
            }
            else
            {
                ultimo.Enlace = p;
                ultimo = p;
            }
        
        }
        //metodo para insertar ordenadamente  
        public void inserOrdenadamenteAsc(int info)
        {
            Nodo p, q, s;

            p = new Nodo();
            p.Info = info;
            p.Enlace = null;
            if (vacia())
            {
                primero = p;
                ultimo = p;
            }
            else
            {
                q = primero;
                s = primero;
                while((q != null) && (q.Info < info))
                {
                    s = q;
                    q = q.Enlace;
                }
                if(q == primero)
                {
                    p.Enlace = primero;
                    primero = p;
                }
                else
                {
                    s.Enlace = p;
                    p.Enlace = q;
                    if (q == null)
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
        public void eliminarDato(int x)
        {
            Nodo p, q;
            if (vacia())
            {
                MessageBox.Show("La lista esta vacía!!");
            }
            else
            {
                q = primero;
                p = primero;
                while ((p != null) && (p.Info != x))
                    p = p.Enlace;

                if (p == null)
                {
                    MessageBox.Show("Valor a eliminar no encontrado");
                    return;
                }
                else
                {
                    if (p.Info == x)
                    {
                        MessageBox.Show("Valor a eliminar encontrado: "+p.Info);
                        q.Enlace = p.Enlace;
                        
                        if (p == primero)
                            primero = p.Enlace;
                        else
                        if (p == ultimo)
                            ultimo = q;
                        return;
                    }
                }
                
            }
        } 
    }
}

