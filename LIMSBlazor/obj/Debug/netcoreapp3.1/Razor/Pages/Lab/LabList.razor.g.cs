#pragma checksum "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12fbe4b33e76f02fb4e726899a19af5c99e9f3d3"
// <auto-generated/>
#pragma warning disable 1591
namespace LIMSBlazor.Pages.Lab
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/config/lablist")]
    public partial class LabList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LIMSBlazor.Shared.DataView>(0);
            __builder.AddAttribute(1, "PageTitle", "Список лабораторий");
            __builder.AddAttribute(2, "UrlAdd", "/labaddedit");
            __builder.AddAttribute(3, "UrlAddText", "Добавить новую лабораторию");
            __builder.AddAttribute(4, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.AddMarkupContent(6, "<tr>\r\n            <th style=\"text-align:center\">#</th>\r\n            <th>Id</th>\r\n            <th>Код</th>\r\n            <th>Наименование</th>\r\n            <th>Местоположение</th>\r\n            <th>Описание</th>\r\n        </tr>\r\n    ");
            }
            ));
            __builder.AddAttribute(7, "Rows", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n");
#nullable restore
#line 18 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
         if (labs == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(9, "            ");
                __builder2.AddMarkupContent(10, "<p style=\"text-align:center\">\r\n                <img src=\"../images/loader.gif\">\r\n            </p>\r\n");
#nullable restore
#line 23 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
             foreach (var lab in labs)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(11, "                ");
                __builder2.OpenElement(12, "tr");
                __builder2.AddMarkupContent(13, "\r\n                    ");
                __builder2.OpenElement(14, "td");
                __builder2.AddAttribute(15, "style", "text-align:center");
                __builder2.AddMarkupContent(16, "\r\n                        ");
                __builder2.OpenElement(17, "a");
                __builder2.AddAttribute(18, "href", "labaddedit/" + (
#nullable restore
#line 30 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
                                             lab.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(19, "\r\n                            <img src=\"../images/iEdit.png\" width=\"20\" height=\"20\">\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                        &nbsp\r\n                        ");
                __builder2.OpenElement(21, "a");
                __builder2.AddAttribute(22, "href", "labdelete/" + (
#nullable restore
#line 34 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
                                            lab.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(23, "\r\n                            <img src=\"../images/iTrash.png\" alt=\"Delete\" title=\"Delete\" width=\"20\" height=\"20\">\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.OpenElement(26, "td");
                __builder2.AddContent(27, 
#nullable restore
#line 38 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
                         lab.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "td");
                __builder2.AddContent(30, 
#nullable restore
#line 39 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
                         lab.Code

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.OpenElement(32, "td");
                __builder2.AddContent(33, 
#nullable restore
#line 40 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
                         lab.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.OpenElement(35, "td");
                __builder2.AddContent(36, 
#nullable restore
#line 41 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
                         locs.Where(x => x.Id == lab.LocId).FirstOrDefault()?.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.OpenElement(38, "td");
                __builder2.AddContent(39, 
#nullable restore
#line 42 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
                         lab.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n");
#nullable restore
#line 44 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
             
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(42, "    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Lab\LabList.razor"
       
    IEnumerable<Lab> labs;
    IEnumerable<Loc> locs;
    protected override async Task OnInitializedAsync()
    {
        locs = await LocService.LocList();
        labs = await LabService.LabList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocService LocService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILabService LabService { get; set; }
    }
}
#pragma warning restore 1591