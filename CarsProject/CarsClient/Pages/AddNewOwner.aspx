<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNewOwner.aspx.cs" Inherits="CarsClient.AddNewOwner" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <br />
    <br />
    <h2>Add new owner</h2>
    <br />
    <br />
    <label>First Name:</label><br /><input type="text" id="fn" runat="server"/>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="This field cannot be empty" ControlToValidate="fn"></asp:RequiredFieldValidator><br />
    <asp:RegularExpressionValidator ID="string" runat="server" ControlToValidate="fn" ErrorMessage="Write correct first name" ValidationExpression="([a-zA-Z]{2,20}\s*)+"  ValidationGroup="string"> </asp:RegularExpressionValidator><br />
    <label>Last Name:</label><br /><input type="text" id="ln" runat="server"/>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="This field cannot be empty" ControlToValidate="ln"></asp:RequiredFieldValidator><br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="ln" ErrorMessage="Write correct last name" ValidationExpression="([a-zA-Z]{2,20}\s*)+"  ValidationGroup="string"> </asp:RegularExpressionValidator><br />
    <label>  Age:  </label> <br /><input type="number" id="ag" runat="server"/><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="This field cannot be empty" ControlToValidate="ag"></asp:RequiredFieldValidator><br />
    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="ag" MaximumValue="100"
                        MinimumValue="18" Type="Integer"  ErrorMessage ="Select value from 18 to 100"></asp:RangeValidator>
    <br />
    <br />
    <asp:Button  runat="server" Text="Add" OnClick="AddNewOwner_Click" Width="173px"/>
    <br />
    <br />
    <asp:label runat="server" ID="owInfo"/>


   
</asp:Content>
