#pragma checksum "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\ManagerView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b24816b2b1781198e21bafe37aeb555d8ddad74"
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
#nullable restore
#line 2 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\ManagerView.razor"
           [Authorize(Policy = "MustBeManager")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ManagerView")]
    public partial class ManagerView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Wellcome Jane to your view! </h2>\r\n\r\n<img src=\"StaticFolder/Images/owl-50267_640.jpg\" asp-append-version=\"true\" width=\"600px\">");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
