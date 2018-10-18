using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Obligatorio1Dominio;

namespace Obligatorio1
{
    public partial class BuscarApartamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btnBuscarAptoPrecio_Click(object sender, EventArgs e)
        {
            int tmpMenor;
            int.TryParse(txtMenorPrecio.Text, out tmpMenor);
            int tmpMayor;
            int.TryParse(txtMayorPrecio.Text, out tmpMayor);
            Sistema.Instancia.ListadoAptoPrecio(tmpMenor, tmpMayor);
            ddlAptoPrecio.DataSource = Sistema.Instancia.ListadoAptoPrecio(tmpMenor, tmpMayor);
            ddlAptoPrecio.DataTextField = "Nombre";
            ddlAptoPrecio.DataBind();
        }

        protected void btnBuscarAptoMetraje_Click(object sender, EventArgs e)
        {
            int tmpMenor;
            int.TryParse(txtMenorMetraje.Text, out tmpMenor);
            int tmpMayor;
            int.TryParse(txtMayorMetraje.Text, out tmpMayor);
            bool respuesta = Sistema.Instancia.HayApto(tmpMenor, tmpMayor);
            if (respuesta)
            {
                lblExisteApto.Text = "Existe un apartamento en el rango indicado";
            }
            else
            {
                lblExisteApto.Text = "No existen apartamentos en el rango indicado";
            }
        }
    }
}