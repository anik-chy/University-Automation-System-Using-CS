<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="LectureDownload.aspx.cs" Inherits="UniversityAutomationSystem.LectureDownload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<center>
<div style="text-align: center; height: 368px">
    
        <asp:Label ID="Label1" runat="server" Text="Enter Course ID : "></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBoxCourseID" runat="server" Width="216px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonGO" runat="server" onclick="ButtonGO_Click" class="btn btn-lg btn-primary" Text="Go" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <asp:GridView ID="GridView1" runat="server" Width="355px" 
                style="margin-left: 512px">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="file_name" 
                        DataNavigateUrlFormatString="~/lectures/{0}" DataTextField="file_name" 
                        HeaderText="File Name" />
                </Columns>
            </asp:GridView>
        </asp:Panel>
    </div>
    </center>
</asp:Content>
