<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manager.Master" AutoEventWireup="true" CodeBehind="AddStaff.aspx.cs" Inherits="Care_Website.Manager.AddStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="css/style.css" rel="stylesheet" />

      <div style="margin-left:25%;padding:1px 16px;height:10px;">
          <br />
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
          <asp:CompareValidator ID="lblCompareEmail" runat="server" ErrorMessage="Re-enter Email Address"></asp:CompareValidator>
         <%-- <asp:Label ID="lblConfirmEmail" runat="server" Text=""></asp:Label>--%><br /><asp:TextBox ID="txtConfirmEmail" runat="server"></asp:TextBox>
          <br />
          <br />
          <asp:Label ID="lblRegPassword" runat="server" Text="Password"></asp:Label><br /><asp:TextBox ID="txtRegPassword" runat="server"></asp:TextBox>
           <br />
          <br />
          <asp:CompareValidator ID="lblCompareRegPasword" runat="server" ErrorMessage="Re-enter Password"></asp:CompareValidator>
          <%--<asp:Label ID="lblRegConfirmPassword" runat="server" Text="Confirm Password"></asp:Label>--%><br /><asp:TextBox ID="txtRegConfirmPassword" runat="server"></asp:TextBox>
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
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnClear" runat="server" Text="Clear" />      &nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Add Staff" OnClick="btnSubmit_Click" />
    </div>

</asp:Content>
