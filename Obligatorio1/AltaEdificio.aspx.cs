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

        }

        protected void btnAltaEdificio_Click(object sender, EventArgs e)
        {
            string error = "El valor '{0}' no es correcto";
            bool equipamiento = false;
            if (rblEquipamiento.SelectedValue == "Si") { equipamiento = true; } //si esta equipada
            bool esOficina = false;
            if (rbtTipoApto.SelectedValue == "oficina") { esOficina = true; } // si es oficina
            //string tmpTipoApartamento = rbtTipoApto.SelectedValue;  
            int tmpPiso;
            if (!int.TryParse(txtPisoApto.Text, out tmpPiso)) //numero de piso
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
            bool garaje = false;
            if (rblGaraje.SelectedValue == "True") { garaje = true; } //si tiene garaje
            int banios = 0; 
            if(!int.TryParse(txtBanio.Text, out banios)) //cantidad de banios
            {
                lblEnviarEdificio.Text = error;
            }
            int dormitorio = 0; 
            if(!int.TryParse(txtDormitorio.Text, out dormitorio)) //cantidad de dormitorios
            {
                lblEnviarEdificio.Text = error;
            }
            int puestosTrabajo = 0; 
            if(!int.TryParse(txtPuestoTrabajo.Text, out puestosTrabajo)) //cantidad de puestos de trabajo
            {
                lblEnviarEdificio.Text = error;
            }
            lblEnviarEdificio.Text = Sistema.Instancia.AltaEdificio(txtNombreEdificio.Text, txtDireccionEdificio.Text, tmpPiso, tmpNumero, tmpMetraje, tmpOrientacion, esOficina, dormitorio, banios, garaje, equipamiento, puestosTrabajo);
        }
    }
}
