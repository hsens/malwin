#pragma checksum "/home/djap/Covenant/Covenant/Components/Indicators/IndicatorTables.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e6dbea06d6859d928ba691fe87f4a8920674b45"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Covenant.Components.Indicators
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
#line 1 "/home/djap/Covenant/Covenant/Components/Indicators/IndicatorTables.razor"
using Covenant.Models.Indicators;

#line default
#line hidden
#nullable disable
    public partial class IndicatorTables : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "/home/djap/Covenant/Covenant/Components/Indicators/IndicatorTables.razor"
       
    [Parameter]
    public IEnumerable<TargetIndicator> TargetIndicators { get; set; }

    [Parameter]
    public IEnumerable<NetworkIndicator> NetworkIndicators { get; set; }

    [Parameter]
    public IEnumerable<FileIndicator> FileIndicators { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
