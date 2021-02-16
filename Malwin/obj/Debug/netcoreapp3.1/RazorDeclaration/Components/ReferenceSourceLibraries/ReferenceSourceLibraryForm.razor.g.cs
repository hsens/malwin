#pragma checksum "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/ReferenceSourceLibraryForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42a2fe47e779eb0d41353bfb2275b8596073d347"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Covenant.Components.ReferenceSourceLibraries
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
#line 3 "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/ReferenceSourceLibraryForm.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/ReferenceSourceLibraryForm.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/ReferenceSourceLibraryForm.razor"
using Covenant.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/ReferenceSourceLibraryForm.razor"
using Covenant.Models.Grunts;

#line default
#line hidden
#nullable disable
    public partial class ReferenceSourceLibraryForm : OwningComponentBase<ICovenantService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "/home/djap/Covenant/Covenant/Components/ReferenceSourceLibraries/ReferenceSourceLibraryForm.razor"
       
    private ReferenceSourceLibrary _ReferenceSourceLibrary;
    [Parameter]
    public ReferenceSourceLibrary ReferenceSourceLibrary
    {
        get
        {
            return _ReferenceSourceLibrary;
        }
        set
        {
            if (value != null && value.Id > 0)
            {
                _ReferenceSourceLibrary = Service.GetReferenceSourceLibrary(value.Id).WaitResult();
            }
            else
            {
                _ReferenceSourceLibrary = value;
            }
        }
    }

    [Parameter]
    public string SubmitIcon { get; set; }

    [Parameter]
    public string SubmitLabel { get; set; }

    [Parameter]
    public EventCallback<ReferenceSourceLibrary> OnSubmit { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await IJSRuntime.InvokeAsync<string>("InitializeSelectPicker", "#Language.selectpicker", ((int)Enum.Parse(typeof(ImplantLanguage), this.ReferenceSourceLibrary.Language.ToString())).ToString());
        await IJSRuntime.InvokeAsync<string>("InitializeSelectPicker", "#ReferenceAssemblies.selectpicker");
        await IJSRuntime.InvokeAsync<string>("InitializeSelectPicker", "#EmbeddedResources.selectpicker");
        if (this.ReferenceSourceLibrary.Language == ImplantLanguage.CSharp)
        {
            await IJSRuntime.InvokeAsync<string>("InitializeSelectPicker", "#CompatibleDotNetVersions.selectpicker");
        }
    }

    private IEnumerable<ReferenceAssembly> GetReferenceAssemblies()
    {
        Task<IEnumerable<ReferenceAssembly>> t = Service.GetReferenceAssemblies();
        t.Wait();
        return t.Result;
    }

    private IEnumerable<EmbeddedResource> GetEmbeddedResources()
    {
        return Service.GetEmbeddedResources().WaitResult();
    }

    private async Task OnChangeReferenceAssemblies()
    {
        string[] ras = await IJSRuntime.InvokeAsync<string[]>("GetValue", new object[] { "#ReferenceAssemblies" });
        IEnumerable<int> ids = ras.Where(id => int.TryParse(id, out _)).Select(sid => int.Parse(sid));
        IEnumerable<int> adds = ids.Where(id => !this.ReferenceSourceLibrary.ReferenceAssemblies.Select(RA => RA.Id).Contains(id));
        IEnumerable<int> removes = this.ReferenceSourceLibrary.ReferenceAssemblies.Select(RA => RA.Id).Where(id => !ids.Contains(id));
        foreach (int id in adds)
        {
            this.ReferenceSourceLibrary.Add(await Service.GetReferenceAssembly(id));
        }
        foreach (int id in removes)
        {
            this.ReferenceSourceLibrary.Remove(this.ReferenceSourceLibrary.ReferenceAssemblies.Find(RA => RA.Id == id));
        }
    }

    private async Task OnChangeEmbeddedResources()
    {
        string[] ers = await IJSRuntime.InvokeAsync<string[]>("GetValue", new object[] { "#EmbeddedResources" });
        IEnumerable<int> ids = ers.Where(id => int.TryParse(id, out _)).Select(sid => int.Parse(sid));
        IEnumerable<int> adds = ids.Where(id => !this.ReferenceSourceLibrary.EmbeddedResources.Select(ER => ER.Id).Contains(id));
        IEnumerable<int> removes = this.ReferenceSourceLibrary.EmbeddedResources.Select(ER => ER.Id).Where(id => !ids.Contains(id));
        foreach (int id in adds)
        {
            this.ReferenceSourceLibrary.Add(await Service.GetEmbeddedResource(id));
        }
        foreach (int id in removes)
        {
            this.ReferenceSourceLibrary.Remove(this.ReferenceSourceLibrary.EmbeddedResources.Find(ER => ER.Id == id));
        }
    }

    private async Task<List<Common.DotNetVersion>> GetCompatibleDotNetVersions()
    {
        string[] ids = await IJSRuntime.InvokeAsync<string[]>("GetValue", new object[] { "#CompatibleDotNetVersions" });
        return ids.Where(id => Enum.TryParse<Common.DotNetVersion>(id, out _)).Select(id => Enum.Parse<Common.DotNetVersion>(id)).ToList();
    }

    private async Task Submit()
    {
        this.ReferenceSourceLibrary.CompatibleDotNetVersions = await GetCompatibleDotNetVersions();
        await this.OnSubmit.InvokeAsync(this.ReferenceSourceLibrary);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591