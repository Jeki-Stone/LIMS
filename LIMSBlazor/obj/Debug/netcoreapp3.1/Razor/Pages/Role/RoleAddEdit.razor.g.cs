#pragma checksum "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Role\RoleAddEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4b028732dd9272cb83779118395520b7f7bcbdd"
// <auto-generated/>
#pragma warning disable 1591
namespace LIMSBlazor.Pages.Role
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Role\RoleAddEdit.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/roleaddedit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/roleaddedit/{id:int}")]
    public partial class RoleAddEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LIMSBlazor.Shared.DataEdit>(0);
            __builder.AddAttribute(1, "PageTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Role\RoleAddEdit.razor"
                      pagetitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Role\RoleAddEdit.razor"
                                         role

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "BtnSaveText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Role\RoleAddEdit.razor"
                                                             buttontext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Role\RoleAddEdit.razor"
                                                                                         RoleSave

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "OnClickCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Role\RoleAddEdit.razor"
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
                __builder2.AddMarkupContent(12, "<td>Название:</td>\r\n            ");
                __builder2.OpenElement(13, "td");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "required", true);
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Role\RoleAddEdit.razor"
                                          role.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => role.Name = __value, role.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "tr");
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.AddMarkupContent(24, "<td>Описание:</td>\r\n            ");
                __builder2.OpenElement(25, "td");
                __builder2.OpenElement(26, "textarea");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "type", "text");
                __builder2.AddAttribute(29, "id", "exampleFormControlTextarea1");
                __builder2.AddAttribute(30, "rows", "5");
                __builder2.AddAttribute(31, "cols", "100");
                __builder2.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Role\RoleAddEdit.razor"
                                                                                                                       role.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => role.Description = __value, role.Description));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\Role\RoleAddEdit.razor"
           
        // Create a new, empty object
        Role role = new Role();

        [Parameter]
        public int id { get; set; }

        // Set default page title and button text
        public string pagetitle = "Добавить новую роль";
        public string buttontext = "Добавить";

        //Executes on page open, set defaults on page.
        protected override async Task OnInitializedAsync()
        {
            // ============ If the passed-in id is zero, assume new data.
            if (id != 0)
            {
                role = await RoleService.Role_GetOne(id);
                // Change page title and button text since this is an edit.
                pagetitle = "Изменить данные роли";
                buttontext = "Изменить";
            }
        }

        protected async Task RoleSave()
        {
            if (role.Id == 0)
            {
                // Insert if id is zero.
                await RoleService.RoleInsert(role);
            }
            else
            {
                // Update is id > 0
                await RoleService.RoleUpdate(role);
            }
            NavigationManager.NavigateTo("/rolelist");
        }
        void Cancel()
        {
            NavigationManager.NavigateTo("/rolelist");
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleService RoleService { get; set; }
    }
}
#pragma warning restore 1591
