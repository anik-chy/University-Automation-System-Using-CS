﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="ShowTeacher_admin.aspx.cs" Inherits="UniversityAutomationSystem.ShowTeacher_admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Teachers</h1>
    <hr />
    <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">
            All Teachers</div>
        <asp:Repeater ID="rptrstudent" runat="server">
            <HeaderTemplate>
                <table class="table">
                    <thead>
                        <tr>
                            <th>
                                Teacher_id
                            </th>
                            <th>
                                Name
                            </th>
                            <th>
                                Delete
                            </th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <%# Eval("teacher_id") %>
                    </td>
                    <td>
                        <%# Eval("name") %>
                    </td>
                    <th>
                        <asp:LinkButton ID="LinkButton2" OnClick="LinkButton2_Click" Text='<%# Eval("teacher_id") %>'
                            runat="server">LinkButton</asp:LinkButton>
                    </th>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody> </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    </br>
    <div class="col-xs-11 space-vert">
        <asp:Button ID="addstu_btn" runat="server" Class="btn btn-success" Text="Add Teacher"
            OnClick="add_student_Click" />
        <asp:Button ID="Button1" runat="server" Class="btn btn-success" Text="Add Course"
            OnClick="add_courses_Click" />
    </div>
    <br />
</asp:Content>
