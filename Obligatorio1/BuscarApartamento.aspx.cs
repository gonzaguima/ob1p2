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
            ddlAptoPrecio.DataSource = Sistema.Instancia.ListadoAptoPrecio(txtMenorPrecio.Text, txtMayorPrecio.Text);
            ddlAptoPrecio.DataTextField = "Nombre";
            ddlAptoPrecio.DataBind();
        }
    }
}