using CarsClient.Logic;
using CarsClient.WindowsService;
using CarsService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsClient
{
    public partial class EditTheOwner : System.Web.UI.Page
    {
        public WCFConnector Connector { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Connector = new WCFConnector();
            if (!IsPostBack)
            {
                
                OwnerDisplayerDropDownList OwnerDisplayer = new OwnerDisplayerDropDownList(OwnerToEditDropDownList,Connector);
                OwnerDisplayer.DisplayAllOwnersInDropDownList();

                EditableOwnerDipsplayerDataList EditableOwnerDisplayer = new EditableOwnerDipsplayerDataList(OwnerToEditDataList, Connector, OwnerToEditDropDownList.SelectedValue);
                EditableOwnerDisplayer.DisplayOwnerInEditableDataList();

                ownersavedInfo.Text = "";

            }
        }

        protected void OwnerToEditDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OwnerDisplayerDropDownList OwnerDisplayer = new OwnerDisplayerDropDownList(OwnerToEditDropDownList, Connector);
            OwnerDisplayer.DisplayAllOwnersInDropDownList();

            EditableOwnerDipsplayerDataList EditableOwnerDisplayer = new EditableOwnerDipsplayerDataList(OwnerToEditDataList, Connector, OwnerToEditDropDownList.SelectedValue);
            EditableOwnerDisplayer.DisplayOwnerInEditableDataList();

            ownersavedInfo.Text = "";
        }
    
    protected void SaveOwner_Click(object sender, EventArgs e)
    {
            OwnerDTO Owner = new OwnerDTO();

            foreach (DataListItem item in OwnerToEditDataList.Items)
            {
                TextBox TextBoxAge = (TextBox)item.FindControl("ownerToEditAge");
                Owner.Age = Convert.ToInt16(TextBoxAge.Text);
                TextBox TextBoxFirstName = (TextBox)item.FindControl("ownerToEditFirstName");
                Owner.FirstName = TextBoxFirstName.Text;
                TextBox TextBoxLastName = (TextBox)item.FindControl("ownerToEditLastName");
                Owner.LastName = TextBoxLastName.Text;
                Label TextBoxOwnerId = (Label)item.FindControl("ownerToEditId");
                Owner.Id = Convert.ToInt16(TextBoxOwnerId.Text);
                
            }
            
            Connector.EditTheOwner(Owner.Id, Owner);
            ownersavedInfo.Text = "Changes have been saved";
        }
    
}
}