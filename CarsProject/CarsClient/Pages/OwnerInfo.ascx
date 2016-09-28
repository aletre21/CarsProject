<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OwnerInfo.ascx.cs" Inherits="CarsClient.Pages.UCOwnerList" %>
 
<asp:DataList ID="OwnerDataList" runat="server">
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
         
        </ItemTemplate>

    </asp:DataList>