using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01364240_Assignment2_q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    int Customer_Tickets = Convert.ToInt32(customer_tickets.Text);
                    ticket_summary.InnerHtml = "";
                    int Modulus = 1;
                    // checking if the tickets lies in bundle 1
                    if (Customer_Tickets <= 50)
                    {
                        for (int i = 1; i <= Customer_Tickets; i++)
                        {
                            ticket_summary.InnerHtml += "You received a bundle of 1! That’s " + i.ToString() + " ticket(s)!<br>";
                        }
                    }
                    // checking if the tickets lies in bundle 2
                    else if (Customer_Tickets >=51 && Customer_Tickets <= 150)
                    {
                        for (int i = 2; i <= Customer_Tickets; i += 2)
                        {
                            ticket_summary.InnerHtml += "You received a bundle of 2! That’s " + i.ToString() + " ticket(s)!<br>";
                        }
                        Modulus = 2;
                    }
                    // checking if the tickets lies in bundle 3
                    else if (Customer_Tickets >= 151 && Customer_Tickets <= 300)
                    {
                        for (int i = 3; i <= Customer_Tickets; i += 3)
                        {
                            ticket_summary.InnerHtml += "You received a bundle of 3! That’s " + i.ToString() + " ticket(s)!<br>";
                        }
                        Modulus = 3;
                    }
                    // the tickets lies in bundle 5
                    else
                    {
                        for (int i = 5; i <= Customer_Tickets; i += 5)
                        {
                            ticket_summary.InnerHtml += "You received a bundle of 5! That’s " + i.ToString() + " ticket(s)!<br>";
                        }
                        Modulus = 5;
                    }
                    // getting the remainder for leftover
                    int Remainder = Customer_Tickets % Modulus;
                    // if leftover print the leftover summary
                    if (Remainder != 0)
                    {
                        ticket_summary.InnerHtml += "Your leftover is " + Remainder.ToString() + " ticket(s). That’s " + Customer_Tickets.ToString() + " ticket(s)!<br>";
                    }
                    ticket_summary.InnerHtml += "Your total ticket(s) is " + Customer_Tickets.ToString() + " and your cost is $" + (Customer_Tickets * 0.25).ToString() + "cad!";
                }
            }
        }
    }
}