#pragma checksum "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acd7f0545bcef09cd2dfdebb10e268482b702a3a"
// <auto-generated/>
#pragma warning disable 1591
namespace _2021BlazorProj1App.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\_Imports.razor"
using _2021BlazorProj1App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\_Imports.razor"
using _2021BlazorProj1App.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>2021BlazorProj1App</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "ContactUs");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> ContactUs\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "li");
            __builder.AddAttribute(39, "class", "nav-item px-3");
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
            __builder.AddAttribute(42, "class", "nav-link");
            __builder.AddAttribute(43, "href", "fetchdata");
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(45, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "li");
            __builder.AddAttribute(49, "class", "nav-item px-3");
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(51);
            __builder.AddAttribute(52, "class", "nav-link");
            __builder.AddAttribute(53, "href", "Timetester");
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Time Tester page\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "li");
            __builder.AddAttribute(59, "class", "nav-item px-3");
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(61);
            __builder.AddAttribute(62, "class", "nav-link");
            __builder.AddAttribute(63, "href", "Mousehandler");
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Mouse Behavior\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n         ");
            __builder.OpenElement(68, "li");
            __builder.AddAttribute(69, "class", "nav-item px-3");
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(71);
            __builder.AddAttribute(72, "class", "nav-link");
            __builder.AddAttribute(73, "href", "Lambdaexpression");
            __builder.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(75, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span>Lambda tutorials\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n         ");
            __builder.OpenElement(78, "li");
            __builder.AddAttribute(79, "class", "nav-item px-3");
            __builder.AddMarkupContent(80, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(81);
            __builder.AddAttribute(82, "class", "nav-link");
            __builder.AddAttribute(83, "href", "Delegateeventhand");
            __builder.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(85, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span>Lambda Event handler\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n          ");
            __builder.OpenElement(88, "li");
            __builder.AddAttribute(89, "class", "nav-item px-3");
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(91);
            __builder.AddAttribute(92, "class", "nav-link");
            __builder.AddAttribute(93, "href", "parent");
            __builder.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(95, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span>Event callback            \r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.OpenElement(98, "li");
            __builder.AddAttribute(99, "class", "nav-item px-3");
            __builder.AddMarkupContent(100, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(101);
            __builder.AddAttribute(102, "class", "nav-link");
            __builder.AddAttribute(103, "href", "Preventdefaultaction");
            __builder.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(105, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span>Prevent Default Actions          \r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(106, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.OpenElement(108, "li");
            __builder.AddAttribute(109, "class", "nav-item px-3");
            __builder.AddMarkupContent(110, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(111);
            __builder.AddAttribute(112, "class", "nav-link");
            __builder.AddAttribute(113, "href", "Stopeventprop");
            __builder.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(115, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span>Stop Event Propagation          \r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(116, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
