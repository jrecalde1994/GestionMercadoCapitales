#pragma checksum "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f114831e26db1f6d2d62a0eac20214b0fcecd731"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f114831e26db1f6d2d62a0eac20214b0fcecd731", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ca82432683befafb8b0af20f6cbfbfd6add7c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CotizacionAccion>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Menu principal";

#line default
#line hidden
            BeginContext(75, 700, true);
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
        <tr>
            <td scope=""row"">");
            EndContext();
            BeginContext(776, 38, false);
#line 27 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(model => model.Ticker));

#line default
#line hidden
            EndContext();
            BeginContext(814, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(838, 38, false);
#line 28 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(876, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(900, 45, false);
#line 29 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(model => model.VarPorcentual));

#line default
#line hidden
            EndContext();
            BeginContext(945, 24, true);
            WriteLiteral("%</td>\r\n            <td>");
            EndContext();
            BeginContext(970, 39, false);
#line 30 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(model => model.PrecioA));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1033, 39, false);
#line 31 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(model => model.CCompra));

#line default
#line hidden
            EndContext();
            BeginContext(1072, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1096, 39, false);
#line 32 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(model => model.PCompra));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1159, 38, false);
#line 33 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(model => model.PVenta));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1221, 38, false);
#line 34 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(model => model.CVenta));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1283, 35, false);
#line 35 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(model => model.Min));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 20, true);
            WriteLiteral(" <input type=\"range\"");
            EndContext();
            BeginWriteAttribute("min", " min=\"", 1338, "\"", 1380, 1);
#line 35 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
WriteAttributeValue("", 1344, Html.DisplayFor(model => model.Min), 1344, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("max", " max=\"", 1381, "\"", 1423, 1);
#line 35 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
WriteAttributeValue("", 1387, Html.DisplayFor(model => model.Max), 1387, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1424, 11, true);
            WriteLiteral(" disabled> ");
            EndContext();
            BeginContext(1436, 35, false);
#line 35 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
                                                                                                                                                                    Write(Html.DisplayFor(model => model.Max));

#line default
#line hidden
            EndContext();
            BeginContext(1471, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1495, 38, false);
#line 36 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(model => model.VolNom));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 24, true);
            WriteLiteral("</td>\r\n            <td>$");
            EndContext();
            BeginContext(1558, 37, false);
#line 37 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
            Write(Html.DisplayFor(model => model.Monto));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 24, true);
            WriteLiteral("K</td>\r\n            <td>");
            EndContext();
            BeginContext(1620, 36, false);
#line 38 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(model => model.Oper));

#line default
#line hidden
            EndContext();
            BeginContext(1656, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1680, 36, false);
#line 39 "C:\proyectos\GestorMercadoCapitales\GestorMercadoCapitales\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(model => model.Hora));

#line default
#line hidden
            EndContext();
            BeginContext(1716, 46, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CotizacionAccion> Html { get; private set; }
    }
}
#pragma warning restore 1591
