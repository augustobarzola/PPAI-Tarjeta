using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_Tarjeta.Vista
{
    public partial class PantallaRegistrarRespuesta : Form
    {
        private Controlador.GestorRegistrarRespuesta gestor;
        private string rtaOperador = "";
        public PantallaRegistrarRespuesta(Controlador.GestorRegistrarRespuesta gestorRegistrarRespuesta)
        {
            gestor = gestorRegistrarRespuesta;
          
            InitializeComponent();
            
        }

        public void setCategoria(string categoria) {
            this.lblCategoria.Text=categoria;
        }
        public void setOpcion(string opcion)
        {
            this.lblOpcion.Text = opcion;
        }
        public void setSubOpcion(string subopcion)
        {
            this.lblSubOpc.Text = subopcion;
            
        }
        public void setGridRow(List<Modelo.Validacion> valida) {
            foreach (Modelo.Validacion v in valida) {
                DataGridViewComboBoxColumn dgvcmb = new DataGridViewComboBoxColumn();
                dgvcmb.HeaderText=v.getNombre();
                dgvcmb.Items.Add("Seleccione una opcion");
                foreach (Modelo.OpcionValidacion o in v.opciones) {

                    dgvcmb.Items.Add(o.getDescripcion());
                    }
               
                this.grillaValidacion.Columns.Add(dgvcmb);
                
           }
            DataGridViewButtonColumn dgvb = new DataGridViewButtonColumn();
            dgvb.HeaderText = "Validar";
            dgvb.Name = "btnValidar";
            dgvb.Text = "Validar";
            dgvb.UseColumnTextForButtonValue = true;
          
            this.grillaValidacion.Columns.Add(dgvb);

            
        }
        public void anularFilas() {
            this.grillaValidacion.AllowUserToAddRows = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblOpcion_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gestor.registrarAccionRequerida();
        }
        public void informarEjecucionCU()
        {
            MessageBox.Show("El Caso de Uso Registrar Accion Requerida fue realizado con exito");
        }
        private void PantallaRegistrarRespuesta_Load(object sender, EventArgs e)
        {

        }

        private void grillaValidacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        private void selectedCellsButton_Click(object sender, System.EventArgs e) {
           
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void setCliente(string nombre) {
            this.lblCliente.Text = nombre;
        }
        private void grillaValidacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex==0) {
                if (gestor.validarRespuesta(grillaValidacion.Columns[0].HeaderText, grillaValidacion.Rows[e.RowIndex].Cells[0].Value.ToString())
                 && gestor.validarRespuesta(grillaValidacion.Columns[1].HeaderText, grillaValidacion.Rows[e.RowIndex].Cells[1].Value.ToString()))
                {
                    
                    DialogResult result=MessageBox.Show("Ingrese la respuesta del operador","Respuesta de Operador",MessageBoxButtons.OK);
                    if (result == System.Windows.Forms.DialogResult.OK) {
                        grillaValidacion.Enabled = false;
                        lblRta.Visible = true;
                        btnResOp.Visible = true;
                        txtBoxRta.Visible = true;
                    
                    }
                }
                else {
                    MessageBox.Show("Alguno de los datos de validacion no fue ingresado correctamente");
                }
               // MessageBox.Show(grillaValidacion.Rows[e.RowIndex].Cells[0].Value.ToString()+"--"+ grillaValidacion.Columns[0].HeaderText);
            }
        }

        private void btnResOp_Click(object sender, EventArgs e)
        {
            if (txtBoxRta.TextLength > 0) {
                btnConfirmar.Enabled = true;
                this.rtaOperador = txtBoxRta.Text;
                DialogResult result = MessageBox.Show("Confirme la operacion realizada", "Confirmar Respuesta", MessageBoxButtons.OK);
                btnResOp.Enabled = false;
                txtBoxRta.Enabled = false;
            }
        }
   

    }
}
