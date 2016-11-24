using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace agenda_wf_ef
{
    public partial class Contatos1 : System.Web.UI.Page
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
                ConsultaContatos();
            }
        }

        public void ConsultaContatos()
        {
            AgendaEntities agenda = new AgendaEntities();
            int Id = int.Parse(codigoUsuario);
            var ds = from c in agenda.Contatos
                     where c.UsuarioId == Id
                     select new
                     {
                         c.Id,
                         c.Nome,
                         c.Cpf,
                         c.Telefone,
                         c.Email,
                         c.Site
                     };

            GridViewContatos.DataSource = ds;
            GridViewContatos.DataBind();
        }

        public void LimpaFormulario()
        {
            labelIdContato.Text = "";
            textoNome.Text = "";
            textoCPF.Text = "";
            textoTelefone.Text = "";
            textoEmail.Text = "";
            textoSite.Text = "";
        }

        public void LimpaMsgErro()
        {
            LabelErroNome.Text = "";
            LabelErroCpf.Text = "";
            LabelErroEmail.Text = "";
        }

        protected void btLimpar_Click(object sender, EventArgs e)
        {
            LimpaFormulario();
        }

        protected void btIncluir_Click(object sender, EventArgs e)
        {
            Validacao validacao = new Validacao();
            bool submit = true;

            LimpaMsgErro();

            if (textoNome.Text == "")
            {
                LabelErroNome.Text = "Nome deve ser preenchido!";
                submit = false;
            }

            if (!validacao.ValidaCpf(textoCPF.Text))
            {
                LabelErroCpf.Text = "CPF Inválido!";
                submit = false;
            }

            if (!validacao.validaEmail(textoEmail.Text))
            {
                LabelErroEmail.Text = "Formato de Email Invalido!";
                submit = false;
            }

            if (submit)
            {
                AgendaEntities agenda = new AgendaEntities();
                Contatos contatos = new Contatos();

                contatos.UsuarioId = int.Parse(codigoUsuario);
                contatos.Nome = textoNome.Text;
                contatos.Cpf = textoCPF.Text;
                contatos.Telefone = textoTelefone.Text;
                contatos.Email = textoEmail.Text;
                contatos.Site = textoSite.Text;

                agenda.AddToContatos(contatos);
                agenda.SaveChanges();

                ConsultaContatos();
                LimpaFormulario();
            }

        }

        protected void btAlterar_Click(object sender, EventArgs e)
        {
            if (labelIdContato.Text != "")
            {
                AgendaEntities agenda = new AgendaEntities();
                Contatos contatos = new Contatos();
                int Id = int.Parse(labelIdContato.Text);

                contatos = agenda.Contatos.Where(c => c.Id == Id).First();

                contatos.Id = int.Parse(labelIdContato.Text);
                contatos.UsuarioId = int.Parse(codigoUsuario);
                contatos.Nome = textoNome.Text;
                contatos.Cpf = textoCPF.Text;
                contatos.Telefone = textoTelefone.Text;
                contatos.Email = textoEmail.Text;
                contatos.Site = textoSite.Text;

                agenda.ApplyCurrentValues("Contatos", contatos);
                agenda.SaveChanges();

                ConsultaContatos();
                LimpaFormulario();
            }
        }

        protected void btExcluir_Click(object sender, EventArgs e)
        {
            if (labelIdContato.Text != "")
            {
                AgendaEntities agenda = new AgendaEntities();
                Contatos contatos = new Contatos();
                int Id = int.Parse(labelIdContato.Text);

                contatos = agenda.Contatos.Where(c => c.Id == Id).First();

                agenda.DeleteObject(contatos);
                agenda.SaveChanges();

                ConsultaContatos();
                LimpaFormulario();
            }
        }

        protected void GridViewContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpaMsgErro();
            labelIdContato.Text = Context.Server.HtmlDecode(GridViewContatos.SelectedRow.Cells[0].Text);
            textoNome.Text = Context.Server.HtmlDecode(GridViewContatos.SelectedRow.Cells[1].Text);
            textoCPF.Text = Context.Server.HtmlDecode(GridViewContatos.SelectedRow.Cells[2].Text);
            textoTelefone.Text = Context.Server.HtmlDecode(GridViewContatos.SelectedRow.Cells[3].Text);
            textoEmail.Text = Context.Server.HtmlDecode(GridViewContatos.SelectedRow.Cells[4].Text);
            textoSite.Text = Context.Server.HtmlDecode(GridViewContatos.SelectedRow.Cells[5].Text);
        }
    }
}