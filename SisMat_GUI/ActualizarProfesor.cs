using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SisMat_BE;
using SisMat_BL;

namespace SisMat_GUI
{
    public partial class ActualizarProfesor : Form
    {

        ProfesorBL objProfesorBL = new ProfesorBL();
        ProfesorBE objProfesorBE = new ProfesorBE();
        EspecialidadBL objEspecialidadBL = new EspecialidadBL();
        UbigeoBL objUbigeoBL = new UbigeoBL();

        Boolean blnCambioFoto;

        Byte[] FotoOriginal;

        public ActualizarProfesor()
        {
            InitializeComponent();
        }

        public Int16 ID { get; set; }
        

        private void ActualizarProfesor_Load(object sender, EventArgs e)
        {
            try
            {
                // Mostramos los datos del profesor

                objProfesorBE = objProfesorBL.ConsultarProfesor(this.ID);

                lblID.Text = objProfesorBE.Id_profe.ToString();
                txtNombre.Text = objProfesorBE.Nom_profe;
                txtApellido.Text = objProfesorBE.Ape_profe;
                mskDNI.Text = objProfesorBE.Dni_profe;
                mskTelefono.Text = objProfesorBE.Tel_profe;
                txtEmail.Text = objProfesorBE.Email_profe;

                if (objProfesorBE.Est_profe == 1)
                {
                    cmbEstado.SelectedItem = "Activo";
                }
                else
                {
                    cmbEstado.SelectedItem = "Inactivo";
                }



                if (objProfesorBE.Sexo == "M")
                {
                    cmbSexo.SelectedItem = "Masculino";
                }
                else if(objProfesorBE.Sexo == "F")
                {
                    cmbSexo.SelectedItem = "Femenino";
                }

                //Cargar combos

                DataTable dt = objEspecialidadBL.ListarEspecialidad();
                DataRow dr;

                dr = dt.NewRow();
                dr["Id_esp"] = 0;
                dr["Des_esp"] = "-Seleccione-";
                dt.Rows.InsertAt(dr, 0);
                cmbEspecialidad.DataSource = dt;
                cmbEspecialidad.DisplayMember = "Des_esp";
                cmbEspecialidad.ValueMember = "Id_esp";

                cmbEspecialidad.SelectedValue = objProfesorBE.Id_esp.ToString();

                //Ubigeo

                String Id_Ubigeo = objProfesorBE.Id_Ubigeo;
                CargarUbigeo(Id_Ubigeo.Substring(0,2), Id_Ubigeo.Substring(2,2), Id_Ubigeo.Substring(4,2));

                //Cargar foto
                // Si no tiene foto....
                if (objProfesorBE.Foto_profe.Length == 0)
                {

                    pctFotoProf.Image = null;

                }
                else // Pero si tiene foto
                {
                    MemoryStream fotoStream = new MemoryStream(objProfesorBE.Foto_profe);
                    pctFotoProf.Image = Image.FromStream(fotoStream);
                    // Guardamos la foto original , por si no se hace cambios...
                    FotoOriginal = objProfesorBE.Foto_profe;
                }

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

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                // Si se escogio una foto se carga en el picture Box y la variable blnCambio se pone en true
                // Esta variable permitira saber si se cambio la foto en la categoria.
                if (openFileDialog1.FileName != String.Empty)
                {
                    pctFotoProf.Image = Image.FromFile(openFileDialog1.FileName);
                    blnCambioFoto = true;
                }
                else // de lo contrario la variable blnCambio se mantiene en falso
                {
                    blnCambioFoto = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validando
                String selectedEsp = cmbEspecialidad.SelectedItem.ToString();
                String selectedSexo = cmbSexo.SelectedItem.ToString();
                String selectedState = cmbEstado.SelectedItem.ToString();

                if (selectedSexo != "Masculino" && selectedSexo != "Femenino")
                {
                    throw new Exception("Seleccione el sexo");
                }

                if (selectedEsp == "-Seleccione-")
                {
                    throw new Exception("Seleccione la especialidad");
                }

                if (selectedState != "Activo" && selectedState != "Inactivo")
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
                if (pctFotoProf.Image == null)
                {
                    throw new Exception("Debe registrar la foto.");
                }

                //Valores

                objProfesorBE.Id_profe = Convert.ToInt16(lblID.Text);

                objProfesorBE.Nom_profe = txtNombre.Text.Trim();
                objProfesorBE.Ape_profe = txtApellido.Text.Trim();
                objProfesorBE.Dni_profe = mskDNI.Text;
                objProfesorBE.Tel_profe = mskTelefono.Text.Trim();
                objProfesorBE.Email_profe = txtEmail.Text.Trim();
                objProfesorBE.Id_esp = Convert.ToInt16(cmbEspecialidad.SelectedValue);

                objProfesorBE.Usu_Ult_Mod = UsuarioCredenciales.Usuario;



                //Foto

                if (blnCambioFoto == true)
                {
                    objProfesorBE.Foto_profe = File.ReadAllBytes(openFileDialog1.FileName);
                }
                else  //Mantenemos la foto original
                {
                    objProfesorBE.Foto_profe = FotoOriginal;
                }


                if (selectedState == "Activo")
                {
                    objProfesorBE.Est_profe = 1;
                }
                else if(selectedState == "Inactivo")
                {
                    objProfesorBE.Est_profe = 0;
                }

                if (selectedSexo == "Masculino")
                {
                    objProfesorBE.Sexo = "M";
                }
                else if (selectedSexo == "Femenino")
                {
                    objProfesorBE.Sexo = "F";
                }

                //Combinacion de valores para el ID_UBIGEO
                objProfesorBE.Id_Ubigeo = cmbDepartamento.SelectedValue.ToString() +
                    cmbProvincia.SelectedValue.ToString() + cmbDistrito.SelectedValue.ToString();



                //Insert
                if (objProfesorBL.ActualizarProfesor(objProfesorBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
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
