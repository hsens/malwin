#pragma checksum "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d84ec7a1a0bd8b82b9972d3219cdb087b604e4"
// <auto-generated/>
#pragma warning disable 1591
namespace Covenant.Components.Grunts
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
#line 3 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
using Covenant.Models.Grunts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
using Covenant.Components.Shared;

#line default
#line hidden
#nullable disable
    public partial class GruntTable : OwningComponentBase<ICovenantService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Covenant.Components.Shared.CovenantTable<Grunt>>(0);
            __builder.AddAttribute(1, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Grunt>>(
#nullable restore
#line 12 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                    Grunts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ItemsChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.List<Grunt>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.List<Grunt>>(this, 
#nullable restore
#line 12 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                          GruntsChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "SearchRow", new System.Func<Grunt, System.String, System.Boolean>(
#nullable restore
#line 12 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                                                    IsRowDisplayed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "IsSearchable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                             IsSearchable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "IsSortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                       IsSortable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "IsPaginated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                                                IsPaginated

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "PageLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                                                                         PageLength

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", "table table-hover");
            __builder.AddAttribute(9, "TableHeader", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\n");
#nullable restore
#line 15 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
         if (this.OnSelectTerminal.HasDelegate)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(11, "            ");
                __builder2.AddMarkupContent(12, "<th class=\"pl-1 pr-1\">\n                <div class=\"secondary-color\">\n                    <span class=\"fe fe-terminal\"></span>\n                </div>\n            </th>\n");
#nullable restore
#line 22 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "        ");
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<Grunt, string>>(14);
                __builder2.AddAttribute(15, "GetSortableProperty", new System.Func<Grunt, string>(
#nullable restore
#line 23 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                                                (grunt) => grunt.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "HeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(17, "Name");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n        ");
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<Grunt, string>>(19);
                __builder2.AddAttribute(20, "GetSortableProperty", new System.Func<Grunt, string>(
#nullable restore
#line 26 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                                                (grunt) => grunt.Hostname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "HeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(22, "Hostname");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\n        ");
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<Grunt, string>>(24);
                __builder2.AddAttribute(25, "GetSortableProperty", new System.Func<Grunt, string>(
#nullable restore
#line 29 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                                                (grunt) => grunt.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "HeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(27, "User");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n        ");
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<Grunt, IntegrityLevel>>(29);
                __builder2.AddAttribute(30, "GetSortableProperty", new System.Func<Grunt, IntegrityLevel>(
#nullable restore
#line 32 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                                                        (grunt) => grunt.Integrity

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "HeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(32, "Integrity");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\n        ");
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<Grunt, DateTime>>(34);
                __builder2.AddAttribute(35, "GetSortableProperty", new System.Func<Grunt, DateTime>(
#nullable restore
#line 35 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                                                  (grunt) => grunt.LastCheckIn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "HeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, "LastCheckIn");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\n        ");
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<Grunt, GruntStatus>>(39);
                __builder2.AddAttribute(40, "GetSortableProperty", new System.Func<Grunt, GruntStatus>(
#nullable restore
#line 38 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                                                     (grunt) => grunt.Status

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "HeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(42, "Status");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\n        ");
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<Grunt, string>>(44);
                __builder2.AddAttribute(45, "GetSortableProperty", new System.Func<Grunt, string>(
#nullable restore
#line 41 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                                                (grunt) => grunt.Note

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "HeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(47, "Note");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\n        ");
                __builder2.OpenComponent<Covenant.Components.Shared.SortableTableHeader<Grunt, string>>(49);
                __builder2.AddAttribute(50, "GetSortableProperty", new System.Func<Grunt, string>(
#nullable restore
#line 44 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                                                (grunt) => grunt.ImplantTemplate?.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "HeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(52, "Template");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\n    ");
            }
            ));
            __builder.AddAttribute(54, "TableRow", (Microsoft.AspNetCore.Components.RenderFragment<Grunt>)((grunt) => (__builder2) => {
                __builder2.AddMarkupContent(55, "\n        ");
                __builder2.OpenElement(56, "tr");
                __builder2.AddAttribute(57, "style", "opacity:" + " " + (
#nullable restore
#line 49 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                             GetGruntStatusOpacity(grunt.Status)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(58, "\n");
#nullable restore
#line 50 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
             if (this.OnSelectTerminal.HasDelegate)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(59, "                ");
                __builder2.OpenElement(60, "td");
                __builder2.AddMultipleAttributes(61, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 52 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                 InputAttributes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(62, "\n                    ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "secondary-color secondary-highlight-hover secondary-shadow");
                __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                                                                                      e => OnSelectTerminal.InvokeAsync(grunt)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(66, "\n                        <span class=\"fe fe-terminal\"></span>\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\n");
#nullable restore
#line 57 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(69, "            ");
                __builder2.OpenElement(70, "td");
                __builder2.AddMultipleAttributes(71, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 58 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                             InputAttributes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(72, "\n                ");
                __builder2.OpenElement(73, "a");
                __builder2.AddAttribute(74, "href", "/grunt/interact/" + (
#nullable restore
#line 59 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                          grunt.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(75, "\n                    ");
                __builder2.AddContent(76, 
#nullable restore
#line 60 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                     grunt.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(77, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\n            ");
                __builder2.OpenElement(80, "td");
                __builder2.AddMultipleAttributes(81, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 63 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                             InputAttributes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(82, 
#nullable restore
#line 63 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                               grunt.Hostname

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\n            ");
                __builder2.OpenElement(84, "td");
                __builder2.AddMultipleAttributes(85, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 64 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                             InputAttributes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(86, 
#nullable restore
#line 64 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                               grunt.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\n            ");
                __builder2.OpenElement(88, "td");
                __builder2.AddMultipleAttributes(89, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 65 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                             InputAttributes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(90, 
#nullable restore
#line 65 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                               grunt.Integrity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\n            ");
                __builder2.OpenElement(92, "td");
                __builder2.AddMultipleAttributes(93, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 66 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                             InputAttributes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(94, 
#nullable restore
#line 66 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                               grunt.LastCheckIn

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\n            ");
                __builder2.OpenElement(96, "td");
                __builder2.AddMultipleAttributes(97, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 67 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                             InputAttributes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(98, 
#nullable restore
#line 67 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                               grunt.Status

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\n            ");
                __builder2.OpenElement(100, "td");
                __builder2.AddMultipleAttributes(101, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 68 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                             InputAttributes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(102, 
#nullable restore
#line 68 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                               grunt.Note

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\n            ");
                __builder2.OpenElement(104, "td");
                __builder2.AddMultipleAttributes(105, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 69 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                             InputAttributes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(106, 
#nullable restore
#line 69 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                                               grunt.ImplantTemplate?.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\n    ");
            }
            ));
            __builder.AddAttribute(109, "ButtonTray", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(110, 
#nullable restore
#line 72 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
                 ButtonTray

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "/home/djap/Covenant/Covenant/Components/Grunts/GruntTable.razor"
       
    [Parameter]
    public List<Grunt> Grunts { get; set; }

    [Parameter]
    public EventCallback<List<Grunt>> GruntsChanged { get; set; }

    [Parameter]
    public bool IsSearchable { get; set; } = false;

    [Parameter]
    public bool IsSortable { get; set; } = true;

    [Parameter]
    public bool IsPaginated { get; set; } = true;

    [Parameter]
    public int PageLength { get; set; } = 50;

    [Parameter]
    public EventCallback<Grunt> OnSelectTerminal { get; set; }

    [Parameter]
    public RenderFragment ButtonTray { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> InputAttributes { get; set; }

    protected async override Task OnInitializedAsync()
    {
        this.Grunts = this.Grunts ?? (await Service.GetGrunts()).ToList();
        Service.DisposeContext();
    }

    private string GetGruntStatusOpacity(GruntStatus s)
    {
        return s == GruntStatus.Active ? "1.0" : "0.3";
    }

    private void OnGruntsChanged(List<Grunt> Grunts)
    {
        this.Grunts = Grunts;
        this.GruntsChanged.InvokeAsync(Grunts);
    }

    private bool IsRowDisplayed(Grunt grunt, string SearchTerm)
    {
        return SearchTerm == string.Empty ||
            grunt.Name.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            (grunt.ImplantTemplate != null && grunt.ImplantTemplate.Name.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase)) ||
            grunt.Hostname.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            grunt.UserName.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            grunt.Status.ToString().Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            grunt.LastCheckIn.ToString().Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            grunt.Integrity.ToString().Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            grunt.OperatingSystem.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase) ||
            grunt.Process.Contains(SearchTerm, StringComparison.CurrentCultureIgnoreCase);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService INotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
