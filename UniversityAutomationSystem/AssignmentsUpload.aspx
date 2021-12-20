<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true"
    CodeBehind="AssignmentsUpload.aspx.cs" Inherits="UniversityAutomationSystem.AssignmentsUpload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <div class="style1">
            Upload Assignments<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Roll :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxRoll" runat="server" Width="196px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Course No :    "></asp:Label>
            <asp:TextBox ID="TextBoxCourseID" runat="server" Width="173px"></asp:TextBox>
            <br />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" class="btn btn-lg btn-primary"
                Text="Submit" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </center>
</asp:Content>
