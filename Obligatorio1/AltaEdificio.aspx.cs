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
                Panel2.Visible = false;
                Panel1.Visible = true;
            }

        }

        protected void btnAltaEdificio_Click(object sender, EventArgs e)
        {
            
            int piso;
            if (!int.TryParse(txtPisoApto.Text, out piso))//numero de piso
            {
                lblEnviarEdificio.Text = "El piso no es un numero";
            }
            int metraje;
            if (!int.TryParse(txtMetrajeApto.Text, out metraje))//numero de metros cuadrados
            {
                lblEnviarEdificio.Text = "El metraje no es numerico";
            }
            string orientacion = ddlOrientacion.SelectedValue;
            string numero = piso.ToString() + orientacion; //calculo de numero de apto = piso + orientacion
            bool esOficina = false;
            if (rbtTipoApto.SelectedValue == "oficina") { esOficina = true; }// si es oficina
            
                bool equipamiento = false;
                if (rblEquipamiento.SelectedValue == "Si") { equipamiento = true; } //si esta equipada
                
                int puestosTrabajo;
            if (!int.TryParse(txtPuestoTrabajo.Text, out puestosTrabajo)) //cantidad de puestos de trabajo
            {
                lblEnviarEdificio.Text = "La cantidad de puestos no es numerica";
            }
                bool garaje = false;
                if (rblGaraje.SelectedValue == "True") { garaje = true; } //si tiene garaje
                int banios;
                if (!int.TryParse(txtBanio.Text, out banios)) //cantidad de banios
                {
                    lblEnviarEdificio.Text = "La cantidad de baños no es numerica";
                }
                int dormitorio;
                if (!int.TryParse(txtDormitorio.Text, out dormitorio)) //cantidad de dormitorios
                {
                    lblEnviarEdificio.Text = "La cantidad de dormitorios no es numerica";

                }
                string nombreEdificio = txtNombreEdificio.Text;
                string direccionEdificio = txtDireccionEdificio.Text;

            if (!esOficina) {
                //si no es oficina, se crea una casa
                string nuevo = Sistema.Instancia.AltaEdificio(nombreEdificio, direccionEdificio, piso, numero, metraje, orientacion, dormitorio, banios, garaje);
                    lblEnviarEdificio.Text = nuevo;
                
            }
            else
            {
                //si es oficina, se crea una oficina
                string nuevo = Sistema.Instancia.AltaEdificio(nombreEdificio, direccionEdificio, piso, numero, metraje, orientacion, puestosTrabajo, equipamiento);
                lblEnviarEdificio.Text = nuevo;
            }
        }

        //cambio de seleccion de apartamento a crear
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
