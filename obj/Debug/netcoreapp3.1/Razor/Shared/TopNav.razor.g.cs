#pragma checksum "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\Shared\TopNav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff258eaee314519aba005969c70ba6f05c271cd0"
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
    public partial class TopNav : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "nav-bar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "pos");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "i");
            __builder.AddAttribute(7, "id", "backbtn");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\Shared\TopNav.razor"
                                  Back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "mdi mdi-chevron-left");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "em");
            __builder.AddContent(12, " ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "href", "/");
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(16, "EmmTol");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\Shared\TopNav.razor"
                        Switchbtn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "tabindex", "-1");
            __builder.AddMarkupContent(21, "\r\n            <i class=\"mdi mdi-menu\"></i>\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "nav");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "ul");
            __builder.AddAttribute(26, "class", "links");
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "li");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "href", "/");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(32, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 10 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\Shared\TopNav.razor"
                     if (loggedIn)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                        ");
            __builder.OpenElement(35, "li");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
            __builder.AddAttribute(37, "href", "/Dashboard");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(39, "Dashboard");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "li");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "href", "/LogOut");
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(45, "LogOut");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 14 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\Shared\TopNav.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                        ");
            __builder.OpenElement(48, "li");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
            __builder.AddAttribute(50, "href", "/Login");
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(52, "Login");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "li");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(55);
            __builder.AddAttribute(56, "href", "/Register");
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(58, "Register");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 19 "E:\CODE\SIT\PRACTICE\APPS\MyApp\MyApp\Shared\TopNav.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        <div class=\"clr\"></div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
