// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591