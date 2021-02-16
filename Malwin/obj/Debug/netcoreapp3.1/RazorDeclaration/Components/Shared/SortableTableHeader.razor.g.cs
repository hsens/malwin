#pragma checksum "/home/djap/Covenant/Covenant/Components/Shared/SortableTableHeader.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "894ed13f06985cc908b5cfcc0e4b7035a3ceb7fa"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Covenant.Components.Shared
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
    public partial class SortableTableHeader<TItem, TItem2> : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "/home/djap/Covenant/Covenant/Components/Shared/SortableTableHeader.razor"
       
    [CascadingParameter]
    public CovenantTable<TItem> CovenantTable { get; set; }

    [Parameter]
    public Func<TItem, TItem2> GetSortableProperty { get; set; }

    [Parameter]
    public RenderFragment HeaderContent { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> InputAttributes { get; set; }

    private bool Sorted { get; set; } = false;
    private bool Ascending { get; set; } = true;

    protected override void OnInitialized()
    {
        this.CovenantTable.OnSortHeader += this.OnAnotherHeaderSorted;
    }

    public void Dispose()
    {
        this.CovenantTable.OnSortHeader -= this.OnAnotherHeaderSorted;
    }

    public void OnAnotherHeaderSorted(object sender, EventArgs e)
    {
        this.Sorted = false;
        this.StateHasChanged();
    }

    private void OnSortHeader()
    {
        _ = this.CovenantTable.OnSort(GetSortableProperty, this.Ascending);
        this.Ascending = !this.Ascending;
        this.Sorted = true;
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591