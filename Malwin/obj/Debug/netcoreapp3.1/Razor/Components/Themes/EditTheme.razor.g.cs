#pragma checksum "/home/djap/Covenant/Covenant/Components/Themes/EditTheme.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9f1126acb0e33c053d2115bc2d1d568c2e2ff44"
// <auto-generated/>
#pragma warning disable 1591
namespace Covenant.Components.Themes
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
#line 5 "/home/djap/Covenant/Covenant/Components/Themes/EditTheme.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/djap/Covenant/Covenant/Components/Themes/EditTheme.razor"
using Covenant.Models.Covenant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/Themes/EditTheme.razor"
           [Authorize(Roles = "User, Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/theme/edit/{ThemeId:int}")]
    public partial class EditTheme : OwningComponentBase<ICovenantService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex justify-content-between flex-wrap flex-md-nowrap pb-2 mb-3");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "h1");
            __builder.AddAttribute(4, "class", "h2");
            __builder.AddContent(5, "Theme: ");
            __builder.OpenElement(6, "span");
            __builder.AddAttribute(7, "class", "primary-color");
            __builder.AddContent(8, 
#nullable restore
#line 10 "/home/djap/Covenant/Covenant/Components/Themes/EditTheme.razor"
                                                       Theme.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n\n");
            __builder.OpenComponent<Covenant.Components.Themes.ThemeForm>(11);
            __builder.AddAttribute(12, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Covenant.Models.Covenant.Theme>(
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/Themes/EditTheme.razor"
                  Theme

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Covenant.Models.Covenant.Theme>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Covenant.Models.Covenant.Theme>(this, 
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/Themes/EditTheme.razor"
                                   OnEdit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "\n    ");
                __builder2.AddMarkupContent(16, "<button type=\"submit\" class=\"btn btn-primary\">\n        <span class=\"fe fe-edit\"></span> Edit\n    </button>\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "/home/djap/Covenant/Covenant/Components/Themes/EditTheme.razor"
       
    [Parameter]
    public int ThemeId { get; set; }

    [Parameter]
    public Theme Theme { get; set; }

    protected override async Task OnInitializedAsync()
    {
        this.Theme = this.Theme ?? await Service.GetTheme(this.ThemeId);
        Service.DisposeContext();
    }

    private async Task OnEdit(Theme theme)
    {
        try
        {
            await Service.EditTheme(theme);
            NavigationManager.NavigateTo($"/covenantuser/index");
        }
        catch (Exception e) when (e is ControllerNotFoundException || e is ControllerBadRequestException || e is ControllerUnauthorizedException)
        {
            // ModelState.AddModelError(string.Empty, e.Message);
            // return RedirectToAction(nameof(Create), new { id = launcher.Name });
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
