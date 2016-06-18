<%@ Page Title="Games" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Games.aspx.cs" Inherits="EnterpriseComputingTeamProject1.GamesPublic" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
                 <div>
                    <label for="PageSizeDropDownList">Week: </label>
                    <asp:DropDownList ID="WeekDropDownList" runat="server"
                        AutoPostBack="true" CssClass="btn btn-default bt-sm dropdown-toggle"
                        OnSelectedIndexChanged="WeekDropDownList_SelectedIndexChanged">
                        <asp:ListItem Text="1" Value="1" />
                        <asp:ListItem Text="2" Value="2" />
                        <asp:ListItem Text="3" Value="3" />
                        <asp:ListItem Text="4" Value="4" />
                    </asp:DropDownList>
                </div>

    <asp:GridView runat="server" ID="GamesGridView"></asp:GridView>
</asp:Content>
