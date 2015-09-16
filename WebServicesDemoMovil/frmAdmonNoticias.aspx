<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAdmonNoticias.aspx.cs" Inherits="WebServicesDemoMovil.frmAdmonNoticias" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="dtgNoticias" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="IdNoticia" DataSourceID="dsNoticias" EnableModelValidation="True">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="IdNoticia" HeaderText="IdNoticia" 
                    InsertVisible="False" ReadOnly="True" SortExpression="IdNoticia" />
                <asp:BoundField DataField="strImagenNoticia" HeaderText="strImagenNoticia" 
                    SortExpression="strImagenNoticia" />
                <asp:BoundField DataField="strTituloNoticia" HeaderText="strTituloNoticia" 
                    SortExpression="strTituloNoticia" />
                <asp:BoundField DataField="strDetalleNoticia" HeaderText="strDetalleNoticia" 
                    SortExpression="strDetalleNoticia" />
                <asp:CheckBoxField DataField="logActiva" HeaderText="logActiva" 
                    SortExpression="logActiva" />
                <asp:CheckBoxField DataField="logNoticiaPpal" HeaderText="logNoticiaPpal" 
                    SortExpression="logNoticiaPpal" />
                <asp:BoundField DataField="dtmFechaPublicacion" 
                    HeaderText="dtmFechaPublicacion" SortExpression="dtmFechaPublicacion" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dsNoticias" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            DeleteCommand="DELETE FROM [tblCMANoticia] WHERE [IdNoticia] = @IdNoticia" 
            InsertCommand="INSERT INTO [tblCMANoticia] ([strImagenNoticia], [strTituloNoticia], [strDetalleNoticia], [logActiva], [logNoticiaPpal], [dtmFechaPublicacion]) VALUES (@strImagenNoticia, @strTituloNoticia, @strDetalleNoticia, @logActiva, @logNoticiaPpal, @dtmFechaPublicacion)" 
            SelectCommand="SELECT * FROM [tblCMANoticia] ORDER BY [dtmFechaPublicacion] DESC" 
            UpdateCommand="UPDATE [tblCMANoticia] SET [strImagenNoticia] = @strImagenNoticia, [strTituloNoticia] = @strTituloNoticia, [strDetalleNoticia] = @strDetalleNoticia, [logActiva] = @logActiva, [logNoticiaPpal] = @logNoticiaPpal, [dtmFechaPublicacion] = @dtmFechaPublicacion WHERE [IdNoticia] = @IdNoticia">
            <DeleteParameters>
                <asp:Parameter Name="IdNoticia" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="strImagenNoticia" Type="String" />
                <asp:Parameter Name="strTituloNoticia" Type="String" />
                <asp:Parameter Name="strDetalleNoticia" Type="String" />
                <asp:Parameter Name="logActiva" Type="Boolean" />
                <asp:Parameter Name="logNoticiaPpal" Type="Boolean" />
                <asp:Parameter Name="dtmFechaPublicacion" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="strImagenNoticia" Type="String" />
                <asp:Parameter Name="strTituloNoticia" Type="String" />
                <asp:Parameter Name="strDetalleNoticia" Type="String" />
                <asp:Parameter Name="logActiva" Type="Boolean" />
                <asp:Parameter Name="logNoticiaPpal" Type="Boolean" />
                <asp:Parameter Name="dtmFechaPublicacion" Type="DateTime" />
                <asp:Parameter Name="IdNoticia" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Nueva</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
