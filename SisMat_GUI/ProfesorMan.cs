using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisMat_BL;

namespace SisMat_GUI
{
    public partial class ProfesorMan : Form
    {

        ProfesorBL objProfesorBL = new ProfesorBL();
        DataView dtv;


        public ProfesorMan()
        {
            InitializeComponent();
        }

        private void ProfesorMan_Load(object sender, EventArgs e)
        {
            try
            {
                dtgProfe.AutoGenerateColumns = false;
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void CargarDatos(String strFiltro)
        {

            dtv = new DataView(objProfesorBL.ListarProfesor());
            dtv.RowFilter = "Ape_profe like '%" + strFiltro + "%'";
            dtgProfe.DataSource = dtv;
            lblRegistros.Text = dtgProfe.Rows.Count.ToString();

        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                AgregarProfesor agregarProfeModal = new AgregarProfesor();
                agregarProfeModal.ShowDialog();

                dtv = new DataView(objProfesorBL.ListarProfesor());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarProfesor actualizarProfeModal = new ActualizarProfesor();
                actualizarProfeModal.ID = Convert.ToInt16(dtgProfe.CurrentRow.Cells[0].Value);
                actualizarProfeModal.ShowDialog();

                dtv = new DataView(objProfesorBL.ListarProfesor());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        //Eliminar

        /*private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult vrpta;

                vrpta = MessageBox.Show("Seguro de eliminar el registro?", "Confirmar", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrpta == DialogResult.Yes){

                    if (objProfesorBL.EliminarProfesor(Convert.ToInt16(dtgProfe.CurrentRow.Cells[0].Value)) == true)
                    {
                        CargarDatos(txtFiltro.Text.Trim());
                    }
                    else
                    {
                        throw new Exception("No se pudo eliminar el registro por que esta vinculado a otra tabla");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error : " + ex.Message);
            }
        }*/

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
