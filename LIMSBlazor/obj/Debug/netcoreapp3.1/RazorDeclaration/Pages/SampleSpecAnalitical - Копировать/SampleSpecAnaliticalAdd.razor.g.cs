// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LIMSBlazor.Pages.SampleSpecAnalitical___Копировать
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpecAnalitical - Копировать\SampleSpecAnaliticalAdd.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/samplespecanaliticaladd")]
    public partial class SampleSpecAnaliticalAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpecAnalitical - Копировать\SampleSpecAnaliticalAdd.razor"
       
    // Create a new, empty object
    SampleSpecAnalitical samplespecanalitical = new SampleSpecAnalitical();

    IEnumerable<SampleSpec> samplespecs;
    string error1 = null;

    IEnumerable<AnalyticalServ> analyticalservs;
    string error2 = null;

    protected override async Task OnInitializedAsync()
    {
        samplespecs = await SampleSpecService.SampleSpecList();
        analyticalservs = await AnalyticalServService.AnalyticalServList();
    }

    protected async Task SampleSpecAnaliticalInsert()
    {
        if (samplespecanalitical.SampleSpecId == 0)
        {
            error1 = "Выберите спецификацию!";
            return;
        }

        if (samplespecanalitical.AnaliticalServiceId == 0)
        {
            error2 = "Выберите аналитический сервис!";
            return;
        }

        await SampleSpecAnaliticalService.SampleSpecAnaliticalInsert(samplespecanalitical);
        NavigationManager.NavigateTo("samplespecanaliticallist");
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
