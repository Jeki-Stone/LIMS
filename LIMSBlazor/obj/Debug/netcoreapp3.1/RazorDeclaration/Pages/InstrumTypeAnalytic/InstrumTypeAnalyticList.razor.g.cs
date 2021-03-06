// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LIMSBlazor.Pages.InstrumTypeAnalytic
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\InstrumTypeAnalytic\InstrumTypeAnalyticList.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/instrumtype/instrumtypeanalyticlist/{InstrumentTypeId:int}")]
    public partial class InstrumTypeAnalyticList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\InstrumTypeAnalytic\InstrumTypeAnalyticList.razor"
       
    IEnumerable<InstrumTypeAnalytic> instrumtypeanalytics;
    IEnumerable<InstrumType> instrumtypes;
    IEnumerable<AnalyticalServ> analyticalservs;

    [Parameter]
    public int InstrumentTypeId { get; set; }
    [Parameter]
    public string UrlInstrumentTypeId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        instrumtypeanalytics = await InstrumTypeAnalyticService.InstrumTypeAnalyticList();
        instrumtypes = await InstrumTypeService.InstrumTypeList();
        analyticalservs = await AnalyticalServService.AnalyticalServList();
        UrlInstrumentTypeId = "/instrumtype/instrumtypeanalyticaddedit/" + @InstrumentTypeId;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAnalyticalServService AnalyticalServService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInstrumTypeService InstrumTypeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInstrumTypeAnalyticService InstrumTypeAnalyticService { get; set; }
    }
}
#pragma warning restore 1591
