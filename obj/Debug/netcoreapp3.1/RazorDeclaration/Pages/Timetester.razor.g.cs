#pragma checksum "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Timetester.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61466e1f9f61d185e119559a2e7ac30a8633c40c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\lenovo\csharpdirectory\2021BlazorProj1App\Pages\Timetester.razor"
           
        private string TimeHeading = "The time today is. We will countdown on timer now.";
        private string Countdown;
        private string checkedMessage = "The time taken was 1 minute";
        private DateTime TimeToday = new DateTime(2017, 11, 10, 10,10,30);

        private void CountDown() {
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
