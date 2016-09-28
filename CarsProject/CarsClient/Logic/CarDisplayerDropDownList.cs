using CarsClient.WindowsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CarsClient.Logic
{
    public class CarDisplayerDropDownList
    {
        private DropDownList dDList;
        private WCFConnector connector;
        public CarDisplayerDropDownList(DropDownList dDList, WCFConnector connector)
        {
            this.dDList = dDList;
            this.connector = connector;
        }

        public void DisplayAllCarsInDropDownList()
        {
            var carsSource = from x in connector.GetAllCars()
                             select new
                             {
                                 x.Id,
                                 DisplayField = String.Format("{0} {1}", x.Brand, x.Model)
                             };

            dDList.DataSource = carsSource;
            dDList.DataValueField = "Id";
            dDList.DataTextField = "DisplayField";
            dDList.DataBind();
        }
    }
}
