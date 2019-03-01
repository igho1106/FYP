<%@ Page Title="" Language="C#" MasterPageFile="~/CareWebsite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Care_Website.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    <link href="Manager/css/style.css" rel="stylesheet" />
    
    <div style="margin-left:25%;padding:1px 16px;height:943px;">

        
  
    <br />
    <br />



    <div class="row">
  
  
  <div  class="column middle">
    <h2 style="margin-left:0px;">Login </h2>
      <P>
      <asp:Label ID="lblUsername" runat="server" Text="User Name"></asp:Label><br /><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
     </P>
      <p>
      <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label><br /><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>  
          </p><br />
      <asp:Button ID="Button3" runat="server" Text="Login" />
</div>
  
  <div class="column side">
    <h2 style="margin-left:0px;">Register </h2>
      
      <br />
          <h2>Enter new staff details</h2>
        <br />
        <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label><br /><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label><br /><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address"></asp:Label><br /><asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
        <br />
        <br />
          <asp:Label ID="lblConfirmEmail" runat="server" Text="Confirm Email Address"></asp:Label><br /><asp:TextBox ID="txtConfirmEmail" runat="server"></asp:TextBox>
          <br />
          <br />
          <asp:Label ID="lblRegPassword" runat="server" Text="Password"></asp:Label><br /><asp:TextBox ID="txtRegPassword" runat="server"></asp:TextBox>
           <br />
          <br />
          <asp:Label ID="lblRegConfirmPassword" runat="server" Text="Confirm Password"></asp:Label><br /><asp:TextBox ID="txtRegConfirmPassword" runat="server"></asp:TextBox>
          <br />
          <br />

        <asp:Label ID="lblHomeAddress" runat="server" Text="Home Address"></asp:Label><br /><asp:TextBox ID="txtHomeAddress" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label><br /><asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number"></asp:Label><br /><asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label><br /><asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnClear" runat="server" Text="Clear" />      &nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Submit" />
  </div>
</div>

</div>



</asp:Content>
