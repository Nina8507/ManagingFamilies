#pragma checksum "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5d0193c32c697faf9260bf498c167a3c4061c20"
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
#line 2 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
using ManagingFamilies.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
using ManagingFamilies.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FamilyPage")]
    public partial class FamilyPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FamilyPage</h3>");
#nullable restore
#line 9 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
 if (familiesToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 14 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
}
else if (!familiesToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em> No Families register!</em></p>");
#nullable restore
#line 20 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-striped");
            __builder.AddMarkupContent(5, "<thead><tr><th scope=\"col\">House Number</th>\r\n                <th scope=\"col\">Street Name</th>\r\n                <th scope=\"col\">Adults</th>\r\n                <th scope=\"col\">Children</th>\r\n                <th scope=\"col\">Pets</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 34 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
         foreach(var family in familiesToShow)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 37 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
                 family.HouseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 38 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
                 family.StreetName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 39 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
                 family.Adults.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 40 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
                 family.Children.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 41 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
                 family.Pets.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\const\RiderProjects\ManagingFamilies\ManagingFamilies\Pages\FamilyPage.razor"
       
    private IList<Family> families;
    private IList<Family> allFamilies;
    private IList<Family> familiesToShow;
    
    protected override async Task OnInitializedAsync()
    {
        //families = FamilyData.GetAllFamilies();
        allFamilies = FamilyData.GetAllFamilies();
        familiesToShow = allFamilies;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyData FamilyData { get; set; }
    }
}
#pragma warning restore 1591
