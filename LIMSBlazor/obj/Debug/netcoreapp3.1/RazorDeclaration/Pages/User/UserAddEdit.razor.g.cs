// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LIMSBlazor.Pages.User
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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\User\UserAddEdit.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/useraddedit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/useraddedit/{id:int}")]
    public partial class UserAddEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\User\UserAddEdit.razor"
       
    // Create a new, empty object
    User user = new User();

    [Parameter]
    public int? id { get; set; }

    // Set default page title and button text
    public string pagetitle = "Добавить нового Пользователя";
    public string buttontext = "Добавить";

    //Executes on page open, set defaults on page.
    protected override async Task OnInitializedAsync()
    {
        // ============ If the passed-in id is zero, assume new data.
        if (id != null)
        {
            user = await UserService.User_GetOne((int)id);
            // Change page title and button text since this is an edit.
            pagetitle = "Изменить данные Пользователя";
            buttontext = "Изменить";
        }
    }

    protected async Task UserSave()
    {
        if (user.Id == 0)
        {
            // Insert if id is zero.
            await UserService.UserInsert(user);
        }
        else
        {
            // Update is id > 0
            await UserService.UserUpdate(user);
        }
        NavigationManager.NavigateTo("/userlist");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("/userlist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
#pragma warning restore 1591
