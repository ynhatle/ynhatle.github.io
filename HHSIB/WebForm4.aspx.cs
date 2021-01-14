using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HHSIB
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        IBHhsDataContext db = new IBHhsDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //lblMsg.Text = "";
                DetailsView1.DefaultMode = DetailsViewMode.Insert;
            }
        }

        

       
    }
}