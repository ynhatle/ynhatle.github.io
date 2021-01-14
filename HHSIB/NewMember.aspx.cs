using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace HHSIB
{
    public partial class NewMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            try
            {
                Roles.AddUserToRole(CreateUserWizard1.UserName, "Members");
            }
            catch (Exception ex)
            {
                
            }
        }

        
    }
}
