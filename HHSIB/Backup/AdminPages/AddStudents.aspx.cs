using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace HHSIB.AdminPages
{
    public partial class AddStudents : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblMsg.Text = "";
                InitializeFields();
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
                    lblMsg.Text = msg;
                }
                
            }
        }

        
        protected void btnAdd_Click(object sender, ImageClickEventArgs e)
        {
            bool success = false;
            string msg = "";
            if (this.IsValid)
            {
                msg = txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim() + ", Class of " + ddlYear.SelectedValue;
                success = AddStudent();
                if (success)
                {
                    lblMsg.Text = msg + " is added successfully !";
                    txtLastName.Text = "";
                    txtFirstName.Text = "";
                    txtAddress.Text = ""; txtCity.Text = ""; txtZipcode.Text = "";
                    txtPhone1.Text = ""; txtPhone2.Text = ""; txtEmail.Text = "";
                    txtParent.Text = ""; txtPEmail1.Text = ""; txtPEmail2.Text = "";
                }
                else
                {
                    lblMsg.Text = "Fail to add " + msg;
                }
                
            }
            else
            {
                lblMsg.Text = "Fail to add " + msg;
            }
        }

        private void InitializeFields()
        {
            GetYears();
            GetHomerooms();
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtAddress.Text = ""; txtCity.Text = ""; txtZipcode.Text = "";
            txtPhone1.Text = ""; txtPhone2.Text = ""; txtEmail.Text = "";
            txtParent.Text = ""; txtPEmail1.Text = ""; txtPEmail2.Text = ""; 
            ddlHomeroom.SelectedIndex = 0;
            ddlYear.SelectedIndex = 0 ;
        }

        private void GetYears()
        {
            int year = 0, month = 0;
            int firstyear = 0, totalyear = 4;

            year = (DateTime.Now).Year;
            month = (DateTime.Now).Month;
            if (month >= 6) //can not add to current year after June
            {
                firstyear = year + 1;
                totalyear = 4;
            }
            else 
            {
                firstyear = year;
                totalyear = 5;
            }            
            int yy = firstyear;
            ddlYear.Items.Clear();
            for (int i = 0; i < totalyear; i++) 
            {
                ListItem item = new ListItem(yy.ToString());
                ddlYear.Items.Add(item);
                yy = yy + 1;
            }

        }

        private void GetHomerooms()
        {            
            IBHomeroomDataContext db = new IBHomeroomDataContext();

            var results = from p in db.IB_Homerooms
                          orderby p.Name
                          select new {p.Name};

            ddlHomeroom.DataSource = results;
            ddlHomeroom.DataTextField = "Name";
            ddlHomeroom.DataValueField = "Name";
            ddlHomeroom.DataBind();            
        }

        private bool AddStudent()
        {
            bool val = true;
            IBStudentsDataContext db = new IBStudentsDataContext();
            try
            {
                IB_Student newst = new IB_Student();
                newst.LastName = txtLastName.Text.Trim();
                newst.FirstName = txtFirstName.Text.Trim();
                newst.Address = txtAddress.Text.Trim();
                newst.City = txtCity.Text.Trim();
                newst.ZipCode = txtZipcode.Text.Trim();
                newst.Phone1 = txtPhone1.Text.Trim();
                newst.Phone2 = txtPhone2.Text.Trim();
                newst.Email = txtEmail.Text.Trim();
                newst.Parents = txtParent.Text.Trim();
                newst.ParentEmail1 = txtPEmail1.Text.Trim();
                newst.ParentEmail2 = txtPEmail2.Text.Trim();
                newst.ClassOf = ddlYear.SelectedItem.Text;
                newst.Homeroom = ddlHomeroom.SelectedItem.Text;

                db.IB_Students.InsertOnSubmit(newst);
                db.SubmitChanges();
                val = true;
            }
            catch (Exception ex)
            {
                val = false;
                lblMsg.Text = "System error when adding this student, please advise Webmaster.";
            }
            return val;
            
        }

        protected void btnCancel_Click(object sender, ImageClickEventArgs e)
        {
            lblMsg.Text = txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim() + ", Class of " + ddlYear.SelectedValue + " is canceled";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtAddress.Text = ""; txtCity.Text = ""; txtZipcode.Text = "";
            txtPhone1.Text = ""; txtPhone2.Text = ""; txtEmail.Text = "";
            txtParent.Text = ""; txtPEmail1.Text = ""; txtPEmail2.Text = "";            
        }
        
    }
}
