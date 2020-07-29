using CapaEntidades.Cache;
using CapaEntidades.DTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class FrmRegistrarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarDocente_Click1(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" || txtApePa.Text != "" || txtApeMa.Text != "" || txtNumDoc.Text != "" ||
                txtNaci.Text != "" || txtTelefono.Text != "" || txtDireccion.Text != "" || Nivel.Text != "")
            {
                N_Docente n_docente = new N_Docente();

                E_PERSONA e_persona = new E_PERSONA(txtNombre.Text, txtApePa.Text, txtApeMa.Text, txtNumDoc.Text, txtNaci.Text, txtTelefono.Text, txtDireccion.Text, Nivel.Text, "A");
                E_NIVEL e_nivel = new E_NIVEL(Convert.ToInt32(Nivel.Text));
                n_docente.insertarDocente(e_persona, e_nivel);

            }
            else
            {
                Response.Write("<script>alert('INGRESE TODOS LOS CAMPOS')</script>");
            }
        }



    }
}