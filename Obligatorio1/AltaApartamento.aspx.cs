﻿using Obligatorio1Dominio;
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

        }

        protected void btnEnviarApto_Click(object sender, EventArgs e)
        {
            
            string tmpEdificio = ddlElegirEdificio.SelectedValue;
            string tmpTipoApartamento = chkTipoApto.SelectedValue;
            int tmpPiso;
            int.TryParse(txtPisoApto.Text, out tmpPiso);
            int tmpMetraje;
            int.TryParse(txtMetrajeApto.Text, out tmpMetraje);
            string tmpOrientacion = ddlOrientacion.SelectedValue;
            string tmpNumero = tmpPiso.ToString() + tmpOrientacion;
            
            

            
                if (Sistema.Instancia.BuscarEdificio(tmpEdificio) != null)
                {
                    Sistema.Instancia.AltaApartamento(tmpPiso, tmpNumero, tmpMetraje, tmpOrientacion);
                }
            


        }
    }
}