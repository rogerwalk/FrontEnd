#pragma checksum "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Marcas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7854e85f80ac23886089ba87577249f5f6f68475"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Marcas_Create), @"mvc.1.0.view", @"/Views/Marcas/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7854e85f80ac23886089ba87577249f5f6f68475", @"/Views/Marcas/Create.cshtml")]
    public class Views_Marcas_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Solution.APIW.Models.Marcas>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Marcas\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Marcas</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""NombreMarca"" class=""control-label""></label>
                <input asp-for=""NombreMarca"" class=""form-control"" />
                <span asp-validation-for=""NombreMarca"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Activo"" class=""control-label""></label>
                <input asp-for=""Activo"" class=""form-control"" />
                <span asp-validation-for=""Activo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\roger\OneDrive\Escritorio\Progra 5\Proyecto\Solution_BackEnd\Solution.APIW\Views\Marcas\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Solution.APIW.Models.Marcas> Html { get; private set; }
    }
}
#pragma warning restore 1591
