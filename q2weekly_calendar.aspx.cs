using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01364240_Assignment2_q1
{
    public partial class weekly_calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    // starting the count from 0 so I can ignore the first day as monday later on
                    int count = 0;
                    string custom_message;
                    monthly_summary.InnerHtml = "";
                    // the loop will run only 5 times, i.e. for 5 weeks of october
                    for (int i = 0; i < 5; i++)
                    {
                        // iterating through the days of week
                        foreach (ListItem work_day in work_days.Items)
                        {
                            // will ignore the first count, i.e first day which is monday, as october starts from tuesday!
                            if (count <= 31 && count > 0)
                            {
                                // checking if the day is selected or not
                                if (work_day.Selected == true)
                                {
                                    custom_message = "work...";
                                }
                                // if not selected then it means the user isn't working on that day
                                else
                                {
                                    custom_message = "have fun!";
                                }
                                // adding the line to the monthly summary
                                monthly_summary.InnerHtml += "Oct " + count.ToString() + " is a " + work_day.Text + "! Time to " + custom_message + "<br>";
                            }
                            // incrementing the count
                            count += 1;
                        }
                    }
                }
            }
        }
    }
}
