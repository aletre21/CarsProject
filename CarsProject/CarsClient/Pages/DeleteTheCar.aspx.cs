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
    public partial class DeleteTheCar : System.Web.UI.Page
    {
        public WCFConnector Connector { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Connector = new WCFConnector();
            if (!IsPostBack)
            {

               
                cInfo.Text = "";

            }
        }
             protected void ShowCar_Click(object sender, EventArgs e)
        {
            
            cInfo.Text = "";

        }

        protected void DeleteCar_Click(object sender, EventArgs e)
        {


            var carId = Convert.ToInt16(((DropDownList)(CarDL.FindControl("DropDownListShowCars"))).SelectedValue);
            Connector.DeleteTheCar(carId);


            CarDisplayerDropDownList CarDisplayer = new CarDisplayerDropDownList(((DropDownList)(CarDL.FindControl("DropDownListShowCars"))), Connector);
            CarDisplayer.DisplayAllCarsInDropDownList();
            
            EditableCarDisplayerDataList EditableCarDisplayer = new EditableCarDisplayerDataList(((DataList)(CarDL.FindControl("CarDisplayerDataListView"))), Connector, ((DropDownList)(CarDL.FindControl("DropDownListShowCars"))).SelectedValue);
            EditableCarDisplayer.DisplayCarInEditableDataList();

            cInfo.Text = "Selected car has been  deleted";



        }


    }
}