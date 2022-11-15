namespace AccesoDatosAccess
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtFechaAlta = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(12, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(738, 44);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Ejemplo de acceso a datos con una base de datos de Access usando ADO.NET y OleDb." +
    "";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExaminar.Location = new System.Drawing.Point(608, 66);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 6;
            this.btnExaminar.Text = "Examinar...";
            // 
            // txtBase
            // 
            this.txtBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBase.Location = new System.Drawing.Point(212, 66);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(390, 20);
            this.txtBase.TabIndex = 5;
            this.txtBase.Text = "txtBase";
            // 
            // btnConectar
            // 
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConectar.Location = new System.Drawing.Point(84, 66);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(124, 23);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar a la base";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.txtComentario);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.btnNuevo);
            this.GroupBox1.Controls.Add(this.btnActualizar);
            this.GroupBox1.Controls.Add(this.txtFechaAlta);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.txtEmail);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtNombre);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.txtID);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.btnLast);
            this.GroupBox1.Controls.Add(this.btnNext);
            this.GroupBox1.Controls.Add(this.btnPrev);
            this.GroupBox1.Controls.Add(this.btnFirst);
            this.GroupBox1.Location = new System.Drawing.Point(33, 114);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(650, 434);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            // 
            // txtComentario
            // 
            this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComentario.Location = new System.Drawing.Point(120, 164);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.Size = new System.Drawing.Size(518, 258);
            this.txtComentario.TabIndex = 16;
            this.txtComentario.Text = "txtComentario";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(12, 168);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(100, 20);
            this.Label7.TabIndex = 15;
            this.Label7.Text = "Comentario:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevo.Location = new System.Drawing.Point(566, 20);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnActualizar.Location = new System.Drawing.Point(482, 20);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Location = new System.Drawing.Point(120, 136);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.Size = new System.Drawing.Size(140, 20);
            this.txtFechaAlta.TabIndex = 14;
            this.txtFechaAlta.Text = "txtFechaAlta";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(12, 140);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 20);
            this.Label6.TabIndex = 13;
            this.Label6.Text = "Fecha alta:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(120, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(518, 20);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Text = "txtEmail";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(12, 112);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 20);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "e-mail:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(120, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(518, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.Text = "txtNombre";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(12, 84);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 20);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Nombre:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(120, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 8;
            this.txtID.Text = "txtID";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(12, 56);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 20);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "ID:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(12, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(128, 23);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Botones de movimiento:";
            // 
            // btnLast
            // 
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLast.Location = new System.Drawing.Point(244, 20);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(28, 23);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ">|";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Location = new System.Drawing.Point(212, 20);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrev.Location = new System.Drawing.Point(180, 20);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(28, 23);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "<";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFirst.Location = new System.Drawing.Point(148, 20);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(28, 23);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "|<";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 610);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnExaminar;
        internal System.Windows.Forms.TextBox txtBase;
        internal System.Windows.Forms.Button btnConectar;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtComentario;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnActualizar;
        internal System.Windows.Forms.TextBox txtFechaAlta;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnLast;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Button btnPrev;
        internal System.Windows.Forms.Button btnFirst;
    }
}

