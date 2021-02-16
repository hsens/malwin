#pragma checksum "/home/djap/Covenant/Covenant/Components/Profiles/ProfileTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9355d049534fac8f8dc49143d0ef7bd21962e64"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Covenant.Components.Profiles
{
    #line hidden
    using System;
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
#line 1 "/home/djap/Covenant/Covenant/Components/Profiles/ProfileTable.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/Profiles/ProfileTable.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/djap/Covenant/Covenant/Components/Profiles/ProfileTable.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/djap/Covenant/Covenant/Components/Profiles/ProfileTable.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/djap/Covenant/Covenant/Components/Profiles/ProfileTable.razor"
using Covenant.Models.Listeners;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/djap/Covenant/Covenant/Components/Profiles/ProfileTable.razor"
using Covenant.Components.Shared;

#line default
#line hidden
#nullable disable
    public partial class ProfileTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/home/djap/Covenant/Covenant/Components/Profiles/ProfileTable.razor"
       
    [Parameter]
    public IEnumerable<Profile> Profiles { get; set; }

    [Parameter]
    public bool IsSearchable { get; set; } = false;

    [Parameter]
    public bool IsSortable { get; set; } = true;

    [Parameter]
    public bool IsPaginated { get; set; } = true;

    [Parameter]
    public int PageLength { get; set; } = 25;

    private string ToString(List<string> list)
    {
        return string.Join(",", list);
    }

    private bool IsAdmin()
    {
        return AuthenticationStateProvider
            .GetAuthenticationStateAsync()
            .WaitResult().User
            .IsInRole("Administrator");
    }

    private bool IsRowDisplayed(Profile profile, string SearchTerm)
    {
        return SearchTerm == string.Empty ||
            profile.Name.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            profile.Description.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            profile.Type.ToString().Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
