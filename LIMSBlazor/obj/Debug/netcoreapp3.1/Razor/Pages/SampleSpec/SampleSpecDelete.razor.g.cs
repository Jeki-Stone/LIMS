#pragma checksum "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpec\SampleSpecDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c45884645d71aaebd6f6d1ac100ac959b35ff66"
// <auto-generated/>
#pragma warning disable 1591
namespace LIMSBlazor.Pages.SampleSpec
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpec\SampleSpecDelete.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/samplespecdelete/{id:int}")]
    public partial class SampleSpecDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LIMSBlazor.Shared.DataEdit>(0);
            __builder.AddAttribute(1, "FormType", "Delete");
            __builder.AddAttribute(2, "PageTitle", "Удалить спецификацию из базы данных");
            __builder.AddAttribute(3, "DeleteWarning", "Вы уверены что хотите удалить эту спецификацию из базы данных? Данные нельзя будет вернуть!");
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpec\SampleSpecDelete.razor"
                                                                                                                                                                                                samplespec

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnClickDelete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 6 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpec\SampleSpecDelete.razor"
                                                                                                                                                                                                                            Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "OnClickCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 6 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpec\SampleSpecDelete.razor"
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
                __builder2.AddMarkupContent(13, "<td>Наименование:</td>\n            ");
                __builder2.OpenElement(14, "td");
                __builder2.AddContent(15, 
#nullable restore
#line 10 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpec\SampleSpecDelete.razor"
                 samplespec.Name

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
                __builder2.AddMarkupContent(20, "<td>Версия:</td>\n            ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#nullable restore
#line 14 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpec\SampleSpecDelete.razor"
                 samplespec.Version

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
                __builder2.AddMarkupContent(27, "<td>Описание:</td>\n            ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 18 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpec\SampleSpecDelete.razor"
                 samplespec.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleSpec\SampleSpecDelete.razor"
            // Create a new, empty object
        SampleSpec samplespec = new SampleSpec();

        [Parameter]
        public int id { get; set; }

        //Executes on page open..
        protected override async Task OnInitializedAsync()
        {
            samplespec = await SampleSpecService.SampleSpec_GetOne(id);
        }

        protected async Task Delete()
        {
            // Insert if id is zero.
            await SampleSpecService.SampleSpecDelete(id);
            NavigationManager.NavigateTo("/samplespeclist");
        }
        void Cancel()
        {
            NavigationManager.NavigateTo("/samplespeclist");
        } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISampleSpecService SampleSpecService { get; set; }
    }
}
#pragma warning restore 1591
