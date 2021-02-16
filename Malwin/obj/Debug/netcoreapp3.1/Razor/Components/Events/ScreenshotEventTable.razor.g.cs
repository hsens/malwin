#pragma checksum "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9092c8e50931ae0e8fa612cecfc5413bef0fd6fd"
// <auto-generated/>
#pragma warning disable 1591
namespace Covenant.Components.Events
{
    #line hidden
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
#line 1 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
using Covenant.Models.Covenant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
using Covenant.Components.Shared;

#line default
#line hidden
#nullable disable
    public partial class ScreenshotEventTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Covenant.Components.Shared.CovenantTable<ScreenshotEvent>>(0);
            __builder.AddAttribute(1, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ScreenshotEvent>>(
#nullable restore
#line 7 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
                                              ScreenshotEvents.ToList()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "SearchRow", new System.Func<ScreenshotEvent, System.String, System.Boolean>(
#nullable restore
#line 7 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
                                                                                    IsRowDisplayed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "IsSearchable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
                             IsSearchable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "IsSortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
                                                       IsSortable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "IsPaginated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
                                                                                IsPaginated

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "PageLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
                                                                                                         PageLength

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "class", "table table-hover");
            __builder.AddAttribute(8, "TableHeader", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<ScreenshotEvent, string>>(10);
                __builder2.AddAttribute(11, "GetSortableProperty", new System.Func<ScreenshotEvent, string>(
#nullable restore
#line 10 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
                                                                                          (screenshot) => screenshot.FileName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "HeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(13, "FileName");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n        ");
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<ScreenshotEvent, int>>(15);
                __builder2.AddAttribute(16, "GetSortableProperty", new System.Func<ScreenshotEvent, int>(
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
                                                                                       (screenshot) => Convert.FromBase64String(screenshot.FileContents).Length

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
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<ScreenshotEvent, string>>(20);
                __builder2.AddAttribute(21, "GetSortableProperty", new System.Func<ScreenshotEvent, string>(
#nullable restore
#line 16 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
                                                                                          (screenshot) => string.Empty

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "HeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(23, "Image");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\n    ");
            }
            ));
            __builder.AddAttribute(25, "TableRow", (Microsoft.AspNetCore.Components.RenderFragment<ScreenshotEvent>)((screenshot) => (__builder2) => {
                __builder2.AddMarkupContent(26, "\n        ");
                __builder2.OpenElement(27, "tr");
                __builder2.AddMarkupContent(28, "\n            ");
                __builder2.OpenElement(29, "td");
                __builder2.AddMarkupContent(30, "\n                ");
                __builder2.AddContent(31, 
#nullable restore
#line 23 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
                 screenshot.FileName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(32, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n            ");
                __builder2.OpenElement(34, "td");
                __builder2.AddMarkupContent(35, "\n                ");
                __builder2.AddContent(36, 
#nullable restore
#line 26 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
                 System.Convert.FromBase64String(screenshot.FileContents).Length

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n            ");
                __builder2.OpenElement(39, "td");
                __builder2.AddMarkupContent(40, "\n                ");
                __builder2.OpenElement(41, "img");
                __builder2.AddAttribute(42, "style", "max-width:100%");
                __builder2.AddAttribute(43, "src", "data:image/png;base64," + " " + (
#nullable restore
#line 29 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
                                                                         screenshot.FileContents

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "/home/djap/Covenant/Covenant/Components/Events/ScreenshotEventTable.razor"
       
    [Parameter]
    public IEnumerable<ScreenshotEvent> ScreenshotEvents { get; set; }

    [Parameter]
    public bool IsSearchable { get; set; } = false;

    [Parameter]
    public bool IsSortable { get; set; } = true;

    [Parameter]
    public bool IsPaginated { get; set; } = true;

    [Parameter]
    public int PageLength { get; set; } = 25;

    private bool IsRowDisplayed(ScreenshotEvent screenshot, string SearchTerm)
    {
        return SearchTerm == string.Empty ||
            screenshot.FileName.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            Convert.FromBase64String(screenshot.FileContents).Length.ToString().Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
