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
    public partial class CarInfo : System.Web.UI.UserControl
    {
        public WCFConnector Connector { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Connector = new WCFConnector();
            if (!IsPostBack)
            {

                CarDisplayerDropDownList CarDisplayer = new CarDisplayerDropDownList(DropDownListShowCars, Connector);
                CarDisplayer.DisplayAllCarsInDropDownList();
                EditableCarDisplayerDataList CarDisplayerDataList = new EditableCarDisplayerDataList(CarDisplayerDataListView, Connector, DropDownListShowCars.SelectedValue);
                CarDisplayerDataList.DisplayCarInEditableDataList();
            }

        }
            protected void CheckOwner_Click(object sender, EventArgs e)
        {
            EditableCarDisplayerDataList CarDisplayerDataList = new EditableCarDisplayerDataList(CarDisplayerDataListView, Connector, DropDownListShowCars.SelectedValue);
            CarDisplayerDataList.DisplayCarInEditableDataList();

        }
    }
    }
