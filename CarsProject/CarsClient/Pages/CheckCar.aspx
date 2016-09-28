<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckCar.aspx.cs" Inherits="CarsClient.CheckCar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%@Register Src="~/Pages/CarInfo.ascx" TagName="CarDL" TagPrefix="UC" %>
    <br />
    <br />
    <h2>Check the Car</h2>
    <br />
    <br />
    
   
     <UC:CarDL id="CarDL" runat="server" />

    <br />
    <br />

 
 


</asp:Content>
