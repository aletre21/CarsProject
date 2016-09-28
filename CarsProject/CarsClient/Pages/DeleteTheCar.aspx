<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteTheCar.aspx.cs" Inherits="CarsClient.DeleteTheCar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<%@Register Src="~/Pages/CarInfo.ascx" TagName="CarDL" TagPrefix="UC" %>
<br />
    <br />
    <h2>Delete the Car</h2>
    <br />
    <br />
     <UC:CarDL id="CarDL" runat="server" />

    <br />
    <br />

   
     <asp:button runat="server" OnClick="DeleteCar_Click" Text="Delete" Width="175px"></asp:button>
    <br />
    <br />
    <asp:label runat="server" ID="cInfo"/>
</asp:Content>



    

    