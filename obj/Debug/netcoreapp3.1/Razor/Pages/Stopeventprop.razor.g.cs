#pragma checksum "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Stopeventprop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aa6d372338e9d5753b4c1743880d1f2a564e325"
// <auto-generated/>
#pragma warning disable 1591
namespace _2021BlazorProj1App.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Stopeventprop")]
    public partial class Stopeventprop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "label");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "checkbox");
            __builder.AddAttribute(4, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Stopeventprop.razor"
                  stopPropagation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => stopPropagation = __value, stopPropagation));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    Stop Propagation\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "m-1 p-1 border border-primary");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Stopeventprop.razor"
                                                     OnSelectParentDiv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.AddMarkupContent(12, "<h3>Parent div</h3>\r\n\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "m-1 p-1 border");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Stopeventprop.razor"
                                          OnSelectChildDiv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "\r\n        Child div that doesn\'t stop propagation when selected.\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "m-1 p-1 border");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Stopeventprop.razor"
                                          OnSelectChildDiv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(21, "onclick", 
#nullable restore
#line 16 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Stopeventprop.razor"
                                      stopPropagation

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n        Child div that stops propagation when selected.\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenElement(25, "p");
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.AddContent(27, 
#nullable restore
#line 22 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Stopeventprop.razor"
     message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Stopeventprop.razor"
       
    private bool stopPropagation = false;
    private string message; 

    private void OnSelectParentDiv() =>
        message = $"The parent div was selected. {DateTime.Now}";

    private void OnSelectChildDiv() =>
        message = $"A child div was selected. {DateTime.Now}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591