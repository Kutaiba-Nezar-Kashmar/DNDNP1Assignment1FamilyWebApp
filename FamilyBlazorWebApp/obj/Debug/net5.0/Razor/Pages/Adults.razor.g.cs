#pragma checksum "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b13ba50b3657e233e4b94db1db3bd767a67df4af"
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
#line 2 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "aduPage");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "searchBox");
            __builder.AddMarkupContent(4, "<p id=\"search\">Search:</p>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "class", "searchInput");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "placeholder", "Name");
            __builder.AddAttribute(9, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                                                                            ((arg) => FilterByPersonName(arg))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "class", "searchInput");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "placeholder", "Gender");
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                                                                              ((arg) => FilterByGender(arg))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "class", "searchInput");
            __builder.AddAttribute(19, "type", "number");
            __builder.AddAttribute(20, "placeholder", "Age");
            __builder.AddAttribute(21, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                                                                             ((arg) => FilterByAge(arg))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "class", "searchInput");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "placeholder", "Eye color");
            __builder.AddAttribute(27, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                                                                                 ((arg) => FilterByEyeColor(arg))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "class", "searchInput");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "placeholder", "Hair color");
            __builder.AddAttribute(33, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                                                                                  ((arg) => FilterByHairColor(arg))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
     if (adultsToShow == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<p><em>Loading</em></p>");
#nullable restore
#line 21 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
    }
    else if (!adultsToShow.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<p><em style=\"color: white\">No people to show. Please add som.</em></p>");
#nullable restore
#line 27 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "<br>\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "adultTableBox");
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table");
            __builder.OpenElement(41, "thead");
            __builder.OpenElement(42, "tr");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(43);
            __builder.AddAttribute(44, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(45, "<th>Person ID</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.AddMarkupContent(47, "<th>First Name</th>\r\n                    ");
            __builder.AddMarkupContent(48, "<th>Last Name</th>\r\n                    ");
            __builder.AddMarkupContent(49, "<th>Job Title</th>\r\n                    ");
            __builder.AddMarkupContent(50, "<th>Salary</th>\r\n                    ");
            __builder.AddMarkupContent(51, "<th>Hair Color</th>\r\n                    ");
            __builder.AddMarkupContent(52, "<th>Eye Color</th>\r\n                    ");
            __builder.AddMarkupContent(53, "<th>Age</th>\r\n                    ");
            __builder.AddMarkupContent(54, "<th>Weight</th>\r\n                    ");
            __builder.AddMarkupContent(55, "<th>Height</th>\r\n                    ");
            __builder.AddMarkupContent(56, "<th>Sex</th>\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(57);
            __builder.AddAttribute(58, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(59, "<th>Edit</th>\r\n                            ");
                __builder2.AddMarkupContent(60, "<th>Remove</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "tbody");
#nullable restore
#line 59 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                 foreach (var adult in adultsToShow)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "tr");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(64);
            __builder.AddAttribute(65, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(66, "td");
                __builder2.AddContent(67, 
#nullable restore
#line 64 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                                     adult.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "td");
            __builder.AddContent(70, 
#nullable restore
#line 67 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                             adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 68 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                             adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 69 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                             adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.OpenElement(78, "td");
            __builder.AddContent(79, 
#nullable restore
#line 70 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                             adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.OpenElement(81, "td");
            __builder.AddContent(82, 
#nullable restore
#line 71 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                             adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.OpenElement(84, "td");
            __builder.AddContent(85, 
#nullable restore
#line 72 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                             adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                        ");
            __builder.OpenElement(87, "td");
            __builder.AddContent(88, 
#nullable restore
#line 73 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                             adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                        ");
            __builder.OpenElement(90, "td");
            __builder.AddContent(91, 
#nullable restore
#line 74 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                             adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                        ");
            __builder.OpenElement(93, "td");
            __builder.AddContent(94, 
#nullable restore
#line 75 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                             adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.OpenElement(96, "td");
            __builder.AddContent(97, 
#nullable restore
#line 76 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                             adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(99);
            __builder.AddAttribute(100, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(101, "td");
                __builder2.OpenElement(102, "button");
                __builder2.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                                                        () => Edit(adult.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(104, "<i class=\"oi oi-pencil\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n                                ");
                __builder2.OpenElement(106, "td");
                __builder2.OpenElement(107, "button");
                __builder2.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                                                        () => RemoveAdult(adult.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(109, "<i class=\"oi oi-trash\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 92 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 96 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\Adults.razor"
 
    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;

    private string? filterByName;
    private string? filterByGender;
    private string? filterByEyeColor;
    private string? filterByHairColor;
    private int? filterbuAge;
    
    private string errorMessage;
    
    protected override async Task OnInitializedAsync()
    {
        allAdults = AdultData.GetAdults();
        adultsToShow = allAdults;
    }

    private void FilterByPersonName(ChangeEventArgs changeEventArgs)
    {
        filterByName = null;
        try
        {
            filterByName = changeEventArgs.Value.ToString().ToLower();
            if (filterByName != null)
            {
                adultsToShow = allAdults.Where(a => ((a.FirstName + "" + a.LastName).ToLower()).Contains(filterByName)).ToList();
            }
            else
            {
                adultsToShow = allAdults;
            }
         }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
    }
    /*foreach(var adult in allAdults)
         use $"{firstName} ${lastname}.Contain" to search for an adult*/
    }

    private void FilterByGender(ChangeEventArgs changeEventArgs)
    {
        filterByGender = null;
        try
        {
            filterByGender = changeEventArgs.Value.ToString().ToLower();
            if (filterByGender != null)
            {
                adultsToShow = allAdults.Where(a => ((a.Sex).ToLower()).Contains(filterByGender)).ToList();
            }
            else
            {
                adultsToShow = allAdults;
            }
        }
        catch (Exception e)
        {
            errorMessage = "Try again";
        }
    }

    private void FilterByAge(ChangeEventArgs changeEventArgs)
    {
        filterbuAge = null;
        try
        {
            filterbuAge = int.Parse(changeEventArgs.Value.ToString());
            if (filterbuAge != null)
            {
                adultsToShow = allAdults.Where(a => a.Age == int.Parse(changeEventArgs.Value.ToString())).ToList();
            }
            else
            {
                adultsToShow = allAdults;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void FilterByEyeColor(ChangeEventArgs changeEventArgs)
    {
        filterByEyeColor = null;
        try
        {
            filterByEyeColor = changeEventArgs.Value.ToString().ToLower();
            if (filterByEyeColor != null)
            {
                adultsToShow = allAdults.Where(a => a.EyeColor.ToLower().Contains(filterByEyeColor)).ToList();
            }
            else
            {
                adultsToShow = allAdults;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    private void FilterByHairColor(ChangeEventArgs changeEventArgs)
    {
        filterByHairColor = null;
        try
        {
            filterByHairColor = changeEventArgs.Value.ToString().ToLower();
            if (filterByHairColor != null)
            {
                adultsToShow = allAdults.Where(a => a.HairColor.ToLower().Contains(filterByHairColor)).ToList();
            }
            else
            {
                adultsToShow = allAdults;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void Edit(int id)
    {
        NavigationManager.NavigateTo($"Edit/{id}");
    }

    private void RemoveAdult(int adultId)
    {
        Adult adultToRemove = allAdults.First(a => a.Id == adultId);
        AdultData.RemoveAdult(adultId);
        allAdults.Remove(adultToRemove);
        adultsToShow.Remove(adultToRemove);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591
