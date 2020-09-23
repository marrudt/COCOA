<%@ Page Title="Capacidad de Carga" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Capacidad de Carga.aspx.cs" Inherits="Web.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 58%;
        }
        .auto-style2 {
            font-size: small;
        }
        .auto-style3 {
            width: 83px;
        }
        .auto-style4 {
            width: 250px;
        }
        .auto-style5 {
            width: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Capacidad de Carga</h1>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3"><strong><span class="auto-style2">Descripción</span></strong>:</td>
            <td class="auto-style4">
                <asp:TextBox ID="descripcionTextBox" runat="server" Width="254px" Font-Size="Small" ForeColor="#333333"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <strong>Activo</strong>:</td>
            <td>
                <asp:CheckBox ID="activoCheckBox" runat="server" />
            </td>
            <td>
    <asp:Button ID="nuevoButton" runat="server" Text="Agregar" Height="32px" OnClick="nuevoButton_Click" />
            </td>
        </tr>
    </table>
    <br />
    <asp:Label ID="mensajeLabel" runat="server" Text="" style="font-weight: 700; color: #CC0000"></asp:Label>
    <asp:GridView ID="CapacidadCargaGridview" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdPesoBrutoVh" DataSourceID="SqlDataSource1" EmptyDataText="No hay registros de datos para mostrar." Font-Bold="True" Font-Size="Small" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="IdPesoBrutoVh" HeaderText="Id" ReadOnly="True" SortExpression="IdPesoBrutoVh">
            <ControlStyle Font-Size="Small" />
            <HeaderStyle Font-Bold="True" Font-Size="Small" />
            </asp:BoundField>
            <asp:BoundField DataField="DescripcionPesoBrutoVh" HeaderText="Descripción" SortExpression="DescripcionPesoBrutoVh">
            <ControlStyle Font-Size="Small" ForeColor="#333333" />
            <HeaderStyle Font-Size="Small" />
            </asp:BoundField>
            <asp:CheckBoxField DataField="Activo" HeaderText="Activo" SortExpression="Activo">
            <HeaderStyle Font-Size="Small" />
            </asp:CheckBoxField>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:Button ID="Button1" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar" />
                    &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandName="Edit" Text="Modificar" />
                    &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="Delete" Text="Borrar" 
                        OnClientClick="return confirm('¿Seguro de Borrar el registro?')"/>
                </ItemTemplate>
                <ControlStyle Font-Size="Small" />
                <FooterStyle Font-Size="Small" />
                <HeaderStyle Font-Size="Small" />
                <ItemStyle Font-Size="Small" />
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" Font-Bold="False" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" Font-Bold="False" Font-Size="Small" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="False" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <h1>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:COCOA %>" DeleteCommand="DELETE FROM [PesoBrutoVh] WHERE [IdPesoBrutoVh] = @IdPesoBrutoVh" InsertCommand="INSERT INTO [PesoBrutoVh] ([DescripcionPesoBrutoVh], [Activo]) VALUES (@DescripcionPesoBrutoVh, @Activo)" ProviderName="<%$ ConnectionStrings:COCOA.ProviderName %>" SelectCommand="SELECT [IdPesoBrutoVh], [DescripcionPesoBrutoVh], [Activo] FROM [PesoBrutoVh]" UpdateCommand="UPDATE [PesoBrutoVh] SET [DescripcionPesoBrutoVh] = @DescripcionPesoBrutoVh, [Activo] = @Activo WHERE [IdPesoBrutoVh] = @IdPesoBrutoVh">
            <DeleteParameters>
                <asp:Parameter Name="IdPesoBrutoVh" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="DescripcionPesoBrutoVh" Type="String" />
                <asp:Parameter Name="Activo" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="DescripcionPesoBrutoVh" Type="String" />
                <asp:Parameter Name="Activo" Type="Boolean" />
                <asp:Parameter Name="IdPesoBrutoVh" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </h1>
</asp:Content>
