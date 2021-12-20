<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true"
    CodeBehind="StudentHome.aspx.cs" Inherits="UniversityAutomationSystem.StudentHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding-top: 10px;">
        <h5 class="proPriceView" runat="server" id="hiname">
        </h5>
    </div>
    <center>
        <div style="padding-top: 20px;">
            <asp:Button ID="show_result_btn" runat="server" Text="Show Results" class="btn btn-lg btn-primary" OnClick="show_result_btn_click" />
        </div>
    </center>
    <hr />
    <center>
        <div style="padding-top: 10px;">
            <asp:Button ID="upload_ass_btn" runat="server" Text="Upload Assignments" class="btn btn-lg btn-primary" OnClick="upload_ass_btn_click"  />
        </div>
    </center>
      <hr />
    <center>
        <div style="padding-top: 10px;">
            <asp:Button ID="Button2" runat="server" Text="Download Lectures" class="btn btn-lg btn-primary" OnClick="download_lec_btn_click" />
        </div>
    </center>
</asp:Content>
