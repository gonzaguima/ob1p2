using Obligatorio1Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio1
{
    public partial class AltaApartamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlElegirEdificio.DataSource = Sistema.Instancia.Edificios;
                ddlElegirEdificio.DataTextField = "Nombre";
                ddlElegirEdificio.DataBind();
                ddlElegirEdificio.Items.Insert(0, "Seleccione edificio");

                Panel1.Visible = false;
                Panel2.Visible = true;
            }

        }

        protected void btnEnviarApto_Click(object sender, EventArgs e)
        {
            bool esOficina = false;
            if (rbtTipoApto.SelectedValue == "oficina") { esOficina = true; }
            string tmpEdificio = ddlElegirEdificio.SelectedValue;
            string tmpTipoApartamento = rbtTipoApto.SelectedValue;
            int tmpPiso;
            int.TryParse(txtPisoApto.Text, out tmpPiso);
            int tmpMetraje;
            int.TryParse(txtMetrajeApto.Text, out tmpMetraje);
            string tmpOrientacion = ddlOrientacion.SelectedValue;
            string tmpNumero = tmpPiso.ToString() + tmpOrientacion;
            bool equipamiento = false;
            if (rblEquipamiento.SelectedValue == "Si") { equipamiento = true; }
            bool garaje = false;
            if (rblGaraje.SelectedValue == "Si") { garaje = true; }
            int banios; 
            int.TryParse(txtBanio.Text, out banios);
            int dormitorio;
            int.TryParse(txtDormitorio.Text, out dormitorio);
            int puestosTrabajo;
            int.TryParse(txtPuestoTrabajo.Text, out puestosTrabajo);
            if (Sistema.Instancia.BuscarEdificio(tmpEdificio) == null)
            {
                
                string msj = Sistema.Instancia.AltaApartamento(tmpPiso, tmpNumero, tmpMetraje, tmpOrientacion, tmpEdificio, esOficina, dormitorio, banios, garaje, equipamiento, puestosTrabajo);
                lblEnviarApto.Text = msj;
            }
        }

        protected void rbtTipoApto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtTipoApto.SelectedValue == "oficina")
            {
                Panel2.Visible = false;
                Panel1.Visible = true;
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
        }
    }
}