#pragma checksum "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26412069e9b45dfbd36642d12bd124f31e6e23a8"
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
#line 2 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdults")]
    public partial class AddAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<h3>Please <a href=\"Login\"> login</a> in order to view this page</h3>");
            }
            ));
            __builder.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
                __builder2.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
                          newAdult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
                                                    AddAdult

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(9, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, "\r\n            ");
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "class", "row justify-content-center align-items-center");
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "col-6");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "class", "createUserBox overflow-auto");
                    __builder3.AddMarkupContent(18, "<div class=\"form-group\"><h4>Please fill the fields:</h4></div>\r\n                        \r\n                        <br>\r\n                        \r\n                        <br>\r\n                        \r\n                        ");
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "form-group");
                    __builder3.OpenElement(21, "input");
                    __builder3.AddAttribute(22, "type", "text");
                    __builder3.AddAttribute(23, "placeholder", "First Name");
                    __builder3.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
                                                                                     newAdult.FirstName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.FirstName = __value, newAdult.FirstName));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(26, "\r\n                        \r\n                        <br>\r\n                        \r\n                        ");
                    __builder3.OpenElement(27, "div");
                    __builder3.AddAttribute(28, "class", "form-group");
                    __builder3.OpenElement(29, "input");
                    __builder3.AddAttribute(30, "type", "text");
                    __builder3.AddAttribute(31, "placeholder", "Last Name");
                    __builder3.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
                                                                                    newAdult.LastName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.LastName = __value, newAdult.LastName));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n                        \r\n                        <br>\r\n                        \r\n                        ");
                    __builder3.OpenElement(35, "div");
                    __builder3.AddAttribute(36, "class", "form-group");
                    __builder3.OpenElement(37, "input");
                    __builder3.AddAttribute(38, "type", "text");
                    __builder3.AddAttribute(39, "placeholder", "Color");
                    __builder3.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
                                                                                newAdult.HairColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.HairColor = __value, newAdult.HairColor));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\r\n                        \r\n                        <br>\r\n                        \r\n                        ");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "class", "form-group");
                    __builder3.OpenElement(45, "input");
                    __builder3.AddAttribute(46, "type", "text");
                    __builder3.AddAttribute(47, "placeholder", "Eye Color");
                    __builder3.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
                                                                                    newAdult.EyeColor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.EyeColor = __value, newAdult.EyeColor));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\r\n                        \r\n                        <br>\r\n                        \r\n                        ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "form-group");
                    __builder3.OpenElement(53, "input");
                    __builder3.AddAttribute(54, "type", "number");
                    __builder3.AddAttribute(55, "placeholder", "Age");
                    __builder3.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
                                                                                newAdult.Age

#line default
#line hidden
#nullable disable
                    , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.Age = __value, newAdult.Age, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\r\n                        \r\n                        <br>\r\n\r\n                        ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "form-group");
                    __builder3.OpenElement(61, "input");
                    __builder3.AddAttribute(62, "type", "number");
                    __builder3.AddAttribute(63, "placeholder", "Weight");
                    __builder3.AddAttribute(64, "step", "any");
                    __builder3.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
                                                                                              newAdult.Weight

#line default
#line hidden
#nullable disable
                    , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.Weight = __value, newAdult.Weight, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n                        \r\n                        <br>\r\n                        \r\n                        ");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "class", "form-group");
                    __builder3.OpenElement(70, "input");
                    __builder3.AddAttribute(71, "type", "number");
                    __builder3.AddAttribute(72, "placeholder", "Height");
                    __builder3.AddAttribute(73, "step", "any");
                    __builder3.AddAttribute(74, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
                                                                                              newAdult.Height

#line default
#line hidden
#nullable disable
                    , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.Height = __value, newAdult.Height, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\r\n                        \r\n                        <br>\r\n                        \r\n                        ");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "form-group");
                    __builder3.OpenElement(79, "input");
                    __builder3.AddAttribute(80, "type", "text");
                    __builder3.AddAttribute(81, "placeholder", "Sex");
                    __builder3.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 73 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
                                                                              newAdult.Sex

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.Sex = __value, newAdult.Sex));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(84, "\r\n                        \r\n                        <br>\r\n                        ");
                    __builder3.OpenElement(85, "div");
                    __builder3.AddAttribute(86, "class", "form-group");
                    __builder3.OpenElement(87, "input");
                    __builder3.AddAttribute(88, "type", "text");
                    __builder3.AddAttribute(89, "placeholder", "Job title");
                    __builder3.AddAttribute(90, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
                                                                                    newAdult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.JobTitle.JobTitle = __value, newAdult.JobTitle.JobTitle));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\r\n                        \r\n                        <br>\r\n                        \r\n                        ");
                    __builder3.OpenElement(93, "div");
                    __builder3.AddAttribute(94, "class", "form-group");
                    __builder3.OpenElement(95, "input");
                    __builder3.AddAttribute(96, "type", "number");
                    __builder3.AddAttribute(97, "placeholder", "Salary");
                    __builder3.AddAttribute(98, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 85 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
                                                                                  newAdult.JobTitle.Salary

#line default
#line hidden
#nullable disable
                    , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.JobTitle.Salary = __value, newAdult.JobTitle.Salary, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(100, "\r\n                        <br>\r\n                        \r\n                        ");
                    __builder3.AddMarkupContent(101, "<div class=\"form-group\"><button class=\"btn btn-outline-dark\" type=\"submit\">Save Changes</button></div>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\kkash\RiderProjects\DNP1Assignment1\FamilyBlazorWebApp\Pages\AddAdults.razor"
 
    //JobTitle = new Job() to create new Job and solve the NullPointer 
    private Adult newAdult = new Adult(){JobTitle = new Job()};

     private void AddAdult()
    {
         AdultData.AddAdult(newAdult);
        NavigationManager.NavigateTo("/Adults");
    
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591
