#pragma checksum "/home/djap/Covenant/Covenant/Components/Credentials/PasswordCredentialTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d165ce744e7d3904ee48c1dd6421ddbdc0f552ea"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Covenant.Components.Credentials
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
#line 1 "/home/djap/Covenant/Covenant/Components/Credentials/PasswordCredentialTable.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/Credentials/PasswordCredentialTable.razor"
using Covenant.Models.Covenant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/djap/Covenant/Covenant/Components/Credentials/PasswordCredentialTable.razor"
using Covenant.Components.Shared;

#line default
#line hidden
#nullable disable
    public partial class PasswordCredentialTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/home/djap/Covenant/Covenant/Components/Credentials/PasswordCredentialTable.razor"
       
    [Parameter]
    public IEnumerable<CapturedPasswordCredential> PasswordCredentials { get; set; }

    [Parameter]
    public bool IsSearchable { get; set; } = false;

    [Parameter]
    public bool IsSortable { get; set; } = true;

    [Parameter]
    public bool IsPaginated { get; set; } = true;

    [Parameter]
    public int PageLength { get; set; } = 10;

    private bool IsRowDisplayed(CapturedPasswordCredential credential, string SearchTerm)
    {
        return SearchTerm == string.Empty ||
            credential.Domain.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            credential.Username.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            credential.Password.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
