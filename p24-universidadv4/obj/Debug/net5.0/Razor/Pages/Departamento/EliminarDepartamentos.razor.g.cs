#pragma checksum "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ff0831d5ea7b2ea6a3575053fec6ab93e2a482b"
// <auto-generated/>
#pragma warning disable 1591
namespace p21_universidadv1.Pages.Departamento
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
#line 3 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EliminarDepartamentos/{Id}")]
    public partial class EliminarDepartamentos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Eliminar Departamento</h3> \n\n ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
                      obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "fieldset");
                __builder2.AddAttribute(9, "disabled", "true");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label for=\"Nombre\" class=\"control-label\">Nombre</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", "Nombre");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
                                                                         obj.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Nombre = __value, obj.Nombre))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Nombre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n             ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label for=\"Presupuesto\" class=\"control-label\">Presupuesto</label>\n                ");
                __Blazor.p21_universidadv1.Pages.Departamento.EliminarDepartamentos.TypeInference.CreateInputNumber_0(__builder2, 23, 24, "Presupuesto", 25, "form-control", 26, 
#nullable restore
#line 20 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
                                                                                obj.Presupuesto

#line default
#line hidden
#nullable disable
                , 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Presupuesto = __value, obj.Presupuesto)), 28, () => obj.Presupuesto);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n             ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "<label for=\"FechaDeInicio\" class=\"control-label\">Fecha de Inicio</label>\n                ");
                __Blazor.p21_universidadv1.Pages.Departamento.EliminarDepartamentos.TypeInference.CreateInputDate_1(__builder2, 33, 34, "FechaDeInicio", 35, "form-control", 36, 
#nullable restore
#line 24 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
                                                                                obj.FechaDeInicio

#line default
#line hidden
#nullable disable
                , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.FechaDeInicio = __value, obj.FechaDeInicio)), 38, () => obj.FechaDeInicio);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "<label for=\"InstructorId\" class=\"control-label\">Instructor </label>\n                ");
                __Blazor.p21_universidadv1.Pages.Departamento.EliminarDepartamentos.TypeInference.CreateInputSelect_2(__builder2, 43, 44, "DepartamentoId", 45, "form-control", 46, 
#nullable restore
#line 28 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
                                                                                   obj.InstructorId

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.InstructorId = __value, obj.InstructorId)), 48, () => obj.InstructorId, 49, (__builder3) => {
                    __builder3.AddMarkupContent(50, "<option value=\"null\">-sin asignar-</option>");
#nullable restore
#line 30 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
                     foreach (var i in @objins )
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(51, "option");
                    __builder3.AddAttribute(52, "value", 
#nullable restore
#line 32 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
                                        i.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(53, 
#nullable restore
#line 32 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
                                               i.NombreCompleto

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 33 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "   \n            ");
                __builder2.OpenElement(55, "button");
                __builder2.AddAttribute(56, "type", "submit");
                __builder2.AddAttribute(57, "class", "btn btn-danger");
                __builder2.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
                                                                     EliminarDepartamento

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(59, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n            ");
                __builder2.OpenElement(61, "button");
                __builder2.AddAttribute(62, "type", "button");
                __builder2.AddAttribute(63, "class", "btn btn-primary");
                __builder2.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
                                                                     Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(65, "Cancelar");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/Users/castr/Downloads/programas/p24-universidadv4/Pages/Departamento/EliminarDepartamentos.razor"
        
    [Parameter]
    public string Id {get;set;}
    Departamento obj = new Departamento();
    List<Instructor> objins;
    protected void EliminarDepartamento() {
        serv.Eliminar(obj);
        NavigationManager.NavigateTo("Departamentos");
    }
    protected void Cancelar() {
       NavigationManager.NavigateTo("Departamentos");
    }
    protected override void OnInitialized() {
         obj = serv.Obtener(int.Parse(Id));
         objins = sins.ObtenerTodo();
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioInstructores sins { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioDepartamentos serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.p21_universidadv1.Pages.Departamento.EliminarDepartamentos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
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
