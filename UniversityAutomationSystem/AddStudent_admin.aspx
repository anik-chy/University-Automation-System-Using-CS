<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true"
    CodeBehind="AddStudent_admin.aspx.cs" Inherits="UniversityAutomationSystem.AddStudent_admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <label class="col-xs-11">
            Student Id</label>
        <div class="col-xs-11">
            <asp:TextBox ID="stu_id" runat="server" placeholder="Stu Id"></asp:TextBox>
        </div>
        <label class="col-xs-11">
            Name</label>
        <div class="col-xs-11">
            <asp:TextBox ID="name" runat="server" placeholder="Name"></asp:TextBox>
        </div>
        <label class="col-xs-11">
            Email</label>
        <div class="col-xs-11">
            <asp:TextBox ID="email" runat="server" placeholder="Email" TextMode="Email"></asp:TextBox>
        </div>

        <label class="col-xs-11">
            year</label>
        <div class="col-xs-11">
            <asp:TextBox ID="year" runat="server" placeholder="Year"></asp:TextBox>
        </div>
        <label class="col-xs-11">
            Semester</label>
        <div class="col-xs-11">
            <asp:TextBox ID="sem" runat="server" placeholder="Semester"></asp:TextBox>
        </div>
        <label class="col-xs-11">
            Section</label>
        <div class="col-xs-11">
            <asp:TextBox ID="sec" runat="server" placeholder="Section"></asp:TextBox>
        </div>
        <label class="col-xs-11">
        Sub Section</label>
        <div class="col-xs-11">
            <asp:TextBox ID="ssec" runat="server" placeholder="Sub Sec"></asp:TextBox>
        </div>
        <label class="col-xs-11">
        Total Credit</label>
        <div class="col-xs-11">
            <asp:TextBox ID="tc" runat="server" placeholder="Credit"></asp:TextBox>
        </div><hr/>
        <label class="col-xs-11">
            Dep_id</label>
        <div class="col-xs-11">
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        </div>
         <label class="col-xs-11">
            Password</label>
        <div class="col-xs-11">
            <asp:TextBox ID="password" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
        </div>
        <hr /><hr/>
        <div class="col-xs-11 space-vert">
            <asp:Button ID="add_btn" runat="server" Class="btn btn-success" Text="ADD" OnClick="add_btn_Click" />
        </div>

    </center>
</asp:Content>
