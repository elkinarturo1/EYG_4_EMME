#pragma checksum "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47157b9c11840731d9e015fce5bbb0605d5a4ab8"
// <auto-generated/>
#pragma warning disable 1591
namespace EMME_Acabados_.Pages.Paginas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\_Imports.razor"
using EMME_Acabados_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\_Imports.razor"
using EMME_Acabados_.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\_Imports.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
using EASendMail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
using EMME_Acabados_.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Contacto")]
    public partial class Contactos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<EMME_Acabados_.Shared.NavMenu>(0);
            __builder.AddAttribute(1, "activadoContacto", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                            Mostrar

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "site-section");
            __builder.AddAttribute(5, "data-aos", "fade");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.AddMarkupContent(8, "<div class=\"row justify-content-center\"><div class=\"col-md-7\"><div class=\"row mb-5\"><div class=\"col-12 \"><h2 class=\"site-section-heading text-center\">Contactanos</h2></div></div></div></div>\r\n\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-lg-8 mb-5");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 25 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                                  contacto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 25 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                                                            OnInitializedAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "row form-group");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-md-6 mb-3 mb-md-0");
                __builder2.AddMarkupContent(23, "<label class=\"text-white\" for=\"fname\">Primer Nombre</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "id", "fname");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                                                                                        contacto.Primero_Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contacto.Primero_Nombre = __value, contacto.Primero_Nombre))));
                __builder2.AddAttribute(29, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contacto.Primero_Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                                ");
                __Blazor.EMME_Acabados_.Pages.Paginas.Contactos.TypeInference.CreateValidationMessage_0(__builder2, 31, 32, 
#nullable restore
#line 32 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                                                        (() => contacto.Primero_Nombre)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-md-6");
                __builder2.AddMarkupContent(36, "<label class=\"text-white\" for=\"lname\">Segundo Nombre</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "id", "lname");
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                                                                                        contacto.Segundo_Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contacto.Segundo_Nombre = __value, contacto.Segundo_Nombre))));
                __builder2.AddAttribute(42, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contacto.Segundo_Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n                                ");
                __Blazor.EMME_Acabados_.Pages.Paginas.Contactos.TypeInference.CreateValidationMessage_1(__builder2, 44, 45, 
#nullable restore
#line 37 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                                                        (() => contacto.Segundo_Nombre)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n                        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "row form-group");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col-md-12");
                __builder2.AddMarkupContent(51, "<label class=\"text-white\" for=\"email\">Email</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
                __builder2.AddAttribute(53, "id", "email");
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                                                                                        contacto.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contacto.Email = __value, contacto.Email))));
                __builder2.AddAttribute(57, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contacto.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n                                ");
                __Blazor.EMME_Acabados_.Pages.Paginas.Contactos.TypeInference.CreateValidationMessage_2(__builder2, 59, 60, 
#nullable restore
#line 46 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                                                        (() => contacto.Segundo_Nombre)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n                        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "row form-group");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-md-12");
                __builder2.AddMarkupContent(66, "<label class=\"text-white\" for=\"subject\">Asunto</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(67);
                __builder2.AddAttribute(68, "id", "subject");
                __builder2.AddAttribute(69, "class", "form-control");
                __builder2.AddAttribute(70, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                                                                                          contacto.Asunto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contacto.Asunto = __value, contacto.Asunto))));
                __builder2.AddAttribute(72, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contacto.Asunto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n                                ");
                __Blazor.EMME_Acabados_.Pages.Paginas.Contactos.TypeInference.CreateValidationMessage_3(__builder2, 74, 75, 
#nullable restore
#line 55 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                                                        (() => contacto.Asunto)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n                        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "row form-group");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "col-md-12");
                __builder2.AddMarkupContent(81, "<label class=\"text-white\" for=\"message\">Mensaje</label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(82);
                __builder2.AddAttribute(83, "name", "message");
                __builder2.AddAttribute(84, "id", "message");
                __builder2.AddAttribute(85, "cols", "30");
                __builder2.AddAttribute(86, "rows", "7");
                __builder2.AddAttribute(87, "class", "form-control");
                __builder2.AddAttribute(88, "placeholder", "Dejanos tus preguntas y pedidos");
                __builder2.AddAttribute(89, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                                                                                                                                                                              contacto.Mensaje

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contacto.Mensaje = __value, contacto.Mensaje))));
                __builder2.AddAttribute(91, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contacto.Mensaje));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n                                ");
                __Blazor.EMME_Acabados_.Pages.Paginas.Contactos.TypeInference.CreateValidationMessage_4(__builder2, 93, 94, 
#nullable restore
#line 63 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                                                        (() => contacto.Mensaje)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n\r\n                        ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "row form-group");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "col-md-12");
                __builder2.OpenElement(100, "input");
                __builder2.AddAttribute(101, "type", "submit");
                __builder2.AddAttribute(102, "value", "Enviar Mensaje");
                __builder2.AddAttribute(103, "class", "btn btn-primary py-2 px-4 text-white color");
                __builder2.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
                                                                                                                                          EnvioEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.AddMarkupContent(106, @"<div class=""col-lg-3 ml-auto""><div class=""mb-3""><p class=""mb-0 font-weight-bold text-white"">Ubicados</p>
                    <p class=""mb-4"">Medellín - Colombia</p>

                    <p class=""mb-0 font-weight-bold text-white"">Telefono</p>
                    <p class=""mb-4"">+57 302 361 5100 <br> +57 301 310 0646</p>

                    <p class=""mb-0 font-weight-bold text-white"">Email</p>
                    <p class=""mb-0"">emme.acabadosarq@gmail.com</p></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Contactos.razor"
       

    bool Mostrar = false;
    Contacto contacto;
    string text;

    protected override async Task OnInitializedAsync()
    {
        contacto = new Contacto();
        Mostrar = true;
    }

    private void EnvioEmail()
    {
        if (contacto.Primero_Nombre != null && contacto.Segundo_Nombre != null && contacto.Email != null && contacto.Asunto != null && contacto.Mensaje != null)
        {
            try
            {
                SmtpMail ObjCorreo = new SmtpMail("TryIt");
                ObjCorreo.From = contacto.Email;
                ObjCorreo.Subject = contacto.Asunto;
                text = contacto.Primero_Nombre + " " + contacto.Segundo_Nombre + " Con el Email: " + contacto.Email + "\n" + contacto.Mensaje;
                ObjCorreo.TextBody = text;
                ObjCorreo.To = "";

                SmtpServer ObjServer = new SmtpServer("smpt.gmail.com");
                ObjServer.User = "";
                ObjServer.Password = "";
                ObjServer.Server = "smtp.gmail.com";
                ObjServer.Port = 587;
                ObjServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                EASendMail.SmtpClient ObjCliente = new EASendMail.SmtpClient();
                ObjCliente.SendMail(ObjServer, ObjCorreo);

                Console.WriteLine("Se envio correctamente");
                navegacion.NavigateTo("/");
            }
            catch(Exception ex)
            {
                navegacion.NavigateTo("/");
                Console.WriteLine(ex.Message);
            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navegacion { get; set; }
    }
}
namespace __Blazor.EMME_Acabados_.Pages.Paginas.Contactos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
