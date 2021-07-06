
namespace ListaSimple
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInserDetras = new System.Windows.Forms.Button();
            this.btnEliminarS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInserAsc = new System.Windows.Forms.Button();
            this.btnInserAscD = new System.Windows.Forms.Button();
            this.btnEliminarD = new System.Windows.Forms.Button();
            this.btnInserDetrasD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnContMul7 = new System.Windows.Forms.Button();
            this.btnInserDetrasDC = new System.Windows.Forms.Button();
            this.btnEliminarDatoDC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.btnInserDelante = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInserAscSC = new System.Windows.Forms.Button();
            this.btnEliminarDatoSC = new System.Windows.Forms.Button();
            this.btnInserDetrasSC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnInserNC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInserDetras
            // 
            this.btnInserDetras.Location = new System.Drawing.Point(29, 62);
            this.btnInserDetras.Name = "btnInserDetras";
            this.btnInserDetras.Size = new System.Drawing.Size(142, 23);
            this.btnInserDetras.TabIndex = 0;
            this.btnInserDetras.Text = "Insertar Por Detras";
            this.btnInserDetras.UseVisualStyleBackColor = true;
            this.btnInserDetras.Click += new System.EventHandler(this.btnInserDetras_Click);
            // 
            // btnEliminarS
            // 
            this.btnEliminarS.Location = new System.Drawing.Point(29, 120);
            this.btnEliminarS.Name = "btnEliminarS";
            this.btnEliminarS.Size = new System.Drawing.Size(143, 23);
            this.btnEliminarS.TabIndex = 1;
            this.btnEliminarS.Text = "Eliminar Dato";
            this.btnEliminarS.UseVisualStyleBackColor = true;
            this.btnEliminarS.Click += new System.EventHandler(this.btnEliminarS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-210, -85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ListaDoble";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 274);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(488, 123);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "ListaSimpleEnlazada";
            // 
            // btnInserAsc
            // 
            this.btnInserAsc.Location = new System.Drawing.Point(29, 149);
            this.btnInserAsc.Name = "btnInserAsc";
            this.btnInserAsc.Size = new System.Drawing.Size(142, 23);
            this.btnInserAsc.TabIndex = 5;
            this.btnInserAsc.Text = "Insertar Asc";
            this.btnInserAsc.UseVisualStyleBackColor = true;
            this.btnInserAsc.Click += new System.EventHandler(this.btnInserAsc_Click);
            // 
            // btnInserAscD
            // 
            this.btnInserAscD.Location = new System.Drawing.Point(189, 120);
            this.btnInserAscD.Name = "btnInserAscD";
            this.btnInserAscD.Size = new System.Drawing.Size(130, 23);
            this.btnInserAscD.TabIndex = 8;
            this.btnInserAscD.Text = "Insertar Asc";
            this.btnInserAscD.UseVisualStyleBackColor = true;
            this.btnInserAscD.Click += new System.EventHandler(this.btnInserAscD_Click);
            // 
            // btnEliminarD
            // 
            this.btnEliminarD.Location = new System.Drawing.Point(189, 91);
            this.btnEliminarD.Name = "btnEliminarD";
            this.btnEliminarD.Size = new System.Drawing.Size(130, 23);
            this.btnEliminarD.TabIndex = 7;
            this.btnEliminarD.Text = "Eliminar Dato";
            this.btnEliminarD.UseVisualStyleBackColor = true;
            this.btnEliminarD.Click += new System.EventHandler(this.btnEliminarD_Click);
            // 
            // btnInserDetrasD
            // 
            this.btnInserDetrasD.Location = new System.Drawing.Point(189, 62);
            this.btnInserDetrasD.Name = "btnInserDetrasD";
            this.btnInserDetrasD.Size = new System.Drawing.Size(130, 23);
            this.btnInserDetrasD.TabIndex = 6;
            this.btnInserDetrasD.Text = "Insertar Por Detras";
            this.btnInserDetrasD.UseVisualStyleBackColor = true;
            this.btnInserDetrasD.Click += new System.EventHandler(this.btnInserDetrasD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "ListaDobleEnlazada";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(54, 245);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 23);
            this.txtDato.TabIndex = 14;
            // 
            // btnContMul7
            // 
            this.btnContMul7.Location = new System.Drawing.Point(189, 149);
            this.btnContMul7.Name = "btnContMul7";
            this.btnContMul7.Size = new System.Drawing.Size(130, 23);
            this.btnContMul7.TabIndex = 15;
            this.btnContMul7.Text = "Contar Mult 7";
            this.btnContMul7.UseVisualStyleBackColor = true;
            this.btnContMul7.Click += new System.EventHandler(this.btnContMul7_Click_1);
            // 
            // btnInserDetrasDC
            // 
            this.btnInserDetrasDC.Location = new System.Drawing.Point(489, 62);
            this.btnInserDetrasDC.Name = "btnInserDetrasDC";
            this.btnInserDetrasDC.Size = new System.Drawing.Size(125, 23);
            this.btnInserDetrasDC.TabIndex = 16;
            this.btnInserDetrasDC.Text = "Insertar Por Detras";
            this.btnInserDetrasDC.UseVisualStyleBackColor = true;
            this.btnInserDetrasDC.Click += new System.EventHandler(this.btnInserDetrasDC_Click);
            // 
            // btnEliminarDatoDC
            // 
            this.btnEliminarDatoDC.Location = new System.Drawing.Point(489, 91);
            this.btnEliminarDatoDC.Name = "btnEliminarDatoDC";
            this.btnEliminarDatoDC.Size = new System.Drawing.Size(125, 26);
            this.btnEliminarDatoDC.TabIndex = 17;
            this.btnEliminarDatoDC.Text = "Eliminar Dato";
            this.btnEliminarDatoDC.UseVisualStyleBackColor = true;
            this.btnEliminarDatoDC.Click += new System.EventHandler(this.btnEliminarDatoDC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "ListaDobleCircular";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.Location = new System.Drawing.Point(506, 374);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(97, 23);
            this.btnLimpiarLista.TabIndex = 20;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = true;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // btnInserDelante
            // 
            this.btnInserDelante.Location = new System.Drawing.Point(29, 91);
            this.btnInserDelante.Name = "btnInserDelante";
            this.btnInserDelante.Size = new System.Drawing.Size(142, 23);
            this.btnInserDelante.TabIndex = 21;
            this.btnInserDelante.Text = "Insertar Por Delante";
            this.btnInserDelante.UseVisualStyleBackColor = true;
            this.btnInserDelante.Click += new System.EventHandler(this.btnInserDelante_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "ListaSimpleCircular";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Contar Mult 7";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnInserAscSC
            // 
            this.btnInserAscSC.Location = new System.Drawing.Point(341, 120);
            this.btnInserAscSC.Name = "btnInserAscSC";
            this.btnInserAscSC.Size = new System.Drawing.Size(130, 23);
            this.btnInserAscSC.TabIndex = 25;
            this.btnInserAscSC.Text = "Insertar Asc";
            this.btnInserAscSC.UseVisualStyleBackColor = true;
            this.btnInserAscSC.Click += new System.EventHandler(this.btnInserAscSC_Click);
            // 
            // btnEliminarDatoSC
            // 
            this.btnEliminarDatoSC.Location = new System.Drawing.Point(341, 91);
            this.btnEliminarDatoSC.Name = "btnEliminarDatoSC";
            this.btnEliminarDatoSC.Size = new System.Drawing.Size(130, 23);
            this.btnEliminarDatoSC.TabIndex = 24;
            this.btnEliminarDatoSC.Text = "Eliminar Dato";
            this.btnEliminarDatoSC.UseVisualStyleBackColor = true;
            this.btnEliminarDatoSC.Click += new System.EventHandler(this.btnEliminarDatoSC_Click);
            // 
            // btnInserDetrasSC
            // 
            this.btnInserDetrasSC.Location = new System.Drawing.Point(341, 62);
            this.btnInserDetrasSC.Name = "btnInserDetrasSC";
            this.btnInserDetrasSC.Size = new System.Drawing.Size(130, 23);
            this.btnInserDetrasSC.TabIndex = 23;
            this.btnInserDetrasSC.Text = "Insertar Por Detras";
            this.btnInserDetrasSC.UseVisualStyleBackColor = true;
            this.btnInserDetrasSC.Click += new System.EventHandler(this.btnInserDetrasSC_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Dato :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "LEDCabeza";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(631, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 26);
            this.button3.TabIndex = 30;
            this.button3.Text = "Eliminar Dato";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnInserNC
            // 
            this.btnInserNC.Location = new System.Drawing.Point(631, 62);
            this.btnInserNC.Name = "btnInserNC";
            this.btnInserNC.Size = new System.Drawing.Size(125, 23);
            this.btnInserNC.TabIndex = 29;
            this.btnInserNC.Text = "Insertar Por Detras";
            this.btnInserNC.UseVisualStyleBackColor = true;
            this.btnInserNC.Click += new System.EventHandler(this.btnInserNC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 409);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnInserNC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInserAscSC);
            this.Controls.Add(this.btnEliminarDatoSC);
            this.Controls.Add(this.btnInserDetrasSC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInserDelante);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarDatoDC);
            this.Controls.Add(this.btnInserDetrasDC);
            this.Controls.Add(this.btnContMul7);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInserAscD);
            this.Controls.Add(this.btnEliminarD);
            this.Controls.Add(this.btnInserDetrasD);
            this.Controls.Add(this.btnInserAsc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarS);
            this.Controls.Add(this.btnInserDetras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserDetras;
        private System.Windows.Forms.Button btnEliminarS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInserAsc;
        private System.Windows.Forms.Button btnInserAscD;
        private System.Windows.Forms.Button btnEliminarD;
        private System.Windows.Forms.Button btnInserDetrasD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnContMul7;
        private System.Windows.Forms.Button btnInserDetrasDC;
        private System.Windows.Forms.Button btnEliminarDatoDC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.Button btnInserDelante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEliminarDatoSC;
        private System.Windows.Forms.Button btnInserDetrasSC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInserAscSC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnInserNC;
    }
}

