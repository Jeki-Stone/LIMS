#pragma checksum "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Shared\DataView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3b88fe633134388e2055726d7f76b71b2850bb7"
// <auto-generated/>
#pragma warning disable 1591
namespace LIMSBlazor.Shared
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
    public partial class DataView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h2");
            __builder.AddContent(1, 
#nullable restore
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Shared\DataView.razor"
     PageTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "btn-group");
            __builder.AddAttribute(5, "role", "group");
            __builder.AddAttribute(6, "aria-label", "Basic example");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "href", 
#nullable restore
#line 3 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Shared\DataView.razor"
              UrlAdd

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "class", "btn btn-secondary");
            __builder.AddContent(11, 
#nullable restore
#line 3 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Shared\DataView.razor"
                                                  UrlAddText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 4 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Shared\DataView.razor"
     if (UrlBack != null && UrlBackText != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", 
#nullable restore
#line 6 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Shared\DataView.razor"
                  UrlBack

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", "btn btn-secondary");
            __builder.AddContent(17, 
#nullable restore
#line 6 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Shared\DataView.razor"
                                                      UrlBackText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 7 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Shared\DataView.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.AddMarkupContent(20, "<div class=\"row\">\r\n</div>\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table table-striped table-sm table-bordered");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "thead");
            __builder.AddAttribute(28, "class", "font-weight-bold");
            __builder.AddContent(29, 
#nullable restore
#line 13 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Shared\DataView.razor"
                                             Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "tbody");
            __builder.AddContent(32, 
#nullable restore
#line 14 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Shared\DataView.razor"
                    Rows

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Shared\DataView.razor"
           

        [Parameter]
        public string PageTitle { get; set; }
        [Parameter]
        public string UrlAdd { get; set; }
        [Parameter]
        public string UrlAddText { get; set; }
        [Parameter]
        public string? UrlBack { get; set; }
        [Parameter]
        public string? UrlBackText { get; set; }
        [Parameter]
        public RenderFragment Header { get; set; }
        [Parameter]
        public RenderFragment Rows { get; set; }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
