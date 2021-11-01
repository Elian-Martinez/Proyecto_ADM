// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Proyecto_final.Pages.Reservaciones
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
#nullable restore
#line 2 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Reservaciones\Listado-Reservaciones.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listado-reservaciones")]
    public partial class Listado_Reservaciones : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "c:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Reservaciones\Listado-Reservaciones.razor"
 
    private List<Reservacion> reservaciones = null;
    private List<Reservacion> reservacionesFiltradas = null;

    private string campoFiltro = "Estado";
    private string textoFiltro = "";

    protected override async Task OnInitializedAsync()
    {
        reservacionesFiltradas = reservaciones = await sc.Reservaciones.Include("Cliente").Include("Vehiculo").ToListAsync();
    }

    private void filtrarReservaciones(ChangeEventArgs e)
    {
        textoFiltro = e.Value.ToString();
        reservacionesFiltradas = reservaciones.FindAll(
        r => r.GetPropertyValue<String>(campoFiltro)
        .ToLower().Contains(textoFiltro.ToLower()));
    }

    private async Task Borrar(Reservacion r)
    {
        var result = await Swal.FireAsync(new SweetAlertOptions()
        {
            Title = "Esta seguro que desea eliminar la Reservacion?",
            Icon = SweetAlertIcon.Error,
            Html = $"{r.FechaInicioCorta} - {r.FechaFinCorta} <br>"
                + $"{r.Cliente.NombreCompleto} <br>"
                + $"{r.Vehiculo.Informacion}",
            ShowCancelButton = true,
            ConfirmButtonText = "Borrar",
            ConfirmButtonColor = "#dc3545",
            CancelButtonText = "Cancelar",
            CancelButtonColor = "#28a745"
        });

        if (!string.IsNullOrEmpty(result.Value))
        {
            sc.Remove(r);
            reservaciones.Remove(r);
            await sc.SaveChangesAsync();

            await Swal.FireAsync(new SweetAlertOptions() {
                Icon = SweetAlertIcon.Warning,
                Title = "Borrado",
                Html = $"La Reservacion del {r.FechaInicioCorta} - {r.FechaFinCorta}"
                    + $"<br> de {r.Cliente.NombreCompleto} ha sido borrada",
            });
        }
    }


    private async Task Pagando(Reservacion r)
    {
        var MontoDebido = r.MontoTotal - r.MontoPagado;

        var result = await Swal.FireAsync(new SweetAlertOptions()
        {
            Title = "Cuanto desea pagar?",
            Input = "number",
            Html = $"<div class='alert alert-success'>Precio total de la reservacion <button class='btn btn-success' disabled>{r.MontoTotal}</div></button> "
                + $" <div class='alert alert-info'>Cantidad que ha pagado es --<button class='btn btn-info' disabled> {r.MontoPagado}</button> --</div>"
                + $" <div class='alert alert-danger'>Cantidad que debe <button class='btn btn-danger' disabled>{MontoDebido}</button></div>",
            ShowCancelButton = true,
            ConfirmButtonText = "Pagar",
            CancelButtonText = "Cancelar"
        });


        if (!string.IsNullOrEmpty(result.Value))
        {
            var MontoAbonado = Convert.ToInt32(result.Value);

            if (MontoDebido < MontoAbonado) {
                await Swal.FireAsync(new SweetAlertOptions() {
                    Icon = SweetAlertIcon.Error,
                    Title = "Monto Superior a la Deuda",
                    Text = "El Monto Abonado es mayor a lo que debe el Cliente. Intente de nuevo",
                });

                await Pagando(r);
                return;
            }

            r.MontoPagado += MontoAbonado;
            await sc.SaveChangesAsync();

            await Swal.FireAsync(new SweetAlertOptions()
            {
                Icon = SweetAlertIcon.Success,
                Title = $"Abonado {MontoAbonado.ToString("C0")}",
                Html = $"Se ha aumento en {MontoAbonado}</br> "
                    + $"La Reservacion del {r.FechaInicioCorta} - {r.FechaFinCorta}"
                    + $"<br> de {r.Cliente.NombreCompleto} <br><br>"
                    + $"Ahora debe {MontoDebido.ToString("C0")}"
            });
        }
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