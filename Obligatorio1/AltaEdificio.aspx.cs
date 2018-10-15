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
            string tmpTipoApartamento = rbtTipoApto.SelectedValue;
            int tmpPiso;
            int.TryParse(txtPisoApto.Text, out tmpPiso);
            int tmpMetraje;
            int.TryParse(txtMetrajeApto.Text, out tmpMetraje);
            string tmpOrientacion = ddlOrientacion.SelectedValue;
            string tmpNumero = tmpPiso.ToString() + tmpOrientacion;
            lblEnviarEdificio.Text = Sistema.Instancia.AltaEdificio(txtNombreEdificio.Text, txtDireccionEdificio.Text, tmpPiso, tmpNumero, tmpMetraje, tmpOrientacion);
        }
    }
}