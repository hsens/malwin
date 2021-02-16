#pragma checksum "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/EditReferenceSourceLibrary.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d6ec328a5c0d4e2edff1a440cbb8522ada61a72"
// <auto-generated/>
#pragma warning disable 1591
namespace Covenant.Components.ReferenceSourceLibraries
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
#line 5 "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/EditReferenceSourceLibrary.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/EditReferenceSourceLibrary.razor"
using Covenant.Models.Grunts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/EditReferenceSourceLibrary.razor"
           [Authorize(Roles = "User, Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/referencesourcelibrary/edit/{ReferenceSourceLibraryId:int}")]
    public partial class EditReferenceSourceLibrary : OwningComponentBase<ICovenantService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex justify-content-between flex-wrap flex-md-nowrap pb-2 mb-3");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "h1");
            __builder.AddAttribute(4, "class", "h2");
            __builder.AddContent(5, "ReferenceSourceLibrary: ");
            __builder.OpenElement(6, "span");
            __builder.AddAttribute(7, "id", "task-name");
            __builder.AddAttribute(8, "class", "primary-color");
            __builder.AddContent(9, 
#nullable restore
#line 10 "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/EditReferenceSourceLibrary.razor"
                                                                                       ReferenceSourceLibrary.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n\n");
            __builder.OpenComponent<Covenant.Components.ReferenceSourceLibraries.ReferenceSourceLibraryForm>(12);
            __builder.AddAttribute(13, "ReferenceSourceLibrary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Covenant.Models.Grunts.ReferenceSourceLibrary>(
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/EditReferenceSourceLibrary.razor"
                                                    ReferenceSourceLibrary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Covenant.Models.Grunts.ReferenceSourceLibrary>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Covenant.Models.Grunts.ReferenceSourceLibrary>(this, 
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/EditReferenceSourceLibrary.razor"
                                                                                      OnEdit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "SubmitIcon", "edit");
            __builder.AddAttribute(16, "SubmitLabel", "Edit");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/EditReferenceSourceLibrary.razor"
       
    [Parameter]
    public int ReferenceSourceLibraryId { get; set; }

    [Parameter]
    public ReferenceSourceLibrary ReferenceSourceLibrary { get; set; }

    protected override async Task OnInitializedAsync()
    {
        this.ReferenceSourceLibrary = this.ReferenceSourceLibrary ?? await Service.GetReferenceSourceLibrary(this.ReferenceSourceLibraryId);
    }

    public async Task OnEdit(ReferenceSourceLibrary library)
    {
        try
        {
            await Service.EditReferenceSourceLibrary(library);
            NavigationManager.NavigateTo("/listener");
        }
        catch (Exception e) when (e is ControllerNotFoundException || e is ControllerBadRequestException || e is ControllerUnauthorizedException)
        {
            // return RedirectToAction(nameof(Edit), new { id = libraryModel.Id });
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
