<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Userprofile.aspx.cs" Inherits="Three_layer.Userprofile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Age</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Address</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>photo</td>
                <td>
                    <asp:Image ID="Image1" runat="server" Height="144px" Width="178px" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="name" HeaderText="Name" />
                            <asp:BoundField DataField="age" HeaderText="Age" />
                            <asp:BoundField DataField="address" HeaderText="address" />
                            <asp:ImageField DataImageUrlField="photo" HeaderText="Photo">
                                <ControlStyle Height="200px" Width="200px" />
                            </asp:ImageField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:DataList ID="DataList1" runat="server">
                        <ItemTemplate>
                            <table class="auto-style1">
                                <tr>
                                    <td>Name</td>
                                    <td>Age</td>
                                    <td>Address</td>
                                    <td>photo</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Eval("name") %>'></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Eval("age") %>'></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Eval("address") %>'></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("photo") %>' />
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
