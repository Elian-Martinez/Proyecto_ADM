#pragma checksum "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf81069ee94dd72eecc4978dde2ca4bd11fb8951"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecto_final.Pages.Vehiculos
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
#line 2 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registrar-vehiculo")]
    public partial class Registrar_Vehiculo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "registrar-vehicul");
            __builder.AddMarkupContent(2, "<a href=\"/menu\"><i class=\"fas fa-arrow-left\"></i></a>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "contenido-registrar-vehicul");
            __builder.AddMarkupContent(5, "<h2 class=\"text-center\">Registrar Vehiculo</h2>");
#nullable restore
#line 9 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
             if (tipos == null) {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Proyecto_final.Shared.Cargando>(6);
            __builder.CloseComponent();
#nullable restore
#line 11 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
            }
            else {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                 vehiculo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                          Submit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "placeholder", "Marca");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                vehiculo.Marca

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Marca = __value, vehiculo.Marca))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vehiculo.Marca));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "placeholder", "Modelo");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                vehiculo.Modelo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Modelo = __value, vehiculo.Modelo))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vehiculo.Modelo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "type", "number");
                __builder2.AddAttribute(27, "placeholder", "Año");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                vehiculo.Año

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Año = __value, vehiculo.Año))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vehiculo.Año));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "placeholder", "Color");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                vehiculo.Color

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Color = __value, vehiculo.Color))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vehiculo.Color));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "placeholder", "Matricula");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                vehiculo.Matricula

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Matricula = __value, vehiculo.Matricula))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vehiculo.Matricula));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "placeholder", "Marca del Seguro");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                vehiculo.MarcaSeguro

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.MarcaSeguro = __value, vehiculo.MarcaSeguro))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vehiculo.MarcaSeguro));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "placeholder", "Numero del Seguro");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                vehiculo.NumeroSeguro

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.NumeroSeguro = __value, vehiculo.NumeroSeguro))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vehiculo.NumeroSeguro));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n\r\n\r\n\r\n                        ");
                __builder2.AddMarkupContent(56, "<h4> Precio por Dia: </h4>\r\n                        ");
                __Blazor.Proyecto_final.Pages.Vehiculos.Registrar_Vehiculo.TypeInference.CreateInputNumber_0(__builder2, 57, 58, "Precio por Dia", 59, "0", 60, 
#nullable restore
#line 35 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                  vehiculo.PrecioDia

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.PrecioDia = __value, vehiculo.PrecioDia)), 62, () => vehiculo.PrecioDia);
                __builder2.AddMarkupContent(63, "\r\n\r\n\r\n\r\n\r\n                        ");
                __builder2.AddMarkupContent(64, "<h4> Tipo: </h4>\r\n                        ");
                __Blazor.Proyecto_final.Pages.Vehiculos.Registrar_Vehiculo.TypeInference.CreateInputSelect_1(__builder2, 65, 66, "input", 67, 
#nullable restore
#line 41 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                  vehiculo.TipoId

#line default
#line hidden
#nullable disable
                , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.TipoId = __value, vehiculo.TipoId)), 69, () => vehiculo.TipoId, 70, (__builder3) => {
                    __builder3.AddMarkupContent(71, "<option value disabled selected>Tipo</option>");
#nullable restore
#line 43 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                             foreach(var tipo in tipos) {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(72, "option");
                    __builder3.AddAttribute(73, "value", 
#nullable restore
#line 44 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                tipo.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(74, 
#nullable restore
#line 44 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                          tipo.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 45 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(75, "\r\n\r\n\r\n\r\n                        ");
                __builder2.AddMarkupContent(76, "<h4> Capacidad de Carga: </h4>\r\n                        ");
                __Blazor.Proyecto_final.Pages.Vehiculos.Registrar_Vehiculo.TypeInference.CreateInputNumber_2(__builder2, 77, 78, "Capacidad de Carga", 79, 
#nullable restore
#line 51 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                  vehiculo.Carga

#line default
#line hidden
#nullable disable
                , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Carga = __value, vehiculo.Carga)), 81, () => vehiculo.Carga);
                __builder2.AddMarkupContent(82, "\r\n\r\n\r\n\r\n                        ");
                __builder2.AddMarkupContent(83, "<h4> Cantidad de Pasajeros: </h4>\r\n                        ");
                __Blazor.Proyecto_final.Pages.Vehiculos.Registrar_Vehiculo.TypeInference.CreateInputNumber_3(__builder2, 84, 85, "Cantidad de Pasajeros", 86, 
#nullable restore
#line 56 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                  vehiculo.Pasajeros

#line default
#line hidden
#nullable disable
                , 87, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo.Pasajeros = __value, vehiculo.Pasajeros)), 88, () => vehiculo.Pasajeros);
                __builder2.AddMarkupContent(89, "\r\n\r\n\r\n                        ");
                __builder2.AddMarkupContent(90, "<h4> Foto: </h4>\r\n                        ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", " col-md-6");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(93);
                __builder2.AddAttribute(94, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                                 InputImage

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(95, "accept", "image/png, image/jpeg");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n                            ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "mx-auto");
                __builder2.OpenElement(99, "img");
                __builder2.AddAttribute(100, "src", 
#nullable restore
#line 63 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                           vehiculo.Foto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(101, "class", "m-2 thumbnail");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n\r\n\r\n\r\n\r\n                        ");
                __builder2.AddMarkupContent(103, "<h4> Ubicacion: </h4>\r\n                        ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "style", "height: 300px");
                __builder2.AddAttribute(106, "class", "col-md-6");
                __builder2.OpenComponent<Proyecto_final.Shared.LeafletMap>(107);
                __builder2.AddAttribute(108, "Map", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorLeaflet.Map>(
#nullable restore
#line 72 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
                                             mapa

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n\r\n\r\n\r\n                        ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "mx-auto");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(112);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n\r\n\r\n\r\n                        ");
                __builder2.AddMarkupContent(114, "<button type=\"submit\">Registrar</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 86 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n\r\n\r\n\r\n  ");
            __builder.AddMarkupContent(116, @"<svg class=""wavessss"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 1440 320""><path fill=""#00cba9"" fill-opacity=""1"" d=""M0,32L16,53.3C32,75,64,117,96,144C128,171,160,181,192,176C224,171,256,149,288,128C320,107,352,85,384,85.3C416,85,448,107,480,149.3C512,192,544,256,576,245.3C608,235,640,149,672,106.7C704,64,736,64,768,80C800,96,832,128,864,170.7C896,213,928,267,960,272C992,277,1024,235,1056,197.3C1088,160,1120,128,1152,128C1184,128,1216,160,1248,160C1280,160,1312,128,1344,106.7C1376,85,1408,75,1424,69.3L1440,64L1440,320L1424,320C1408,320,1376,320,1344,320C1312,320,1280,320,1248,320C1216,320,1184,320,1152,320C1120,320,1088,320,1056,320C1024,320,992,320,960,320C928,320,896,320,864,320C832,320,800,320,768,320C736,320,704,320,672,320C640,320,608,320,576,320C544,320,512,320,480,320C448,320,416,320,384,320C352,320,320,320,288,320C256,320,224,320,192,320C160,320,128,320,96,320C64,320,32,320,16,320L0,320Z""></path></svg>");
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\HP 15-BS191DX\Desktop\Proyecto_Final\Programacion-III-Proyecto-Final\Pages\Vehiculos\Registrar-Vehiculo.razor"
 
    private Vehiculo vehiculo = new Vehiculo();
    private List<TipoVehiculo> tipos = null;

    private Map mapa = null;
    private Marker ubicacionVehiculo = null;

    protected override async Task OnInitializedAsync() {
        tipos = await sc.TipoVehiculos.ToListAsync();

        var defaultLatLng = new LatLng(18.5548f, -70.0578f);

        mapa = new Map(jsr) {
            Center = defaultLatLng,
            Zoom = 7.47f
        };

        ubicacionVehiculo = new Marker(defaultLatLng) {
            Draggable = true,
            Title = "Selecciona tu ubicacion"
        };

        mapa.OnInitialized += () => {
            mapa.AddLayer(new TileLayer
            {
                UrlTemplate = "https://tile.openstreetmap.org/{z}/{x}/{y}.png",
                Attribution = "&copy; <a href=\"https://www.openstreetmap.org/copyright\">OpenStreetMap</a> contributors",
            });
            mapa.AddLayer(ubicacionVehiculo);
        };

        mapa.OnClick += (Map sender, MouseEvent e) => {
            vehiculo.Latitud = e.LatLng.Lat;
            vehiculo.Longitud = e.LatLng.Lng;
            ubicacionVehiculo.Position = e.LatLng;
            mapa.RemoveLayer(ubicacionVehiculo);
            mapa.AddLayer(ubicacionVehiculo);
        };

        ubicacionVehiculo.OnDrag += (Marker sender, DragEvent e) => {
            vehiculo.Latitud = e.LatLng.Lat;
            vehiculo.Longitud = e.LatLng.Lng;
        };
    }

    private async Task Submit() {
        await sc.AddAsync(vehiculo);
        await sc.SaveChangesAsync();
        await Swal.FireAsync(
            $"Agregado",
            $"",
            SweetAlertIcon.Success
        );
        nm.NavigateTo("/listado-vehiculos");
    }

    private async Task InputImage(InputFileChangeEventArgs e) {
        var format = "image/jpg";

        var resizedImage = await e.GetMultipleFiles()[0].RequestImageFileAsync(format, 200, 200);
        var buffer = new byte[resizedImage.Size];
        await resizedImage.OpenReadStream().ReadAsync(buffer);

        var imageUri = $"data:{format};base64,{Convert.ToBase64String(buffer)}";

        vehiculo.Foto = imageUri;
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
namespace __Blazor.Proyecto_final.Pages.Vehiculos.Registrar_Vehiculo
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "min", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
