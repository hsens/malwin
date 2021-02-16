#pragma checksum "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4caa0537fa5d74811a8b943d7a5f0b01361d7321"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Covenant.Components.Listeners
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
#line 5 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
using Covenant.Models.Covenant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
using Covenant.Models.Listeners;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
using Covenant.Components.HostedFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
           [Authorize(Roles = "User, Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listener/edit/{ListenerId:int}")]
    public partial class EditListener : OwningComponentBase<ICovenantService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
       
    [Parameter]
    public int ListenerId { get; set; }

    [Parameter]
    public Listener Listener { get; set; }

    private bool IsDeleted { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        this.Listener = this.Listener ?? await Service.GetListener(this.ListenerId);
        Service.DisposeContext();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await IJSRuntime.InvokeAsync<object>("ShowTab", new[] { "#info-tab" });
    }

    private async Task OnSubmitHttpListener(HttpListener listener)
    {
        try
        {
            await Service.EditHttpListener(listener);
            NavigationManager.NavigateTo("/listener");
        }
        catch (Exception e) when (e is ControllerNotFoundException || e is ControllerBadRequestException || e is ControllerUnauthorizedException)
        {
            // ModelState.AddModelError(string.Empty, e.Message);
            // return RedirectToAction(nameof(Create));
        }
    }

    private async Task OnSubmitBridgeListener(BridgeListener listener)
    {
        try
        {
            await Service.EditBridgeListener(listener);
            NavigationManager.NavigateTo("/listener");
        }
        catch (Exception e) when (e is ControllerNotFoundException || e is ControllerBadRequestException || e is ControllerUnauthorizedException)
        {
            // ModelState.AddModelError(string.Empty, e.Message);
            // return RedirectToAction(nameof(Create));
        }
    }

    private async Task StartListener()
    {
        try
        {
            if (Listener.Status != ListenerStatus.Active)
            {
                Listener.Status = ListenerStatus.Active;
                await Service.EditListener(Listener);
                NavigationManager.NavigateTo("/listener");
            }
        }
        catch (Exception e) when (e is ControllerNotFoundException || e is ControllerBadRequestException || e is ControllerUnauthorizedException)
        {
            // ModelState.AddModelError(string.Empty, e.Message);
            // return RedirectToAction(nameof(Index));
        }
    }

    private async Task StopListener()
    {
        try
        {
            if (Listener.Status != ListenerStatus.Stopped)
            {
                Listener.Status = ListenerStatus.Stopped;
                await Service.EditListener(Listener);
                NavigationManager.NavigateTo("/listener");
            }
        }
        catch (Exception e) when (e is ControllerNotFoundException || e is ControllerBadRequestException || e is ControllerUnauthorizedException)
        {
            // ModelState.AddModelError(string.Empty, e.Message);
            // return RedirectToAction(nameof(Index));
        }
    }

    private async Task DeleteListener()
    {
        try
        {
            this.IsDeleted = true;
            await Service.DeleteListener(Listener.Id);
            NavigationManager.NavigateTo("/listener");
        }
        catch (Exception e) when (e is ControllerNotFoundException || e is ControllerBadRequestException || e is ControllerUnauthorizedException)
        {
            // ModelState.AddModelError(string.Empty, e.Message);
            // return RedirectToAction(nameof(Index));
        }
    }

    private IEnumerable<HostedFile> GetHostedFiles()
    {
        return this.IsDeleted ? new List<HostedFile>() : Service.GetHostedFilesForListener(Listener.Id).WaitResult();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration Configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<CovenantUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
