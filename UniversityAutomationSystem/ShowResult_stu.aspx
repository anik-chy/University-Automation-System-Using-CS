<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true"
    CodeBehind="ShowResult_stu.aspx.cs" Inherits="UniversityAutomationSystem.ShowResult_stu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Results</h1>
    <hr />
    <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">
            All Results</div>
        <asp:Repeater ID="rptrResults" runat="server">
            <HeaderTemplate>
                <table class="table">
                    <thead>
                        <tr>
                            <th>
                                Course ID
                            </th>
                            <th>
                                Attendence
                            </th>
                            <th>
                                Quiz
                            </th>
                            <th>
                                Final
                            </th>
                            <th>
                                Total
                            </th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <th>
                         <%# Eval("course_id") %>
                    </th>
                    <td>
                        <%# Eval("attendance_number") %>
                    </td>
                    <td>
                        <%# Eval("quiz_number") %>
                    </td>
                    <td>
                        <%# Eval("final") %>
                    </td>
                    <td>
                        <%# Eval("number") %>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody> </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
