#pragma checksum "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef0d7ff5503d1ab67fb5e8a5fe5109847c895540"
// <auto-generated/>
#pragma warning disable 1591
namespace LIMSBlazor.Pages.Cli
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clilist")]
    public partial class CliList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LIMSBlazor.Shared.DataView>(0);
            __builder.AddAttribute(1, "PageTitle", "Список клиентов");
            __builder.AddAttribute(2, "UrlAdd", "/cliaddedit");
            __builder.AddAttribute(3, "UrlAddText", "Добавить нового клиента");
            __builder.AddAttribute(4, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.AddMarkupContent(6, @"<tr>
            <td style=""text-align:center"">#</td>
            <td>Id клиента</td>
            <td>Имя Клиетна</td>
            <td>Полное имя Клиента</td>
            <td>Номер телефона Клиента</td>
            <td>Организация</td>
        </tr>
    ");
            }
            ));
            __builder.AddAttribute(7, "Rows", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n");
#nullable restore
#line 17 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
         if (clis == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(9, "            ");
                __builder2.AddMarkupContent(10, "<p style=\"text-align:center\">\r\n                <img src=\"../images/loader.gif\" width=\"50\" height=\"50\">\r\n            </p>\r\n");
#nullable restore
#line 22 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
             foreach (var cli in clis)
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
                __builder2.AddAttribute(18, "href", "cliaddedit/" + (
#nullable restore
#line 29 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
                                             cli.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(19, "\r\n                            <img src=\"../images/iEdit.png\" width=\"20\" height=\"20\">\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                        &nbsp\r\n                        ");
                __builder2.OpenElement(21, "a");
                __builder2.AddAttribute(22, "href", "clidelete/" + (
#nullable restore
#line 33 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
                                            cli.Id

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
#line 37 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
                         cli.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "td");
                __builder2.AddContent(30, 
#nullable restore
#line 38 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
                         cli.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.OpenElement(32, "td");
                __builder2.AddContent(33, 
#nullable restore
#line 39 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
                         cli.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.OpenElement(35, "td");
                __builder2.AddContent(36, 
#nullable restore
#line 40 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
                         cli.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.OpenElement(38, "td");
                __builder2.AddContent(39, 
#nullable restore
#line 41 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
                         cli.Organization

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n");
#nullable restore
#line 43 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
             
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
#line 48 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Cli\CliList.razor"
       
    IEnumerable<Cli> clis;
    protected override async Task OnInitializedAsync()
    {
        clis = await CliService.CliList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICliService CliService { get; set; }
    }
}
#pragma warning restore 1591