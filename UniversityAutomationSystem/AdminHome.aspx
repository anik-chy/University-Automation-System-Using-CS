<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="UniversityAutomationSystem.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="padding-top: 10px;">
        <h5 class="proPriceView" runat="server" id="hiname">
        </h5>
    </div>
    <center>
        <div style="padding-top: 20px;">
            <asp:Button ID="show_student_btn" runat="server" Text="Show Students" class="btn btn-lg btn-primary" OnClick="show_student_btn_click" />
        </div>
    </center>
    <hr />
    <center>
        <div style="padding-top: 10px;">
            <asp:Button ID="show_teacher_btn" runat="server" Text="Show Teachers" class="btn btn-lg btn-primary" OnClick="show_teacher_btn_click" />
        </div>
    </center>
      <hr />
    <center>
        <div style="padding-top: 10px;">
            <asp:Button ID="approve_results_btn" runat="server" Text="Approve Results" class="btn btn-lg btn-primary" OnClick="approve_results_btn_click"/>
            
        </div>
    </center>

</asp:Content>
