<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Solver.aspx.cs" Inherits="Solver" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quadric equation solver</title>
</head>
<body>
    <form id="formInput" runat="server" action="/SolverResult.aspx" method="POST">
        <p>
            a:
            <asp:TextBox ID="a_value" runat="server" />
            <asp:RequiredFieldValidator ID="a_rq" runat="server" ControlToValidate="a_value" ErrorMessage='This field is required.' /> 
            <asp:CompareValidator ID="a_cv" runat="server" ControlToValidate="a_value" Type="Integer" Operator="DataTypeCheck" ErrorMessage="Value must be an integer!" />
        </p>

        <p>
            b:
            <asp:TextBox ID="b_value" runat="server" />
            <asp:RequiredFieldValidator ID="b_rq" runat="server" ControlToValidate="b_value" ErrorMessage='This field is required.' /> 
            <asp:CompareValidator ID="b_cv" runat="server" ControlToValidate="b_value" Type="Integer" Operator="DataTypeCheck" ErrorMessage="Value must be an integer!" />
        </p>

        <p>
            c:
            <asp:TextBox ID="c_value" runat="server" />
            <asp:RequiredFieldValidator ID="c_rq" runat="server" ControlToValidate="c_value" ErrorMessage='This field is required.' /> 
            <asp:CompareValidator ID="c_cv" runat="server" ControlToValidate="c_value" Type="Integer" Operator="DataTypeCheck" ErrorMessage="Value must be an integer!" />
        </p>

        <asp:Button ID="submit" runat="server" Text="Submit"></asp:Button>
    </form>
</body>
</html>
