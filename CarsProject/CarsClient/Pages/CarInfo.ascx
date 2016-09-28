<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CarInfo.ascx.cs" Inherits="CarsClient.CarInfo" %>
<asp:DropDownList ID="DropDownListShowCars" runat="server" Height="30px" Width="144px" OnSelectedIndexChanged="CheckOwner_Click" AutoPostBack="true">
    </asp:DropDownList>
     <br />
    <br />
   
    <asp:DataList ID="CarDisplayerDataListView" runat="server">
        <ItemTemplate>
           <h2>Owner: </h2><br /><br />
        <label>ID:</label> <br />   <%#DataBinder.Eval(Container.DataItem,"DisplayFieldOwnerId") %>
            <br />
       <br />   <label>First Name: </label>  <br /> <%#DataBinder.Eval(Container.DataItem,"DisplayFieldOwnerFirstName") %>
            <br />
         <br />   <label>Last Name: </label>  <br />  <%#DataBinder.Eval(Container.DataItem,"DisplayFieldOwnerLastName") %>
            <br />
        <br />  <label>Age: </label>  <br />    <%#DataBinder.Eval(Container.DataItem,"DisplayFieldOwnerAge") %>
            <br /><br />
         <h2>Car's information:</h2><br /><br />
            <label>ID: </label>  <br /> <%#DataBinder.Eval(Container.DataItem,"DisplayFieldCarId") %><br />
    <br />   <label>Brand: </label>  <br />      <%#DataBinder.Eval(Container.DataItem,"DisplayFieldCarBrand") %><br />
     <br />   <label>Model: </label>  <br />     <%#DataBinder.Eval(Container.DataItem,"DisplayFieldCarModel") %><br />
     <br />   <label>KM: </label>  <br />     <%#DataBinder.Eval(Container.DataItem,"DisplayFieldCarKM") %><br />
        </ItemTemplate>

    </asp:DataList>