using CarsClient.WindowsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CarsClient.Logic
{
    public class OwnerDisplayerDropDownList
    {
        private DropDownList dDList;
        private WCFConnector connector;
        public OwnerDisplayerDropDownList(DropDownList dDList, WCFConnector connector)
        {
            this.dDList = dDList;
            this.connector = connector;
        }

        public void DisplayAllOwnersInDropDownList()
        {
            var datasource = from x in connector.GetAllOwners()
                             select new
                             {
                                 x.Id,
                                 x.FirstName,
                                 x.LastName,
                                 DisplayField = String.Format("{0} {1}", x.FirstName, x.LastName)
                             };

            dDList.DataSource = datasource;
            dDList.DataValueField = "Id";
            dDList.DataTextField = "DisplayField";
            dDList.DataBind();
        }
    }
}