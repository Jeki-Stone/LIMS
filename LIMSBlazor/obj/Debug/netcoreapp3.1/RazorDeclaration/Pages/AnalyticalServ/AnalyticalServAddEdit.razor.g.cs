// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LIMSBlazor.Pages.AnalyticalServ
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/analyticalservaddedit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/analyticalservaddedit/{id:int}")]
    public partial class AnalyticalServAddEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
           
        // Create a new, empty object
        AnalyticalServ analyticalserv = new AnalyticalServ();

        IEnumerable<Category> сategorys;
        IEnumerable<Unit> units;

        [Parameter]
        public int id { get; set; }

        // Set default page title and button text
        public string pagetitle = "Добавить новый аналитический сервис";
        public string buttontext = "Добавить";

        //Executes on page open, set defaults on page.
        protected override async Task OnInitializedAsync()
        {
            сategorys = await CategoryService.CategoryList();
            units = await UnitService.UnitList();
            // ============ If the passed-in id is zero, assume new data.
            if (id != 0)
            {
                analyticalserv = await AnalyticalServService.AnalyticalServ_GetOne(id);
                // Change page title and button text since this is an edit.
                pagetitle = "Изменить данные аналитического сервиса";
                buttontext = "Изменить";
            }
        }

        protected async Task AnalyticalServSave()
        {
            if (analyticalserv.Id == 0)
            {
                // Insert if id is zero.
                await AnalyticalServService.AnalyticalServInsert(analyticalserv);
            }
            else
            {
                // Update is id > 0
                await AnalyticalServService.AnalyticalServUpdate(analyticalserv);
            }
            NavigationManager.NavigateTo("/analyticalservlist");
        }
        void Cancel()
        {
            NavigationManager.NavigateTo("/analyticalservlist");
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnitService UnitService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAnalyticalServService AnalyticalServService { get; set; }
    }
}
#pragma warning restore 1591
