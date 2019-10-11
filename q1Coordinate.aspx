<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q1Coordinate.aspx.cs" Inherits="n01364240_Assignment2_q1.q1Coordinate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Please enter a value of X</h2>
            <asp:TextBox runat="server" ID="x_axis"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter a value of X axis" ControlToValidate="x_axis"></asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" 
                    ControlToValidate="x_axis" 
                    ErrorMessage="Please enter a valid value of x axis" OnServerValidate="Axis_Validate">
            </asp:CustomValidator>
        </div>
        <div>
            <h2>Please enter a value of Y</h2>
            <asp:TextBox runat="server" ID="y_axis"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter a valid value of Y axis" ControlToValidate="y_axis"></asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" 
                    ControlToValidate="y_axis" 
                    ErrorMessage="Axis should not be non zero!" OnServerValidate="Axis_Validate">
            </asp:CustomValidator>
        </div>
        <section>
             <div id="quadrant" runat="server"></div>
        </section>
        <asp:Button runat="server" Text="Submit"/>
    </form>
</body>
</html>
