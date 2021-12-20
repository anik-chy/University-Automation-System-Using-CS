<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true"
    CodeBehind="UploadResult_tec.aspx.cs" Inherits="UniversityAutomationSystem.UploadResult_tec" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <table>
            <tr>
                <td>
                    Choose Year
                </td>
                <td>
                    <asp:DropDownList ID="ddl_country" runat="server" Width="150px" AutoPostBack="True"
                        OnSelectedIndexChanged="ddl_country_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            </br>
            <tr>
                <td>
                    Choose Semester :
                </td>
                <td>
                    <asp:DropDownList ID="ddl_city" runat="server" Width="150px" AutoPostBack="True"
                        OnSelectedIndexChanged="ddl_city_SelectedIndexChanged">
                    </asp:DropDownList>
                    <br />
                </td>
            </tr>
            <hr />
            <tr>
                <td>
                    Choose StudentID :
                </td>
                <td>
                    <asp:DropDownList ID="ddl_stu" runat="server" Width="150px" AutoPostBack="True" OnSelectedIndexChanged="ddl_stu_SelectedIndexChanged">
                    </asp:DropDownList>
                    <br />
                </td>
            </tr>
        </table>
    </center>
    <hr />
    <center>
        <label class="col-xs-11">
            Quiz Number</label>
        <div class="col-xs-11">
            <asp:TextBox ID="qn" runat="server" placeholder="Quiz No."></asp:TextBox>
        </div>
        </br>
        <label class="col-xs-11">
            Attendence Number</label>
        <div class="col-xs-11">
            <asp:TextBox ID="an" runat="server" placeholder="Attendence No."></asp:TextBox>
        </div>
        </br>
        <label class="col-xs-11">
            Final Number</label>
        <div class="col-xs-11">
            <asp:TextBox ID="fn" runat="server" placeholder="Final No." ></asp:TextBox>
        </div>
        </br>
        <hr/>
        <div class="col-xs-11 space-vert">
            <asp:Button ID="upload_btn" runat="server" Class="btn btn-success" Text="Upload"
                OnClick="upload_btn_Click" />
                <a CssClass="btn btn-default"  href="ShowCourse_tec.aspx" role="button">Back</a>
        </div>
    </center>
</asp:Content>
