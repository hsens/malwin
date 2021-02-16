#pragma checksum "/home/djap/Covenant/Covenant/Components/Credentials/HashCredentialTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "998ff6fae1aca10ec781875e191553197a31f8fc"
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
#line 1 "/home/djap/Covenant/Covenant/Components/Credentials/HashCredentialTable.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/Credentials/HashCredentialTable.razor"
using Covenant.Models.Covenant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/djap/Covenant/Covenant/Components/Credentials/HashCredentialTable.razor"
using Covenant.Components.Shared;

#line default
#line hidden
#nullable disable
    public partial class HashCredentialTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "/home/djap/Covenant/Covenant/Components/Credentials/HashCredentialTable.razor"
       
    [Parameter]
    public IEnumerable<CapturedHashCredential> HashCredentials { get; set; }

    [Parameter]
    public bool IsSearchable { get; set; } = false;

    [Parameter]
    public bool IsSortable { get; set; } = true;

    [Parameter]
    public bool IsPaginated { get; set; } = true;

    [Parameter]
    public int PageLength { get; set; } = 10;

    private bool IsRowDisplayed(CapturedHashCredential credential, string SearchTerm)
    {
        return SearchTerm == string.Empty ||
            credential.Domain.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            credential.Username.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            credential.HashCredentialType.ToString().Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            credential.Hash.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
