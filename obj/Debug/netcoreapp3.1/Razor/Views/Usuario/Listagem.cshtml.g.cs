#pragma checksum "C:\Users\Jhones\OneDrive\SENAC\UC07\Biblioteca\Views\Usuario\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8871bac843c6ae9b01621517f2ea3739917d08f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listagem), @"mvc.1.0.view", @"/Views/Usuario/Listagem.cshtml")]
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
#line 1 "C:\Users\Jhones\OneDrive\SENAC\UC07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jhones\OneDrive\SENAC\UC07\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8871bac843c6ae9b01621517f2ea3739917d08f2", @"/Views/Usuario/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jhones\OneDrive\SENAC\UC07\Biblioteca\Views\Usuario\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""row"">
    <div class=""col-md-12"">

        
        <table  class=""table""> 
            <thead>
                <tr><th>ID</th>
                <th>Usuario</th>
                <th>Login</th>
               
                
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "C:\Users\Jhones\OneDrive\SENAC\UC07\Biblioteca\Views\Usuario\Listagem.cshtml"
                 foreach(Usuario u in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\Jhones\OneDrive\SENAC\UC07\Biblioteca\Views\Usuario\Listagem.cshtml"
                   Write(u.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\Jhones\OneDrive\SENAC\UC07\Biblioteca\Views\Usuario\Listagem.cshtml"
                   Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Jhones\OneDrive\SENAC\UC07\Biblioteca\Views\Usuario\Listagem.cshtml"
                   Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    \r\n                   \r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 674, "\"", 705, 2);
            WriteAttributeValue("", 681, "/Usuario/Editar?ID=", 681, 19, true);
#nullable restore
#line 30 "C:\Users\Jhones\OneDrive\SENAC\UC07\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 700, u.ID, 700, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 750, "\"", 782, 2);
            WriteAttributeValue("", 757, "/Usuario/Excluir?ID=", 757, 20, true);
#nullable restore
#line 31 "C:\Users\Jhones\OneDrive\SENAC\UC07\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 777, u.ID, 777, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Jhones\OneDrive\SENAC\UC07\Biblioteca\Views\Usuario\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td><a href=\"/Usuario/Cadastro/\">Cadastrar um novo usuario</a></td>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591