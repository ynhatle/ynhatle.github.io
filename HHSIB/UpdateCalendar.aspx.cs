using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace HHSIB.AdminPages
{
    public partial class UpdateCalendar : System.Web.UI.Page
    {
        DateTime frDate, toDate;
        bool validDate = false;
            
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitForm();
                lblMsg.Text = "Enter From Date only for one-day event.<br/> Enter a range of dates in FromDate and ToDate for event spaning several days.";
            }
            else
            {
                this.Validate();
            }
        }

        private void InitForm()
        {
            LoadDays();
            ddlDay1.SelectedIndex = -1; ddlDay2.SelectedIndex = -1;
            LoadMonths();
            ddlMth1.SelectedIndex = -1; ddlMth2.SelectedIndex = -1;
            LoadYears();
            ddlYr1.SelectedIndex = 0; ddlYr2.SelectedIndex = 0;
            txtDesc.Text = "";
            
        }
        private void LoadDays()
        {
            ListItem item;
            ddlDay1.Items.Clear();
            ddlDay2.Items.Clear();
            for (int i = 1; i <= 31; i++)
            {
                if (i < 10)
                    item = new ListItem("0" + i.ToString());
                else
                    item = new ListItem(i.ToString());
                ddlDay1.Items.Add(item);
                ddlDay2.Items.Add(item);
            }
        }
        private void LoadMonths()
        {
            ListItem item;
            ddlMth1.Items.Clear();
            ddlMth2.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                    item = new ListItem("0" + i.ToString());
                else
                    item = new ListItem(i.ToString());
                ddlMth1.Items.Add(item);
                ddlMth2.Items.Add(item);
            }
        }
        private void LoadYears()
        {
            int year = (DateTime.Now).Year;
            
            int yy = year;
            ddlYr1.Items.Clear();
            ddlYr2.Items.Clear();

            for (int i = 0; i < 2; i++)
            {
                ListItem item = new ListItem(yy.ToString());
                ddlYr1.Items.Add(item);
                ddlYr2.Items.Add(item);
                yy = yy + 1;
            }

        }
        
        private bool ValidateDates(string dd, string mm, string yy, out DateTime outDate)
        {
            bool val = false;
            string dateIn = "";
            string[] formats = {"dd/MM/yyyy"};
                   
            try
            {                
                dateIn = dd + "/" + mm + "/" + yy;
                val = DateTime.TryParseExact(dateIn, formats, null, DateTimeStyles.AssumeLocal, out outDate); 
            }
            catch
            {
                val = false; outDate = DateTime.Now; 
            }
            return val;


        }

        private bool UpdateCalendarTable(DateTime date1, DateTime date2, string Desc)
        {
            bool val = false;
            try
            {
                IBHhsDataContext db = new IBHhsDataContext();
                //IBCalendarDataContext db = new IBCalendarDataContext();                
                DateTime dt = date1;

                //add 1st day 
                IB_Calendar newEntry = new IB_Calendar();
                newEntry.IBEVent = Desc;
                newEntry.IBDate = dt;
                db.IB_Calendars.InsertOnSubmit(newEntry);

                //add repeating days
                if (date2 != date1)
                {
                    TimeSpan ts = date2 - date1;
                    int diffDays = ts.Days;
                    for (int i = 1; i < diffDays + 1 ; i++)
                    {
                        dt = date1.AddDays(i);  
                        newEntry = new IB_Calendar();
                        newEntry.IBEVent = Desc;
                        newEntry.IBDate = dt;
                        db.IB_Calendars.InsertOnSubmit(newEntry);
                    }
                }
                db.SubmitChanges();
                val = true;               

            }
            catch (Exception e)          
            {
                val = false;
                lblMsg.Text = "System error when adding this student, please advise Webmaster." + e.Message;
            }
            return val;
            
        }

        protected void btnAdd_Click(object sender, ImageClickEventArgs e)
        {
            lblMsg.Text = "";
            try
            {
                //Check FromDate
                validDate = ValidateDates(ddlDay1.SelectedValue.ToString(), ddlMth1.SelectedValue.ToString(), ddlYr1.SelectedValue.ToString(), out frDate);
                if (validDate)
                {
                    //Check ToDate
                    if ((ddlDay2.SelectedValue.ToString() != ddlDay1.SelectedValue.ToString()) ||
                       (ddlMth2.SelectedValue.ToString() != ddlMth1.SelectedValue.ToString()) ||
                       (ddlYr2.SelectedValue.ToString() != ddlYr1.SelectedValue.ToString()))
                    {
                        validDate = ValidateDates(ddlDay2.SelectedValue.ToString(), ddlMth2.SelectedValue.ToString(), ddlYr2.SelectedValue.ToString(), out toDate);
                        //ToDate can not be earlier than FromDate
                        if (validDate)
                        {
                            if (DateTime.Compare(toDate, frDate) < 0)
                            {
                                lblMsg.Text = "To Date can not be earlier than From Date";
                                validDate = false;
                            }
                        }
                        else
                        {
                            lblMsg.Text = "To Date is not a valid date.";
                        }
                    }
                    else
                    {
                        toDate = frDate;
                    }
                }
                else
                {
                    lblMsg.Text = "From Date is not a valid Date.";
                }
                //update Table
                if (validDate)
                {
                    bool success = UpdateCalendarTable(frDate, toDate, txtDesc.Text.ToString().Trim());
                    if (success)
                        lblMsg.Text = "Events added successfully.";
                    else
                        lblMsg.Text = "Faild to add event." + lblMsg.Text;
                }
            }
            catch
            {
                lblMsg.Text = "Fail to add Events.";
            }
        }

        protected void btnCancel_Click(object sender, ImageClickEventArgs e)
        {
            lblMsg.Text = "Event is canceled";
            this.Validate();
            InitForm();
        }

        protected void ddlDay1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlDay2.SelectedIndex = ddlDay1.SelectedIndex;
        }

        protected void ddlMth1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlMth2.SelectedIndex = ddlMth1.SelectedIndex;
        }

        protected void ddlYr1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlYr2.SelectedIndex = ddlYr1.SelectedIndex;
        }


    }
}
