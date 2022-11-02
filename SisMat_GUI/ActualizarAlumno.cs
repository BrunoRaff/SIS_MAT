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
                cmbSexo.Text = "Femenino";
                cmbSexo.Items.Add("Masculino");
                cmbSexo.Items.Add("Femenino");
            } else
            {
                cmbSexo.Text = "Masculino";
                cmbSexo.Items.Add("Femenino");
                cmbSexo.Items.Add("Masculino");
            }
            txtApellido.Text = objAlumno.Ape_alum;
            txtDireccion.Text = objAlumno.Dir_alum;
            mskDNI.Text = objAlumno.Dni_alum;
            mskTelefono.Text = objAlumno.Tel_alum;
            txtEmail.Text = objAlumno.Email_alum;
            dtpNacimiento.Text = Convert.ToDateTime(objAlumno.Fec_nac).ToString();

            String Id_Ubigeo = objAlumno.Id_Ubigeo;
            cmbDepartamento.SelectedValue = Id_Ubigeo.Substring(0, 2);
            cmbProvincia.SelectedValue = Id_Ubigeo.Substring(2, 2);
            cmbDist.SelectedValue = Id_Ubigeo.Substring(4, 2);

            /*
            Int16 idCarrera = alumnoBL.ConsultarAlumnoCarrera(this.IdAlumno);
            Int16 idSemestre = alumnoBL.ConsultarAlumnoSemestre(this.IdAlumno);
            
            cmbCarrera.SelectedValue = idCarrera;
            cmbSemestre.SelectedValue = idSemestre;*/


            if (objAlumno.Est_alum == 1)
            {
                cmbEstado.Text = "Activo";
                cmbEstado.Items.Add("Inactivo");
                cmbEstado.Items.Add("Activo");
            } else
            {
                cmbEstado.Text = "Inactivo";
                cmbEstado.Items.Add("Inactivo");
                cmbEstado.Items.Add("Activo");
            }

            if (objAlumno.Foto_alum != null)
            {
                MemoryStream fotoStream = new MemoryStream(objAlumno.Foto_alum);
                pctFoto.Image = Image.FromStream(fotoStream);
        
                FotoOriginal = objAlumno.Foto_alum;
            }
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

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            String selectedIdDistrito = cmbDist.SelectedValue.ToString();
            if (selectedIdDistrito != "0" & cmbDist.SelectedIndex != 0)
            {
                actualIdUbigeo = actualIdUbigeo + selectedIdDistrito;
            }
        }

        private void btnActualizarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                String selectedState;
                String selectedSexo;


                if (cmbEstado.SelectedItem == null)
                {
                    selectedState = cmbEstado.Text;
                } else
                {
                    selectedState = cmbEstado.SelectedItem.ToString();
                }
                if (cmbSexo.SelectedItem == null)
                {
                    selectedSexo = cmbSexo.Text;
                } else
                {
                    selectedSexo = cmbSexo.SelectedItem.ToString();
                }
                if (txtNombre.Text.Trim() == "" | txtApellido.Text.Trim() == "" | mskDNI.Text.Trim() == "" | mskTelefono.Text.Trim() == "" | txtEmail.Text.Trim() == "" | dtpNacimiento.Text.Trim() == "" | txtDireccion.Text.Trim() == "")
                {
                    throw new Exception("Todos los campos son obligatorios");
                }
                if (cmbDist.SelectedIndex == 0 | cmbProvincia.SelectedIndex == 0 | cmbDepartamento.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar el ubigeo");
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

                objAlumnoBE.Id_Ubigeo = cmbDepartamento.SelectedValue.ToString() + cmbProvincia.SelectedValue.ToString() + cmbDist.SelectedValue.ToString();

                if (openFileDialog.FileName.Length > 0)
                {
                    objAlumnoBE.Foto_alum = File.ReadAllBytes(openFileDialog.FileName);
                } else
                {
                    objAlumnoBE.Foto_alum = FotoOriginal;
                }
                objAlumnoBE.Usu_Registro = UsuarioCredenciales.Usuario;
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
