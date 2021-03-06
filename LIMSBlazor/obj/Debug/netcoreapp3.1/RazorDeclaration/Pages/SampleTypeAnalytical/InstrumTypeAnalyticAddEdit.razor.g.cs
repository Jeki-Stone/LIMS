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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleTypeAnalytical\InstrumTypeAnalyticAddEdit.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/instrumtype/instrumtypeanalyticaddedit/{InstrumentTypeId:int}/{AnalyticalServiceId:int}")]
    public partial class InstrumTypeAnalyticAddEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleTypeAnalytical\InstrumTypeAnalyticAddEdit.razor"
       
    // Create a new, empty object
    InstrumTypeAnalytic instrumtypeanalytic = new InstrumTypeAnalytic();

    IEnumerable<InstrumType> instrumtypes;
    IEnumerable<AnalyticalServ> analyticalservs;

    [Parameter]
    public int InstrumentTypeId { get; set; }
    [Parameter]
    public int AnalyticalServiceId { get; set; }

    // Set default page title and button text
    public string pagetitle = "Добавить новый аналитический сервис типа";
    public string buttontext = "Добавить";

    //Executes on page open, set defaults on page.
    protected override async Task OnInitializedAsync()
    {
        instrumtypes = await InstrumTypeService.InstrumTypeList();
        analyticalservs = await AnalyticalServService.AnalyticalServList();
        // ============ If the passed-in id is zero, assume new data.
        if ((InstrumentTypeId != 0) & (AnalyticalServiceId != 0))
        {
            instrumtypeanalytic = await InstrumTypeAnalyticService.InstrumTypeAnalytic_GetOne(InstrumentTypeId, AnalyticalServiceId);
            // Change page title and button text since this is an edit.

            pagetitle = "Изменить данные аналитического сервиса типа";
            buttontext = "Изменить";
        }
    }

    protected async Task InstrumTypeAnalyticSave()
    {
        if ((instrumtypeanalytic.InstrumentTypeId == 0) & (instrumtypeanalytic.AnalyticalServiceId == 0))
        {
            // Insert if id is zero.
            await InstrumTypeAnalyticService.InstrumTypeAnalyticInsert(instrumtypeanalytic, InstrumentTypeId);
        }
        else
        {
            // Update is id > 0
            instrumtypeanalytic.OldAnalyticalServiceId = AnalyticalServiceId;
            await InstrumTypeAnalyticService.InstrumTypeAnalyticUpdate(instrumtypeanalytic);
        }
        NavigationManager.NavigateTo("/instrumtype/instrumtypeanalyticlist/" + InstrumentTypeId);
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("/instrumtype/instrumtypeanalyticlist/" + InstrumentTypeId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAnalyticalServService AnalyticalServService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInstrumTypeService InstrumTypeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInstrumTypeAnalyticService InstrumTypeAnalyticService { get; set; }
    }
}
#pragma warning restore 1591