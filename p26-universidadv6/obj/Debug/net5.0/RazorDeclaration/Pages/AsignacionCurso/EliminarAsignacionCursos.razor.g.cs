// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace p21_universidadv1.Pages.AsignacionCurso
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
#line 3 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/AsignacionCurso/EliminarAsignacionCursos.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/AsignacionCurso/EliminarAsignacionCursos.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EliminarAsignacionCursos/{Id1:int}/{Id2:int}")]
    public partial class EliminarAsignacionCursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/home/alonso/Documentos/desappint21/p26-universidadv6/Pages/AsignacionCurso/EliminarAsignacionCursos.razor"
       
    [Parameter] public int Id1 {get;set;}
    [Parameter] public int Id2 {get;set;}
    AsignacionCurso obj = new AsignacionCurso();
    List<Instructor> objins;
    List<Curso> objins1;
    protected void EliminarAsignacionCurso() {
        serv.Eliminar(obj);
        NavigationManager.NavigateTo("AsignacionCursos");
    }
    protected void Cancelar() {
       NavigationManager.NavigateTo("AsignacionCursos");
    }
    protected override void OnInitialized() {
         objins = sins.ObtenerTodo("");
         objins1 = sins1.ObtenerTodo("");
         obj = serv.Obtener(Id1,Id2);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioCursos sins1 { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioInstructores sins { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioAsignacionCursos serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
