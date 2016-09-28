<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNewCar.aspx.cs" Inherits="CarsClient.Contact" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       <br />
    <br />
    <h2>Add new car</h2>
    <br />
    <br />
      <label>Owner:</label><br /><asp:DropDownList ID="DropDownListOwnerToSelect" runat="server" Height="30px" Width="176px"></asp:DropDownList> 
          <br />
        <br />
      <label>Brand:</label><br /><input type="text" runat="server" ID="carBrand"/>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="This field cannot be empty" ControlToValidate="carBrand"></asp:RequiredFieldValidator><br />
    <asp:RegularExpressionValidator ID="string1" runat="server" ControlToValidate="carBrand" ErrorMessage="Write correct brand" ValidationExpression="([a-zA-Z]{2,20}\s*)+"  ValidationGroup="string"> </asp:RegularExpressionValidator><br />
      <label>Model:</label><br /><input type="text" runat="server" ID="carModel"/>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" ErrorMessage="This field cannot be empty" ControlToValidate="carModel"></asp:RequiredFieldValidator><br />
     
    <br /> <label>KM:</label><br /><input type="number" runat="server" ID="carKM"/>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator41" runat="server" ErrorMessage="This field cannot be empty" ControlToValidate="carKM"></asp:RequiredFieldValidator><br />
    <asp:RangeValidator ID="RangeValidator11" runat="server" ControlToValidate="carKM" MaximumValue="900"
                        MinimumValue="25" Type="Integer"  ErrorMessage ="Select value from 25 to 900"></asp:RangeValidator>
     <br />
    <br />
         
    <asp:button id="addCar" OnClick="AddCar_Click" runat="server"   Text="Add" Width="176px"  ></asp:button>
     <br />
    <br />
    <asp:label runat="server" ID="info"></asp:label>
</asp:Content>
