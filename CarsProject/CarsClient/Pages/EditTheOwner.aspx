<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditTheOwner.aspx.cs" Inherits="CarsClient.EditTheOwner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <br />
    <br />
    <h2>Edit the Owner</h2>
    <br />
    <br />
   
    <asp:DropDownList ID="OwnerToEditDropDownList" runat="server" Height="30px" Width="175px" OnSelectedIndexChanged="OwnerToEditDropDownList_SelectedIndexChanged" AutoPostBack="true">
    </asp:DropDownList>
     <br />
    <br />
     <asp:DataList ID="OwnerToEditDataList" runat="server">
        <ItemTemplate>

           <label>ID:</label><br />
          <asp:label runat="server" id="ownerToEditId"  Enabled="false"  Text='<%#DataBinder.Eval(Container.DataItem,"DisplayFieldOwnerId") %>' /><br />
            <br />
            <label>First Name:</label><br />
             <asp:TextBox runat="server" id="ownerToEditFirstName"  Text='<%#DataBinder.Eval(Container.DataItem,"DisplayFieldOwnerFirstName") %>' />
               <asp:RequiredFieldValidator ID="RequiredFieldValidatorOwnerToEditFirstName" runat="server" ErrorMessage="This field cannot be empty" ControlToValidate="ownerToEditFirstName"></asp:RequiredFieldValidator><br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorOwnerToEditFirstName" runat="server" ControlToValidate="ownerToEditFirstName" ErrorMessage="Write correct first name" ValidationExpression="([a-zA-Z]{2,20}\s*)+"  ValidationGroup="string"> </asp:RegularExpressionValidator><br />
            
            <label>Last Name:</label><br>
             <asp:TextBox runat="server"   id="ownerToEditLastName"   Text='<%#DataBinder.Eval(Container.DataItem,"DisplayFieldOwnerLastName") %>' />
           <asp:RequiredFieldValidator ID="RequiredFieldValidatorOwnerToEditLastName" runat="server" ErrorMessage="This field cannot be empty" ControlToValidate="ownerToEditLastName"></asp:RequiredFieldValidator><br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorOwnerToEditLastName" runat="server" ControlToValidate="ownerToEditLastName" ErrorMessage="Write correct last name" ValidationExpression="([a-zA-Z]{2,20}\s*)+"  ValidationGroup="string"> </asp:RegularExpressionValidator><br />
            
             <label>Age:</label><br />
             <asp:TextBox runat="server"  id="ownerToEditAge"  Text='<%#DataBinder.Eval(Container.DataItem,"DisplayFieldOwnerAge") %>' />
              <asp:RequiredFieldValidator ID="RequiredFieldValidatorOwnerToEditAge" runat="server" ErrorMessage="This field cannot be empty" ControlToValidate="ownerToEditAge"></asp:RequiredFieldValidator><br />
    <asp:RangeValidator ID="RangeValidatorOwnerToEditAge" runat="server" ControlToValidate="ownerToEditAge" MaximumValue="100"
                        MinimumValue="18" Type="Integer"  ErrorMessage ="Select value from 18 to 100"></asp:RangeValidator>
        </ItemTemplate>
    </asp:DataList>
            <br /><br />
     <asp:button runat="server" OnClick="SaveOwner_Click" Text="Save" Width="175px"></asp:button>
    <br />
    <br />
    <asp:label runat="server" ID="ownersavedInfo"/>
</asp:Content>
