#pragma checksum "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/OficinaAsignada/OficinaAsignadas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3cb42a4b32fbd9a7cc75082d27b80e1fc78af15"
// <auto-generated/>
#pragma warning disable 1591
namespace p21_universidadv1.Pages.OficinaAsignada
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/alonso/Documentos/desappint21/p26-universidadv6/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/alonso/Documentos/desappint21/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alonso/Documentos/desappint21/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alonso/Documentos/desappint21/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/alonso/Documentos/desappint21/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/alonso/Documentos/desappint21/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/alonso/Documentos/desappint21/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/alonso/Documentos/desappint21/p26-universidadv6/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/alonso/Documentos/desappint21/p26-universidadv6/_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/alonso/Documentos/desappint21/p26-universidadv6/_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/OficinaAsignada/OficinaAsignadas.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/OficinaAsignada/OficinaAsignadas.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/OficinaAsignadas")]
    public partial class OficinaAsignadas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Informacion de Oficina Asignada</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "AgregarOficinaAsignadas");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<span class=\"oi oi-plus\">Agregar Nuevo</span>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 12 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/OficinaAsignada/OficinaAsignadas.razor"
 if(obj is null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p>Cargando ...</p>");
#nullable restore
#line 14 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/OficinaAsignada/OficinaAsignadas.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><th>Instructor</th>\n            <th>Ubicacion</th></thead>\n    \n    ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 22 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/OficinaAsignada/OficinaAsignadas.razor"
         foreach (var i in obj)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 25 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/OficinaAsignada/OficinaAsignadas.razor"
                     i.Instructor.NombreCompleto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 26 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/OficinaAsignada/OficinaAsignadas.razor"
                     i.Ubicacion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "class", "nav-link");
            __builder.AddAttribute(21, "href", "EditarOficinaAsignadas/" + (
#nullable restore
#line 28 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/OficinaAsignada/OficinaAsignadas.razor"
                                                                      i.InstructorId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "<span class=\"oi oi-pencil\">Editar</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                     ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "class", "nav-link");
            __builder.AddAttribute(26, "href", "EliminarOficinaAsignadas/" + (
#nullable restore
#line 31 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/OficinaAsignada/OficinaAsignadas.razor"
                                                                         i.InstructorId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "<span class=\"oi oi-pencil\">Eliminar</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/OficinaAsignada/OficinaAsignadas.razor"
        } 

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/OficinaAsignada/OficinaAsignadas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/OficinaAsignada/OficinaAsignadas.razor"
       
    List<OficinaAsignada> obj;
 
    protected override void OnInitialized() {
        obj = serv.ObtenerTodo();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioOficinaAsignadas serv { get; set; }
    }
}
#pragma warning restore 1591
