#pragma checksum "/home/djap/Covenant/Covenant/Components/Grunts/TabbedTerminals.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccc4d3610cf5bf9c3a4be950f56d007fca4ee5a9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Covenant.Components.Grunts
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
#line 4 "/home/djap/Covenant/Covenant/Components/Grunts/TabbedTerminals.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/djap/Covenant/Covenant/Components/Grunts/TabbedTerminals.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/djap/Covenant/Covenant/Components/Grunts/TabbedTerminals.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/djap/Covenant/Covenant/Components/Grunts/TabbedTerminals.razor"
using Covenant.Models.Covenant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/djap/Covenant/Covenant/Components/Grunts/TabbedTerminals.razor"
using Covenant.Models.Grunts;

#line default
#line hidden
#nullable disable
    public partial class TabbedTerminals : OwningComponentBase<ICovenantService>, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "/home/djap/Covenant/Covenant/Components/Grunts/TabbedTerminals.razor"
       
    [Parameter]
    public List<Grunt> TerminalGrunts { get; set; } = new List<Grunt>();

    [Parameter]
    public EventCallback<List<Grunt>> TerminalGruntsChanged { get; set; }

    [Parameter]
    public EventCallback<int> OnRemoveTerminal { get; set; }

    [CascadingParameter]
    private Task<AuthenticationState> AuthenticationState { get; set; }

    private CovenantUser CurrentUser { get; set; }
    private string ShowTab { get; set; } = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        this.CurrentUser = await Service.GetCurrentUser((await this.AuthenticationState).User);
        this.INotificationService.OnEditGrunt += OnEditGrunt;
        Service.DisposeContext();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (this.ShowTab != string.Empty)
        {
            await IJSRuntime.InvokeAsync<string>("ShowTab", ShowTab);
            this.ShowTab = string.Empty;
        }
    }

    public void Dispose()
    {
        this.INotificationService.OnEditGrunt -= OnEditGrunt;
    }

    private void OnEditGrunt(object sender, Grunt grunt)
    {
        if (this.TerminalGrunts.Any(G => G.Id == grunt.Id))
        {
            this.TerminalGrunts[this.TerminalGrunts.FindIndex(G => G.Id == grunt.Id)] = grunt;
            this.InvokeAsync(() => this.StateHasChanged());
        }
    }

    public void OnSelectTerminal(Grunt grunt)
    {
        int index = this.TerminalGrunts.FindIndex(G => G.Id == grunt.Id);
        if (index == -1)
        {
            this.TerminalGrunts.Add(grunt);
            index = this.TerminalGrunts.Count() - 1;
        }
        this.ShowTab = $"#terminal-tab-{index}";
        this.TerminalGruntsChanged.InvokeAsync(this.TerminalGrunts);
        this.StateHasChanged();
    }

    private async Task OnInteract(Tuple<Grunt, string> tuple)
    {
        GruntCommand command = await Service.InteractGrunt(tuple.Item1.Id, this.CurrentUser.Id, tuple.Item2);
        Service.DisposeContext();
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService INotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
