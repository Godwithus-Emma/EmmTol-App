#pragma checksum "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\Shared\Notice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ffafe07c2074045988d42cd83a3665b45e9e21f"
// <auto-generated/>
#pragma warning disable 1591
namespace MyApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\_Imports.razor"
using MyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\_Imports.razor"
using MyApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class Notice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 2 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\Shared\Notice.razor"
              $" use-fade {(FadeIn ? "fade-in" : "")} {(Success? "success": "error")}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "span");
            __builder.AddContent(4, 
#nullable restore
#line 3 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\Shared\Notice.razor"
           _notification

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
