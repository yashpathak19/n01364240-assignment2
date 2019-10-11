<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q3raffle_bundle.aspx.cs" Inherits="n01364240_Assignment2_q1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Please enter the number of tickets that you want to buy</h2>
            <asp:TextBox runat="server" ID="customer_tickets"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter the number of tickets that you want to purchase" ControlToValidate="customer_tickets"></asp:RequiredFieldValidator>
            <div id="ticket_summary" runat="server"></div>
            <asp:Button runat="server" Text="Submit"/>
        </div>
    </form>
</body>
</html>
