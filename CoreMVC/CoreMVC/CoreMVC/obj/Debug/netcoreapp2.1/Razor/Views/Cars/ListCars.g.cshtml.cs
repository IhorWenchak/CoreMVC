#pragma checksum "E:\CoreMVC\CoreMVC\CoreMVC\CoreMVC\Views\Cars\ListCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0add680d13d6125ce1419a027d0ca18c4eb86b5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_ListCars), @"mvc.1.0.view", @"/Views/Cars/ListCars.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/ListCars.cshtml", typeof(AspNetCore.Views_Cars_ListCars))]
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
#line 1 "E:\CoreMVC\CoreMVC\CoreMVC\CoreMVC\Views\_ViewImports.cshtml"
using CoreMVC.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0add680d13d6125ce1419a027d0ca18c4eb86b5f", @"/Views/Cars/ListCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b02b914de6084755344427be51edc1be4c432cdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_ListCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\CoreMVC\CoreMVC\CoreMVC\CoreMVC\Views\Cars\ListCars.cshtml"
  
    foreach (var car in Model.AllCars)
    {

#line default
#line hidden
            BeginContext(53, 152, true);
            WriteLiteral("        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm\">\r\n                    <h3>\r\n                        ");
            EndContext();
            BeginContext(206, 8, false);
#line 9 "E:\CoreMVC\CoreMVC\CoreMVC\CoreMVC\Views\Cars\ListCars.cshtml"
                   Write(car.Name);

#line default
#line hidden
            EndContext();
            BeginContext(214, 114, true);
            WriteLiteral("\r\n                    </h3>\r\n                </div>               \r\n                </div>  \r\n            </div>\r\n");
            EndContext();
            BeginContext(330, 118, true);
            WriteLiteral("<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm\">\r\n            <img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 448, "\"", 462, 1);
#line 19 "E:\CoreMVC\CoreMVC\CoreMVC\CoreMVC\Views\Cars\ListCars.cshtml"
WriteAttributeValue("", 454, car.Img, 454, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 463, "\"", 478, 1);
#line 19 "E:\CoreMVC\CoreMVC\CoreMVC\CoreMVC\Views\Cars\ListCars.cshtml"
WriteAttributeValue("", 469, car.Name, 469, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(479, 117, true);
            WriteLiteral(">\r\n        </div>\r\n\r\n        <div class=\"col-sm\">\r\n            <p class=\"text-dark, display-2\" >\r\n              <p>  ");
            EndContext();
            BeginContext(597, 20, false);
#line 24 "E:\CoreMVC\CoreMVC\CoreMVC\CoreMVC\Views\Cars\ListCars.cshtml"
              Write(car.Price.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(617, 29, true);
            WriteLiteral(" $ </p>\r\n\r\n              <p> ");
            EndContext();
            BeginContext(647, 13, false);
#line 26 "E:\CoreMVC\CoreMVC\CoreMVC\CoreMVC\Views\Cars\ListCars.cshtml"
             Write(car.ShortDesc);

#line default
#line hidden
            EndContext();
            BeginContext(660, 28, true);
            WriteLiteral("  </p>\r\n\r\n              <p> ");
            EndContext();
            BeginContext(689, 12, false);
#line 28 "E:\CoreMVC\CoreMVC\CoreMVC\CoreMVC\Views\Cars\ListCars.cshtml"
             Write(car.LongDesc);

#line default
#line hidden
            EndContext();
            BeginContext(701, 180, true);
            WriteLiteral("  </p>\r\n            </p>\r\n        </div>\r\n\r\n        <div class=\"col-sm\">\r\n            <p class=\"text-dark\">\r\n             \r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
#line 40 "E:\CoreMVC\CoreMVC\CoreMVC\CoreMVC\Views\Cars\ListCars.cshtml"
        }
        

#line default
#line hidden
            BeginContext(903, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
