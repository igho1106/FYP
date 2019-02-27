<%@ Page Title="" Language="C#" MasterPageFile="~/Caregiver/Care.Master" AutoEventWireup="true" CodeBehind="FeedbackInquiry.aspx.cs" Inherits="Care_Website.Caregiver.FeedbackInquiry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin-left:25%;padding:1px 16px;height:1000px;">

        <h1>Enter Feedback</h1>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="192px" Width="296px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" />
</asp:Content>
