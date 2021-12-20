<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="AddCourse_tec_admin.aspx.cs" Inherits="UniversityAutomationSystem.AddCourse_tec_admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="panel panel-default">
        <center>
            <table>
                <tr>
                    <td>
                        Select Course
                    </td>
                    <td>
                        <div class="col-xs-11">
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="173px" AutoPostBack="True"
                                OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        Select Stu Id
                    </td>
                    <td>
                        <div class="col-xs-11">
                            <asp:DropDownList ID="DropDownList2" runat="server" Width="173px" AutoPostBack="True"
                                OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        Year
                    </td>
                    <td>
                        <div class="col-xs-11">
                            <asp:TextBox ID="year" runat="server" placeholder="year"></asp:TextBox>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        Semester
                    </td>
                    <td>
                        <div class="col-xs-11">
                            <asp:TextBox ID="sem" runat="server" placeholder="Semester"></asp:TextBox>
                        </div>
                    </td>
                </tr>
            </table>
        </center>
    </div>
    <center>
        <div class="col-xs-11 space-vert">
            <asp:Button ID="add_btn" runat="server" Class="btn btn-success" Text="Add Course"
                OnClick="add_btn_Click" />
                <a CssClass="btn btn-default"  href="AdminHome.aspx" role="button">Back</a>
        </div>
    </center>
</asp:Content>
