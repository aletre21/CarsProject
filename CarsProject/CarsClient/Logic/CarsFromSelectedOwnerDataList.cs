using CarsClient.WindowsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CarsClient.Logic
{
    public class CarsFromSelectedOwnerDataList
    {
        private DataList dList;
        private WCFConnector connector;
        private string selectedIndex;

        public CarsFromSelectedOwnerDataList(DataList dList, WCFConnector connector, string selectedIndex)
        {
            this.connector = connector;
            this.dList = dList;
            this.selectedIndex = selectedIndex;
        }

        public void DisplayCarsFromSelectedOwnerDataList()
        {
            var selectedCar = from x in connector.GetAllCars()
                              where selectedIndex == x.Owner.Id.ToString()
                              select new
                              {
                                  DisplayFieldCarId = String.Format("{0} ", x.Id),
                                  DisplayFieldCarBrand = String.Format("{0}", x.Brand),
                                  DisplayFieldCarModel = String.Format("{0}", x.Model),
                                  DisplayFieldCarKM = String.Format("{0}", x.KM)
                              };

            dList.DataSource = selectedCar;
            dList.DataBind();

        }
    }
}