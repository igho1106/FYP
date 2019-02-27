<%@ Page Title="" Language="C#" MasterPageFile="~/Caregiver/Care.Master" AutoEventWireup="true" CodeBehind="AddNote.aspx.cs" Inherits="Care_Website.Caregiver.AddNote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #Text1 {
            height: 132px;
            width: 344px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin-left:25%;padding:1px 16px;height:1000px;">

        <h1>New Care Note</h1>

        <asp:Label ID="Label1" runat="server" Text="Select client name from list to begin"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="111px" Width="204px"></asp:ListBox>

        <br />
        <input id="Text1" type="text" />
        <br />

        <asp:Button ID="Button1" runat="server" Text="Submit" />
    </div>

        
    
</asp:Content>
