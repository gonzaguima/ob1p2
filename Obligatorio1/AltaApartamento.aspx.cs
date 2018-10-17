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
            if (tmpEdificio != "0")
            {
                if (esOficina)
                {
                    lblEnviarApto.Text = Sistema.Instancia.AltaApartamento(tmpPiso, tmpNumero, tmpMetraje, tmpOrientacion, tmpEdificio, esOficina);
                }
            }
        }
    }
}