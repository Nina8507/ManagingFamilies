#pragma checksum "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "926189ece7d7a611d8caec41aeeca06e231fda99"
// <auto-generated/>
#pragma warning disable 1591
namespace ManagingFamilies.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\_Imports.razor"
using ManagingFamilies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\_Imports.razor"
using ManagingFamilies.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Policy", "MustBeMale");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "<h1>Hello, John!</h1>\r\n    \r\n    ");
                __builder2.AddMarkupContent(4, "<h2>Welcome back.</h2>\r\n    \r\n    <img src=\"/StaticFolder/Images/9472721391_d5f7634f1e_c.jpg\" asp-append-version=\"true\" width=\"600px\">");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
