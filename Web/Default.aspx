<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <%--<h1>COCOA </h1>--%>
                <h2>Sistema de Cotizaciones y Ordenes de Compra Automayor</h2>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
     <div style="width:50%; float:left;">
    <h3>Opciones:</h3>
    <ol class="round">
        <li class="one">
            <h5>Maestras</h5>
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Administrador/Capacidad de Carga.aspx">Capacidad de Carga</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton2" runat="server">Cilindrajes</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton3" runat="server">Ciudades</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton4" runat="server">Clase</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="~/Cotizaciones/Clientes.aspx">Clientes</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton6" runat="server">Impoconsumo</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton7" runat="server">Intervalo de Precio</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton8" runat="server">Impoconsumo</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton9" runat="server">IVA</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton10" runat="server">Número de Pasajeros</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton11" runat="server">Productos</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton12" runat="server" PostBackUrl="~/Orden de Compra/Proveedores.aspx">Proveedores</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton13" runat="server">Segmentos</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton14" runat="server">Tipo de Vehículo</asp:LinkButton><br />
        </li>
        <li class="two">
            <h5>Transacciones</h5>
            <asp:LinkButton ID="LinkButton15" runat="server">Cotizaciones</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton16" runat="server">Ordenes de Compra</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton17" runat="server">Editar Cotizaciones</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton18" runat="server">Editar Orden de Compra</asp:LinkButton><br />
        </li>
        </div>
    <ol class="round">
     <div style="width:50%; float:left;">
        <li class="three">
            <h5>Consultas</h5>
            <asp:LinkButton ID="LinkButton19" runat="server">Cotizaciones</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton20" runat="server">Ordenes de Compra</asp:LinkButton><br />
        </li>
        <li class="four">
            <h5>Reportes</h5>
            <asp:LinkButton ID="LinkButton21" runat="server">Cotización Marisol Ibagón</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton22" runat="server">Cotización Edgar Sierra</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton25" runat="server">Cotizacion Sin Clasificacion</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton23" runat="server">Orden de Compra Marisol Ibagón</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton24" runat="server">Orden de compra Edgar Sierra</asp:LinkButton><br />
        </li>
        <li class="five">
            <h5>Listados</h5>
            <asp:LinkButton ID="LinkButton27" runat="server">Clientes</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton28" runat="server">Cotizaciones</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton26" runat="server">Ordenes de Compra</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton29" runat="server">Productos</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton30" runat="server">Proveedores</asp:LinkButton><br />
        </li>
         </div>
    </ol>
</asp:Content>
