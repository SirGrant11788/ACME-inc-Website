<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ACMEINC.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>OUR DETAILS</h3>
    <address>
        34 Sandton Drive<br />
        Johannesburg, GA 2000<br />
        <abbr title="Phone">P:</abbr>
        011.123.123
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@acmeinc.com">Support@acmeinc.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@acmein.com">Marketing@acmeinc.com</a><br />
        <strong>Consultation:</strong> <a href="mailto:Consultation@acmein.com">Consultation@acmeinc.com</a>
    </address>
</asp:Content>
