#pragma checksum "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe710767211418e28971edd30a3cf440c62a5700"
// <auto-generated/>
#pragma warning disable 1591
namespace p21_universidadv1.Pages.AsignacionCurso
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/castr/Downloads/programas/p25-universidadv5/_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AgregarAsignacionCursos")]
    public partial class AgregarAsignacionCursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Asignar Curso a Instructor</h3> \n\n ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                      obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                                           CrearAsignacionCurso

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label for=\"InstructorId\" class=\"control-label\">Instructor </label>\n                ");
                __Blazor.p21_universidadv1.Pages.AsignacionCurso.AgregarAsignacionCursos.TypeInference.CreateInputSelect_0(__builder2, 16, 17, "InstructorId", 18, "form-control", 19, 
#nullable restore
#line 18 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                                                                                 obj.InstructorId

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.InstructorId = __value, obj.InstructorId)), 21, () => obj.InstructorId, 22, (__builder3) => {
                    __builder3.OpenElement(23, "option");
                    __builder3.AddAttribute(24, "value", 
#nullable restore
#line 19 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                                     0

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(25, "disabled");
                    __builder3.AddContent(26, "-Elije un Instructor-");
                    __builder3.CloseElement();
#nullable restore
#line 20 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                     foreach (var i in @objins )
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(27, "option");
                    __builder3.AddAttribute(28, "value", 
#nullable restore
#line 22 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                                        i.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(29, 
#nullable restore
#line 22 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                                               i.NombreCompleto

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 23 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label for=\"CursoId\" class=\"control-label\">Cruso </label>\n                ");
                __Blazor.p21_universidadv1.Pages.AsignacionCurso.AgregarAsignacionCursos.TypeInference.CreateInputSelect_1(__builder2, 34, 35, "CursoId", 36, "form-control", 37, 
#nullable restore
#line 28 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                                                                            obj.CursoId

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.CursoId = __value, obj.CursoId)), 39, () => obj.CursoId, 40, (__builder3) => {
                    __builder3.OpenElement(41, "option");
                    __builder3.AddAttribute(42, "value", 
#nullable restore
#line 29 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                                     0

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(43, "disabled");
                    __builder3.AddContent(44, "-Elije un Curso-");
                    __builder3.CloseElement();
#nullable restore
#line 30 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                     foreach (var i in @objins1 )
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(45, "option");
                    __builder3.AddAttribute(46, "value", 
#nullable restore
#line 32 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                                        i.CursoId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(47, 
#nullable restore
#line 32 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                                                    i.Titulo

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 33 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n         \n            \n            ");
                __builder2.AddMarkupContent(49, "<button type=\"submit\" class=\"btn btn-primary\">Guardar</button>\n            ");
                __builder2.OpenElement(50, "button");
                __builder2.AddAttribute(51, "type", "button");
                __builder2.AddAttribute(52, "class", "btn btn-primary");
                __builder2.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
                                                                     Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(54, "Cancelar");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/Users/castr/Downloads/programas/p25-universidadv5/Pages/AsignacionCurso/AgregarAsignacionCursos.razor"
       
    AsignacionCurso obj = new AsignacionCurso();
    List<Instructor> objins;
    List<Curso> objins1;
    protected void CrearAsignacionCurso() {
        serv.Insertar(obj);
        NavigationManager.NavigateTo("AsignacionCursos");
    }
    protected void Cancelar() {
       NavigationManager.NavigateTo("AsignacionCursos");
    }
    protected override void OnInitialized() {
         objins = sins.ObtenerTodo("");
         objins1 = sins1.ObtenerTodo("");
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
namespace __Blazor.p21_universidadv1.Pages.AsignacionCurso.AgregarAsignacionCursos
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
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
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
