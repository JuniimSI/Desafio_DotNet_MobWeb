#pragma checksum "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39cdd8e99a4339e0cb0c3515bfa3d47e2ce028f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
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
#line 1 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\_ViewImports.cshtml"
using Desafio_dotNet_Mobweb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\_ViewImports.cshtml"
using Desafio_dotNet_Mobweb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39cdd8e99a4339e0cb0c3515bfa3d47e2ce028f6", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d52ecfcd74a50753f04886c5aae90016b7f030c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Desafio_dotNet_Mobweb.Models.Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Usuarios";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    Hello Usuarios\r\n</div>\r\n\r\n<div id=\"view-all\">\r\n    ");
#nullable restore
#line 13 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\Index.cshtml"
Write(await Html.PartialAsync("_ViewAll", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Desafio_dotNet_Mobweb.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
