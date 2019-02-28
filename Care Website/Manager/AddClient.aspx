<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manager.Master" AutoEventWireup="true" CodeBehind="AddClient.aspx.cs" Inherits="Care_Website.Manager.AddClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="css/style.css" rel="stylesheet" />
    <div style="margin-left:25%;padding:1px 16px;height:10px;">
          <br />
          <br />
          <h2>Enter new staff details</h2>
        <br />
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label><br /><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label><br /><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email Address"></asp:Label><br /><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
          <asp:Label ID="Label8" runat="server" Text="Confirm Email Address"></asp:Label><br /><asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
          <br />
          <br />
          <asp:Label ID="Label9" runat="server" Text="Password"></asp:Label><br /><asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
           <br />
          <br />
          <asp:Label ID="Label10" runat="server" Text="Confirm Password"></asp:Label><br /><asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
          <br />
          <br />

        <asp:Label ID="Label4" runat="server" Text="Home Address"></asp:Label><br /><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label><br /><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="Label6" runat="server" Text="Phone Number"></asp:Label><br /><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label><br /><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Clear" />      &nbsp;<asp:Button ID="Button2" runat="server" Text="Submit" />
    </div>

</asp:Content>
