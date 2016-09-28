using CarsClient.Logic;
using CarsClient.WindowsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsClient
{
    public partial class DeleteTheOwner : System.Web.UI.Page
    {
        public WCFConnector Connector { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Connector = new WCFConnector();
            if (!IsPostBack)
            {
            OwnerDisplayerDropDownList OwnerDisplayer = new OwnerDisplayerDropDownList(OwnerToDeleteDropDownList, Connector);
            OwnerDisplayer.DisplayAllOwnersInDropDownList();

            EditableOwnerDipsplayerDataList EditableOwnerDisplayer = new EditableOwnerDipsplayerDataList((DataList)OwnerDL.FindControl("OwnerDataList"), Connector, OwnerToDeleteDropDownList.SelectedValue);
            EditableOwnerDisplayer.DisplayOwnerInEditableDataList();

            oInfo.Text = "";
        } }

        protected void RefreshOwner_Click(object sender, EventArgs e)
        {
            
            EditableOwnerDipsplayerDataList EditableOwnerDisplayer = new EditableOwnerDipsplayerDataList((DataList)OwnerDL.FindControl("OwnerDataList"), Connector, OwnerToDeleteDropDownList.SelectedValue);
            EditableOwnerDisplayer.DisplayOwnerInEditableDataList();

            oInfo.Text = "";

        }

        protected void DeleteOwner_Click(object sender, EventArgs e)
        {


            var ownerId = Convert.ToInt16(OwnerToDeleteDropDownList.SelectedValue);
            Connector.DeleteTheOwner(ownerId);


            OwnerDisplayerDropDownList OwnerDisplayer = new OwnerDisplayerDropDownList(OwnerToDeleteDropDownList, Connector);
            OwnerDisplayer.DisplayAllOwnersInDropDownList();

            EditableOwnerDipsplayerDataList EditableOwnerDisplayer = new EditableOwnerDipsplayerDataList((DataList)OwnerDL.FindControl("OwnerDataList"), Connector, OwnerToDeleteDropDownList.SelectedValue);
            EditableOwnerDisplayer.DisplayOwnerInEditableDataList();

            oInfo.Text = "Selected owner has been  deleted";



        }
    }
}