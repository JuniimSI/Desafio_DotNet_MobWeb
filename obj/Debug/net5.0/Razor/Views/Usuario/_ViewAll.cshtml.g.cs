#pragma checksum "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "194e450a2a56b4b3e3d51c2ab284decb72f72ce4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario__ViewAll), @"mvc.1.0.view", @"/Views/Usuario/_ViewAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"194e450a2a56b4b3e3d51c2ab284decb72f72ce4", @"/Views/Usuario/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d52ecfcd74a50753f04886c5aae90016b7f030c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Desafio_dotNet_Mobweb.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Apelido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 538, "\"", 640, 4);
            WriteAttributeValue("", 548, "showInPopup(\'", 548, 13, true);
#nullable restore
#line 19 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml"
WriteAttributeValue("", 561, Url.Action("AddOrEdit","Usuario",null,Context.Request.Scheme), 561, 62, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 623, "\',\'Novo", 623, 7, true);
            WriteAttributeValue(" ", 630, "Usu??rio\')", 631, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\">Criar novo</a>\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml"
         foreach (var usuario in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelIem => usuario.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelIem => usuario.Apelido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelIem => usuario.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelIem => usuario.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1314, "\"", 1442, 5);
            WriteAttributeValue("", 1324, "showInPopup(\'", 1324, 13, true);
#nullable restore
#line 41 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml"
WriteAttributeValue("", 1337, Url.Action("AddOrEdit","Usuario", new { id = usuario.Id }, Context.Request.Scheme), 1337, 83, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1420, "\',\'Edi????o", 1420, 9, true);
            WriteAttributeValue(" ", 1429, "do", 1430, 3, true);
            WriteAttributeValue(" ", 1432, "Usu??rio\')", 1433, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\">Editar</a> \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "194e450a2a56b4b3e3d51c2ab284decb72f72ce49036", async() => {
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml"
                                                WriteLiteral(usuario.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    \r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "G:\Workspace STS\dotnet\Desafio_dotNet\Desafio_dotNet_Mobweb\Views\Usuario\_ViewAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
