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
using SisMat_BE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SisMat_GUI.Properties;

namespace SisMat_GUI
{
    public partial class AgregarProfesor : Form
    {

        ProfesorBL objProfesorBL = new ProfesorBL();
        ProfesorBE objProfesorBE = new ProfesorBE();
        EspecialidadBL objEspecialidadBL = new EspecialidadBL();
        UbigeoBL objUbigeoBL = new UbigeoBL();



        public AgregarProfesor()
        {
            InitializeComponent();
        }

        private void AgregarProfesor_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos los combos
                DataTable dt = objEspecialidadBL.ListarEspecialidad();
                DataRow dr;

                dr = dt.NewRow();
                dr["Id_esp"] = 0;
                dr["Des_esp"] = "-Seleccione-";
                dt.Rows.InsertAt(dr,0);
                cmbEspecialidad.DataSource = dt;
                cmbEspecialidad.ValueMember = "Id_esp";
                cmbEspecialidad.DisplayMember = "Des_esp";

                cmbEstado.SelectedItem = "-Seleccione-";
                cmbSexo.SelectedItem = "-Seleccione-";

                CargarUbigeo("14", "01", "01");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {

            cmbDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cmbDepartamento.DisplayMember = "Departamento";
            cmbDepartamento.ValueMember = "IdDepa";
            cmbDepartamento.SelectedValue = IdDepa;

            cmbProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cmbProvincia.DisplayMember = "Provincia";
            cmbProvincia.ValueMember = "IdProv";
            cmbProvincia.SelectedValue = IdProv;

            cmbDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cmbDistrito.DisplayMember = "Distrito";
            cmbDistrito.ValueMember = "IdDist";
            cmbDistrito.SelectedValue = IdDist;


        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validando
                String selectedEsp = cmbEspecialidad.SelectedItem.ToString();
                String selectedSexo = cmbSexo.SelectedItem.ToString();
                String selectedState = cmbEstado.SelectedItem.ToString();

                if (selectedSexo == "-Seleccione-")
                {
                    throw new Exception("Seleccione el sexo");
                }

                if (selectedEsp == "-Seleccione-")
                {
                    throw new Exception("Seleccione la especialidad");
                }


                if (selectedState == "-Seleccione-")
                { 
                    throw new Exception("Seleccione el estado");
                }

                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre esta vacio");
                }

                if (txtApellido.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido esta vacio");
                }


                if (mskTelefono.MaskFull != true)
                {
                    throw new Exception("Debe ingresar un numero telefónico de 9 dígitos");
                }

                if (mskDNI.MaskFull != true)
                {
                    throw new Exception("El DNI debe ser de 8 caracteres");
                }
                //if (pctFotoProf.Image == null)
                //{
                //    throw new Exception("Debe registrar la foto.");
                //}

                //Valores

                objProfesorBE.Nom_profe = txtNombre.Text.Trim();
                objProfesorBE.Ape_profe = txtApellido.Text.Trim();
                objProfesorBE.Dni_profe = mskDNI.Text;
                objProfesorBE.Tel_profe = mskTelefono.Text.Trim();
                objProfesorBE.Email_profe = txtEmail.Text.Trim();
                objProfesorBE.Id_esp = Convert.ToInt16(cmbEspecialidad.SelectedValue);
                if (selectedSexo == "Masculino")
                {
                    objProfesorBE.Sexo = "M";
                }
                else if(selectedSexo == "Femenino")
                {
                    objProfesorBE.Sexo = "F";
                }



                if (selectedState == "Activo")
                {
                    objProfesorBE.Est_profe = 1;
                }
                else if(selectedState == "Inactivo")
                {
                    objProfesorBE.Est_profe = 0;
                }

                objProfesorBE.Usu_Registro = UsuarioCredenciales.Usuario;



                //Foto

                

                if (pctFotoProf.Image != null)
                {
                    objProfesorBE.Foto_profe = File.ReadAllBytes(openFileDialog1.FileName);
                }
                else
                {
                    objProfesorBE.Foto_profe = File.ReadAllBytes(@".\Img\defaultUser.jpeg");   
                }




                //Combinacion de valores para el ID_UBIGEO
                objProfesorBE.Id_Ubigeo = cmbDepartamento.SelectedValue.ToString() +
                    cmbProvincia.SelectedValue.ToString() + cmbDistrito.SelectedValue.ToString();

                

                //Insert
                if (objProfesorBL.InsertarProfesor(objProfesorBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try {

                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                // Si se escogio una foto se carga en el picture Box
                if (openFileDialog1.FileName != String.Empty)
                {
                    pctFotoProf.Image = Image.FromFile(openFileDialog1.FileName);
                }


            }
            catch (Exception)
            {
                throw;
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

