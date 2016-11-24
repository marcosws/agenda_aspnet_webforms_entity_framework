using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace agenda_wf_ef.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            AgendaEntities agenda = new AgendaEntities();
            string login = LoginUser.UserName.ToString();
            string senha = LoginUser.Password.ToString();

            var usr = agenda.Usuarios.Where(u => u.Email.Equals(login) && u.Senha.Equals(senha)).FirstOrDefault();

            if (usr != null)
            {
                FormsAuthentication.SetAuthCookie(usr.Nome.ToString(), false);
                Session["codigo"] = usr.Id.ToString();
                Session["usuario"] = usr.Nome.ToString();
                Response.Redirect("~/Contatos.aspx");
            }
        }
    }
}
