#pragma checksum "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0014ce2f1d4aed7d839319f4c49fd23dd6c271bb"
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
            __builder.OpenComponent<LIMSBlazor.Shared.DataEdit>(0);
            __builder.AddAttribute(1, "PageTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                      pagetitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                                         analyticalserv

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "BtnSaveText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                                                                       buttontext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                                                                                                   AnalyticalServSave

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "OnClickCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                                                                                                                                       Cancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "table");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "tr");
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.AddMarkupContent(12, "<td>Наименование:</td>\r\n            ");
                __builder2.OpenElement(13, "td");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "required", true);
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                                          analyticalserv.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => analyticalserv.Name = __value, analyticalserv.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "tr");
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.AddMarkupContent(24, "<td>Категория:</td>\r\n            ");
                __builder2.OpenElement(25, "td");
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.OpenElement(27, "select");
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "required", true);
                __builder2.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                               analyticalserv.CategoryId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => analyticalserv.CategoryId = __value, analyticalserv.CategoryId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(32, "\r\n");
#nullable restore
#line 19 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                     if (сategorys != null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(33, "                        ");
                __builder2.OpenElement(34, "option");
                __builder2.AddAttribute(35, "value", "0");
                __builder2.AddMarkupContent(36, "Выберите значение");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n");
#nullable restore
#line 22 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                        foreach (var item in сategorys)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(38, "                            ");
                __builder2.OpenElement(39, "option");
                __builder2.AddAttribute(40, "value", 
#nullable restore
#line 24 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                                            item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(41, 
#nullable restore
#line 24 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n");
#nullable restore
#line 25 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(43, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenElement(47, "tr");
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.AddMarkupContent(49, "<td>Ед. измерения:</td>\r\n            ");
                __builder2.OpenElement(50, "td");
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenElement(52, "select");
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "required", true);
                __builder2.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                               analyticalserv.UnitId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => analyticalserv.UnitId = __value, analyticalserv.UnitId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(57, "\r\n");
#nullable restore
#line 34 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                     if (units != null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(58, "                        ");
                __builder2.OpenElement(59, "option");
                __builder2.AddAttribute(60, "value", "0");
                __builder2.AddMarkupContent(61, "Выберите значение");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n");
#nullable restore
#line 37 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                        foreach (var item in units)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(63, "                            ");
                __builder2.OpenElement(64, "option");
                __builder2.AddAttribute(65, "value", 
#nullable restore
#line 39 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                                            item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(66, 
#nullable restore
#line 39 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n");
#nullable restore
#line 40 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(68, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenElement(72, "tr");
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.AddMarkupContent(74, "<td>Описание:</td>\r\n            ");
                __builder2.OpenElement(75, "td");
                __builder2.OpenElement(76, "textarea");
                __builder2.AddAttribute(77, "class", "form-control");
                __builder2.AddAttribute(78, "type", "text");
                __builder2.AddAttribute(79, "id", "exampleFormControlTextarea1");
                __builder2.AddAttribute(80, "rows", "5");
                __builder2.AddAttribute(81, "cols", "100");
                __builder2.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\AnalyticalServ\AnalyticalServAddEdit.razor"
                                                                                                                       analyticalserv.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => analyticalserv.Description = __value, analyticalserv.Description));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n");
            }
            ));
            __builder.CloseComponent();
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