#pragma checksum "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Themes\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ac24543a524bc3788954e1354f86971431fd41e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Themes_List), @"mvc.1.0.view", @"/Views/Themes/List.cshtml")]
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
#line 1 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\_ViewImports.cshtml"
using Kurs.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ac24543a524bc3788954e1354f86971431fd41e", @"/Views/Themes/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41ddb86636f022a439f79acfd811498f530b2281", @"/Views/_ViewImports.cshtml")]
    public class Views_Themes_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div align=\"center\"><h1>Последние статьи</h1></div>\r\n\r\n\r\n<div  class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 6 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Themes\List.cshtml"
      
        foreach (var theme in Model.themes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 231, "\"", 247, 1);
#nullable restore
#line 10 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Themes\List.cshtml"
WriteAttributeValue("", 237, theme.img, 237, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 248, "\"", 265, 1);
#nullable restore
#line 10 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Themes\List.cshtml"
WriteAttributeValue("", 254, theme.name, 254, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:650px; height:400px;\"/>\r\n                <h5>");
#nullable restore
#line 11 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Themes\List.cshtml"
               Write(theme.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p>");
#nullable restore
#line 12 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Themes\List.cshtml"
              Write(theme.shortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 13 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Themes\List.cshtml"
              Write(theme.level);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><a class=\"btn btn-warning\" href=\"#\">Читать</a></p>\r\n            </div>\r\n");
#nullable restore
#line 16 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Themes\List.cshtml"
        }
        
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
