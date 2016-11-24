<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contatos.aspx.cs" Inherits="agenda_wf_ef.Contatos1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 107px;
        }
        .style3
        {
            width: 307px;
        }
        .MsgErro
        {
            color: Red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Contatos
    </h2>
    <p>
        Visualize, Crie, Altere e Exclua Contatos.
    </p>
    <table class="style1">
        <tr>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="Id:"></asp:Label>
            </td>
            <td class="style3">
                <asp:Label ID="labelIdContato" runat="server"></asp:Label>
            </td>
            <td>
            
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label3" runat="server" Text="Nome:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="textoNome" runat="server" Width="300px" CssClass="txtNome"></asp:TextBox>
            </td>
            <td>
            
                <asp:Label ID="LabelErroNome" runat="server" CssClass="MsgErro"></asp:Label>
            
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label4" runat="server" Text="CPF:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="textoCPF" runat="server" Width="150px" CssClass="txtCpf"></asp:TextBox>
            </td>
            <td>
            
                <asp:Label ID="LabelErroCpf" runat="server" CssClass="MsgErro"></asp:Label>
            
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label5" runat="server" Text="Telefone"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="textoTelefone" runat="server" Width="150px" CssClass="txtTelefone"></asp:TextBox>
            </td>
            <td>
            
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label6" runat="server" Text="E-mail:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="textoEmail" runat="server" Width="150px" CssClass="txtEmail"></asp:TextBox>
            </td>
            <td>
            
                <asp:Label ID="LabelErroEmail" runat="server" CssClass="MsgErro"></asp:Label>
            
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label7" runat="server" Text="Site:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="textoSite" runat="server" Width="150px" CssClass="txtSite"></asp:TextBox>
            </td>
            <td>
            
            </td>
        </tr>
    </table>
    <asp:Button ID="btIncluir" runat="server" Text="Incluir" Width="76px" CssClass="incluir"
        onclick="btIncluir_Click" />
    <asp:Button ID="btAlterar" runat="server" Text="Alterar" Width="75px"  CssClass="alterar"
        onclick="btAlterar_Click" />
    <asp:Button ID="btExcluir" runat="server" Text="Excluir" Width="75px"  CssClass="excluir"
        onclick="btExcluir_Click" />
    <asp:Button ID="btLimpar" runat="server" onclick="btLimpar_Click" Text="Limpar" 
        Width="75px" />

    <p>
        <asp:GridView ID="GridViewContatos" runat="server" 
            onselectedindexchanged="GridViewContatos_SelectedIndexChanged" 
            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
            GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField Datafield="Id" HeaderText="Código" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="Cpf" HeaderText="CPF" />
                <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                <asp:BoundField DataField="Email" HeaderText="E-mail" />
                <asp:BoundField DataField="Site" HeaderText="Site" />
                <asp:CommandField SelectText="Editar" HeaderText="Operação" ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </p>
</asp:Content>
