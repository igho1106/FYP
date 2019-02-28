<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manager.Master" AutoEventWireup="true" CodeBehind="UserManager.aspx.cs" Inherits="Care_Website.Manager.UserManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <link href="css/style.css" rel="stylesheet" />
    <div style="margin-left:25%;padding:1px 16px;height:10px;">
        <h2>Manage User Accounts</h2>
        <br />




            <div class="Row">
    <div style="float:left"><h3><asp:Label ID="Label6" runat="server" Text="Caregivers"></asp:Label></h3>
            <br />
            <asp:ListBox ID="ListBox6" runat="server" Height="119px" Width="206px"></asp:ListBox> </div>
    <div style="float:right"><h3><asp:Label ID="Label5" runat="server" Text="Staffs"></asp:Label></h3>
         <br />
         <asp:ListBox ID="ListBox5" runat="server" Height="118px" Width="206px"></asp:ListBox></div>
    <div style="margin-left:600px"><h3><asp:Label ID="Label4" runat="server" Text="Clients"></asp:Label></h3>
         <br />
         <asp:ListBox ID="ListBox4" runat="server" Height="118px" Width="206px"></asp:ListBox></div>


               
</div>




</div>
</asp:Content>


