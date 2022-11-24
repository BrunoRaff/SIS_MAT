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
    public partial class AgregarAlumno : Form
    {
        UbigeoBL ubigeoBL = new UbigeoBL();
        AlumnoBE objAlumnoBE = new AlumnoBE();
        MatriculaBE objMatriculaBE = new MatriculaBE();
        AlumnoBL alumnoBL = new AlumnoBL();

        CarreraBL carreraBL = new CarreraBL();
        SemestreBL semestreBL = new SemestreBL();

        String actualIdUbigeo = "";

        OpenFileDialog openFileDialog = new OpenFileDialog();
        public AgregarAlumno()
        {
            InitializeComponent();
        }

        private void MatricularAlumno_Load(object sender, EventArgs e)
        {
            
      
            cmbSexo.SelectedItem = "-Seleccione-";
            cmbEstado.SelectedItem = "-Seleccione-";

            CargarUbigeo("14", "01", "01");


            /*
            DataTable dtCarreras = carreraBL.ListarCarrera();
            DataRow drCarrera;
            drCarrera = dtCarreras.NewRow();
            drCarrera["Id_carrera"] = 0;
            drCarrera["Nom_carrera"] = "Seleccione una carrera";
            dtCarreras.Rows.InsertAt(drCarrera, 0);
            cmbCarrera.DataSource = dtCarreras;
            cmbCarrera.DisplayMember = "Nom_carrera";
            cmbCarrera.ValueMember = "Id_carrera";*/

            /*
            DataTable dtSemestre = semestreBL.ListarSemestre();
            DataRow drSemestre;
            drSemestre = dtSemestre.NewRow();
            drSemestre["Id_semestre"] = 0;
            drSemestre["Des_semestre"] = "Selecciona un semestre";
            dtSemestre.Rows.InsertAt(drSemestre, 0);
            cmbSemestre.DataSource = dtSemestre;
            cmbSemestre.DisplayMember = "Des_semestre";
            cmbSemestre.ValueMember = "Id_semestre";*/

        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {

            cmbDepartamento.DataSource = ubigeoBL.Ubigeo_Departamentos();
            cmbDepartamento.DisplayMember = "Departamento";
            cmbDepartamento.ValueMember = "IdDepa";
            cmbDepartamento.SelectedValue = IdDepa;

            cmbProvincia.DataSource = ubigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cmbProvincia.DisplayMember = "Provincia";
            cmbProvincia.ValueMember = "IdProv";
            cmbProvincia.SelectedValue = IdProv;

            cmbDist.DataSource = ubigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cmbDist.DisplayMember = "Distrito";
            cmbDist.ValueMember = "IdDist";
            cmbDist.SelectedValue = IdDist;


        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            try
            {
                String selectedSexo = cmbSexo.SelectedItem.ToString();
                String selectedState = cmbEstado.SelectedItem.ToString();

                if (txtNombre.Text.Trim() == "" | txtApellido.Text.Trim() == "" | mskDNI.MaskFull != true | mskTelefono.MaskFull != true| txtEmail.Text.Trim() == "" | dtpFechaNacimiento.Text.Trim() == "" | selectedSexo == "-Seleccione-" | selectedState == "-Seleccione-" | txtDireccion.Text.Trim() == "")
                {
                    throw new Exception("Todos los campos son obligatorios");
                }
                if (cmbDist.SelectedIndex == 0 | cmbProvincia.SelectedIndex == 0 | cmbDepartamento.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar el ubigeo");
                }
                //if (pctbFoto.Image == null)
                //{
                //    throw new Exception("Una foto es necesaria");
                //}
                /*
                if (cmbCarrera.SelectedIndex == 0 | cmbSemestre.SelectedIndex == 0)
                {
                    throw new Exception("Una carrera y un semestre son necesarios");
                }*/

                objAlumnoBE.Nom_alum = txtNombre.Text;
                objAlumnoBE.Ape_alum = txtApellido.Text;
                objAlumnoBE.Dni_alum = mskDNI.Text;
                objAlumnoBE.Email_alum = txtEmail.Text;
                objAlumnoBE.Dir_alum = txtDireccion.Text;
                objAlumnoBE.Tel_alum = mskTelefono.Text;
                objAlumnoBE.Est_alum = 1;
                if (selectedSexo == "Masculino")
                {
                    objAlumnoBE.Sexo = "M";
                } else
                {
                    objAlumnoBE.Sexo = "F";
                }
                if (selectedState == "Inactivo")
                {
                    objAlumnoBE.Est_alum = 0;
                }
                else
                {
                    objAlumnoBE.Est_alum = 1;
                }

                //Ubigeo

                objAlumnoBE.Id_Ubigeo = cmbDepartamento.SelectedValue.ToString() +
                    cmbProvincia.SelectedValue.ToString() + cmbDist.SelectedValue.ToString();


                if (openFileDialog.FileName.Length > 0)
                {
                    objAlumnoBE.Foto_alum = File.ReadAllBytes(openFileDialog.FileName);
                }
                else
                {
                    objAlumnoBE.Foto_alum = File.ReadAllBytes(@".\Img\defaultUser.jpeg");
                }


                objAlumnoBE.Usu_Registro = UsuarioCredenciales.Usuario;
                objAlumnoBE.Fec_Registro = DateTime.Today;
                objAlumnoBE.Fec_nac = Convert.ToDateTime(dtpFechaNacimiento.Text);
                /*objMatriculaBE.Id_semestre = Convert.ToInt16(cmbSemestre.SelectedValue);
                objMatriculaBE.Id_carrera = Convert.ToInt16(cmbCarrera.SelectedValue); */
                
                if (alumnoBL.InsertarAlumno(objAlumnoBE))
                {
                    MessageBox.Show("Alumno " + objAlumnoBE.Nom_alum + " " + objAlumnoBE.Ape_alum + " agregado correctamente", "Success", MessageBoxButtons.OK);
                    this.Close();

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cmbDepartamento.SelectedValue.ToString(), "01", "01");

        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cmbDepartamento.SelectedValue.ToString(), cmbProvincia.SelectedValue.ToString(), "01");


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
