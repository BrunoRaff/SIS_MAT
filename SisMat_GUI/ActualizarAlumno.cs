using Microsoft.VisualBasic.Logging;
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
    public partial class ActualizarAlumno : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        UbigeoBL ubigeoBL = new UbigeoBL();
        AlumnoBE objAlumnoBE = new AlumnoBE();
        MatriculaBE objMatriculaBE = new MatriculaBE();
        AlumnoBL alumnoBL = new AlumnoBL();

        CarreraBL carreraBL = new CarreraBL();
        SemestreBL semestreBL = new SemestreBL();


        Byte[] FotoOriginal;

        String actualIdUbigeo = "";
        Boolean isActualPhotoChanged = false;


        private Int16 _IdAlumno;
        public Int16 IdAlumno
        {
            get { return _IdAlumno; }
            set { _IdAlumno = value; }

        }

        public ActualizarAlumno()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarAlumno_Load(object sender, EventArgs e)
        {
            


            DataTable dtCarreras = carreraBL.ListarCarrera();
            DataRow drCarrera;
            drCarrera = dtCarreras.NewRow();
            drCarrera["Id_carrera"] = 0;
            drCarrera["Nom_carrera"] = "Seleccione una carrera";
            dtCarreras.Rows.InsertAt(drCarrera, 0);
            /*
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
            cmbSemestre.ValueMember = "Id_semestre";
            */
            

            AlumnoBE objAlumno = alumnoBL.ConsultarAlumno(IdAlumno);
            txtNombre.Text = objAlumno.Nom_alum;
            if (objAlumno.Sexo == "F")
            {
                cmbSexo.SelectedItem = "Femenino";
            } else
            {
                cmbSexo.SelectedItem = "Masculino";
            }
            lblID.Text = objAlumno.Id_alum.ToString();
            txtApellido.Text = objAlumno.Ape_alum;
            txtDireccion.Text = objAlumno.Dir_alum;
            mskDNI.Text = objAlumno.Dni_alum;
            mskTelefono.Text = objAlumno.Tel_alum;
            txtEmail.Text = objAlumno.Email_alum;
            dtpNacimiento.Text = Convert.ToDateTime(objAlumno.Fec_nac).ToString();

            String Id_Ubigeo = objAlumno.Id_Ubigeo;
            CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));

            /*
            Int16 idCarrera = alumnoBL.ConsultarAlumnoCarrera(this.IdAlumno);
            Int16 idSemestre = alumnoBL.ConsultarAlumnoSemestre(this.IdAlumno);
            
            cmbCarrera.SelectedValue = idCarrera;
            cmbSemestre.SelectedValue = idSemestre;*/


            if (objAlumno.Est_alum == 1)
            {
                cmbEstado.SelectedItem = "Activo";
            } else
            {
                cmbEstado.SelectedItem = "Inactivo";
            }

            if (objAlumno.Foto_alum != null)
            {
                MemoryStream fotoStream = new MemoryStream(objAlumno.Foto_alum);
                pctFoto.Image = Image.FromStream(fotoStream);
        
                FotoOriginal = objAlumno.Foto_alum;
            }
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


        private void btnActualizarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                String selectedState = cmbEstado.SelectedItem.ToString();
                String selectedSexo = cmbSexo.SelectedItem.ToString();


                if (selectedState == "-Seleccione-")
                {
                    throw new Exception("Seleccione el estado");
                }
                if (selectedSexo == "-Seleccione-")
                {
                    throw new Exception("Seleccione el sexo");
                }
                if (txtNombre.Text.Trim() == "" | txtApellido.Text.Trim() == "" | mskDNI.MaskFull != true | mskTelefono.MaskFull != true | txtEmail.Text.Trim() == "" | dtpNacimiento.Text.Trim() == "" | txtDireccion.Text.Trim() == "")
                {
                    throw new Exception("Todos los campos son obligatorios");
                }
                /*
                if (cmbCarrera.SelectedIndex == 0 | cmbSemestre.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar una carrera y semestre");
                }*/
                if (pctFoto.Image == null)
                {
                    throw new Exception("Si el alumno no tenia foto previamente, ahora si debe de tener, Porfavor ingrese una foto");
                }

                AlumnoBE objAlumnoBE = new AlumnoBE();
                objAlumnoBE.Id_alum = IdAlumno;
                objAlumnoBE.Nom_alum = txtNombre.Text;
                objAlumnoBE.Ape_alum = txtApellido.Text;
                objAlumnoBE.Dni_alum = mskDNI.Text;
                objAlumnoBE.Email_alum = txtEmail.Text;
                objAlumnoBE.Dir_alum = txtDireccion.Text;
                objAlumnoBE.Tel_alum = mskTelefono.Text;
                if (selectedState == "Inactivo")
                {
                    objAlumnoBE.Est_alum = 0;
                } else
                {
                    objAlumnoBE.Est_alum = 1;
                }

                if (selectedSexo == "Masculino")
                {
                    objAlumnoBE.Sexo = "M";
                }
                else
                {
                    objAlumnoBE.Sexo = "F";
                }

                objAlumnoBE.Id_Ubigeo = cmbDepartamento.SelectedValue.ToString() +
                                    cmbProvincia.SelectedValue.ToString() + cmbDist.SelectedValue.ToString();

                if (openFileDialog.FileName.Length > 0)
                {
                    objAlumnoBE.Foto_alum = File.ReadAllBytes(openFileDialog.FileName);
                } else
                {
                    objAlumnoBE.Foto_alum = FotoOriginal;
                }
                objAlumnoBE.Usu_Ult_Mod = UsuarioCredenciales.Usuario;
                objAlumnoBE.Fec_Ult_Mod = DateTime.Today;
                objAlumnoBE.Fec_nac = Convert.ToDateTime(dtpNacimiento.Text);
                /*
                objMatriculaBE.Id_semestre = Convert.ToInt16(cmbSemestre.SelectedValue);
                objMatriculaBE.Id_carrera = Convert.ToInt16(cmbCarrera.SelectedValue);*/

                if (alumnoBL.ActualizarAlumno(objAlumnoBE))
                {
                    MessageBox.Show("Alumno " + objAlumnoBE.Nom_alum + " " + objAlumnoBE.Ape_alum + " actualizado correctamente", "Success", MessageBoxButtons.OK);
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Espera un momento!");
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
            try
            {
                openFileDialog.FileName = String.Empty;
                openFileDialog.Multiselect = false;
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != String.Empty)
                {
                    pctFoto.Image = Image.FromFile(openFileDialog.FileName);
                    isActualPhotoChanged = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
