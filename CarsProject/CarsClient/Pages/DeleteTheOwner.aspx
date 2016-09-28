<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteTheOwner.aspx.cs" Inherits="CarsClient.DeleteTheOwner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%@Register TagName="OwnerDL" TagPrefix="UC" Src="~/Pages/OwnerInfo.ascx" %>
    <br />
    <br />
    <h2>Delete the Owner</h2>
    <br />
    <br />
    <asp:DropDownList ID="OwnerToDeleteDropDownList" runat="server" Height="30px" Width="175px" OnSelectedIndexChanged="RefreshOwner_Click" AutoPostBack="true">
    </asp:DropDownList>
     <br />
    <br />
   
 
    <UC:OwnerDL id="OwnerDL" runat="server" />

    <br />
    <br />

   
     <asp:button runat="server" OnClick="DeleteOwner_Click" Text="Delete" Width="175px"></asp:button>
    <br />
    <br />
    <asp:label runat="server" ID="oInfo"/>
</asp:Content>
