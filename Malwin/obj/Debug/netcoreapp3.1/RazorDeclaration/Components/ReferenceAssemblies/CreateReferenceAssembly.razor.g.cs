#pragma checksum "/home/djap/Covenant/Covenant/Components/ReferenceAssemblies/CreateReferenceAssembly.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a29cae75eda6085543b15337682ebb66cf9b8a38"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Covenant.Components.ReferenceAssemblies
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
#line 5 "/home/djap/Covenant/Covenant/Components/ReferenceAssemblies/CreateReferenceAssembly.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/djap/Covenant/Covenant/Components/ReferenceAssemblies/CreateReferenceAssembly.razor"
using Covenant.Models.Grunts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/ReferenceAssemblies/CreateReferenceAssembly.razor"
           [Authorize(Roles = "User, Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/referenceassembly/create")]
    public partial class CreateReferenceAssembly : OwningComponentBase<ICovenantService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/home/djap/Covenant/Covenant/Components/ReferenceAssemblies/CreateReferenceAssembly.razor"
       
    [Parameter]
    public ReferenceAssembly ReferenceAssembly { get; set; }

    protected override void OnInitialized()
    {
        this.ReferenceAssembly = this.ReferenceAssembly ?? new ReferenceAssembly();
    }

    public async Task OnCreate(ReferenceAssembly assembly)
    {
        try
        {
            await Service.CreateReferenceAssembly(assembly);
            NavigationManager.NavigateTo("/grunttask");
        }
        catch (Exception e) when (e is ControllerNotFoundException || e is ControllerBadRequestException || e is ControllerUnauthorizedException)
        {
            // return View(new ReferenceAssembly());
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
