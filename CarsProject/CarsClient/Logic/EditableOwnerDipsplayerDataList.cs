using CarsClient.WindowsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CarsClient.Logic
{
   

    public class EditableOwnerDipsplayerDataList
    {
        private DataList dList;
        private WCFConnector connector;
        private string selectedIndex;

        public EditableOwnerDipsplayerDataList(DataList dList, WCFConnector connector, string selectedIndex)
        {
            this.connector = connector;
            this.dList = dList;
            this.selectedIndex = selectedIndex;
        }

        public void DisplayOwnerInEditableDataList()
        {
            var datasourceowners = from x in connector.GetAllOwners()
                                   where selectedIndex == x.Id.ToString()
                                   select new
                                   {

                                       DisplayFieldOwnerFirstName = String.Format("{0}", x.FirstName),
                                       DisplayFieldOwnerId = String.Format("{0}", x.Id),
                                       DisplayFieldOwnerLastName = String.Format("{0}", x.LastName),
                                       DisplayFieldOwnerAge = String.Format("{0}", x.Age)
                                   };

            dList.DataSource = datasourceowners;
            dList.DataBind();
        }




    }
}