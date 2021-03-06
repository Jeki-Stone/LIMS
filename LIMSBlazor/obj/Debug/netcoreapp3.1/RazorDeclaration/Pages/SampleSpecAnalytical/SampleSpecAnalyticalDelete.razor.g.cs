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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpecAnalytical\SampleSpecAnalyticalDelete.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/samplespecanalyticaldelete/{SampleSpecId:int}/{AnalyticalServiceId:int}")]
    public partial class SampleSpecAnalyticalDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpecAnalytical\SampleSpecAnalyticalDelete.razor"
            // Create a new, empty  object
        SampleSpecAnalytical samplespecanalytical = new SampleSpecAnalytical();

        [Parameter]
        public int SampleSpecId { get; set; }
        [Parameter]
        public int AnalyticalServiceId { get; set; }

        IEnumerable<SampleSpec> samplespecs;
        IEnumerable<AnalyticalServ> analyticalservs;

        //Executes on page open..
        protected override async Task OnInitializedAsync()
        {
            samplespecanalytical = await SampleSpecAnalyticalService.SampleSpecAnalytical_GetOne(SampleSpecId, AnalyticalServiceId);
            samplespecs = await SampleSpecService.SampleSpecList();
            analyticalservs = await AnalyticalServService.AnalyticalServList();
        }

        protected async Task Delete()
        {
            // Insert if id is zero.
            await SampleSpecAnalyticalService.SampleSpecAnalyticalDelete(SampleSpecId, AnalyticalServiceId);
            NavigationManager.NavigateTo("/samplespecanalyticallist");
        }
        void Cancel()
        {
            NavigationManager.NavigateTo("/samplespecanalyticallist");
        } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAnalyticalServService AnalyticalServService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISampleSpecService SampleSpecService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISampleSpecAnalyticalService SampleSpecAnalyticalService { get; set; }
    }
}
#pragma warning restore 1591