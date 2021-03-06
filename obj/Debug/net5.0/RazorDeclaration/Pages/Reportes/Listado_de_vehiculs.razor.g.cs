// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Proyecto_final.Pages.Reportes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Proyecto_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Proyecto_final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Proyecto_final.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using Proyecto_final.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using BlazorLeaflet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using BlazorLeaflet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using BlazorLeaflet.Models.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/reporte1")]
    public partial class Listado_de_vehiculs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Reportes\Listado_de_vehiculs.razor"
      
    private List<Vehiculo> vehiculos = null;
    private List<Vehiculo> vehiculosDisponibles = null;

    public DateTime Fechai = DateTime.Now.Date;
    public DateTime fechaf = DateTime.Now.Date.AddDays(7);

    protected override async Task OnInitializedAsync()
    {
        vehiculos = await sc.Vehiculos.Include("Reservaciones").Where(v => v.Habilitado).ToListAsync();
        filtrarVehiculosDisponibles();
    }
    private void filtrarVehiculosDisponibles()
    {
        vehiculosDisponibles = vehiculos.Where(
            v => !v.Reservaciones.Any(
                r => Math.Max(r.FechaInicio.Ticks, Fechai.Ticks)
                    <= Math.Min(r.FechaFin.Ticks, fechaf.Ticks)))
        .ToList();
    }

    private void cambioFechaInicio(ChangeEventArgs e)
    {
        Fechai = Convert.ToDateTime(e.Value);
        filtrarVehiculosDisponibles();
    }

    private void cambioFechaFin(ChangeEventArgs e)
    {
        fechaf = Convert.ToDateTime(e.Value);
        filtrarVehiculosDisponibles();
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
