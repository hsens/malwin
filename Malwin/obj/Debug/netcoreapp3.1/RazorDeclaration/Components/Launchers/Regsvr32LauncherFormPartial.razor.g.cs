#pragma checksum "/home/djap/Covenant/Covenant/Components/Launchers/Regsvr32LauncherFormPartial.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88d3f6b790f2fa6a934a195fa295650fba2f7606"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Covenant.Components.Launchers
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
#line 1 "/home/djap/Covenant/Covenant/Components/Launchers/Regsvr32LauncherFormPartial.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/Launchers/Regsvr32LauncherFormPartial.razor"
using Covenant.Models.Launchers;

#line default
#line hidden
#nullable disable
    public partial class Regsvr32LauncherFormPartial : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "/home/djap/Covenant/Covenant/Components/Launchers/Regsvr32LauncherFormPartial.razor"
       
    [Parameter]
    public Launcher Launcher { get; set; }
    public Regsvr32Launcher Regsvr32Launcher { get; set; }

    [Parameter]
    public EventCallback<Launcher> LauncherChanged { get; set; }

    protected override void OnInitialized()
    {
        this.Regsvr32Launcher = (Regsvr32Launcher)this.Launcher;
    }

    private void OnParameterStringChanged(ChangeEventArgs e)
    {
        this.Regsvr32Launcher.ParameterString = e.Value.ToString();
        this.LauncherChanged.InvokeAsync(this.Regsvr32Launcher);
    }

    private void OnDllNameChanged(ChangeEventArgs e)
    {
        this.Regsvr32Launcher.DllName = e.Value.ToString();
        this.LauncherChanged.InvokeAsync(this.Regsvr32Launcher);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591