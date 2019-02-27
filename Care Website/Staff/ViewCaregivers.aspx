<%@ Page Title="" Language="C#" MasterPageFile="~/Staff/Staff.Master" AutoEventWireup="true" CodeBehind="ViewCaregivers.aspx.cs" Inherits="Care_Website.Staff.ViewCaregivers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div style="margin-left:25%;padding:1px 16px;height:1000px;">

            <h2>Caregivers List</h2>
            <asp:ListBox ID="ListBox1" runat="server" Height="234px" Width="322px"></asp:ListBox>
        </div>
</asp:Content>
