<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="TeacherHome.aspx.cs" Inherits="UniversityAutomationSystem.TeacherHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="padding-top: 10px;">
        <h5 class="proPriceView" runat="server" id="hiname">
        </h5>
    </div>
    <center>
        <div style="padding-top: 20px;">
            <asp:Button ID="upload_result_btn" runat="server" Text="Upload Results" class="btn btn-lg btn-primary" OnClick="upload_result_btn_click" />
        </div>
    </center>
    <hr />
    <center>
        <div style="padding-top: 10px;">
            <asp:Button ID="upload_lec_btn" runat="server" Text="Upload Lectures" class="btn btn-lg btn-primary" OnClick="upload_lec_btn_click"/>
        </div>
    </center>
      <hr />
    <center>
        <div style="padding-top: 10px;">
            <asp:Button ID="Button2" runat="server" Text="Download Assignments" class="btn btn-lg btn-primary" OnClick="download_ass_btn_click" />
        </div>
    </center>
</asp:Content>
