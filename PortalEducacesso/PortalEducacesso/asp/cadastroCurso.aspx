<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastroCurso.aspx.cs" Inherits="PortalEducacesso.asp.cadastroCurso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/estiloEd1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ul class="lista">
        <li>
            <label for="txtNome">Nome:</label>
            <asp:TextBox ID="txtNome" runat="server" TabIndex="1"></asp:TextBox>
        </li>

        <li>
            <label for="txtDescricao">Descricao:</label>
            <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
        </li>

        <li>
            <label for="selectCateg">Categoria:</label>

            <asp:DropDownList ID="selectCateg" runat="server">
                <asp:ListItem>Linguagem de Programação</asp:ListItem>
                <asp:ListItem>Matematica</asp:ListItem>
            </asp:DropDownList>
        </li>
        <li>
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
        </li>
        </ul>
    </div>
    </form>
</body>
</html>
