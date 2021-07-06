using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSimple
{
    public partial class Form1 : Form
    {
        //Listas Simples E/C
        ListaSimpleEnlazada lse = new ListaSimpleEnlazada();
        LSECircular lsc = new LSECircular();
        //LDE N/C
        ListaDobleEnlazada lde = new ListaDobleEnlazada();        
        LDECircular ldc = new LDECircular();

        LDECabeza ldec = new LDECabeza();

        public Form1()
        {
            InitializeComponent();
        }



        //METODOS MOSTRAR----------------------------------
        //Simplemente Enlazada
        void MostrarLSE()
        {
            listView1.Clear();
            Nodo p;
            p = lse.primero;

            while (p != null)
            {
                listView1.Items.Add(p.Info.ToString());
                p = p.Enlace;
            }
        }
        //Simplemente Enlazada Circular
        void MostrarLSC()
        {
            listView1.Clear();
            Nodo p;
            p = lsc.primero;
            do
            {
                if (p != null)
                {
                    listView1.Items.Add(p.Info.ToString());
                    p = p.Enlace;
                }                
            } while (p != lsc.primero);
        }
        void MostrarLDC()
        {
            listView1.Clear();
            NodoDoble p;
            p = ldc.primero;
            do
            {
                if (p != null)
                {
                    listView1.Items.Add(p.Info.ToString());
                    p = p.EnlaceDer;

                }
                
            }while (p != ldc.primero);           
        }
        void MostrarLDE()
        {
            listView1.Clear();
            NodoDoble p;
            p = lde.primero;

            while(p!= null)
            {
                listView1.Items.Add(p.Info.ToString());
                p = p.EnlaceDer;
            }
        }
        void MostrarLDEC()
        {
            listView1.Clear();
            NodoDoble p;
            p = ldec.primero;

            while (p != null)
            {
                listView1.Items.Add(p.Info.ToString());
                p = p.EnlaceDer;
            }
        }
        private void btnInserDetrasD_Click(object sender, EventArgs e)
        {
            lde.insertar(Int32.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
            MostrarLDE();
        }

        private void btnInserAsc_Click(object sender, EventArgs e)
        {
            lse.inserOrdenadamenteAsc(Int32.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
            MostrarLSE();
        }

        private void btnInserAscD_Click(object sender, EventArgs e)
        {
            lde.InserOrdenadoAsc(Int32.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
            MostrarLDE();

        }

        private void btnEliminarD_Click(object sender, EventArgs e)
        {
            lde.eliminar(Int32.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
            MostrarLDE();
        }
        
        private void btnInserDetras_Click(object sender, EventArgs e)
        {
            lse.insertarDelante(Int32.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
            MostrarLSE();
        }

        private void btnContMul7_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Num Mult 7 = "+lde.contarMult7());
        }

        private void btnEliminarS_Click(object sender, EventArgs e)
        {
            lse.eliminarDato(Int32.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
            MostrarLSE();
        }


        

        private void btnInserDetrasDC_Click(object sender, EventArgs e)
        {
            ldc.insertar(Int32.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
            MostrarLDC();
        }

        private void btnEliminarDatoDC_Click(object sender, EventArgs e)
        {
            ldc.eliminarDato(Int32.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
            MostrarLDC();
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            lse.eliminar();
            
        }

       
        private void btnInserDelante_Click(object sender, EventArgs e)
        {
            lse.insertarDelante(Int32.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
            MostrarLSE();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInserDetrasSC_Click(object sender, EventArgs e)
        {
            lsc.insertarDetras(Int32.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
            MostrarLSC();
        }

        private void btnEliminarDatoSC_Click(object sender, EventArgs e)
        {
            lsc.eliminarDato(Int32.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
            MostrarLSC();
        }

        private void btnInserAscSC_Click(object sender, EventArgs e)
        {
            lsc.inserOrdenadamenteAsc(Int32.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
            MostrarLSC();
        }

        private void btnInserNC_Click(object sender, EventArgs e)
        {
            ldec.insertar(Int32.Parse(txtDato.Text));
            txtDato.Text = "";
            txtDato.Focus();
            MostrarLDEC();
        }
    }
   
}
