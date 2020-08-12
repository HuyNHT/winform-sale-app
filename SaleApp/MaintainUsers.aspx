<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaintainUsers.aspx.cs" Inherits="SaleApp.MaintainUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            User name&nbsp;
            <asp:TextBox ID="txtUserName" runat="server" Width="147px"></asp:TextBox>
            <br />
            Password
            <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 8px" Width="143px"></asp:TextBox>
            <br />
            BirthDate&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtBirthDate" runat="server" Width="141px"></asp:TextBox>
            <br />
            Address&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server" Width="143px"></asp:TextBox>
            <br />
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server" Width="147px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <br />
            <br />
            <asp:GridView ID="gvUserInfoList" runat="server" Width="262px" AutoGenerateSelectButton="True" OnSelectedIndexChanging="gvUserInfoList_SelectedIndexChanging">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
