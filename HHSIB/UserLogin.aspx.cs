using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace HHSIB
{
    public partial class UserLogin : System.Web.UI.Page
    {
        string Role = "";
        string RequestPage = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                lblMessage.Text = "";
                txtUserId.Text = "";
                txtPswd.Text = "Please enter UserId and Password.";
            }
            else //Page is postback
            {
                this.Validate();
                if (!this.IsValid)
                {
                    string msg = "";
                    // Loop through all validation controls to see which
                    // generated the errors.
                    foreach (IValidator aValidator in this.Validators)
                    {
                        if (!aValidator.IsValid)
                        {
                            msg += "<br />" + aValidator.ErrorMessage;
                        }
                    }
                    //lblMessage.Text = msg;
                }
                if (Request.QueryString["PARM"] != null)
                    RequestPage = Request.QueryString["PARM"].Trim();                        

            }

        }

        private bool ValidateUser(string UsrName, string Pwd, out string uRole)
        {
            bool Val = false;
            uRole = "";
            try
            {
                string URL = Request.PhysicalApplicationPath + "App_Data/loginuserpwd.xml";
                XmlDocument loginDocument = new XmlDocument();
                XmlTextReader r = new XmlTextReader(URL);                
                loginDocument.Load(r);               
                                  
                foreach (XmlNode node in loginDocument.SelectSingleNode(@"Users").ChildNodes)
                {
                    string _usrName = node.SelectSingleNode(@"./@userId").Value;
                    string _pwd = node.SelectSingleNode(@"./@password").Value;

                    if (_usrName == UsrName && _pwd == Pwd)
                    {
                        uRole = node.SelectSingleNode(@"./@role").Value;
                        Val = true;
                    }                    
                }                
            }
            catch
            {
                Val = false;
            }
            return Val;
            
        }
                        
        
        protected void btnLogin_Click(object sender, ImageClickEventArgs e)
        {
            Role = "";
            if (ValidateUser(txtUserId.Text, txtPswd.Text, out Role))
            {
                if (Role == "Admin")
                {
                    if (RequestPage == "ParentPage")                        
                        Response.Redirect("MemberPages/Directory.aspx");
                    else                        
                        Response.Redirect("AdminPages/Default.aspx");
                }
                else //Member role
                {
                    if (RequestPage == "ParentPage")                        
                        Response.Redirect("MemberPages/Directory.aspx");
                    else
                        lblMessage.Text = "Admin Menu is not allowed for this UserId !";
                }
                    
            }
            else
            {
                lblMessage.Text = "UserID and/or Password are not valid. Please try again !";
            }
        }
    }
}
