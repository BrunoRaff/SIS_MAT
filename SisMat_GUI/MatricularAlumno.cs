using SisMat_ADO;
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
    public partial class MatricularAlumno : Form
    {
        UbigeoBL ubigeoBL = new UbigeoBL();
        AlumnoBE objAlumnoBE = new AlumnoBE();
        MatriculaBE objMatriculaBE = new MatriculaBE();
        AlumnoBL alumnoBL = new AlumnoBL();

        CarreraBL carreraBL = new CarreraBL();
        SemestreBL semestreBL = new SemestreBL();

        String actualIdUbigeo = "";

        OpenFileDialog openFileDialog = new OpenFileDialog();
        public MatricularAlumno()
        {
            InitializeComponent();
        }

        private void MatricularAlumno_Load(object sender, EventArgs e)
        {
            
            DataTable dt = ubigeoBL.Ubigeo_Departamentos();
            DataRow dr;

            dr = dt.NewRow();
            dr["IDDEPA"] = 0;
            dr["DEPARTAMENTO"] = "Seleccione un Departamento";
            dt.Rows.InsertAt(dr, 0);
            cmbDepartamento.DataSource = dt;
            cmbDepartamento.DisplayMember = "DEPARTAMENTO";
            cmbDepartamento.ValueMember = "IDDEPA";

            DataTable dtCarreras = carreraBL.ListarCarrera();
            DataRow drCarrera;
            drCarrera = dtCarreras.NewRow();
            drCarrera["Id_carrera"] = 0;
            drCarrera["Nom_carrera"] = "Seleccione una carrera";
            dtCarreras.Rows.InsertAt(drCarrera, 0);
            cmbCarrera.DataSource = dtCarreras;
            cmbCarrera.DisplayMember = "Nom_carrera";
            cmbCarrera.ValueMember = "Id_carrera";

            DataTable dtSemestre = semestreBL.ListarSemestre();
            DataRow drSemestre;
            drSemestre = dtSemestre.NewRow();
            drSemestre["Id_semestre"] = 0;
            drSemestre["Des_semestre"] = "Selecciona un semestre";
            dtSemestre.Rows.InsertAt(drSemestre, 0);
            cmbSemestre.DataSource = dtSemestre;
            cmbSemestre.DisplayMember = "Des_semestre";
            cmbSemestre.ValueMember = "Id_semestre";

        }

        private void cmbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            String selectedDepartamentoId = cmbDepartamento.SelectedValue.ToString();
            
            if (selectedDepartamentoId != "0")
            {
                actualIdUbigeo = selectedDepartamentoId;
                DataTable dt = ubigeoBL.Ubigeo_ProvinciasDepartamento(selectedDepartamentoId);
                DataRow dr;
                dr = dt.NewRow();
                dr["IDPROV"] = 0;
                dr["PROVINCIA"] = "Seleccione una Provincia";
                dt.Rows.InsertAt(dr, 0);
                cmbProvincia.DataSource = dt;
                cmbProvincia.DisplayMember = "PROVINCIA";
                cmbProvincia.ValueMember = "IDPROV";
            }
        }
        private void cmbProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            String selectedIdProvincia = cmbProvincia.SelectedValue.ToString();
            if (selectedIdProvincia != "0")
            {
                DataTable dt = ubigeoBL.Ubigeo_DistritosProvinciaDepartamento(cmbDepartamento.SelectedValue.ToString(), selectedIdProvincia);
                DataRow dr;
                dr = dt.NewRow();
                dr["IDDIST"] = 0;
                dr["DISTRITO"] = "Seleccione un Distrito";
                dt.Rows.InsertAt(dr, 0);
                cmbDist.DataSource = dt;
                cmbDist.DisplayMember = "DISTRITO";
                cmbDist.ValueMember = "IDDIST";
                actualIdUbigeo = actualIdUbigeo + selectedIdProvincia;
            }
        }

        private void cmbDist_SelectedValueChanged(object sender, EventArgs e)
        {
            String selectedIdDistrito = cmbDist.SelectedValue.ToString();
            if (selectedIdDistrito != "0" & cmbDist.SelectedIndex != 0)
            {
                actualIdUbigeo = actualIdUbigeo + selectedIdDistrito;
            }
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            try
            {
                String selectedSexo = cmbSexo.SelectedItem.ToString();
                if (txtNombre.Text.Trim() == "" | txtApellido.Text.Trim() == "" | txtDNI.Text.Trim() == "" | txtTelefono.Text.Trim() == "" | txtEmail.Text.Trim() == "" | mskFechaNac.Text.Trim() == "" | selectedSexo != "Masculino" && selectedSexo != "Femenino" | txtDireccion.Text.Trim() == "")
                {
                    throw new Exception("Todos los campos son obligatorios");
                }
                if (cmbDist.SelectedIndex == 0 | cmbProvincia.SelectedIndex == 0 | cmbDepartamento.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar el ubigeo");
                }
                if (txtTelefono.Text.Length != 9)
                {
                    throw new Exception("Debe ingresar un numero telefónico de 9 dígitos");
                }
                if (pctbFoto.Image == null)
                {
                    throw new Exception("Una foto es necesaria");
                }
                if (cmbCarrera.SelectedIndex == 0 | cmbSemestre.SelectedIndex == 0)
                {
                    throw new Exception("Una carrera y un semestre son necesarios");
                }

                objAlumnoBE.Nom_alum = txtNombre.Text;
                objAlumnoBE.Ape_alum = txtApellido.Text;
                objAlumnoBE.Dni_alum = txtDNI.Text;
                objAlumnoBE.Email_alum = txtEmail.Text;
                objAlumnoBE.Dir_alum = txtDireccion.Text;
                objAlumnoBE.Tel_alum = txtTelefono.Text;
                objAlumnoBE.Est_alum = 1;
                if (selectedSexo == "Masculino")
                {
                    objAlumnoBE.Sexo = "M";
                } else
                {
                    objAlumnoBE.Sexo = "F";
                }
                objAlumnoBE.Id_Ubigeo = actualIdUbigeo;
          
                if (openFileDialog.FileName.Length > 0)
                {
                    objAlumnoBE.Foto_alum = File.ReadAllBytes(openFileDialog.FileName);
                }
                objAlumnoBE.Usu_Ult_Mod = UsuarioCredenciales.Usuario;
                objAlumnoBE.Fec_Registro = DateTime.Today;
                objAlumnoBE.Fec_Ult_Mod = DateTime.Today;
                objAlumnoBE.Fec_nac = Convert.ToDateTime(mskFechaNac.Text);
                objMatriculaBE.Id_semestre = Convert.ToInt16(cmbSemestre.SelectedValue);
                objMatriculaBE.Id_carrera = Convert.ToInt16(cmbCarrera.SelectedValue); 
                
                if (alumnoBL.InsertarAlumno(objAlumnoBE, objMatriculaBE))
                {
                    MessageBox.Show("Alumno " + objAlumnoBE.Nom_alum + " " + objAlumnoBE.Ape_alum + " matriculado correctamente", "Success", MessageBoxButtons.OK);
                    this.Close();

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = String.Empty;
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != String.Empty)
            {
                pctbFoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
