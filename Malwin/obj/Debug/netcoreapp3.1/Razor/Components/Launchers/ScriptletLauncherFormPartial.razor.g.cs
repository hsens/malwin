#pragma checksum "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6b3858a8b0fff3aa517a5fe5796dfc2b0a23286"
// <auto-generated/>
#pragma warning disable 1591
namespace Covenant.Components.Launchers
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
#line 1 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
using Covenant.Models.Launchers;

#line default
#line hidden
#nullable disable
    public partial class ScriptletLauncherFormPartial : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-row");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-group col-md-3");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.AddMarkupContent(6, "<label for=\"ScriptLanguage\">ScriptLanguage</label><br>\n        ");
            __builder.OpenElement(7, "select");
            __builder.AddAttribute(8, "id", "ScriptLanguage");
            __builder.AddAttribute(9, "name", "ScriptLanguage");
            __builder.AddAttribute(10, "value", 
#nullable restore
#line 9 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
                                                                  ScriptletLauncher

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
                                                                                                (e => OnScriptLanguageChanged(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "class", "selectpicker show-menu-arrow");
            __builder.AddAttribute(13, "data-dropup-auto", "false");
            __builder.AddAttribute(14, "data-width", "auto");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 10 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
             foreach (var n in Enum.GetNames(typeof(ScriptingLanguage)))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", 
#nullable restore
#line 12 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
                                 ((Enum)typeof(ScriptingLanguage).GetField(n).GetValue(null)).ToString("d")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, 
#nullable restore
#line 12 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
                                                                                                               n

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n");
#nullable restore
#line 13 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "text-danger");
            __Blazor.Covenant.Components.Launchers.ScriptletLauncherFormPartial.TypeInference.CreateValidationMessage_0(__builder, 25, 26, 
#nullable restore
#line 15 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
                                                         () => ScriptletLauncher.ScriptLanguage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "form-group col-md-6");
            __builder.AddMarkupContent(31, "\n        ");
            __builder.AddMarkupContent(32, "<label for=\"ProgId\">ProgId</label>\n        ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "id", "ProgId");
            __builder.AddAttribute(35, "name", "ProgId");
            __builder.AddAttribute(36, "value", 
#nullable restore
#line 20 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
                                                 ScriptletLauncher.ProgId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
                                                                                      (e => OnProgIdChanged(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "class", "form-control");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "text-danger");
            __Blazor.Covenant.Components.Launchers.ScriptletLauncherFormPartial.TypeInference.CreateValidationMessage_1(__builder, 42, 43, 
#nullable restore
#line 21 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
                                                         () => ScriptletLauncher.ProgId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/home/djap/Covenant/Covenant/Components/Launchers/ScriptletLauncherFormPartial.razor"
       
    [Parameter]
    public Launcher Launcher { get; set; }
    public ScriptletLauncher ScriptletLauncher { get; set; }

    [Parameter]
    public EventCallback<Launcher> LauncherChanged { get; set; }

    protected override void OnInitialized()
    {
        this.ScriptletLauncher = (ScriptletLauncher)this.Launcher;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await IJSRuntime.InvokeAsync<string>("InitializeSelectPicker", "#ScriptLanguage.selectpicker", ((int)Enum.Parse(typeof(ScriptingLanguage), ScriptletLauncher.ScriptLanguage.ToString())).ToString());
    }

    private void OnScriptLanguageChanged(ChangeEventArgs e)
    {
        if (Enum.TryParse(e.Value.ToString(), out ScriptingLanguage lang))
        {
            this.ScriptletLauncher.ScriptLanguage = lang;
            this.LauncherChanged.InvokeAsync(this.ScriptletLauncher);
        }
    }

    private void OnProgIdChanged(ChangeEventArgs e)
    {
        this.ScriptletLauncher.ProgId = e.Value.ToString();
        this.LauncherChanged.InvokeAsync(this.ScriptletLauncher);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
namespace __Blazor.Covenant.Components.Launchers.ScriptletLauncherFormPartial
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591