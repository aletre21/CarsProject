<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckOwner.aspx.cs" Inherits="CarsClient.About" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <h2>Check the Owner</h2>
    <br />
    <br />
    <asp:DropDownList ID="DropDownListOwnerToCheck" runat="server" OnSelectedIndexChanged="CheckCars"  Width="230px"  AutoPostBack="true" Height="23px">
        
        </asp:DropDownList>
       <br />
    <br />
    <h2>Cars:</h2>
   <br />
    <br />
    <asp:DataList ID="DataListCarsFromSelectedOwner" runat="server" RepeatLayout="Table">
       <HeaderTemplate>
<table style="border-style:solid; border-width:1px" >
<tr style="border-style:solid; border-width:1px">
<th style="padding:10px; border-style:solid; border-width:1px">ID</th>
<th style="padding:10px; border-style:solid; border-width:1px">Brand</th>
    <th style="padding:10px; border-style:solid; border-width:1px">Model</th>
    <th style="padding:10px; border-style:solid; border-width:1px">KM</th>
</tr>
</HeaderTemplate>
        <ItemTemplate>
            <tr>
       <td style="padding:10px; border-style:solid; border-width:1px"><%#DataBinder.Eval(Container.DataItem,"DisplayFieldCarId") %></td> 
   <td style="padding:10px; border-style:solid; border-width:1px"><%#DataBinder.Eval(Container.DataItem,"DisplayFieldCarBrand") %></td> 
   <td style="padding:10px; border-style:solid; border-width:1px"><%#DataBinder.Eval(Container.DataItem,"DisplayFieldCarModel") %></td> 
   <td style="padding:10px; border-style:solid; border-width:1px"><%#DataBinder.Eval(Container.DataItem,"DisplayFieldCarKM") %></td> 
  
           </tr>
        </ItemTemplate>

    </asp:DataList>

    <br />
    <br />
     
</asp:Content>
