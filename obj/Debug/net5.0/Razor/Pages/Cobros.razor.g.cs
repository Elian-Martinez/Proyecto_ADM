#pragma checksum "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Cobros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c342430822c00801a8c5dda010086fd21e3622f6"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecto_final.Pages
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
#line 2 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Cobros.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cobros")]
    public partial class Cobros : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<img src=\"imgs/clients.png\" class=\"Backgroundclientes\" alt>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "contenido-tabla-registro");
            __builder.AddAttribute(3, "style", "margin: 1cm;");
            __builder.AddMarkupContent(4, "<a href=\"/menu\"><i class=\"fas fa-arrow-left\"></i></a>\r\n    ");
            __builder.AddMarkupContent(5, "<h1 style=\"color: black;\">Facturas / Cobros</h1>\r\n    ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "style", "width:100%; height:auto;");
            __builder.AddAttribute(8, "class", "Tabla-Presentacion");
            __builder.AddMarkupContent(9, @"<thead><tr class=""Tabla-Cabeza""><th>Cod_Cliente</th>
                <th>Cliente</th>
                <th>Vehiculo</th>
                <th>Fecha de inicio</th>
                <th>Fecha de fin</th>
                <th>Monto Pagado</th>
                <th>Monto Total</th></tr></thead>
        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 23 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Cobros.razor"
             foreach (Reservacion res in reservaciones)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.AddAttribute(12, "class", "Tabla-Pie");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 26 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Cobros.razor"
                         res.ClienteId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 27 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Cobros.razor"
                         res.Cliente

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 28 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Cobros.razor"
                         res.Vehiculo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 29 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Cobros.razor"
                         res.FechaInicio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 30 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Cobros.razor"
                         res.FechaFin

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 31 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Cobros.razor"
                         res.MontoPagado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 32 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Cobros.razor"
                         res.MontoTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Cobros.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Cobros.razor"
      
    private List<Reservacion> reservaciones = null;

    protected override async Task OnInitializedAsync() {
        reservaciones = await sc.Reservaciones.Include("Cliente")
            .Include("Vehiculo").ToListAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SistemaDbContext sc { get; set; }
    }
}
#pragma warning restore 1591
