#pragma checksum "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23f349d7366f601d43b514d30e06e280bae99d63"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecto_final.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Proyecto_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Proyecto_final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Proyecto_final.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Proyecto_final.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using BlazorLeaflet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using BlazorLeaflet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using BlazorLeaflet.Models.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 6 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Shared\LoginDisplay.razor"
          
            var user = um.GetUserAsync(context.User).Result;


#line default
#line hidden
#nullable disable
                __builder2.OpenElement(2, "p");
                __builder2.AddAttribute(3, "style", "margin: 0;");
                __builder2.AddContent(4, 
#nullable restore
#line 9 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Shared\LoginDisplay.razor"
                                   user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.OpenElement(6, "img");
                __builder2.AddAttribute(7, "src", 
#nullable restore
#line 10 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Shared\LoginDisplay.razor"
                       user.Foto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(8, "alt");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<AppUser> um { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SistemaDbContext sc { get; set; }
    }
}
#pragma warning restore 1591
