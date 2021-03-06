// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LIMSBlazor.Pages.Sample___Копировать
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample - Копировать\SampleAdd.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sampleadd")]
    public partial class SampleAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample - Копировать\SampleAdd.razor"
       
    // Create a new, empty object
    Sample sample = new Sample();

    IEnumerable<Cli> clis;
    IEnumerable<SampleType> sampletypes;
    IEnumerable<Loc> locs;
    string error1 = null;
    string error2 = null;
    string error3 = null;

    protected override async Task OnInitializedAsync()
    {
        clis = await CliService.CliList();
        sampletypes = await SampleTypeService.SampleTypeList();
        locs = await LocService.LocList();
    }

    protected async Task SampleInsert()
    {
        if (sample.ClientId == 0)
        {
            error1 = "Выберите клиента!";
            return;
        } else
        {
            error1 = null;
        }
        if (sample.SampleTypeId == 0)
        {
            error2 = "Выберите тип образца!";
            return;
        }
        else
        {
            error2 = null;
        }
        if (sample.LocationId == 0)
        {
            error3 = "Выберите место взятия образца!";
            return;
        } else
        {
            error3 = null;
        }

        sample.CreateUser = "Создавший пользователь";

        await SampleService.SampleInsert(sample);
        NavigationManager.NavigateTo("/samplelist");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("/samplelist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocService LocService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISampleTypeService SampleTypeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICliService CliService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISampleService SampleService { get; set; }
    }
}
#pragma warning restore 1591
