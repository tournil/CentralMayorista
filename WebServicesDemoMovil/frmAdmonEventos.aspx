<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAdmonEventos.aspx.cs" Inherits="WebServicesDemoMovil.frmAdmonEventos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="IdEvento" DataSourceID="dsEventos" EnableModelValidation="True">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="IdEvento" HeaderText="IdEvento" 
                    InsertVisible="False" ReadOnly="True" SortExpression="IdEvento" />
                <asp:BoundField DataField="dtmFechaEvento" HeaderText="dtmFechaEvento" 
                    SortExpression="dtmFechaEvento" />
                <asp:BoundField DataField="strNombreEvento" HeaderText="strNombreEvento" 
                    SortExpression="strNombreEvento" />
                <asp:BoundField DataField="strDescripcionEvento" 
                    HeaderText="strDescripcionEvento" SortExpression="strDescripcionEvento" />
                <asp:BoundField DataField="strUrlEvento" HeaderText="strUrlEvento" 
                    SortExpression="strUrlEvento" />
                <asp:BoundField DataField="strUrlImagenEvento" HeaderText="strUrlImagenEvento" 
                    SortExpression="strUrlImagenEvento" />
                <asp:CheckBoxField DataField="LogActivo" HeaderText="LogActivo" 
                    SortExpression="LogActivo" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="dsEventos" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            DeleteCommand="DELETE FROM [tblCMAEvento] WHERE [IdEvento] = @IdEvento" 
            InsertCommand="INSERT INTO [tblCMAEvento] ([dtmFechaEvento], [strNombreEvento], [strDescripcionEvento], [strUrlEvento], [strUrlImagenEvento], [LogActivo]) VALUES (@dtmFechaEvento, @strNombreEvento, @strDescripcionEvento, @strUrlEvento, @strUrlImagenEvento, @LogActivo)" 
            SelectCommand="SELECT * FROM [tblCMAEvento]" 
            UpdateCommand="UPDATE [tblCMAEvento] SET [dtmFechaEvento] = @dtmFechaEvento, [strNombreEvento] = @strNombreEvento, [strDescripcionEvento] = @strDescripcionEvento, [strUrlEvento] = @strUrlEvento, [strUrlImagenEvento] = @strUrlImagenEvento, [LogActivo] = @LogActivo WHERE [IdEvento] = @IdEvento">
            <DeleteParameters>
                <asp:Parameter Name="IdEvento" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="dtmFechaEvento" Type="String" />
                <asp:Parameter Name="strNombreEvento" Type="String" />
                <asp:Parameter Name="strDescripcionEvento" Type="String" />
                <asp:Parameter Name="strUrlEvento" Type="String" />
                <asp:Parameter Name="strUrlImagenEvento" Type="String" />
                <asp:Parameter Name="LogActivo" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="dtmFechaEvento" Type="String" />
                <asp:Parameter Name="strNombreEvento" Type="String" />
                <asp:Parameter Name="strDescripcionEvento" Type="String" />
                <asp:Parameter Name="strUrlEvento" Type="String" />
                <asp:Parameter Name="strUrlImagenEvento" Type="String" />
                <asp:Parameter Name="LogActivo" Type="Boolean" />
                <asp:Parameter Name="IdEvento" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Nuevo evento</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
