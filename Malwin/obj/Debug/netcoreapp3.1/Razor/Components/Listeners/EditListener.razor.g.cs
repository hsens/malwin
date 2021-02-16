#pragma checksum "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4caa0537fa5d74811a8b943d7a5f0b01361d7321"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pb-2 mb-3");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "h1");
            __builder.AddAttribute(4, "class", "h2");
            __builder.AddContent(5, "Listener: ");
            __builder.OpenElement(6, "span");
            __builder.AddAttribute(7, "class", "primary-color");
            __builder.AddContent(8, 
#nullable restore
#line 20 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                                          Listener.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n\n");
#nullable restore
#line 23 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
 if (Listener.ListenerType.Name == "HTTP")
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.AddMarkupContent(12, @"<ul class=""nav nav-tabs mb-3"" id=""listener-tab"" role=""tablist"">
        <li class=""nav-item"">
            <a class=""nav-link"" id=""info-tab"" data-toggle=""tab"" href=""#info"" role=""tab"" aria-controls=""info"" aria-selected=""false"">
                <span class=""fe fe-info""></span>
                Info
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""host-tab"" data-toggle=""tab"" href=""#host"" role=""tab"" aria-controls=""host"" aria-selected=""false"">
                <span class=""fe fe-cloud""></span>
                Hosted Files
            </a>
        </li>
    </ul>
");
            __builder.AddContent(13, "    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "tab-content");
            __builder.AddAttribute(16, "id", "listener-tab-content");
            __builder.AddMarkupContent(17, "\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "tab-pane fade");
            __builder.AddAttribute(20, "id", "info");
            __builder.AddAttribute(21, "role", "tabpanel");
            __builder.AddAttribute(22, "aria-labelledby", "info-tab");
            __builder.AddMarkupContent(23, "\n            ");
            __builder.OpenComponent<Covenant.Components.Listeners.HttpListenerForm>(24);
            __builder.AddAttribute(25, "Listener", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Covenant.Models.Listeners.HttpListener>(
#nullable restore
#line 42 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                          (HttpListener)Listener

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "Profiles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Covenant.Models.Listeners.Profile>>(
#nullable restore
#line 43 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                        new List<Profile> { Listener.Profile }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Covenant.Models.Listeners.HttpListener>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Covenant.Models.Listeners.HttpListener>(this, 
#nullable restore
#line 44 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                        OnSubmitHttpListener

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(28, "SubmitIcon", "edit");
            __builder.AddAttribute(29, "SubmitLabel", "Edit");
            __builder.AddAttribute(30, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "btn-group");
            __builder.AddAttribute(34, "role", "group");
            __builder.AddMarkupContent(35, "\n");
#nullable restore
#line 49 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                 if (Listener.Status == ListenerStatus.Active)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "                    ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                                    StopListener

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "btn btn-warning");
            __builder.AddMarkupContent(41, "\n                        <span class=\"fe fe-stop-circle\"></span> Stop\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n");
#nullable restore
#line 54 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "                    ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                                    StartListener

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "class", "btn btn-primary");
            __builder.AddMarkupContent(48, "\n                        <span class=\"fe fe-play\"></span> Start\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n");
#nullable restore
#line 60 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                                DeleteListener

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "class", "btn btn-danger ml-2");
            __builder.AddMarkupContent(55, "\n                    <span class=\"fe fe-x\"></span> Delete\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "tab-pane fade");
            __builder.AddAttribute(61, "id", "host");
            __builder.AddAttribute(62, "role", "tabpanel");
            __builder.AddAttribute(63, "aria-labelledby", "host-tab");
            __builder.AddMarkupContent(64, "\n            ");
            __builder.OpenComponent<Covenant.Components.HostedFiles.HostedFileIndex>(65);
            __builder.AddAttribute(66, "ListenerId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 67 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                         ListenerId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "HostedFiles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Covenant.Models.Listeners.HostedFile>>(
#nullable restore
#line 67 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                                                  GetHostedFiles()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n");
#nullable restore
#line 70 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
}
else if (Listener.ListenerType.Name == "Bridge")
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "    ");
            __builder.AddMarkupContent(72, @"<ul class=""nav nav-tabs mb-3"" id=""listener-tab"" role=""tablist"">
        <li class=""nav-item"">
            <a class=""nav-link"" id=""info-tab"" data-toggle=""tab"" href=""#info"" role=""tab"" aria-controls=""info"" aria-selected=""false"">
                <span class=""fe fe-info""></span>
                Info
            </a>
        </li>
    </ul>
");
            __builder.AddContent(73, "    ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "tab-content");
            __builder.AddAttribute(76, "id", "listener-tab-content");
            __builder.AddMarkupContent(77, "\n        ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "tab-pane fade");
            __builder.AddAttribute(80, "id", "info");
            __builder.AddAttribute(81, "role", "tabpanel");
            __builder.AddAttribute(82, "aria-labelledby", "info-tab");
            __builder.AddMarkupContent(83, "\n            ");
            __builder.OpenComponent<Covenant.Components.Listeners.BridgeListenerForm>(84);
            __builder.AddAttribute(85, "Listener", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Covenant.Models.Listeners.BridgeListener>(
#nullable restore
#line 84 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                            (BridgeListener)Listener

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "Profiles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Covenant.Models.Listeners.Profile>>(
#nullable restore
#line 85 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                          new List<Profile> { Listener.Profile }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Covenant.Models.Listeners.BridgeListener>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Covenant.Models.Listeners.BridgeListener>(this, 
#nullable restore
#line 86 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                          OnSubmitBridgeListener

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(88, "SubmitIcon", "edit");
            __builder.AddAttribute(89, "SubmitLabel", "Edit");
            __builder.AddAttribute(90, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 89 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(91, "\n            ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "btn-group");
            __builder.AddAttribute(94, "role", "group");
            __builder.AddMarkupContent(95, "\n");
#nullable restore
#line 91 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                 if (Listener.Status == ListenerStatus.Active)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "                    ");
            __builder.OpenElement(97, "button");
            __builder.AddAttribute(98, "type", "button");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                                    StopListener

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(100, "class", "btn btn-warning");
            __builder.AddMarkupContent(101, "\n                        <span class=\"fe fe-stop-circle\"></span> Stop\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\n");
#nullable restore
#line 96 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "                    ");
            __builder.OpenElement(104, "button");
            __builder.AddAttribute(105, "type", "button");
            __builder.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                                    StartListener

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "class", "btn btn-primary");
            __builder.AddMarkupContent(108, "\n                        <span class=\"fe fe-play\"></span> Start\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n");
#nullable restore
#line 102 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "                ");
            __builder.OpenElement(111, "button");
            __builder.AddAttribute(112, "type", "button");
            __builder.AddAttribute(113, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
                                                DeleteListener

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(114, "class", "btn btn-danger ml-2");
            __builder.AddMarkupContent(115, "\n                    <span class=\"fe fe-x\"></span> Delete\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\n");
#nullable restore
#line 114 "/home/djap/Covenant/Covenant/Components/Listeners/EditListener.razor"
}

#line default
#line hidden
#nullable disable
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