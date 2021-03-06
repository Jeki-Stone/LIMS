// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LIMSBlazor.Pages.SampleTypeAnalytical
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\_Imports.razor"
using LIMSBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\_Imports.razor"
using LIMSBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleTypeAnalytical\SampleTypeAnalyticalDelete.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sampletype/sampletypeanalyticaldelete/{SampleTypeId:int}/{AnalyticalServiceId:int}")]
    public partial class SampleTypeAnalyticalDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleTypeAnalytical\SampleTypeAnalyticalDelete.razor"
        // Create a new, empty object
    SampleTypeAnalytical sampletypeanalytical = new SampleTypeAnalytical();
    IEnumerable<SampleType> sampletypes;
    IEnumerable<AnalyticalServ> analyticalservs;

    [Parameter]
    public int SampleTypeId { get; set; }
    [Parameter]
    public int AnalyticalServiceId { get; set; }

    //Executes on page open..
    protected override async Task OnInitializedAsync()
    {
        sampletypeanalytical = await SampleTypeAnalyticalService.SampleTypeAnalytical_GetOne(SampleTypeId, AnalyticalServiceId);
        sampletypes = await SampleTypeService.SampleTypeList();
        analyticalservs = await AnalyticalServService.AnalyticalServList();
    }

    protected async Task Delete()
    {
        // Insert if id is zero.
        await SampleTypeAnalyticalService.SampleTypeAnalyticalDelete(SampleTypeId, AnalyticalServiceId);
        NavigationManager.NavigateTo("/sampletype/sampletypeanalyticallist/" + SampleTypeId);
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("/sampletype/sampletypeanalyticallist/" + SampleTypeId);
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAnalyticalServService AnalyticalServService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISampleTypeService SampleTypeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISampleTypeAnalyticalService SampleTypeAnalyticalService { get; set; }
    }
}
#pragma warning restore 1591
