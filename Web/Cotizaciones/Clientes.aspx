<%@ Page Title="Clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Web.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">   
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 184px;
        }
        .auto-style3 {
            width: 172px;
        }
        .auto-style4 {
            width: 15px;
        }
        .auto-style5 {
            width: 184px;
            height: 58px;
        }
        .auto-style6 {
            width: 15px;
            height: 58px;
        }
        .auto-style7 {
            width: 172px;
            height: 58px;
        }
        .auto-style8 {
            height: 58px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Clientes</h2>
    <table class="auto-style1">
        <tr>
            <td class="auto-style5" style="text-align: right; font-weight: bold;">Nit:</td>
            <td class="auto-style6">
                <asp:TextBox ID="nitTextBox" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td class="auto-style7" style="text-align: right; font-weight: bold;">Activo:</td>
            <td class="auto-style8">
                <asp:CheckBox ID="activoCheckBox" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; font-weight: bold;">Nombre Cliente:</td>
            <td colspan="3">
                <asp:TextBox ID="nombreClienteTextBox" runat="server" Width="701px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; font-weight: bold;">Nombre Contacto:</td>
            <td colspan="3">
                <asp:TextBox ID="nombreContactoTextBox" runat="server" Width="701px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; font-weight: bold;">Dirección:</td>
            <td colspan="3">
                <asp:TextBox ID="direccionTextBox" runat="server" Width="701px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; font-weight: bold;">Email:</td>
            <td colspan="3">
                <asp:TextBox ID="emailTextBox" runat="server" Width="701px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; font-weight: bold;">Teléfono 1</td>
            <td class="auto-style4">
                <asp:TextBox ID="telefono1TextBox" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td class="auto-style3" style="text-align: right; font-weight: bold;">Teléfono 2:</td>
            <td>
                <asp:TextBox ID="telefono2TextBox" runat="server" Width="150px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; font-weight: bold;">Ciudad:</td>
            <td class="auto-style4">
                <asp:DropDownList ID="ciudadDropDownList" runat="server" DataSourceID="ciudadSqlDataSource" DataTextField="DescripcionCiudad" DataValueField="IdCiudad">
                </asp:DropDownList>
            </td>
            <td class="auto-style3" style="text-align: right; font-weight: bold;">Celular:</td>
            <td>
                <asp:TextBox ID="celularTextBox" runat="server" Width="150px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right; font-weight: bold;">Notas:</td>
            <td colspan="3">
                <asp:TextBox ID="notasTextBox" runat="server" Height="76px" TextMode="MultiLine" Width="701px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <center><p>
        <asp:Button ID="consultarButton" runat="server" Text="Consultar" OnClick="consultarButton_Click" />
        <asp:Button ID="modificarButton" runat="server" Text="Editar" OnClick="modificarButton_Click" />
        <asp:Button ID="eliminarButton" runat="server" Text="Eliminar" OnClick="eliminarButton_Click" OnClientClick ="return confirm('¿Seguro eliminar registro?')" />
        <asp:Button ID="crearButton" runat="server" Text="Crear" OnClick="nuevoButton_Click" />
        <asp:Button ID="nuevoButton" runat="server" Text="Nuevo" OnClick="NuevoButton_Click" />
    </p></center>
    <p>
        <center><asp:Label ID="mensajeLabel" runat="server" Text="" style="font-weight: 700; color: #CC0000"></asp:Label></center>
    </p>
    <p>
        <asp:GridView ID="clientesGridView" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdCliente" DataSourceID="clientesSqlDataSource" EmptyDataText="No hay registros de datos para mostrar." ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="IdCliente" HeaderText="Id" ReadOnly="True" SortExpression="IdCliente" />
                <asp:BoundField DataField="Nit" HeaderText="Nit" SortExpression="Nit" />
                <asp:BoundField DataField="NombreCliente" HeaderText="Nombre Cliente" SortExpression="NombreCliente" />
                <asp:BoundField DataField="NombreContacto" HeaderText="Nombre Contacto" SortExpression="NombreContacto" Visible="False" />
                <asp:BoundField DataField="Direccion" HeaderText="Dirección" SortExpression="Direccion" Visible="False" />
                <asp:TemplateField HeaderText="Ciudad" SortExpression="IdCiudad">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ciudadSqlDataSource" DataTextField="DescripcionCiudad" DataValueField="IdCiudad" SelectedValue='<%# Bind("IdCiudad") %>'>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ciudadSqlDataSource" DataTextField="DescripcionCiudad" DataValueField="IdCiudad" Enabled="False" SelectedValue='<%# Bind("IdCiudad") %>'>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Telefono1" HeaderText="Teléfono" SortExpression="Telefono1" />
                <asp:BoundField DataField="Telefono2" HeaderText="Teléfono 2" SortExpression="Telefono2" Visible="False" />
                <asp:BoundField DataField="Celular" HeaderText="Celular" SortExpression="Celular" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Notas" HeaderText="Notas" SortExpression="Notas" Visible="False" />
                <asp:CheckBoxField DataField="Activo" HeaderText="Activo" SortExpression="Activo" />
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
        <asp:SqlDataSource ID="clientesSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:COCOA %>" DeleteCommand="DELETE FROM [Clientes] WHERE [IdCliente] = @IdCliente" InsertCommand="INSERT INTO [Clientes] ([Nit], [NombreCliente], [NombreContacto], [Direccion], [IdCiudad], [Telefono1], [Telefono2], [Celular], [Email], [Notas], [Activo]) VALUES (@Nit, @NombreCliente, @NombreContacto, @Direccion, @IdCiudad, @Telefono1, @Telefono2, @Celular, @Email, @Notas, @Activo)" ProviderName="<%$ ConnectionStrings:COCOA.ProviderName %>" SelectCommand="SELECT [IdCliente], [Nit], [NombreCliente], [NombreContacto], [Direccion], [IdCiudad], [Telefono1], [Telefono2], [Celular], [Email], [Notas], [Activo] FROM [Clientes]" UpdateCommand="UPDATE [Clientes] SET [Nit] = @Nit, [NombreCliente] = @NombreCliente, [NombreContacto] = @NombreContacto, [Direccion] = @Direccion, [IdCiudad] = @IdCiudad, [Telefono1] = @Telefono1, [Telefono2] = @Telefono2, [Celular] = @Celular, [Email] = @Email, [Notas] = @Notas, [Activo] = @Activo WHERE [IdCliente] = @IdCliente">
            <DeleteParameters>
                <asp:Parameter Name="IdCliente" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nit" Type="String" />
                <asp:Parameter Name="NombreCliente" Type="String" />
                <asp:Parameter Name="NombreContacto" Type="String" />
                <asp:Parameter Name="Direccion" Type="String" />
                <asp:Parameter Name="IdCiudad" Type="Int32" />
                <asp:Parameter Name="Telefono1" Type="String" />
                <asp:Parameter Name="Telefono2" Type="String" />
                <asp:Parameter Name="Celular" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Notas" Type="String" />
                <asp:Parameter Name="Activo" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nit" Type="String" />
                <asp:Parameter Name="NombreCliente" Type="String" />
                <asp:Parameter Name="NombreContacto" Type="String" />
                <asp:Parameter Name="Direccion" Type="String" />
                <asp:Parameter Name="IdCiudad" Type="Int32" />
                <asp:Parameter Name="Telefono1" Type="String" />
                <asp:Parameter Name="Telefono2" Type="String" />
                <asp:Parameter Name="Celular" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Notas" Type="String" />
                <asp:Parameter Name="Activo" Type="Boolean" />
                <asp:Parameter Name="IdCliente" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="ciudadSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:COCOA %>" SelectCommand="select IdCiudad,DescripcionCiudad from 
Ciudades
union
select 0,'[Seleccione Ciudad]'
Order by 2"></asp:SqlDataSource>
    </p>
</asp:Content>
