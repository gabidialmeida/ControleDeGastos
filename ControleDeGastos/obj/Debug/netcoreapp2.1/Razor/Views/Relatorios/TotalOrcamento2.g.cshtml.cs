#pragma checksum "C:\Users\GABRIELA\Desktop\ControleDeGastos\ControleDeGastos\Views\Relatorios\TotalOrcamento2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd27a4e8be23d22c4df97a09b116c2b0d07f129f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Relatorios_TotalOrcamento2), @"mvc.1.0.view", @"/Views/Relatorios/TotalOrcamento2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Relatorios/TotalOrcamento2.cshtml", typeof(AspNetCore.Views_Relatorios_TotalOrcamento2))]
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
#line 1 "C:\Users\GABRIELA\Desktop\ControleDeGastos\ControleDeGastos\Views\_ViewImports.cshtml"
using ControleDeGastos;

#line default
#line hidden
#line 2 "C:\Users\GABRIELA\Desktop\ControleDeGastos\ControleDeGastos\Views\_ViewImports.cshtml"
using ControleDeGastos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd27a4e8be23d22c4df97a09b116c2b0d07f129f", @"/Views/Relatorios/TotalOrcamento2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a58a80135b0adb3d3efdc195df33e3b5150c18e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorios_TotalOrcamento2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ControleDeGastos.Models.Orcamento>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\GABRIELA\Desktop\ControleDeGastos\ControleDeGastos\Views\Relatorios\TotalOrcamento2.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "C:\Users\GABRIELA\Desktop\ControleDeGastos\ControleDeGastos\Views\Relatorios\TotalOrcamento2.cshtml"
  
    ViewBag.Meses = new SelectList(new object[]
{
new {Mes = "Janeiro", Value = "1"},
new {Mes = "Fevereiro", Value = "2"},
new {Mes = "Março", Value = "3"},
new {Mes = "Abril", Value = "4"},
new {Mes = "Maio", Value = "5"},
new {Mes = "Junho", Value = "6"},
new {Mes = "Julho", Value = "7"},
new {Mes = "Agosto", Value = "8"},
new {Mes = "Setembro", Value = "9"},
new {Mes = "Outubro", Value = "10"},
new {Mes = "Novembro", Value = "11"},
new {Mes = "Dezembro", Value = "12"}
}, "Value", "Mes");

#line default
#line hidden
            BeginContext(653, 58, true);
            WriteLiteral("<h2>Total Gasto no mês</h2>\r\n<hr />\r\n<div>\r\n\r\n    <!--<h4>");
            EndContext();
            BeginContext(712, 13, false);
#line 28 "C:\Users\GABRIELA\Desktop\ControleDeGastos\ControleDeGastos\Views\Relatorios\TotalOrcamento2.cshtml"
       Write(ViewBag.Meses);

#line default
#line hidden
            EndContext();
            BeginContext(725, 56, true);
            WriteLiteral("</h4><br /> -->  \r\n    <h4>Novembro</h4><br />\r\n    <h4>");
            EndContext();
            BeginContext(782, 13, false);
#line 30 "C:\Users\GABRIELA\Desktop\ControleDeGastos\ControleDeGastos\Views\Relatorios\TotalOrcamento2.cshtml"
   Write(ViewBag.Total);

#line default
#line hidden
            EndContext();
            BeginContext(795, 27, true);
            WriteLiteral("</h4><br />\r\n\r\n\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ControleDeGastos.Models.Orcamento> Html { get; private set; }
    }
}
#pragma warning restore 1591