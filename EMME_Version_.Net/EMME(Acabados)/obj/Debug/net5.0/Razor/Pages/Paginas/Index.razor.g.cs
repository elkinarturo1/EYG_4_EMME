#pragma checksum "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c535ec19989b96b736cacebf8f9477198958b4e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<EMME_Acabados_.Shared.NavMenu>(0);
            __builder.AddAttribute(1, "activadoIndex", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Index.razor"
                        Mostrar

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.AddMarkupContent(3, @"<div class=""container-fluid"" data-aos=""fade"" data-aos-delay=""500""><div class=""row""><div class=""col-lg-4""><div class=""image-wrap-2""><div class=""image-info""><h2 class=""mb-3"">Comercial</h2>
                    <a href=""/Galeria/Comercial"" class=""btn btn-outline-white py-2 px-4"">Ver más</a></div>
                <img src=""/phosen/images/img_1.jpg"" alt=""Image"" class=""img-fluid""></div></div>

        <div class=""col-lg-4""><div class=""image-wrap-2""><div class=""image-info""><h2 class=""mb-3"">Empresarial</h2>
                    <a href=""/Galeria/Empresarial"" class=""btn btn-outline-white py-2 px-4"">Ver más</a></div>
                <img src=""/phosen/images/img_2.jpg"" alt=""Image"" class=""img-fluid image-aco""></div></div>

        <div class=""col-lg-4""><div class=""image-wrap-2""><div class=""image-info""><h2 class=""mb-3"">Residencial</h2>
                    <a href=""/Galeria/Residencial"" class=""btn btn-outline-white py-2 px-4"">Ver más</a></div>
                <img src=""/phosen/images/img_1.jpg"" alt=""Image"" class=""img-fluid image-aco""></div></div></div>
    <div class=""row justify-content-center""><div class=""col-lg-4""><div class=""image-wrap-2""><div class=""image-info""><h2 class=""mb-3"">Obra blanca</h2>
                    <a href=""/Galeria/ObraBlanca"" class=""btn btn-outline-white py-2 px-4"">Ver más</a></div>
                <img src=""/phosen/images/img_2.jpg"" alt=""Image"" class=""img-fluid ""></div></div></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "D:\EMME(Acabados) 2021-07-26\EMME(Acabados)\EMME(Acabados)\Pages\Paginas\Index.razor"
          
        private bool Mostrar = false;

        protected override async Task OnInitializedAsync()
        {
            Mostrar = true;
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591