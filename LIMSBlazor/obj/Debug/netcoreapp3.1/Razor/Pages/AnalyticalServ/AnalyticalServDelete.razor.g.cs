#pragma checksum "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "debc5ebf34d811ba7d434f932673e9862c679a84"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServDelete.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/analyticalservdelete/{id:int}")]
    public partial class AnalyticalServDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LIMSBlazor.Shared.DataEdit>(0);
            __builder.AddAttribute(1, "FormType", "Delete");
            __builder.AddAttribute(2, "PageTitle", "Удалить аналитический сервис");
            __builder.AddAttribute(3, "DeleteWarning", "Вы уверены что хотите удалить этот аналитический сервис? Данные нельзя будет вернуть!");
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServDelete.razor"
                                                                                                                                                                                   analyticalserv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnClickDelete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServDelete.razor"
                                                                                                                                                                                                                   Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "OnClickCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServDelete.razor"
                                                                                                                                                                                                                                           Cancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\n    ");
                __builder2.OpenElement(9, "table");
                __builder2.AddAttribute(10, "class", "editform");
                __builder2.AddMarkupContent(11, "\n        ");
                __builder2.OpenElement(12, "tr");
                __builder2.AddMarkupContent(13, "\n            ");
                __builder2.AddMarkupContent(14, "<td>Наименование:</td>\n            ");
                __builder2.OpenElement(15, "td");
                __builder2.AddContent(16, 
#nullable restore
#line 12 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServDelete.razor"
                 analyticalserv.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n        ");
                __builder2.OpenElement(19, "tr");
                __builder2.AddMarkupContent(20, "\n            ");
                __builder2.AddMarkupContent(21, "<td>Категория:</td>\n            ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 16 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServDelete.razor"
                 сategorys?.Where(x => x.Id == analyticalserv.CategoryId).FirstOrDefault()?.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n        ");
                __builder2.OpenElement(26, "tr");
                __builder2.AddMarkupContent(27, "\n            ");
                __builder2.AddMarkupContent(28, "<td>Ед. измерения:</td>\n            ");
                __builder2.OpenElement(29, "td");
                __builder2.AddContent(30, 
#nullable restore
#line 20 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServDelete.razor"
                 units?.Where(x => x.Id == analyticalserv.UnitId).FirstOrDefault()?.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n        ");
                __builder2.OpenElement(33, "tr");
                __builder2.AddMarkupContent(34, "\n            ");
                __builder2.AddMarkupContent(35, "<td>Описание:</td>\n            ");
                __builder2.OpenElement(36, "td");
                __builder2.AddContent(37, 
#nullable restore
#line 24 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServDelete.razor"
                 analyticalserv.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServDelete.razor"
            // Create a new, empty  object
        AnalyticalServ analyticalserv = new AnalyticalServ();

        [Parameter]
        public int id { get; set; }

        IEnumerable<Category> сategorys;
        IEnumerable<Unit> units;

        //Executes on page open..
        protected override async Task OnInitializedAsync()
        {
            сategorys = await CategoryService.CategoryList();
            units = await UnitService.UnitList();
            analyticalserv = await AnalyticalServService.AnalyticalServ_GetOne(id);
        }

        protected async Task Delete()
        {
            // Insert if id is zero.
            await AnalyticalServService.AnalyticalServDelete(id);
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