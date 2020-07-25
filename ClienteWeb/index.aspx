<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ClienteWeb.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align:center; color:blue; height: 48px; text-shadow:2px 4px 6px#ff0000;">Empresa Tecnologia WCF</h1>

            <p style="color:blueviolet">Los usuarios pueden ingresar los factores para obtener sus resultados.</p>
        </div>
        <div>
            <h2 style="color:dodgerblue">Resultado:</h2>
             <asp:Label ID="lblResultado" runat="server" Text="0"></asp:Label>
            <br />
            <asp:Label ID="lblAnterior" runat="server" Text="0"></asp:Label>
        </div>
        
        <asp:Button ID="BtnSiete" runat="server" Text="7" Height="51px" Width="49px" OnClick="BtnSiete_Click" />
        <asp:Button ID="BtnOcho" runat="server" Text="8"  Height="51px" Width="49px" OnClick="BtnOcho_Click" />
        <asp:Button ID="BtnNueve" runat="server" Text="9"  Height="51px" Width="49px" OnClick="BtnNueve_Click" /><br />
        <asp:Button ID="BtnCuatro" runat="server" Text="4"  Height="51px" Width="49px" OnClick="BtnCuatro_Click" />
        <asp:Button ID="BtnCinco" runat="server" Text="5"  Height="51px" Width="49px" OnClick="BtnCinco_Click"/>
        <asp:Button ID="BtnSeis" runat="server" Text="6"  Height="51px" Width="49px" OnClick="BtnSeis_Click" /><br />
        <asp:Button ID="BtnTres" runat="server" Text="3"  Height="51px" Width="49px" OnClick="BtnTres_Click" />
        <asp:Button ID="BtnDos" runat="server" Text="2"  Height="51px" Width="49px" OnClick="BtnDos_Click" />
        <asp:Button ID="BtnUno" runat="server" Text="1"  Height="51px" Width="49px" OnClick="BtnUno_Click" /><br />
        <asp:Button ID="BtnCero" runat="server" Text="0"  Height="51px" Width="49px" OnClick="BtnCero_Click" />
        <asp:Button ID="BtnBorrar" runat="server" Text="Borrar"  Height="51px" Width="49px" OnClick="BtnBorrar_Click" />
        <br />
        <asp:Button ID="BtnAdiccion" runat="server" Text="+" Height="51px" Width="49px" OnClick="BtnAdiccion_Click" />
        <asp:Button ID="BtnSustraccion" runat="server" Text="-" Height="51px" Width="49px" OnClick="BtnSustraccion_Click" />
        <br />
        <asp:Button ID="BtnProducto" runat="server" Text="*" Height="51px" Width="49px" OnClick="BtnProducto_Click" />
        <asp:Button ID="BtnDivision" runat="server" Text="/" Height="51px" Width="49px" OnClick="BtnDivision_Click"/>
        <asp:Button ID="btnCalcular" runat="server" Text="="  Height="51px" Width="49px" OnClick="btnCalcular_Click" />
        
    </form>
</body>
</html>
