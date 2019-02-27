<%@ Page Title="" Language="C#" MasterPageFile="~/CareWebsite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Care_Website.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    <link href="Manager/css/style.css" rel="stylesheet" />
    
    <div style="margin-left:25%;padding:1px 16px;height:807px;">

        
  
    <br />
    <br />



    <div class="row">
  
  
  <div  class="column middle">
    <h2 style="margin-left:0px;">Login </h2>
      <P>
      <asp:Label ID="Label10" runat="server" Text="User Name"></asp:Label>
      <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
     </P>
      <p>
      <asp:Label ID="Label11" runat="server" Text="Password"></asp:Label>
      <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>  
          </p>
</div>
  
  <div class="column side">
    <h2 style="margin-left:0px;">Register </h2>
      
      <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label><asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Clear" />      &nbsp;<asp:Button ID="Button4" runat="server" Text="Submit" />
   
      
  </div>
</div>

</div>



</asp:Content>
