<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditTheCar.aspx.cs" Inherits="CarsClient.EditTheCar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <%@Register TagName="OwnerDL" TagPrefix="UC" Src="~/Pages/OwnerInfo.ascx" %>
    <br />
    <br />
    <h2>Edit the Car</h2>
    <br />
    <br />
    <asp:DropDownList ID="CarToEditDropDownList" runat="server" Height="30px" Width="175px" OnSelectedIndexChanged="CarIsChanged_SelectedIndexChanged" AutoPostBack="true">
    </asp:DropDownList>
     <br />
    <br />
   
        <asp:DataList ID="CarToEditDataList" runat="server">
        <ItemTemplate>
             <h2>Current Owner:</h2><br />
          
           <label>ID:</label><br />
          <asp:label runat="server"  Enabled="false"  Text='<%#DataBinder.Eval(Container.DataItem,"DisplayFieldOwnerId") %>' /><br />
            <br />
            <label>First Name:</label><br />
             <asp:label runat="server"  Enabled="false"  Text='<%#DataBinder.Eval(Container.DataItem,"DisplayFieldOwnerFirstName") %>' /><br />
            <br /> <label>Last Name:</label><br>
             <asp:label runat="server"  Enabled="false"  Text='<%#DataBinder.Eval(Container.DataItem,"DisplayFieldOwnerLastName") %>' /><br />
           <br />  <label>Age:</label><br />
             <asp:label runat="server"  Enabled="false"  Text='<%#DataBinder.Eval(Container.DataItem,"DisplayFieldOwnerAge") %>' /><br />
            
            <br />
            <h2>Car's information</h2>
             <br /><label>ID:</label><br />
             <asp:label runat="server"   id="carToEditID" Enabled="false"  Text='<%#DataBinder.Eval(Container.DataItem,"DisplayFieldCarId") %>' /><br />
            <br /> <label>Brand:</label><br />
             <asp:TextBox runat="server" id="carToEditBrand" Text='<%#DataBinder.Eval(Container.DataItem,"DisplayFieldCarBrand") %>' />
              <asp:RequiredFieldValidator ID="RequiredFieldValidatorCarToEditBrand" runat="server" ErrorMessage="This field cannot be empty" ControlToValidate="carToEditBrand"></asp:RequiredFieldValidator><br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorCarToEditBrand" runat="server" ControlToValidate="carToEditBrand" ErrorMessage="Write correct brand" ValidationExpression="([a-zA-Z]{2,20}\s*)+"  ValidationGroup="string"> </asp:RegularExpressionValidator><br />
          <label>Model:</label><br />
             <asp:TextBox runat="server"  id="carToEditModel"  Text='<%#DataBinder.Eval(Container.DataItem,"DisplayFieldCarModel") %>' /><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorCarToEditModel" runat="server" ErrorMessage="This field cannot be empty" ControlToValidate="carToEditModel"></asp:RequiredFieldValidator><br />
            <label>KM:</label><br />
             <asp:TextBox runat="server" id="carToEditKM"   Text='<%#DataBinder.Eval(Container.DataItem,"DisplayFieldCarKM") %>' />
         <asp:RequiredFieldValidator ID="RequiredFieldValidatorCarToEditKM" runat="server" ErrorMessage="This field cannot be empty" ControlToValidate="carToEditKM"></asp:RequiredFieldValidator><br />
    <asp:RangeValidator ID="RangeValidatorCarToEditKM" runat="server" ControlToValidate="carToEditKM" MaximumValue="900"
                        MinimumValue="25" Type="Integer"  ErrorMessage ="Select value from 25 to 900"></asp:RangeValidator>
        </ItemTemplate>

    </asp:DataList>
    

    <br />
    <h2>Change the Owner</h2>
    <br />
    <asp:DropDownList ID="OwnerToChangeDropDownList" runat="server" Height="30px" Width="176px" OnSelectedIndexChanged="OwnerIsChanged_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList> 
  
    <br />
    <br />
      <UC:OwnerDL id="OwnerDL" runat="server" />
    <br />
    <br>

     <asp:button runat="server" OnClick="SaveCar_Click" Text="Save" Width="175px"></asp:button>
    <br />
    <br />
    <asp:label runat="server" ID="carsavedInfo"/>
</asp:Content>
