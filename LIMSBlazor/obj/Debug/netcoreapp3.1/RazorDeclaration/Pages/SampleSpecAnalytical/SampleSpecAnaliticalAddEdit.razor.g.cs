// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LIMSBlazor.Pages.SampleSpecAnalytical
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpecAnalytical\SampleSpecAnaliticalAddEdit.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/samplespecanaliticaladdedit/{SampleSpecId:int}/{AnaliticalServiceId:int}")]
    public partial class SampleSpecAnaliticalAddEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpecAnalytical\SampleSpecAnaliticalAddEdit.razor"
       
    // Create a new, empty object
    SampleSpecAnalitical samplespecanalitical = new SampleSpecAnalitical();

    IEnumerable<SampleSpec> samplespecs;
    IEnumerable<AnalyticalServ> analyticalservs;

    [Parameter]
    public int SampleSpecId { get; set; }
    [Parameter]
    public int AnaliticalServiceId { get; set; }

    // Set default page title and button text
    public string pagetitle = "Добавить новый элемент спецификации";
    public string buttontext = "Добавить";

    //Executes on page open, set defaults on page.
    protected override async Task OnInitializedAsync()
    {
        samplespecs = await SampleSpecService.SampleSpecList();
        analyticalservs = await AnalyticalServService.AnalyticalServList();
        // ============ If the passed-in id is zero, assume new data.
        if ((SampleSpecId != 0) & (AnaliticalServiceId != 0))
        {
            samplespecanalitical = await SampleSpecAnaliticalService.SampleSpecAnalitical_GetOne(SampleSpecId, AnaliticalServiceId);
            // Change page title and button text since this is an edit.
            pagetitle = "Изменить данные элемента спецификации";
            buttontext = "Изменить";
        }
    }

    protected async Task SampleSpecAnaliticalSave()
    {
        if ((samplespecanalitical.SampleSpecId == 0) & (samplespecanalitical.AnaliticalServiceId == 0))
        {
            // Insert if id is zero.
            await SampleSpecAnaliticalService.SampleSpecAnaliticalInsert(samplespecanalitical);
        }
        else
        {
            // Update is id > 0
            await SampleSpecAnaliticalService.SampleSpecAnaliticalUpdate(samplespecanalitical);
        }
        NavigationManager.NavigateTo("/samplespecanaliticallist");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("/samplespecanaliticallist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAnalyticalServService AnalyticalServService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISampleSpecService SampleSpecService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISampleSpecAnaliticalService SampleSpecAnaliticalService { get; set; }
    }
}
#pragma warning restore 1591
