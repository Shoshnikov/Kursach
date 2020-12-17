#pragma checksum "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2c31f63a941b0feebd1b86aa257602f5a7f295c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\Kursach\Kurs\Views\_ViewImports.cshtml"
using Kurs.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\_ViewImports.cshtml"
using Kurs.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2c31f63a941b0feebd1b86aa257602f5a7f295c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"801384f6bff152c8db9e48f3bf9262239cb88dc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<hr />
<section class=""py-5 text-center container"">
    <div class=""row py-lg-5"">
        <div class=""col-lg-6 col-md-8 mx-auto"">
            <h1 class=""fw-light"">Немного о самом Blender</h1>
            <p class=""lead text-muted"">
                Blender — профессиональное cвободное и открытое программное обеспечение для создания трёхмерной компьютерной графики,
                включающее в себя средства моделирования, скульптинга, анимации, симуляции, рендеринга,
                постобработки и монтажа видео со звуком, компоновки с помощью «узлов» (Node Compositing),
                а также создания 2D-анимаций. В настоящее время пользуется большой популярностью среди бесплатных 3D-редакторов
                в связи с его быстрым стабильным развитием и технической поддержкой.
            </p>
        </div>
    </div>
</section>
<hr />

<div align=""center""><h1>Последние статьи</h1></div>


<div class=""row mt-5 mb-2"">
    <a class=""btn btn-danger"" href=""/Home/MasterThemes?levelID=3"">");
            WriteLiteral(@"Мастер</a>
    <a class=""btn btn-danger"" href=""/Home/MasterThemes?levelID=2"">Хочу убивать еврейских детей</a>
    <a class=""btn btn-danger"" href=""/Home/MasterThemes?levelID=1"">Пидорасина блядская этот волков</a>
    <a class=""btn btn-danger"" href=""/Home/MasterThemes?levelID=4"">Бляди ебучие бляди в рот их ебал чтоб им пусто было</a>

");
#nullable restore
#line 29 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Home\Index.cshtml"
      
        foreach (Theme theme in Model.themes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 1508, "\"", 1524, 1);
#nullable restore
#line 33 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Home\Index.cshtml"
WriteAttributeValue("", 1514, theme.img, 1514, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1525, "\"", 1542, 1);
#nullable restore
#line 33 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Home\Index.cshtml"
WriteAttributeValue("", 1531, theme.name, 1531, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:650px; height:400px;\" />\r\n                <div class=\"col-lg-4__text\">\r\n                    <h5 class=\"text--card\" >");
#nullable restore
#line 35 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Home\Index.cshtml"
                                       Write(theme.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p  >");
#nullable restore
#line 36 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Home\Index.cshtml"
                    Write(theme.shortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p  class=\"text--italic\" >");
#nullable restore
#line 37 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Home\Index.cshtml"
                                         Write(theme.level.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1863, "\"", 1895, 3);
            WriteAttributeValue("", 1870, "Theme/Index?id=", 1870, 15, true);
#nullable restore
#line 38 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Home\Index.cshtml"
WriteAttributeValue("", 1885, theme.id, 1885, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1894, "", 1895, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Читать</a></p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 41 "C:\Users\ivans\source\repos\Kurs\Kurs\Views\Home\Index.cshtml"
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
