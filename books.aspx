<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="books.aspx.cs" Inherits="WebApplication3.books" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div style="float:left; display:block">
                <asp:Literal runat="server" ID="divImages"></asp:Literal>
            </div>            
            <asp:DataList runat="server" ID="DL_Writers" RepeatDirection="Vertical" RepeatColumns="4">
                <ItemStyle VerticalAlign="Top" HorizontalAlign="Center" />
                <ItemTemplate>
                    <div style="padding: 10px 10px 5px 10px;">
                        <asp:Image ImageUrl='<%# DataBinder.Eval(Container.DataItem, "IMageUrl").ToString() %>'
                            runat="server" ID="ImgProfile" Style="border: 3px solid grey; max-height: 250px" />
                    </div>

                </ItemTemplate>
            </asp:DataList>

            <asp:GridView ID="GridBooks" runat="server" AutoGenerateColumns="false" Visible="false">
                <Columns>
                    <asp:TemplateField HeaderText="Preview Image">
                        <ItemTemplate>
                            <asp:Image ID="ImageButton1" runat="server" ImageUrl='<%# Eval("ImageUrl")%>'
                                Height="250px" Style="cursor: pointer" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
