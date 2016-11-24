using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace agenda_wf_ef.Account
{
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        }

        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {
            AgendaEntities agenda = new AgendaEntities();
            Usuarios usuarios = new Usuarios();

            usuarios.Nome = RegisterUser.UserName.ToString();
            usuarios.Email = RegisterUser.Email.ToString();
            usuarios.Senha = RegisterUser.Password.ToString();

            agenda.AddToUsuarios(usuarios);
            agenda.SaveChanges();

            Response.Redirect("Login.aspx");
        }

    }
}
