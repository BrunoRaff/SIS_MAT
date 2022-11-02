using SisMat_BE;
using SisMat_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisMat_GUI
{
    public partial class AlumnoMan : Form
    {
        AlumnoBL alumnoBL = new AlumnoBL();
        DataView dtv;
       
        public AlumnoMan()
        {
            InitializeComponent();
        }
        public void obtenerAlumnos(String query)
        {
            dtv = new DataView(alumnoBL.ListarAlumno());
            dtv.RowFilter = "Nom_alum like '%"+query+"%'";

            dtgAlumno.DataSource = dtv;

        }

        private void AlumnoMan_Load(object sender, EventArgs e)
        {
            dtgAlumno.AutoGenerateColumns = false;
            obtenerAlumnos("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarAlumno matricularModal = new AgregarAlumno();
            matricularModal.ShowDialog();
            obtenerAlumnos("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarAlumno actualizarModal = new ActualizarAlumno();
            if (dtgAlumno.CurrentRow != null)
            actualizarModal.IdAlumno = Convert.ToInt16(dtgAlumno.CurrentRow.Cells[0].Value);
            actualizarModal.ShowDialog();
            obtenerAlumnos("");
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            obtenerAlumnos(txtFiltro.Text);
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (alumnoBL.EliminarAlumno(Convert.ToInt16(dtgAlumno.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("Alumno eliminado correctamente");
                obtenerAlumnos("");
            }
        }
    }
}
