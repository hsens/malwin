#pragma checksum "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc49d598b4f9ab1464919b5d789d7319a305971e"
// <auto-generated/>
#pragma warning disable 1591
namespace Covenant.Components.GruntTaskings
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
#line 3 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
using Covenant.Models.Grunts;

#line default
#line hidden
#nullable disable
    public partial class GruntTaskingForm : OwningComponentBase<ICovenantService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddMarkupContent(1, "\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-row");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group col-md-4");
            __builder.AddMarkupContent(7, "\n            ");
            __builder.AddMarkupContent(8, "<label for=\"Name\">Name</label>\n            ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "id", "Name");
            __builder.AddAttribute(11, "name", "Name");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "readonly", true);
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                GruntTasking.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GruntTasking.Name = __value, GruntTasking.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group col-md-4");
            __builder.AddMarkupContent(20, "\n            ");
            __builder.AddMarkupContent(21, "<label for=\"Grunt.Name\">Grunt</label>\n            ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "id", "Grunt.Name");
            __builder.AddAttribute(24, "name", "Grunt.Name");
            __builder.AddAttribute(25, "href", "/grunt/interact/" + (
#nullable restore
#line 16 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                                        GruntTasking.Grunt.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "class", "btn btn-secondary text-left w-100");
            __builder.AddMarkupContent(27, "\n                ");
            __builder.AddContent(28, 
#nullable restore
#line 17 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                 GruntTasking.Grunt.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group col-md-4");
            __builder.AddMarkupContent(34, "\n            ");
            __builder.AddMarkupContent(35, "<label for=\"GruntTask.Name\">Task</label>\n            ");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "id", "GruntTask.Name");
            __builder.AddAttribute(38, "name", "GruntTask.Name");
            __builder.AddAttribute(39, "href", "/grunttask/edit/" + (
#nullable restore
#line 22 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                                                GruntTasking.GruntTask.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "btn btn-secondary text-left w-100");
            __builder.AddMarkupContent(41, "\n                ");
            __builder.AddContent(42, 
#nullable restore
#line 23 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                 GruntTasking.GruntTask.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "form-row");
            __builder.AddMarkupContent(49, "\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group col-md-4");
            __builder.AddMarkupContent(52, "\n            ");
            __builder.AddMarkupContent(53, "<label for=\"Status\">Status</label><br>\n            ");
            __builder.OpenElement(54, "select");
            __builder.AddAttribute(55, "id", "Status");
            __builder.AddAttribute(56, "name", "Status");
            __builder.AddAttribute(57, "class", "selectpicker show-menu-arrow");
            __builder.AddAttribute(58, "data-dropup-auto", "false");
            __builder.AddAttribute(59, "data-width", "auto");
            __builder.AddAttribute(60, "disabled", true);
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                     GruntTasking.Status

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GruntTasking.Status = __value, GruntTasking.Status));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(63, "\n");
#nullable restore
#line 31 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                 foreach (var n in Enum.GetNames(typeof(GruntTaskingStatus)))
                {
                    if (Enum.TryParse<GruntTaskingStatus>(n, out GruntTaskingStatus status) && this.GruntTasking.Status == status)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "                        ");
            __builder.OpenElement(65, "option");
            __builder.AddAttribute(66, "selected", true);
            __builder.AddAttribute(67, "value", 
#nullable restore
#line 35 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                  ((Enum)typeof(GruntTaskingStatus).GetField(n).GetValue(null)).ToString("d")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(68, 
#nullable restore
#line 35 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                                                                                                 n

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n");
#nullable restore
#line 36 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                        ");
            __builder.OpenElement(71, "option");
            __builder.AddAttribute(72, "value", 
#nullable restore
#line 39 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                         ((Enum)typeof(GruntTaskingStatus).GetField(n).GetValue(null)).ToString("d")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(73, 
#nullable restore
#line 39 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                                                                                        n

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n");
#nullable restore
#line 40 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\n        ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "form-group col-md-4");
            __builder.AddMarkupContent(80, "\n            ");
            __builder.AddMarkupContent(81, "<label for=\"GruntCommand.CommandTime\">CommandTime</label>\n            ");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "id", "GruntCommand.CommandTime");
            __builder.AddAttribute(84, "name", "GruntCommand.CommandTime");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "readonly", true);
            __builder.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                                                        GruntTasking.GruntCommand.CommandTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GruntTasking.GruntCommand.CommandTime = __value, GruntTasking.GruntCommand.CommandTime));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n        ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "form-group col-md-4");
            __builder.AddMarkupContent(93, "\n            ");
            __builder.AddMarkupContent(94, "<label for=\"Type\">Type</label><br>\n            ");
            __builder.OpenElement(95, "select");
            __builder.AddAttribute(96, "id", "Type");
            __builder.AddAttribute(97, "name", "Type");
            __builder.AddAttribute(98, "class", "selectpicker show-menu-arrow");
            __builder.AddAttribute(99, "data-dropup-auto", "false");
            __builder.AddAttribute(100, "data-width", "auto");
            __builder.AddAttribute(101, "disabled", true);
            __builder.AddAttribute(102, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                 GruntTasking.Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GruntTasking.Type = __value, GruntTasking.Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(104, "\n");
#nullable restore
#line 51 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                 foreach (var n in Enum.GetNames(typeof(GruntTaskingType)))
                {
                    if (Enum.TryParse<GruntTaskingType>(n, out GruntTaskingType type) && this.GruntTasking.Type == type)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "                        ");
            __builder.OpenElement(106, "option");
            __builder.AddAttribute(107, "selected", true);
            __builder.AddAttribute(108, "value", 
#nullable restore
#line 55 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                  ((Enum)typeof(GruntTaskingType).GetField(n).GetValue(null)).ToString("d")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(109, 
#nullable restore
#line 55 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                                                                                               n

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\n");
#nullable restore
#line 56 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(111, "                        ");
            __builder.OpenElement(112, "option");
            __builder.AddAttribute(113, "value", 
#nullable restore
#line 59 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                         ((Enum)typeof(GruntTaskingType).GetField(n).GetValue(null)).ToString("d")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(114, 
#nullable restore
#line 59 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                                                                                      n

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\n");
#nullable restore
#line 60 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(116, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\n    ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "form-row");
            __builder.AddMarkupContent(122, "\n        ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "form-group col-md-4");
            __builder.AddMarkupContent(125, "\n            ");
            __builder.AddMarkupContent(126, "<label for=\"GruntCommand.User.UserName\">UserName</label>\n            ");
            __builder.OpenElement(127, "input");
            __builder.AddAttribute(128, "id", "GruntCommand.User.UserName");
            __builder.AddAttribute(129, "name", "GruntCommand.User.UserName");
            __builder.AddAttribute(130, "class", "form-control");
            __builder.AddAttribute(131, "readonly", true);
            __builder.AddAttribute(132, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                                                            GruntTasking.GruntCommand.User.UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(133, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GruntTasking.GruntCommand.User.UserName = __value, GruntTasking.GruntCommand.User.UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\n        ");
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "form-group col-md-8");
            __builder.AddMarkupContent(138, "\n            ");
            __builder.AddMarkupContent(139, "<label for=\"GruntCommand.Command\">Command</label>\n            ");
            __builder.OpenElement(140, "textarea");
            __builder.AddAttribute(141, "id", "GruntCommand.Command");
            __builder.AddAttribute(142, "name", "GruntCommand.Command");
            __builder.AddAttribute(143, "rows", "1");
            __builder.AddAttribute(144, "class", "form-control");
            __builder.AddAttribute(145, "readonly", true);
            __builder.AddAttribute(146, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                                                   GruntTasking.GruntCommand.Command

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(147, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GruntTasking.GruntCommand.Command = __value, GruntTasking.GruntCommand.Command));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\n");
#nullable restore
#line 75 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
     for (int i = 0; i < Math.Min(GruntTasking.Parameters.Count, GruntTasking.GruntTask.Options.Count); i++)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(151, "        ");
            __builder.OpenElement(152, "div");
            __builder.AddAttribute(153, "class", "form-group");
            __builder.AddMarkupContent(154, "\n            ");
            __builder.OpenElement(155, "label");
            __builder.AddAttribute(156, "for", "Parameters[" + (
#nullable restore
#line 78 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                    i

#line default
#line hidden
#nullable disable
            ) + "]");
            __builder.AddContent(157, 
#nullable restore
#line 78 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                         GruntTasking.GruntTask.Options[i].Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\n            ");
            __builder.OpenElement(159, "input");
            __builder.AddAttribute(160, "id", "Parameters[" + (
#nullable restore
#line 79 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                   i

#line default
#line hidden
#nullable disable
            ) + "]");
            __builder.AddAttribute(161, "name", "Parameters[" + (
#nullable restore
#line 79 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                         i

#line default
#line hidden
#nullable disable
            ) + "]");
            __builder.AddAttribute(162, "class", "form-control");
            __builder.AddAttribute(163, "readonly", true);
            __builder.AddAttribute(164, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                                    GruntTasking.Parameters[i]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(165, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GruntTasking.Parameters[i] = __value, GruntTasking.Parameters[i]));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\n");
#nullable restore
#line 81 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(168, "    ");
            __builder.OpenElement(169, "div");
            __builder.AddAttribute(170, "class", "form-group");
            __builder.AddMarkupContent(171, "\n        ");
            __builder.AddMarkupContent(172, "<label for=\"GruntCommand.CommandOutput.Output\">Output</label>\n");
#nullable restore
#line 84 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
         if (this.GruntTasking.GruntTask.Name == "ScreenShot")
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(173, "            ");
            __builder.OpenElement(174, "img");
            __builder.AddAttribute(175, "style", "max-width:100%");
            __builder.AddAttribute(176, "src", "data:image/png;base64," + " " + (
#nullable restore
#line 86 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                                     GruntTasking.GruntCommand.CommandOutput.Output

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\n");
#nullable restore
#line 87 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(178, "            ");
            __builder.OpenElement(179, "textarea");
            __builder.AddAttribute(180, "asp-for", "GruntCommand.CommandOutput.Output");
            __builder.AddAttribute(181, "rows", "20");
            __builder.AddAttribute(182, "class", "form-control");
            __builder.AddAttribute(183, "readonly", true);
            __builder.AddAttribute(184, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 90 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
                                                                         GruntTasking.GruntCommand.CommandOutput.Output

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(185, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GruntTasking.GruntCommand.CommandOutput.Output = __value, GruntTasking.GruntCommand.CommandOutput.Output));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\n");
#nullable restore
#line 91 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(187, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "/home/djap/Covenant/Covenant/Components/GruntTaskings/GruntTaskingForm.razor"
       
    [Parameter]
    public GruntTasking GruntTasking { get; set; }

    protected override async Task OnInitializedAsync()
    {
        this.GruntTasking.Grunt = this.GruntTasking.Grunt ?? await Service.GetGrunt(this.GruntTasking.GruntId);
        this.GruntTasking.GruntTask = this.GruntTasking.GruntTask ?? await Service.GetGruntTask(this.GruntTasking.GruntTaskId);
        this.GruntTasking.GruntCommand = this.GruntTasking.GruntCommand ?? await Service.GetGruntCommand(this.GruntTasking.GruntCommandId);
        this.GruntTasking.GruntCommand.CommandOutput = this.GruntTasking.GruntCommand.CommandOutput ?? await Service.GetCommandOutput(this.GruntTasking.GruntCommand.CommandOutputId);
        this.GruntTasking.GruntCommand.User = this.GruntTasking.GruntCommand.User ?? await Service.GetUser(this.GruntTasking.GruntCommand.UserId);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await IJSRuntime.InvokeAsync<string>("InitializeSelectPicker", "#Type.selectpicker");
        await IJSRuntime.InvokeAsync<string>("InitializeSelectPicker", "#Status.selectpicker");
        await IJSRuntime.InvokeAsync<string>("InitializeSelectPicker", "#Type.selectpicker", ((int)Enum.Parse(typeof(GruntTaskingType), this.GruntTasking.Type.ToString())).ToString());
        await IJSRuntime.InvokeAsync<string>("InitializeSelectPicker", "#Status.selectpicker", ((int)Enum.Parse(typeof(GruntTaskingStatus), this.GruntTasking.Status.ToString())).ToString());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
