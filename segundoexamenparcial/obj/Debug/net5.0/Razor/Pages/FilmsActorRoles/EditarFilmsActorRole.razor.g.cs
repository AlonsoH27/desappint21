#pragma checksum "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/EditarFilmsActorRole.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e96ab6fef2fbed6b38505e6eac7165c99335596"
// <auto-generated/>
#pragma warning disable 1591
namespace segundoexamenparcial.Pages.FilmsActorRoles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/alonso/Documentos/desappint21/segundoexamenparcial/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/alonso/Documentos/desappint21/segundoexamenparcial/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alonso/Documentos/desappint21/segundoexamenparcial/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alonso/Documentos/desappint21/segundoexamenparcial/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/alonso/Documentos/desappint21/segundoexamenparcial/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/alonso/Documentos/desappint21/segundoexamenparcial/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/alonso/Documentos/desappint21/segundoexamenparcial/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/alonso/Documentos/desappint21/segundoexamenparcial/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/alonso/Documentos/desappint21/segundoexamenparcial/_Imports.razor"
using segundoexamenparcial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/alonso/Documentos/desappint21/segundoexamenparcial/_Imports.razor"
using segundoexamenparcial.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/EditarFilmsActorRole.razor"
using segundoexamenparcial.Modelo;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditarFilmsActorRole")]
    public partial class EditarFilmsActorRole : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar films actor role</h3>\n");
            __builder.AddMarkupContent(1, @"<div class=""row""><div class=""col-md-8""><div class=""form-group""><label for=""filmsActorRolesId"" class=""control-label"">Films actor roles Id</label>
            <input type=""text"" id=""fullName"" class=""form-control""></div>
        <div class=""form-group""><label for=""filmTitleId"" class=""control-label"">Selecciona el film title Id</label>
            <input type=""text"" id=""fullName"" class=""form-control""></div><div class=""form-group""><label for=""actorId"" class=""control-label"">Selecciona el actor Id</label>
            <input type=""text"" id=""fullName"" class=""form-control""></div><div class=""form-group""><label for=""roleTypeId"" class=""control-label"">Selecciona el role type Id</label>
            <input type=""text"" id=""fullName"" class=""form-control""></div><div class=""form-group""><label for=""characterName"" class=""control-label"">Selecciona el character name</label>
            <input type=""text"" id=""fullName"" class=""form-control""></div><div class=""form-group""><label for=""characterDescription"" class=""control-label"">Selecciona el character description</label>
            <input type=""text"" id=""fullName"" class=""form-control""></div>
        <button type=""submit"" class=""btn btn-primary"">Guardar</button>
        <button type=""button"" class=""btn btn-primary"">Cancelar</button></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/EditarFilmsActorRole.razor"
       
    FilmsActorRoles obj = new FilmsActorRoles();
    List<filmTitles> obj1;
    List<Actor> obj2;
    List<roleTypes> obj3;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
