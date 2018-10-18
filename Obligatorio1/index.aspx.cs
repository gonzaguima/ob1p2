using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Obligatorio1Dominio;

namespace Obligatorio1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList1.DataSource = Sistema.Instancia.Edificios;
            DropDownList1.DataTextField = "Nombre";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "Seleccione edificio");

            DropDownList2.DataSource = Sistema.Instancia.CargaAptos();
            DropDownList1.DataTextField = "Numero";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "Seleccione edificio");
        }
    }
}