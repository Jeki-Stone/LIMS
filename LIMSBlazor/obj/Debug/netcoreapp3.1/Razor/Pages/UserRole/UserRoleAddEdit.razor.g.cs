#pragma checksum "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3797768ac81a7c1be702c8aa6a008ef294b90ac8"
// <auto-generated/>
#pragma warning disable 1591
namespace LIMSBlazor.Pages.UserRole
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userlist/userroleaddedit/{UserId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/userlist/userroleaddedit/{UserId:int}/{LabId:int}/{RoleId:int}")]
    public partial class UserRoleAddEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LIMSBlazor.Shared.DataEdit>(0);
            __builder.AddAttribute(1, "PageTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                      pagetitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                                         userrole

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "BtnSaveText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                                                                 buttontext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                                                                                             UserRoleSave

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "OnClickCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
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
                __builder2.AddMarkupContent(12, "<td>Пользователь:</td>\r\n            ");
                __builder2.OpenElement(13, "td");
                __builder2.AddContent(14, 
#nullable restore
#line 14 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                 users?.Where(x => x.Id == UserId).FirstOrDefault()?.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "tr");
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.AddMarkupContent(19, "<td>Лаборатория:</td>\r\n            ");
                __builder2.OpenElement(20, "td");
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.OpenElement(22, "select");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "required", true);
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                               userrole.LabId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userrole.LabId = __value, userrole.LabId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(27, "\r\n");
#nullable restore
#line 20 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                     if (labs != null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(28, "                        ");
                __builder2.OpenElement(29, "option");
                __builder2.AddAttribute(30, "value", "0");
                __builder2.AddMarkupContent(31, "Выберите значение");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n");
#nullable restore
#line 23 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                        foreach (var item in labs)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(33, "                            ");
                __builder2.OpenElement(34, "option");
                __builder2.AddAttribute(35, "value", 
#nullable restore
#line 25 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                                            item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(36, 
#nullable restore
#line 25 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n");
#nullable restore
#line 26 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(38, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenElement(42, "tr");
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.AddMarkupContent(44, "<td>Роль:</td>\r\n            ");
                __builder2.OpenElement(45, "td");
                __builder2.AddMarkupContent(46, "\r\n                ");
                __builder2.OpenElement(47, "select");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "required", true);
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                               userrole.RoleId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userrole.RoleId = __value, userrole.RoleId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(52, "\r\n");
#nullable restore
#line 35 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                     if (roles != null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(53, "                        ");
                __builder2.OpenElement(54, "option");
                __builder2.AddAttribute(55, "value", "0");
                __builder2.AddMarkupContent(56, "Выберите значение");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n");
#nullable restore
#line 38 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                        foreach (var item in roles)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(58, "                            ");
                __builder2.OpenElement(59, "option");
                __builder2.AddAttribute(60, "value", 
#nullable restore
#line 40 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                                            item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(61, 
#nullable restore
#line 40 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n");
#nullable restore
#line 41 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(63, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\UserRole\UserRoleAddEdit.razor"
           
        // Create a new, empty object
        UserRole userrole = new UserRole();

        IEnumerable<User> users;
        IEnumerable<Lab> labs;
        IEnumerable<Role> roles;

        [Parameter]
        public int UserId { get; set; }
        [Parameter]
        public int LabId { get; set; }
        [Parameter]
        public int RoleId { get; set; }

        // Set default page title and button text
        public string pagetitle = "Добавить новую роль пользователю";
        public string buttontext = "Добавить";

        //Executes on page open, set defaults on page.
        protected override async Task OnInitializedAsync()
        {
            users = await UserService.UserList();
            labs = await LabService.LabList();
            roles = await RoleService.RoleList();
            // ============ If the passed-in id is zero, assume new data.
            if ((UserId != 0) & (LabId != 0) & (RoleId != 0))
            {
                userrole = await UserRoleService.UserRole_GetOne(UserId, LabId, RoleId);
                // Change page title and button text since this is an edit.

                pagetitle = "Изменить данные роли пользователя";
                buttontext = "Изменить";
            }
        }

        protected async Task UserRoleSave()
        {
            if ((userrole.UserId != 0) & (userrole.LabId != 0) & (userrole.RoleId != 0))
            {
                // Update is id > 0
                userrole.OldLabId = LabId;
                userrole.OldRoleId = RoleId;
                await UserRoleService.UserRoleUpdate(userrole);
            }
            else
            {
                // Insert if id is zero.
                await UserRoleService.UserRoleInsert(userrole, UserId);
            }
            NavigationManager.NavigateTo("/userlist/userrolelist/" + UserId);
        }
        void Cancel()
        {
            NavigationManager.NavigateTo("/userlist/userrolelist/" + UserId);
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleService RoleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILabService LabService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRoleService UserRoleService { get; set; }
    }
}
#pragma warning restore 1591