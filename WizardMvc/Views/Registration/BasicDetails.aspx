<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<WizardMvc.Domain.Entities.RegistrationData>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	BasicDetails
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

  <h2> Registration: Basic Details</h2>
  Please Enter Your Details

  <% using (Html.BeginForm()) {%>
  <p> Name: <%: Html.EditorFor(x=>x.Name) %></p>
  <p> E-mail <%: Html.EditorFor(x=>x.Email) %></p>
  <p><input type="submit" name="nextButton" value="Next >" /></p>
  <% } %>

</asp:Content>
