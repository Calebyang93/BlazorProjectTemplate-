#pragma checksum "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Timetester.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb61e5e5204c11381e6da83048275321ed222fab"
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
#nullable restore
#line 3 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Timetester.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Timetester")]
    public partial class Timetester : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "      \r\n    ");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, 
#nullable restore
#line 5 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Timetester.razor"
         TimeHeading

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "  \r\n  \r\n    Time Tester Counter:   \r\n    <br>  \r\n    <br>  \r\n\r\n    ");
            __builder.OpenElement(4, "p");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "label");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Timetester.razor"
                          TimeToday

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TimeToday = __value, TimeToday));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, " \r\n        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Timetester.razor"
                          ShowTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "\r\n            Show Time\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "  \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __builder.OpenElement(18, "p");
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "label");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "checkbox");
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Timetester.razor"
                                          CheckChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddContent(26, 
#nullable restore
#line 23 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Timetester.razor"
         checkedMessage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Timetester.razor"
           
        private string TimeHeading = "The time today is. We will countdown on timer now.";
        private string Showtime;
        private string checkedMessage = "The time taken was 1 minute";
        private DateTime TimeToday = new DateTime(2017, 11, 10, 10,10,30);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Timetester.razor"
            

        private async Task ShowTime() {
            await Task.Delay(4000);
            TimeHeading = $"{TimeToday}!!!";
        }
        private void CheckChanged() {
            checkedMessage = $"Last changed at {DateTime.Now}";
        }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
