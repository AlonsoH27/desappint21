#pragma checksum "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4dbd1e39f01c12b4557d385bcc8ca7dea4924c7"
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
#line 2 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
using segundoexamenparcial.Modelo;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FilmsActorRoles")]
    public partial class FilmsActorRoles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Films actores roles</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "AgregarFilmsActorRoles");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<span class=\"oi oi-plus\">Agregar nuevo films actor role</span>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 10 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
 if (obj is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p>Cargando . . .</p>");
#nullable restore
#line 13 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><th>Films actor role Id</th>\n            <th>Films title Id</th>\n            <th>Actor Id</th>\n            <th>Role type Id</th>\n            <th>Character name</th>\n            <th>Character descripcion</th></thead>\n\n    ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 25 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
         foreach (var i in obj)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 28 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
                     i.filmsActorRolesId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 29 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
                     i.filmTitleId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 30 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
                     i.actorId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 31 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
                     i.roleTypeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 32 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
                     i.characterName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 33 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
                     i.characterDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                    ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "EditarFilmsActorRole/" + (
#nullable restore
#line 35 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
                                                                    i.filmsActorRolesId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "<span class=\"oi oi-pencil\">Editar</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                     ");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "class", "nav-link");
            __builder.AddAttribute(38, "href", "EliminarFilmsActorRole/" + (
#nullable restore
#line 38 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
                                                                       i.filmsActorRolesId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "<span class=\"oi oi-pencil\">Eliminar</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "/home/alonso/Documentos/desappint21/segundoexamenparcial/Pages/FilmsActorRoles/FilmsActorRoles.razor"
       
    List<filmsActorRoles> obj;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
