#pragma checksum "/home/djap/Covenant/Covenant/Components/EmbeddedResources/EmbeddedResourceForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c625c8623c75d37837e1a0ef4c2e78839c8aafd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Covenant.Components.EmbeddedResources
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
#line 1 "/home/djap/Covenant/Covenant/Components/EmbeddedResources/EmbeddedResourceForm.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/EmbeddedResources/EmbeddedResourceForm.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/djap/Covenant/Covenant/Components/EmbeddedResources/EmbeddedResourceForm.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/djap/Covenant/Covenant/Components/EmbeddedResources/EmbeddedResourceForm.razor"
using Covenant.Models.Grunts;

#line default
#line hidden
#nullable disable
    public partial class EmbeddedResourceForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "/home/djap/Covenant/Covenant/Components/EmbeddedResources/EmbeddedResourceForm.razor"
       
    [Parameter]
    public EmbeddedResource EmbeddedResource { get; set; }

    [Parameter]
    public string SubmitIcon { get; set; }

    [Parameter]
    public string SubmitLabel { get; set; }

    [Parameter]
    public EventCallback<EmbeddedResource> OnSubmit { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
