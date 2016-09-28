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
    public partial class AddNewOwner : System.Web.UI.Page
    {
        public WCFConnector Connector { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
           Connector = new WCFConnector();
            if (!IsPostBack)
            {
            owInfo.Text = "";
            }
          

        }

        protected void AddNewOwner_Click(object sender, EventArgs e)
        {   
                OwnerDTO Owner= new OwnerDTO();
                Owner.Age= Convert.ToInt16(ag.Value);
                Owner.FirstName = fn.Value;
                Owner.LastName = ln.Value;
                Connector.AddNewOwner(Owner);
                owInfo.Text = "The new owner has been added";
                ag.Value="";
                fn.Value = "";
                ln.Value = "";
        }
        
          

        }
    }
