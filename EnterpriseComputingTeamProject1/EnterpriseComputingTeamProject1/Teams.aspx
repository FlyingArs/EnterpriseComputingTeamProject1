<%--
   Authors & Student Number:
    Fei Wang 200278460
    Siqian Yu 200286902
   Date Modified: 06-15-2016
   File Description: This is the Teams Statistics Page that lists Teams' names, description and socores
    
    --%>

<%@ Page Title="Teams" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Teams.aspx.cs" Inherits="EnterpriseComputingTeamProject1.TeamsPublic" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offest-2 col-md-8">
                <h1>Teams Stats</h1>

                <!-- Drop Down List for Page Size-->
                <label for="PageSizeDropDownList">Records per page: </label>
                <asp:DropDownList ID="PageSizeDropDownList" runat="server" AutoPostBack="true" 
                    CssClass="btn btn-default btn-sm dropdown-toggle" OnSelectedIndexChanged="PageSizeDropDownList_SelectedIndexChanged">
                    <asp:ListItem Text="5" Value="5" />
                    <asp:ListItem Text="10" Value="10" />
                    <asp:ListItem Text="All" Value="10000" />
                </asp:DropDownList>

                <!-- ASP GirdView to List All the Teams Stats -->
                <asp:GridView runat="server" CssClass="table table-bordered table-striped table-hover"
                     ID="TeamsGridView" AutoGenerateColumns="false" DataKeyNames="TeamID"
                     AllowPaging="true" PageSize="5" OnPageIndexChanging="TeamsGridView_PageIndexChanging"
                     AllowSorting="true" OnSorting="TeamsGridView_Sorting" OnRowDataBound="TeamsGridView_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="TeamID" HeaderText="Team ID" Visible="true" SortExpression="TeamID" />
                        <asp:BoundField DataField="TeamName" HeaderText="Department Name" Visible="true" SortExpression="TeamName" />
                        <asp:BoundField DataField="TeamDescription" HeaderText="Description" Visible="true" SortExpression="TeamDescription" />
                    </Columns>
                </asp:GridView>

            </div>
        </div>
    </div>
</asp:Content>
