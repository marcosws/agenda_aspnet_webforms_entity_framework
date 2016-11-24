using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace agenda_wf_ef
{
    public partial class Usuarios1 : System.Web.UI.Page
    {
        string codigoUsuario = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["codigo"] == null)
            {
                Response.Redirect("Account/Login.aspx");
            }
            else
            {
                codigoUsuario = Session["codigo"].ToString();

                AgendaEntities agenda = new AgendaEntities();

                var ds = agenda.Usuarios.Select(c => new
                {
                    c.Id,
                    c.Nome,
                    c.Email
                });

                GridViewUsuarios.DataSource = ds;
                GridViewUsuarios.DataBind();
            }
        }
    }
}