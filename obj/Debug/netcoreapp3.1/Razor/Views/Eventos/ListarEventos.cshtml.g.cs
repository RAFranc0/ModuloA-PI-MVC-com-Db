#pragma checksum "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\Eventos\ListarEventos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06eb1e9d7c01a7b5cfe20450f985babebea0ceb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eventos_ListarEventos), @"mvc.1.0.view", @"/Views/Eventos/ListarEventos.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\_ViewImports.cshtml"
using Atv4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\_ViewImports.cshtml"
using Atv4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06eb1e9d7c01a7b5cfe20450f985babebea0ceb8", @"/Views/Eventos/ListarEventos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a2b6022633b2c010a7d60347390f99c9a210b09", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Eventos_ListarEventos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventoViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\Eventos\ListarEventos.cshtml"
  
    ViewData["Title"] = "Lista de Pacotes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 7 "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\Eventos\ListarEventos.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Titulo</th>
            <th>Descricao</th>
            <th>Data</th>
            <th>Horario</th>
            <th>Local</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\Eventos\ListarEventos.cshtml"
         foreach (var evento in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 24 "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\Eventos\ListarEventos.cshtml"
               Write(evento.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\Eventos\ListarEventos.cshtml"
               Write(evento.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\Eventos\ListarEventos.cshtml"
               Write(evento.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 27 "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\Eventos\ListarEventos.cshtml"
               Write(evento.Data.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\Eventos\ListarEventos.cshtml"
               Write(evento.Horario.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 29 "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\Eventos\ListarEventos.cshtml"
               Write(evento.Local);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 31 "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\Eventos\ListarEventos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n<button class=\"btn btn-secondary\" id=\"btnVoltar\">Voltar</button>\n\n<script>\n    document.getElementById(\"btnVoltar\").addEventListener(\"click\", function(){\n        window.location.href=\'");
#nullable restore
#line 39 "C:\Users\Raul\Documents\SENAC\Módulo A - Senac\Projeto Integrador\Atv4\Views\Eventos\ListarEventos.cshtml"
                         Write(Url.Action("PainelUsuario", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\n    })\n</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventoViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
