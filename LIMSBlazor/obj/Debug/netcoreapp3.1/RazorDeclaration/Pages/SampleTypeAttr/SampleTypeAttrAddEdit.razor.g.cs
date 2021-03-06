// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LIMSBlazor.Pages.SampleTypeAttr
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleTypeAttr\SampleTypeAttrAddEdit.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sampletype/sampletypeattraddedit/{SampleTypeId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/sampletype/sampletypeattraddedit/{SampleTypeId:int}/{AttrId:int}")]
    public partial class SampleTypeAttrAddEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\SampleTypeAttr\SampleTypeAttrAddEdit.razor"
           
        // Create a new, empty object
        SampleTypeAttr sampletypeattr = new SampleTypeAttr();

        IEnumerable<SampleType> sampletypes;
        IEnumerable<Attr> attrs;

        [Parameter]
        public int SampleTypeId { get; set; }
        [Parameter]
        public int AttrId { get; set; }

        // Set default page title and button text
        public string pagetitle = "Добавить новый атрибут для типа испытания";
        public string buttontext = "Добавить";

        //Executes on page open, set defaults on page.
        protected override async Task OnInitializedAsync()
        {
            sampletypes = await SampleTypeService.SampleTypeList();
            attrs = await AttrService.AttrList();
            // ============ If the passed-in id is zero, assume new data.
            if ((SampleTypeId != 0) & (AttrId != 0))
            {
                sampletypeattr = await SampleTypeAttrService.SampleTypeAttr_GetOne(SampleTypeId, AttrId);
                // Change page title and button text since this is an edit.

                pagetitle = "Изменить данные атрибута для типа испытания";
                buttontext = "Изменить";
            }
        }

        protected async Task SampleTypeAttrSave()
        {
            if ((sampletypeattr.SampleTypeId != 0) & (sampletypeattr.AttrId != 0))
            {
                // Update is id > 0
                sampletypeattr.OldAttrId = AttrId;
                await SampleTypeAttrService.SampleTypeAttrUpdate(sampletypeattr);                
            }
            else
            {
                // Insert if id is zero.
                await SampleTypeAttrService.SampleTypeAttrInsert(sampletypeattr, SampleTypeId);
            }
            NavigationManager.NavigateTo("/sampletype/sampletypeattrlist/" + SampleTypeId);
        }
        void Cancel()
        {
            NavigationManager.NavigateTo("/sampletype/sampletypeattrlist/" + SampleTypeId);
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAttrService AttrService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISampleTypeService SampleTypeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISampleTypeAttrService SampleTypeAttrService { get; set; }
    }
}
#pragma warning restore 1591