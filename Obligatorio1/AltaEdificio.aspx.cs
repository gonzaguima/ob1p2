﻿using System;
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
            Sistema.Instancia.AltaEdificio(txtNombreEdificio.Text, txtDireccionEdificio.Text);
        }
    }
}