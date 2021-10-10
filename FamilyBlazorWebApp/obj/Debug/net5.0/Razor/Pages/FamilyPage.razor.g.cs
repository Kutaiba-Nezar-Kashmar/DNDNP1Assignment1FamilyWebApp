#pragma checksum "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e82ab62f25ae66f8f73abef4a86da5beb6ef46e1"
// <auto-generated/>
#pragma warning disable 1591
namespace FamilyBlazorWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\_Imports.razor"
using FamilyBlazorWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\_Imports.razor"
using FamilyBlazorWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Family")]
    public partial class FamilyPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
 if (familiesToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading</em></p>");
#nullable restore
#line 13 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
}
else if (!familiesToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em style=\"color: white\">No Families to show. Please add som.</em></p>");
#nullable restore
#line 19 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
}
else
{
  

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<br>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "FamilyBox");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "<thead><tr><th>Family ID</th>\r\n                <th>Street Name</th>\r\n                <th>House Number</th>\r\n                <th>Edit</th>\r\n                <th>View Family Members</th></tr></thead>\r\n            ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 36 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
             foreach (var family in familiesToShow)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 39 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
                         family.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 40 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
                         family.StreetName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 41 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
                         family.HouseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
                                            () => Edit(family.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
                                            () => ViewFamilyMembers(family.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "<i class=\"oi oi-arrow-thick-right\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
                                            () => RemoveFamily(family.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "<i class=\"oi oi-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
                           Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "<i class=\"oi oi-arrow-circle-bottom\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\FamilyPage.razor"
 
    private IList<Family> familiesToShow;
    private IList<Family> allFamilies;

    protected override async Task OnInitializedAsync()
    {
        allFamilies = FamilyData.GetFamilies();
        familiesToShow = allFamilies;
    }

    private void ViewFamilyMembers(int familyId)
    {
        NavigationManager.NavigateTo($"FamilyMembers/{familyId}");
    }
    
    private void Edit(int id)
    {
        NavigationManager.NavigateTo($"EditFamily/{id}");
    }

    private void Add()
    {
        NavigationManager.NavigateTo("AddFamily");
    }

    private void RemoveFamily(int familyId)
    {
        Family familyToRemove = allFamilies.First(f => f.Id == familyId);
        FamilyData.RemoveFamily(familyId);
        allFamilies.Remove(familyToRemove);
        familiesToShow.Remove(familyToRemove);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyData FamilyData { get; set; }
    }
}
#pragma warning restore 1591
