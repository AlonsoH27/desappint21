#pragma checksum "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "023ac5d282b8c871ea9984bdde60f5af3da9e6d5"
// <auto-generated/>
#pragma warning disable 1591
namespace p21_universidadv1.Pages.Instructor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Instructores")]
    public partial class Instructores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Informacion de Instructores</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "AgregarInstructores");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<span class=\"oi oi-plus\">Agregar Nuevo</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n\n");
            __builder.AddMarkupContent(7, "<label>Buscar por apeidos:</label>\n");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                                (e) => Filtro(e) 

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 15 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
 if(obj is null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<p>Cargando ...</p>");
#nullable restore
#line 17 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, @"<thead><th>Id</th>
            <th>Apeido Paterno</th>
            <th>Apeido Materno</th>
            <th>Nombre</th>
            <th>Email</th>
            <th>Fecha Ingreso</th>
            <th>Ubicacion</th>
            <th>Cursos Asignados</th></thead>
    
    ");
            __builder.OpenElement(15, "tbody");
#nullable restore
#line 31 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
         foreach (var i in obj)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "tr");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 34 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                     i.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 35 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                     i.Apaterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 36 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                     i.Amaterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 37 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                     i.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 38 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                     i.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 39 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                     i.FechaContratacion.ToString("yyy-MMM-dd")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 40 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                      i.OficinaAsignada==null?"-sin oficina-":i.OficinaAsignada.Ubicacion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 41 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                 if(i.AsignacionCursos.Count==0) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "<td>-sin asignacion-</td>");
#nullable restore
#line 43 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                } else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "td");
#nullable restore
#line 45 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                         foreach(var a in i.AsignacionCursos) {
                            

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, 
#nullable restore
#line 46 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                             a.Curso.CursoId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, " - ");
            __builder.AddContent(41, 
#nullable restore
#line 46 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                                                  a.Curso.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(42, " <br />\n");
#nullable restore
#line 47 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 49 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "td");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "class", "nav-link");
            __builder.AddAttribute(46, "href", "EditarInstructores/" + (
#nullable restore
#line 51 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                                                                  i.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "<span class=\"oi oi-pencil\">Editar</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                     ");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "class", "nav-link");
            __builder.AddAttribute(51, "href", "ElimnarInstructores/" + (
#nullable restore
#line 54 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
                                                                    i.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "<span class=\"oi oi-pencil\">Eliminar</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/Instructor/Instructores.razor"
       
    List<Instructor> obj;
 
    protected override void OnInitialized() {
        obj = serv.ObtenerTodo("");

    }

    protected void Filtro(ChangeEventArgs e) {
        string cadenabuscar = e.Value.ToString();
        obj = serv.ObtenerTodo(cadenabuscar);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioInstructores serv { get; set; }
    }
}
#pragma warning restore 1591
