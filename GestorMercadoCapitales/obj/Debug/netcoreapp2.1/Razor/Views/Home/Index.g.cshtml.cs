#pragma checksum "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2646983e46b9888154736d3e42fe298e68a7d7eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\_ViewImports.cshtml"
using GestorMercadoCapitales;

#line default
#line hidden
#line 2 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\_ViewImports.cshtml"
using GestorMercadoCapitales.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2646983e46b9888154736d3e42fe298e68a7d7eb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ca82432683befafb8b0af20f6cbfbfd6add7c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CotizacionAccion>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Menu principal";

#line default
#line hidden
            BeginContext(81, 660, true);
            WriteLiteral(@"

<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Ticker</th>
            <th scope=""col"">Precio</th>
            <th scope=""col"">Var.%</th>
            <th scope=""col"">Precio A</th>
            <th scope=""col"">C. Compra</th>
            <th scope=""col"">P. Compra</th>
            <th scope=""col"">P. Venta</th>
            <th scope=""col"">C. Venta</th>
            <th scope=""col"">Min-Max</th>
            <th scope=""col"">Vol. Num.</th>
            <th scope=""col"">Monto</th>
            <th scope=""col"">Oper</th>
            <th scope=""col"">Hora</th>
        </tr>
    </thead>
    <tbody>

");
            EndContext();
#line 27 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
         try
        {
            

#line default
#line hidden
#line 29 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
             foreach (var datos in Model)
            {

#line default
#line hidden
            BeginContext(824, 58, true);
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\">");
            EndContext();
            BeginContext(883, 12, false);
#line 32 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                               Write(datos.ticker);

#line default
#line hidden
            EndContext();
            BeginContext(895, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(927, 12, false);
#line 33 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                   Write(datos.precio);

#line default
#line hidden
            EndContext();
            BeginContext(939, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(971, 19, false);
#line 34 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                   Write(datos.varPorcentual);

#line default
#line hidden
            EndContext();
            BeginContext(990, 33, true);
            WriteLiteral(" %</td>\r\n                    <td>");
            EndContext();
            BeginContext(1024, 13, false);
#line 35 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                   Write(datos.precioA);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1069, 13, false);
#line 36 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                   Write(datos.cCompra);

#line default
#line hidden
            EndContext();
            BeginContext(1082, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1114, 13, false);
#line 37 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                   Write(datos.pCompra);

#line default
#line hidden
            EndContext();
            BeginContext(1127, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1159, 12, false);
#line 38 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                   Write(datos.pVenta);

#line default
#line hidden
            EndContext();
            BeginContext(1171, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1203, 12, false);
#line 39 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                   Write(datos.cVenta);

#line default
#line hidden
            EndContext();
            BeginContext(1215, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1247, 9, false);
#line 40 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                   Write(datos.min);

#line default
#line hidden
            EndContext();
            BeginContext(1256, 20, true);
            WriteLiteral(" <input type=\"range\"");
            EndContext();
            BeginWriteAttribute("min", " min=\"", 1276, "\"", 1292, 1);
#line 40 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
WriteAttributeValue("", 1282, datos.min, 1282, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("max", " max=\"", 1293, "\"", 1309, 1);
#line 40 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
WriteAttributeValue("", 1299, datos.max, 1299, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1310, 11, true);
            WriteLiteral(" disabled> ");
            EndContext();
            BeginContext(1322, 9, false);
#line 40 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                                                                                              Write(datos.max);

#line default
#line hidden
            EndContext();
            BeginContext(1331, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1363, 12, false);
#line 41 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                   Write(datos.volNom);

#line default
#line hidden
            EndContext();
            BeginContext(1375, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1407, 12, false);
#line 42 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                   Write(datos.ajuste);

#line default
#line hidden
            EndContext();
            BeginContext(1419, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1451, 10, false);
#line 43 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                   Write(datos.oper);

#line default
#line hidden
            EndContext();
            BeginContext(1461, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1493, 10, false);
#line 44 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                   Write(datos.hora);

#line default
#line hidden
            EndContext();
            BeginContext(1503, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 46 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#line 46 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
             
        }
        catch { }

#line default
#line hidden
            BeginContext(1578, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CotizacionAccion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
