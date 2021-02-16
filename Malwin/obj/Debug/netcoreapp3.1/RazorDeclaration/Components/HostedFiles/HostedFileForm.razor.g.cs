#pragma checksum "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72d34d0850c5eabe7f44df295beaaba37cfa935a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Covenant.Components.HostedFiles
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
#line 1 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileForm.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileForm.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileForm.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileForm.razor"
using Covenant.Models.Listeners;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileForm.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    public partial class HostedFileForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "/home/djap/Covenant/Covenant/Components/HostedFiles/HostedFileForm.razor"
       
    [Parameter]
    public HostedFile HostedFile { get; set; }

    [Parameter]
    public EventCallback<HostedFile> OnSubmit { get; set; }

    [Parameter]
    public string SubmitIcon { get; set; }

    [Parameter]
    public string SubmitLabel { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    private async Task FileUpload(IFileListEntry[] files)
    {
        IFileListEntry file = files.FirstOrDefault();
        if (file != null)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                await file.Data.CopyToAsync(ms);
                HostedFile.Content = Convert.ToBase64String(ms.ToArray());
            }
        }
    }

    private async Task OnFormSubmit()
    {
        await this.OnSubmit.InvokeAsync(this.HostedFile);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591