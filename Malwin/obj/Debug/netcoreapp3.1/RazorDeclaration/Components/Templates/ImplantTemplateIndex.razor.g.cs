#pragma checksum "/home/djap/Covenant/Covenant/Components/Templates/ImplantTemplateIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb04b4f56dc0ce760cc767e9f0565452fdcd94e0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Covenant.Components.Templates
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/home/djap/Covenant/Covenant/Components/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/djap/Covenant/Covenant/Components/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/djap/Covenant/Covenant/Components/_Imports.razor"
using Covenant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/djap/Covenant/Covenant/Components/Templates/ImplantTemplateIndex.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/djap/Covenant/Covenant/Components/Templates/ImplantTemplateIndex.razor"
using Covenant.Models.Grunts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/djap/Covenant/Covenant/Components/Templates/ImplantTemplateIndex.razor"
           [Authorize(Roles = "User, Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/template")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/template/index")]
    public partial class ImplantTemplateIndex : OwningComponentBase<ICovenantService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/home/djap/Covenant/Covenant/Components/Templates/ImplantTemplateIndex.razor"
       
    [Parameter]
    public IEnumerable<ImplantTemplate> ImplantTemplates { get; set; }

    protected override async Task OnInitializedAsync()
    {
        this.ImplantTemplates = this.ImplantTemplates ?? await Service.GetImplantTemplates();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
