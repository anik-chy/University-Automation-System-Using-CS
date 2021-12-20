<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true"
    CodeBehind="ShowCourse_tec.aspx.cs" Inherits="UniversityAutomationSystem.ShowCourse_tec" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1>
        Courses</h1>
    <hr />
    <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">
            All Courses</div>
        <asp:Repeater ID="rptrcourse" runat="server">
            <HeaderTemplate>
                <table class="table">
                    <thead>
                        <tr>
                            <th>
                                Course ID
                            </th>
                            <th>
                                Course Title
                            </th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <th>
                    <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click" Text='<%# Eval("course_id") %>'  runat="server">LinkButton</asp:LinkButton>
                         
                    </th>
                    <td>
                        <%# Eval("title") %>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody> </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
