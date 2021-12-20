<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true"
    CodeBehind="LectureUpload.aspx.cs" Inherits="UniversityAutomationSystem.LectureUpload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <div class="style1" style="height: 255px">
        <br />
        <asp:Label ID="Label3" runat="server" Text="Upload Lecture"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Course ID : "></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBoxCourseID" runat="server" Width="200px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Topic :"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxTopic" runat="server" Width="203px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonUpload" runat="server" OnClick="ButtonUpload_Click" class="btn btn-lg btn-primary" Text="Upload" />
    </div>
    </center>
</asp:Content>
