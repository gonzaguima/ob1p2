using Obligatorio1Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio1
{
    public partial class BuscarEdificios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarEdificio_Click(object sender, EventArgs e)
        {
            int menorMetraje;
            int mayorMetraje;

            int.TryParse(txtMenorMetraje.Text, out menorMetraje);
            int.TryParse(txtMayorMetraje.Text,out mayorMetraje);
            string orientacion = ddlBuscarOrientacion.SelectedValue;

            ddlResultadoEdificios.DataSource = Sistema.Instancia.ListadoEdificios(menorMetraje, mayorMetraje, orientacion);
            ddlResultadoEdificios.DataTextField = "Nombre";
            ddlResultadoEdificios.DataBind();
        }
    }
}