#pragma checksum "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aad048df5324997d745e2206e2b3a9675bb281e"
// <auto-generated/>
#pragma warning disable 1591
namespace LIMSBlazor.Pages.Sample
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sampledelete/{id:int}")]
    public partial class SampleDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LIMSBlazor.Shared.DataEdit>(0);
            __builder.AddAttribute(1, "FormType", "Delete");
            __builder.AddAttribute(2, "PageTitle", "Удалить образец");
            __builder.AddAttribute(3, "DeleteWarning", "Вы уверены что хотите удалить этот образец? Данные нельзя будет вернуть!");
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
                                                                                                                                                         sample

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnClickDelete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
                                                                                                                                                                                 Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "OnClickCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
                                                                                                                                                                                                         Cancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\n    ");
                __builder2.OpenElement(9, "table");
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenElement(11, "tr");
                __builder2.AddMarkupContent(12, "\n            ");
                __builder2.AddMarkupContent(13, "<td>Время получения:</td>\n            ");
                __builder2.OpenElement(14, "td");
                __builder2.AddContent(15, 
#nullable restore
#line 13 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
                 sample.RecieveTime

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\n        ");
                __builder2.OpenElement(18, "tr");
                __builder2.AddMarkupContent(19, "\n            ");
                __builder2.AddMarkupContent(20, "<td>Время начала тестов:</td>\n            ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#nullable restore
#line 17 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
                 sample.TestTime

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n        ");
                __builder2.OpenElement(25, "tr");
                __builder2.AddMarkupContent(26, "\n            ");
                __builder2.AddMarkupContent(27, "<td>Клиент:</td>\n            ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 21 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
                 clis?.Where(x => x.Id == sample.ClientId).FirstOrDefault()?.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n        ");
                __builder2.OpenElement(32, "tr");
                __builder2.AddMarkupContent(33, "\n            ");
                __builder2.AddMarkupContent(34, "<td>Тип образца:</td>\n            ");
                __builder2.OpenElement(35, "td");
                __builder2.AddContent(36, 
#nullable restore
#line 25 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
                 sampletypes?.Where(x => x.Id == sample.SampleTypeId).FirstOrDefault()?.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n        ");
                __builder2.OpenElement(39, "tr");
                __builder2.AddMarkupContent(40, "\n            ");
                __builder2.AddMarkupContent(41, "<td>Статус:</td>\n            ");
                __builder2.OpenElement(42, "td");
                __builder2.AddContent(43, 
#nullable restore
#line 29 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
                 sample.Status

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\n        ");
                __builder2.OpenElement(46, "tr");
                __builder2.AddMarkupContent(47, "\n            ");
                __builder2.AddMarkupContent(48, "<td>Готовность:</td>\n            ");
                __builder2.OpenElement(49, "td");
                __builder2.AddContent(50, 
#nullable restore
#line 33 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
                 sample.IsFinal

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n        ");
                __builder2.OpenElement(53, "tr");
                __builder2.AddMarkupContent(54, "\n            ");
                __builder2.AddMarkupContent(55, "<td>Записка:</td>\n            ");
                __builder2.OpenElement(56, "td");
                __builder2.AddContent(57, 
#nullable restore
#line 37 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
                 sample.Note

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\n        ");
                __builder2.OpenElement(60, "tr");
                __builder2.AddMarkupContent(61, "\n            ");
                __builder2.AddMarkupContent(62, "<td>Место взятия образца:</td>\n            ");
                __builder2.OpenElement(63, "td");
                __builder2.AddContent(64, 
#nullable restore
#line 41 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
                 locs?.Where(x => x.Id == sample.LocationId).FirstOrDefault()?.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\n        ");
                __builder2.OpenElement(67, "tr");
                __builder2.AddMarkupContent(68, "\n            ");
                __builder2.AddMarkupContent(69, "<td>Причины изменений:</td>\n            ");
                __builder2.OpenElement(70, "td");
                __builder2.AddContent(71, 
#nullable restore
#line 45 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
                 sample.LastEditComment

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Sample\SampleDelete.razor"
            // Create a new, empty  object
        Sample sample = new Sample();

        IEnumerable<Cli> clis;
        IEnumerable<SampleType> sampletypes;
        IEnumerable<Loc> locs;

        [Parameter]
        public int id { get; set; }

        //Executes on page open..
        protected override async Task OnInitializedAsync()
        {
            clis = await CliService.CliList();
            sampletypes = await SampleTypeService.SampleTypeList();
            locs = await LocService.LocList();
            sample = await SampleService.Sample_GetOne(id);
        }

        protected async Task Delete()
        {
            // Insert if id is zero.
            await SampleService.SampleDelete(id);
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
