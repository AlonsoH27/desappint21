#pragma checksum "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4c34172422c748961ea7e006dd91488400964a2"
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
#line 1 "/Users/castr/Downloads/programas/p24-universidadv4/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/castr/Downloads/programas/p24-universidadv4/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p24-universidadv4/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p24-universidadv4/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/castr/Downloads/programas/p24-universidadv4/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/castr/Downloads/programas/p24-universidadv4/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/castr/Downloads/programas/p24-universidadv4/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/castr/Downloads/programas/p24-universidadv4/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/castr/Downloads/programas/p24-universidadv4/_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/castr/Downloads/programas/p24-universidadv4/_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EliminarOficinaAsignadas/{Id:int}")]
    public partial class EliminarOficinaAsignadas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Eliminar Oficina Asignada</h3> \n<hr>\n");
            __builder.AddMarkupContent(1, "<h3>Estas seguro que desas Eliminar? </h3>\n\n ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor"
                      obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "fieldset");
                __builder2.AddAttribute(10, "disabled", "true");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label for=\"InstructorId\" class=\"control-label\">Instructor </label>\n                ");
                __Blazor.p21_universidadv1.Pages.OficinaAsignada.EliminarOficinaAsignadas.TypeInference.CreateInputSelect_0(__builder2, 14, 15, "InstructorId", 16, "form-control", 17, 
#nullable restore
#line 18 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor"
                                                                                 obj.InstructorId

#line default
#line hidden
#nullable disable
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.InstructorId = __value, obj.InstructorId)), 19, () => obj.InstructorId, 20, (__builder3) => {
                    __builder3.OpenElement(21, "option");
                    __builder3.AddAttribute(22, "value", 
#nullable restore
#line 19 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor"
                                     0

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(23, "disabled");
                    __builder3.AddContent(24, "-Elije un Instructor-");
                    __builder3.CloseElement();
#nullable restore
#line 20 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor"
                     foreach (var i in @objins )
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(25, "option");
                    __builder3.AddAttribute(26, "value", 
#nullable restore
#line 22 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor"
                                        i.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(27, 
#nullable restore
#line 22 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor"
                                               i.NombreCompleto

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 23 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n            \n               ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "<label for=\"Ubicacion\" class=\"control-label\">Ubicacion</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "id", "Ubicacion");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor"
                                                                            obj.Ubicacion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Ubicacion = __value, obj.Ubicacion))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Ubicacion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n            ");
                __builder2.OpenElement(39, "button");
                __builder2.AddAttribute(40, "type", "submit");
                __builder2.AddAttribute(41, "class", "btn btn-danger");
                __builder2.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor"
                                                                    EliminarOficinaAsignada

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(43, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n            ");
                __builder2.OpenElement(45, "button");
                __builder2.AddAttribute(46, "type", "button");
                __builder2.AddAttribute(47, "class", "btn btn-primary");
                __builder2.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor"
                                                                     Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(49, "Cancelar");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/OficinaAsignada/EliminarOficinaAsignadas.razor"
       
    [Parameter] public int Id {get; set;}
    OficinaAsignada obj = new OficinaAsignada();
    List<Instructor> objins;
    protected void EliminarOficinaAsignada() {
        serv.Eliminar(obj);
        NavigationManager.NavigateTo("OficinaAsignadas");
    }
    protected void Cancelar() {
       NavigationManager.NavigateTo("OficinaAsignadas");
    }
    protected override void OnInitialized() {
         objins = sins.ObtenerTodo();
         obj = serv.Obtener(Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioInstructores sins { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioOficinaAsignadas serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.p21_universidadv1.Pages.OficinaAsignada.EliminarOficinaAsignadas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
