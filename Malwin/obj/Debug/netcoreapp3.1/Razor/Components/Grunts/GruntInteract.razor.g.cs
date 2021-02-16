#pragma checksum "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1dd564e8743e86a7e964784148a695dc6d10972"
// <auto-generated/>
#pragma warning disable 1591
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
#line 6 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
using Covenant.Models.Grunts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
using Covenant.Models.Covenant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
using Covenant.Components.GruntTaskings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
           [Authorize(Roles = "User, Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/grunt/interact/{GruntId:int}")]
    public partial class GruntInteract : OwningComponentBase<ICovenantService>, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 20 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
 if (this.Grunt == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p>Loading...</p>\n");
#nullable restore
#line 23 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "d-flex justify-content-between flex-wrap flex-md-nowrap pb-2 mb-3");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "h1");
            __builder.AddAttribute(7, "class", "h2");
            __builder.AddContent(8, "Grunt: ");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "id", "grunt-name");
            __builder.AddAttribute(11, "class", "primary-color");
            __builder.AddContent(12, 
#nullable restore
#line 27 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
                                                                           Grunt.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n");
#nullable restore
#line 30 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
     if (!string.IsNullOrEmpty(this.Grunt.Note))
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.OpenElement(16, "p");
            __builder.AddMarkupContent(17, "<b>Note</b>: ");
            __builder.AddContent(18, 
#nullable restore
#line 32 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
                         Grunt.Note

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
#nullable restore
#line 33 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.AddMarkupContent(21, @"<ul class=""nav nav-tabs mb-3"" id=""grunt-tab"" role=""tablist"">
        <li class=""nav-item"">
            <a class=""nav-link"" id=""info-tab"" data-toggle=""tab"" href=""#info"" role=""tab"" aria-controls=""info"" aria-selected=""false"">
                <span class=""fe fe-info""></span>
                Info
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""interact-tab"" data-toggle=""tab"" href=""#interact"" role=""tab"" aria-controls=""interact"" aria-selected=""false"">
                <span class=""fe fe-terminal""></span>
                Interact
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""task-tab"" data-toggle=""tab"" href=""#task"" role=""tab"" aria-controls=""task"" aria-selected=""false"">
                <span class=""fe fe-box""></span>
                Task
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""taskings-tab"" data-toggle=""tab"" href=""#taskings"" role=""tab"" aria-controls=""taskings"" aria-selected=""false"">
                <span class=""fe fe-layers""></span>
                Taskings
            </a>
        </li>
    </ul>
");
            __builder.AddContent(22, "    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "tab-content");
            __builder.AddAttribute(25, "id", "grunt-tab-content");
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "tab-pane fade");
            __builder.AddAttribute(29, "id", "info");
            __builder.AddAttribute(30, "role", "tabpanel");
            __builder.AddAttribute(31, "aria-labelledby", "info-tab");
            __builder.AddMarkupContent(32, "\n            ");
            __builder.OpenComponent<Covenant.Components.Grunts.GruntForm>(33);
            __builder.AddAttribute(34, "Grunt", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Covenant.Models.Grunts.Grunt>(
#nullable restore
#line 64 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
                              Grunt

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Covenant.Models.Grunts.Grunt>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Covenant.Models.Grunts.Grunt>(this, 
#nullable restore
#line 64 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
                                               OnEdit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "tab-pane fade");
            __builder.AddAttribute(40, "id", "interact");
            __builder.AddAttribute(41, "role", "tabpanel");
            __builder.AddAttribute(42, "aria-labelledby", "interact-tab");
            __builder.AddMarkupContent(43, "\n            ");
            __builder.OpenComponent<Covenant.Components.Grunts.GruntInteractTerminal>(44);
            __builder.AddAttribute(45, "Grunt", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Covenant.Models.Grunts.Grunt>(
#nullable restore
#line 67 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
                                          Grunt

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "OnInteract", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Tuple<Covenant.Models.Grunts.Grunt, System.String>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Tuple<Covenant.Models.Grunts.Grunt, System.String>>(this, 
#nullable restore
#line 67 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
                                                             OnInteract

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "tab-pane fade");
            __builder.AddAttribute(51, "id", "task");
            __builder.AddAttribute(52, "role", "tabpanel");
            __builder.AddAttribute(53, "aria-labelledby", "task-tab");
            __builder.AddMarkupContent(54, "\n            ");
            __builder.OpenComponent<Covenant.Components.Grunts.GruntTaskAssignForm>(55);
            __builder.AddAttribute(56, "GruntId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 70 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
                                          GruntId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Covenant.Models.Grunts.GruntTask>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Covenant.Models.Grunts.GruntTask>(this, 
#nullable restore
#line 70 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
                                                             OnTask

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "tab-pane fade mb-5");
            __builder.AddAttribute(62, "id", "taskings");
            __builder.AddAttribute(63, "role", "tabpanel");
            __builder.AddAttribute(64, "aria-labelledby", "taskings-tab");
            __builder.AddMarkupContent(65, "\n            ");
            __builder.OpenComponent<Covenant.Components.GruntTaskings.GruntTaskingTable>(66);
            __builder.AddAttribute(67, "GruntTaskings", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Covenant.Models.Grunts.GruntTasking>>(
#nullable restore
#line 73 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
                                              GruntTaskings

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "PageLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 73 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
                                                                         50

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n");
#nullable restore
#line 76 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "/home/djap/Covenant/Covenant/Components/Grunts/GruntInteract.razor"
       
    [Parameter]
    public int GruntId { get; set; }

    [Parameter]
    public Grunt Grunt { get; set; }

    private CovenantUser CovenantUser { get; set; }
    private List<GruntTasking> GruntTaskings { get; set; }

    protected override async Task OnInitializedAsync()
    {
        this.Grunt = this.Grunt ?? await Service.GetGrunt(this.GruntId);
        AuthenticationState state = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        this.CovenantUser = await UserManager.GetUserAsync(state.User);
        this.GruntTaskings = (await Service.GetGruntTaskingsForGrunt(this.GruntId)).ToList();
        Service.DisposeContext();
        this.INotificationService.OnEditGrunt += OnEditGrunt;
        this.INotificationService.OnCreateGruntTasking += OnCreateGruntTasking;
        this.INotificationService.OnEditGruntTasking += OnEditGruntTasking;
    }

    public void Dispose()
    {
        this.INotificationService.OnEditGrunt -= OnEditGrunt;
        this.INotificationService.OnCreateGruntTasking -= OnCreateGruntTasking;
        this.INotificationService.OnEditGruntTasking -= OnEditGruntTasking;
    }

    bool scrollToBottom = false;
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await IJSRuntime.InvokeAsync<string>("ShowTab", "#info-tab");
        }
        if (scrollToBottom)
        {
            await IJSRuntime.InvokeAsync<string>("ScrollToBottom", "#interact-scroll");
        }
    }

    private void OnEditGrunt(object sender, Grunt grunt)
    {
        if (this.GruntId == grunt.Id)
        {
            this.Grunt = grunt;
        }
    }

    private void OnCreateGruntTasking(object sender, GruntTasking gruntTasking)
    {
        if (this.GruntId == gruntTasking.GruntId)
        {
            this.GruntTaskings.Add(gruntTasking);
            // scrollToBottom = true;
        }
    }

    private void OnEditGruntTasking(object sender, GruntTasking gruntTasking)
    {
        if (this.GruntId == gruntTasking.GruntId)
        {
            int index = this.GruntTaskings.FindIndex(GT => GT.Id == gruntTasking.Id);
            if (index != -1)
            {
                this.GruntTaskings[index] = gruntTasking;
                // scrollToBottom = true;
                _ = this.InvokeAsync(() => this.StateHasChanged());
            }
        }
    }

    private async Task OnEdit(Grunt grunt)
    {
        try
        {
            AuthenticationState state = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            await Service.EditGrunt(grunt, await Service.GetCurrentUser(state.User));
            Service.DisposeContext();
        }
        catch (Exception e) when (e is ControllerNotFoundException || e is ControllerBadRequestException || e is ControllerUnauthorizedException)
        {
            // return RedirectToAction(nameof(Interact), new { id = grunt.Id });
        }
    }

    private async Task OnInteract(Tuple<Grunt, string> tuple)
    {
        GruntCommand command = await Service.InteractGrunt(this.Grunt.Id, this.CovenantUser.Id, tuple.Item2);
        Service.DisposeContext();
        this.StateHasChanged();
    }

    private async Task OnTask(GruntTask task)
    {
        try
        {
            AuthenticationState state = await AuthenticationStateProvider.GetAuthenticationStateAsync();

            task = await Service.EditGruntTask(task);
            Service.DisposeContext();
            CovenantUser currentUser = await Service.GetCurrentUser(state.User);
            GruntCommand command = await Service.CreateGruntCommand(new GruntCommand
            {
                Command = task.GetVerboseCommand(),
                CommandTime = DateTime.UtcNow,
                UserId = currentUser.Id,
                GruntId = this.Grunt.Id,
                CommandOutputId = 0,
                CommandOutput = new CommandOutput()
            });
            Service.DisposeContext();
            GruntTasking created = await Service.CreateGruntTasking(new GruntTasking
            {
                GruntTaskId = task.Id,
                GruntId = this.Grunt.Id,
                Type = task.TaskingType,
                Status = GruntTaskingStatus.Uninitialized,
                GruntCommandId = command.Id
            });
            Service.DisposeContext();
            await IJSRuntime.InvokeAsync<string>("ShowTab", "#interact-tab");
        }
        catch (Exception e) when (e is ControllerNotFoundException || e is ControllerBadRequestException || e is ControllerUnauthorizedException)
        {
            // return RedirectToAction(nameof(Index));
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService INotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<CovenantUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
