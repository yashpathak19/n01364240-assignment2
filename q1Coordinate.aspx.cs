using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01364240_Assignment2_q1
{
    public partial class q1Coordinate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    string Quadrant_No;
                    // converting the axis to integer
                    int X_Axis = Convert.ToInt32(x_axis.Text);
                    int Y_Axis = Convert.ToInt32(y_axis.Text);

                    //if the x and y value is positive the quadrant will fall in 1st
                    if (X_Axis > 0 && Y_Axis > 0)
                    {
                        Quadrant_No = "I";
                    }
                    //if the x value is negative and y value is psoitive then the quadrant will fall in Second 
                    else if (X_Axis < 0 && Y_Axis > 0)
                    {
                        Quadrant_No = "II";
                    }
                    //if the x and y value is negative then the coordinates will fall in third
                    else if (X_Axis < 0 && Y_Axis < 0)
                    {
                        Quadrant_No = "III";
                    }
                    //if the x value is positive and y axis is negative than the coordinates will fall in fourth
                    else if (X_Axis > 0 && Y_Axis < 0)
                    {
                        Quadrant_No = "IV";
                    }
                    else if (X_Axis == 0 && Y_Axis == 0)
                    {
                        Quadrant_No = "Origin";
                    }
                    else
                    {
                        Quadrant_No = "None! As the X Axis and Y Axis value should be non zero";
                    }
                    quadrant.InnerHtml = "(" + X_Axis.ToString() + "," + Y_Axis.ToString() + ") falls in Quadrant " + Quadrant_No;
                }
            }
        }
    }
}
