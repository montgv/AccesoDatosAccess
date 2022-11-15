using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AccesoDatosAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Las variables que usaremos en este ejemplo
        DataTable dt;
        SqlDataAdapter da;
        int fila;


        private void Form1_Load(object sender, EventArgs e)
        {
            // Limpiar los controles del GroupBox y
            // deshabilitarlos hasta que se conecte a la base de datos
            //
            foreach (Control c in this.GroupBox1.Controls)
            {
                // Limpiar los textbox
                if (c is TextBox)
                {
                    c.Text = "";
                }
                // Deshabilitarlos
                c.Enabled = false;
            }
            this.GroupBox1.Enabled = false;
            this.GroupBox1.Text = "Debes conectar antes de usar los datos";
            //
            // El nombre de la base de datos:
            // (poner el path real de la base de datos de prueba)
            this.txtBase.Text = "db2000.mdb";
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.File.Exists(txtBase.Text) == false)
                {
                    MessageBox.Show("No existe la base de datos indicada");
                    txtBase.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message + "\nSeguramente porque no existe la base de datos indicada");
                txtBase.Focus();
                return;
            }
            //
            // La cadena de conexión
            string sCnn = "Data Source=" + txtBase.Text + "; Initial Catalog=pruebaDB; User ID=SA; Password=oretania";
            // La cadena de selección
            string sSel = "SELECT * FROM Prueba ORDER BY ID";
            // Para traer solo los registros entre dos fechas
            // sSel = "SELECT * FROM Prueba WHERE (FechaAlta >= #2006/01/05# AND FechaAlta <= #2006/01/06#)";


            // Comprobar si hay algún error
            try
            {
                // Crear un nuevo objeto del tipo DataAdapter
                //Dim cnn As New OleDbConnection(sCnn)
                da = new SqlDataAdapter(sSel, sCnn);
                // Crear los comandos de insertar, actualizar y eliminar
                SqlConnection cnx = new SqlConnection(sCnn);
                // Como hay campos con caracteres especiales,
                // al usarlos incluirlos entre corchetes.
                cb.QuotePrefix = "[";
                cb.QuoteSuffix = "]";
                // Asignar los comandos al DataAdapter
                // (se supone que lo hace automáticamente, pero...)
                da.UpdateCommand = cb.GetUpdateCommand();
                da.InsertCommand = cb.GetInsertCommand();
                da.DeleteCommand = cb.GetDeleteCommand();
                //
                // Esta base de datos usa el ID con valores automáticos
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                //
                dt = new DataTable();
                // Llenar la tabla con los datos indicados
                da.Fill(dt);
                //
                // Habilitar los controles
                foreach (Control c in this.GroupBox1.Controls)
                {
                    c.Enabled = true;
                }
                this.GroupBox1.Enabled = true;
                this.GroupBox1.Text = "Conexión realizada";

                // Y mostrar el primer registro
                if (dt.Rows.Count > 0)
                {
                    btnFirst_Click(null, null);
                }
                else
                {
                    fila = -1;
                    btnActualizar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al conectar o recuperar los datos:\n" + ex.Message,
                                "Conectar con la base",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Crear un nuevo registro
            DataRow dr = dt.NewRow();
            // Asignar los datos de los textbox a la fila
            asignarDatos(dr);
            // Añadir la nueva fila a la tabla
            dt.Rows.Add(dr);
            // Guardar físicamente los datos en la base
            try
            {
                da.Update(dt);
                dt.AcceptChanges();
                // Si es el primer registro de la base,
                // volver a leer los datos para actualizar los IDs
                if (Convert.ToInt32("0" + dr["ID"].ToString()) == 0)
                {
                    dt = new DataTable();
                    da.Fill(dt);
                }
                // Posicionarlo en la última fila
                btnLast_Click(null, null);
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error de concurrencia:\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
         
            }
        }

        private void asignarDatos(DataRow dr)
        {
            // Usar los datos que hay en los textbox
            dr["Nombre"] = txtNombre.Text;
            dr["e-mail"] = txtEmail.Text;
            dr["FechaAlta"] = txtFechaAlta.Text;
            dr["Comentario"] = txtComentario.Text;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar los datos en la fila actual
            if (fila < 0 || fila > dt.Rows.Count - 1) return;

            DataRow dr = dt.Rows[fila];
            // Asignar los datos de los textbox a la fila
            asignarDatos(dr);
            // Guardar físicamente los datos en la base
            try
            {
                da.Update(dt);
                dt.AcceptChanges();
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error de concurrencia:\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void mostrarDatos(int f)
        {
            int uf = dt.Rows.Count - 1;
            if (f < 0 || uf < 0) return;
            //
            DataRow dr = dt.Rows[f];
            txtID.Text = dr["ID"].ToString();
            txtNombre.Text = dr["Nombre"].ToString();
            txtEmail.Text = dr["e-mail"].ToString();
            txtFechaAlta.Text = dr["FechaAlta"].ToString();
            txtComentario.Text = dr["Comentario"].ToString();
            //
            btnActualizar.Enabled = true;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            // Posicionarse en la primera fila
            fila = 0;
            // Mostrar los datos de la fila indicada
            mostrarDatos(fila);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Posicionarse en la fila anterior
            fila = fila - 1;
            if (fila < 0) fila = 0;
            // Mostrar los datos de la fila indicada
            mostrarDatos(fila);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Posicionarse en la fila siguiente
            int uf = dt.Rows.Count - 1;
            fila = fila + 1;
            if (fila > uf) fila = uf;
            // Mostrar los datos de la fila indicada
            mostrarDatos(fila);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            // Posicionarse en la última fila
            fila = dt.Rows.Count - 1;
            // Mostrar los datos de la fila indicada
            mostrarDatos(fila);
        }
    }
}
