#pragma checksum "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfa48dbfaa3fc83235daec36163a14cc0d0b5ac1"
// <auto-generated/>
#pragma warning disable 1591
namespace Covenant.Components.GruntTaskings
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
#line 6 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingIndex.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingIndex.razor"
using Covenant.Models.Grunts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingIndex.razor"
           [Authorize(Roles = "User, Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/grunttasking")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/grunttasking/index")]
    public partial class GruntTaskingIndex : OwningComponentBase<ICovenantService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pb-2 mb-3\">\n    <h1 class=\"h2\">GruntTaskings</h1>\n</div>\n\n");
            __builder.OpenComponent<Covenant.Components.GruntTaskings.GruntTaskingTable>(1);
            __builder.AddAttribute(2, "GruntTaskings", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Covenant.Models.Grunts.GruntTasking>>(
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingIndex.razor"
                                  GruntTaskings

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "IsPaginated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingIndex.razor"
                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "PageLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingIndex.razor"
                                                                                10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "IsSearchable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingIndex.razor"
                                                                                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "IsSortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingIndex.razor"
                                                                                                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingIndex.razor"
       
    [Parameter]
    public List<GruntTasking> GruntTaskings { get; set; }

    protected override async Task OnInitializedAsync()
    {
        this.GruntTaskings = this.GruntTaskings ?? (await Service.GetGruntTaskings()).ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
