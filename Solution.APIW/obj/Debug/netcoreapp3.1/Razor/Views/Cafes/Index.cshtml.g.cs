#pragma checksum "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6841ebd823f0c6a12d02bbd27345dde879d1171"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cafes_Index), @"mvc.1.0.view", @"/Views/Cafes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6841ebd823f0c6a12d02bbd27345dde879d1171", @"/Views/Cafes/Index.cshtml")]
    public class Views_Cafes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Solution.APIW.Models.Cafe>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Activo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdMarcaNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdProductorNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Activo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdMarcaNavigation.NombreMarca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdProductorNavigation.NombreProductor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1639, "\"", 1666, 1);
#nullable restore
#line 58 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
WriteAttributeValue("", 1654, item.IdCafe, 1654, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1719, "\"", 1746, 1);
#nullable restore
#line 59 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
WriteAttributeValue("", 1734, item.IdCafe, 1734, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1801, "\"", 1828, 1);
#nullable restore
#line 60 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
WriteAttributeValue("", 1816, item.IdCafe, 1816, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Cafes\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Solution.APIW.Models.Cafe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
