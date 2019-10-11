<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q2weekly_calendar.aspx.cs" Inherits="n01364240_Assignment2_q1.weekly_calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Weekly Calendar</h1>
            <h2>Please select your study/work days</h2>
            <asp:CheckBoxList runat="server" ID="work_days">
                <asp:ListItem Value="mon">Monday</asp:ListItem>
                <asp:ListItem Value="tues">Tuesday</asp:ListItem>
                <asp:ListItem Value="wed">Wednesday</asp:ListItem>
                <asp:ListItem Value="thurs">Thursday</asp:ListItem>
                <asp:ListItem Value="fri">Friday</asp:ListItem>
                <asp:ListItem Value="sat">Saturday</asp:ListItem>
                <asp:ListItem Value="mon">Sunday</asp:ListItem>
            </asp:CheckBoxList>
            <div id="monthly_summary" runat="server"></div>
            <asp:Button runat="server" Text="Submit"/>
        </div>
    </form>
</body>
</html>
