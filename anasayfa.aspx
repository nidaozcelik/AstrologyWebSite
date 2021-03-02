<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="anasayfa.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            height: 25px;
        }
        .auto-style4 {
            width: 314px;
        }
        .auto-style5 {
            width: 703px;
        }
        .auto-style6 {
            width: 136px;
        }
        .newStyle1 {
            font-family: "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
        color: #FFFFFF;
    }
        .newStyle2 {
            font-family: "Hobo Std";
        }
        .newStyle3 {
            font-family: "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
        }
        .auto-style2 {
            margin-top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style2">
        <tr>
            <td class="auto-style5">
                <table class="auto-style2" style="width: 92%; height: 317px;">
                    <tr>
                        <td class="auto-style4">
                            <asp:Image ID="Image2" runat="server" Height="353px" Width="513px" ImageUrl="~/resimler/12.jpg" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label4" runat="server" Text="Label" CssClass="newStyle3" style="font-style: italic; font-size: x-large; color: #990000"></asp:Label>
                            <br />
                            <br />
                            <asp:Label ID="Label5" runat="server" CssClass="newStyle1" Text="Label"></asp:Label>
                            <br />
                            <br />
                            <br />
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style3" colspan="2">
                            <asp:Label ID="Label1" runat="server" Text="Cinsiyetiniz:"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:RadioButton ID="RadioButton1" AutoPostBack="true" GroupName="ab" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Kadın" />
                            <asp:RadioButton ID="RadioButton2" AutoPostBack="true" GroupName="ab" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Erkek" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="Label2" runat="server" Text="Siz"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Partner"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="250px" Width="105px"  OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                                <asp:ListItem>Koç</asp:ListItem>
                                <asp:ListItem>Boğa</asp:ListItem>
                                <asp:ListItem>İkizler</asp:ListItem>
                                <asp:ListItem>Yengeç</asp:ListItem>
                                <asp:ListItem>Aslan</asp:ListItem>
                                <asp:ListItem>Başak</asp:ListItem>
                                <asp:ListItem>Terazi</asp:ListItem>
                                <asp:ListItem>Akrep</asp:ListItem>
                                <asp:ListItem>Yay</asp:ListItem>
                                <asp:ListItem>Oğlak</asp:ListItem>
                                <asp:ListItem>Kova</asp:ListItem>
                                <asp:ListItem>Balık</asp:ListItem>
                            </asp:ListBox>
                        </td>
                        <td>
                            <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" Height="250px" Width="105px"  OnSelectedIndexChanged="ListBox2_SelectedIndexChanged">
                                <asp:ListItem>Koç</asp:ListItem>
                                <asp:ListItem>Boğa</asp:ListItem>
                                <asp:ListItem>İkizler</asp:ListItem>
                                <asp:ListItem>Yengeç</asp:ListItem>
                                <asp:ListItem>Aslan</asp:ListItem>
                                <asp:ListItem>Başak</asp:ListItem>
                                <asp:ListItem>Terazi</asp:ListItem>
                                <asp:ListItem>Akrep</asp:ListItem>
                                <asp:ListItem>Yay</asp:ListItem>
                                <asp:ListItem>Oğlak</asp:ListItem>
                                <asp:ListItem>Kova</asp:ListItem>
                                <asp:ListItem>Balık</asp:ListItem>
                            </asp:ListBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

