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
#line 1 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\User\UserDelete.razor"
using LIMSBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userdelete/{id:int}")]
    public partial class UserDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Иван\source\repos\LIMSBlazor\LIMSBlazor\Pages\User\UserDelete.razor"
            // Create a new, empty object
        User user = new User();

        [Parameter]
        public int id { get; set; }

        //Executes on page open..
        protected override async Task OnInitializedAsync()
        {
            user = await UserService.User_GetOne(id);
        }

        protected async Task Delete()
        {
            // Insert if id is zero.
            await UserService.UserDelete(id);
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
