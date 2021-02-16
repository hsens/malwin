#pragma checksum "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "380f1e9ac79598acdcc30435d81e890ac2990723"
// <auto-generated/>
#pragma warning disable 1591
namespace Covenant.Components.HostedFiles
{
    #line hidden
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
#line 1 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
using Covenant.Models.Listeners;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
using Covenant.Components.Shared;

#line default
#line hidden
#nullable disable
    public partial class HostedFileTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Covenant.Components.Shared.CovenantTable<HostedFile>>(0);
            __builder.AddAttribute(1, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<HostedFile>>(
#nullable restore
#line 10 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                                         HostedFiles.ToList()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "SearchRow", new System.Func<HostedFile, System.String, System.Boolean>(
#nullable restore
#line 10 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                                                                          IsRowDisplayed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "IsSearchable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                             IsSearchable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "IsSortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                                                       IsSortable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "IsPaginated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                                                                                IsPaginated

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "PageLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                                                                                                         PageLength

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "class", "table table-hover");
            __builder.AddAttribute(8, "TableHeader", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<HostedFile, string>>(10);
                __builder2.AddAttribute(11, "GetSortableProperty", new System.Func<HostedFile, string>(
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                                                                                     (file) => file.Path

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "HeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(13, "Path");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n        ");
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<HostedFile, int>>(15);
                __builder2.AddAttribute(16, "GetSortableProperty", new System.Func<HostedFile, int>(
#nullable restore
#line 16 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                                                                                  (file) => Convert.FromBase64String(file.Content).Length

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "HeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, "Size");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<HostedFile, string>>(20);
                __builder2.AddAttribute(21, "GetSortableProperty", new System.Func<HostedFile, string>(
#nullable restore
#line 19 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                                                                                     (file) => string.Empty

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "HeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(23, "Download");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\n    ");
            }
            ));
            __builder.AddAttribute(25, "TableRow", (Microsoft.AspNetCore.Components.RenderFragment<HostedFile>)((file) => (__builder2) => {
                __builder2.AddMarkupContent(26, "\n        ");
                __builder2.OpenElement(27, "tr");
                __builder2.AddMarkupContent(28, "\n            ");
                __builder2.OpenElement(29, "td");
                __builder2.AddMarkupContent(30, "\n                ");
                __builder2.OpenElement(31, "a");
                __builder2.AddAttribute(32, "href", "/listener/" + (
#nullable restore
#line 26 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                                    file.ListenerId

#line default
#line hidden
#nullable disable
                ) + "/hostedfile/edit/" + (
#nullable restore
#line 26 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                                                                     file.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(33, 
#nullable restore
#line 26 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                                                                               file.Path

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\n            ");
                __builder2.OpenElement(36, "td");
                __builder2.AddMarkupContent(37, "\n                ");
                __builder2.AddContent(38, 
#nullable restore
#line 29 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                 Convert.FromBase64String(file.Content).Length

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(39, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n            ");
                __builder2.OpenElement(41, "td");
                __builder2.AddMarkupContent(42, "\n                ");
                __builder2.OpenElement(43, "button");
                __builder2.AddAttribute(44, "type", "button");
                __builder2.AddAttribute(45, "class", "btn btn-primary");
                __builder2.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
                                                                        e => OnDownload(file)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(47, "\n                    <span class=\"fe fe-download\"></span>\n                    Download\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileTable.razor"
       
    [Parameter]
    public IEnumerable<HostedFile> HostedFiles { get; set; }

    [Parameter]
    public bool IsSearchable { get; set; } = false;

    [Parameter]
    public bool IsSortable { get; set; } = true;

    [Parameter]
    public bool IsPaginated { get; set; } = true;

    [Parameter]
    public int PageLength { get; set; } = 25;

    private async Task OnDownload(HostedFile file)
    {
        if (!Common.ContentTypeMappings.TryGetValue(Path.GetExtension(file.Path), out string contentType))
        {
            contentType = Common.DefaultContentTypeMapping;
        }
        await IJSRuntime.InvokeAsync<string>(
            "DownloadFile",
            Path.GetFileName(file.Path),
            contentType,
            file.Content
        );
    }

    private bool IsRowDisplayed(HostedFile file, string SearchTerm)
    {
        return SearchTerm == string.Empty ||
            file.Path.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591