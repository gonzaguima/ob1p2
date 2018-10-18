using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Obligatorio1Dominio;

namespace Obligatorio1
{
    public partial class AltaEdificio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }

        }

        protected void btnAltaEdificio_Click(object sender, EventArgs e)
        {
            string error = "El valor no es correcto";
            int tmpPiso;
            if (!int.TryParse(txtPisoApto.Text, out tmpPiso))//numero de piso
            {
                lblEnviarEdificio.Text = error;
            }
            int tmpMetraje;
            if (!int.TryParse(txtMetrajeApto.Text, out tmpMetraje))//numero de metros cuadrados
            {
                lblEnviarEdificio.Text = error;
            }
            string tmpOrientacion = ddlOrientacion.SelectedValue;
            string tmpNumero = tmpPiso.ToString() + tmpOrientacion; //calculo de numero de apto = piso + orientacion
            bool esOficina = false;
            if (rbtTipoApto.SelectedValue == "oficina") { esOficina = true; }// si es oficina
            
                bool equipamiento = false;
                if (rblEquipamiento.SelectedValue == "Si") { equipamiento = true; } //si esta equipada
                
                int puestosTrabajo;
            if (!int.TryParse(txtPuestoTrabajo.Text, out puestosTrabajo)) //cantidad de puestos de trabajo
            {
                lblEnviarEdificio.Text = error;
            }
                bool garaje = false;
                if (rblGaraje.SelectedValue == "True") { garaje = true; } //si tiene garaje
                int banios;
                if (!int.TryParse(txtBanio.Text, out banios)) //cantidad de banios
                {
                    lblEnviarEdificio.Text = error;
                }
                int dormitorio;
                if (!int.TryParse(txtDormitorio.Text, out dormitorio)) //cantidad de dormitorios
                {
                    lblEnviarEdificio.Text = error;

                }

            
            lblEnviarEdificio.Text = Sistema.Instancia.AltaEdificio(txtNombreEdificio.Text, txtDireccionEdificio.Text, tmpPiso, tmpNumero, tmpMetraje, tmpOrientacion, esOficina, dormitorio, banios, garaje, equipamiento, puestosTrabajo);
        }


        protected void rbtTipoApto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtTipoApto.SelectedValue == "oficina")
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
            else
            {
                Panel2.Visible = false;
                Panel1.Visible = true;
            }
        }
    }
}
