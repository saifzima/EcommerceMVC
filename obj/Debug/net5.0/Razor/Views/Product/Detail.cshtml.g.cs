#pragma checksum "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f86ff2220dd8266339931bdbdfdeda38cd573e6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\_ViewImports.cshtml"
using EcommerceMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\_ViewImports.cshtml"
using EcommerceMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f86ff2220dd8266339931bdbdfdeda38cd573e6b", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e5b95bdb520a4101d64f735ad34f10dba324a4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EcommerceMVC.Models.DTO.Product.ProductResponseModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section style=""background-color: #e3d6d6;"">
  <div class=""container py-5"">
    <div class=""row justify-content-center"">
      <div class=""col-md-8 col-lg-6 col-xl-4"">
        <div class=""card text-black"">
          <i class=""fab fa-apple fa-lg pt-3 pb-1 px-3""></i>
          <img");
            BeginWriteAttribute("src", " src=\"", 357, "\"", 410, 2);
            WriteAttributeValue("", 363, "https://localhost:5001/Images/", 363, 30, true);
#nullable restore
#line 10 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\Detail.cshtml"
WriteAttributeValue("", 393, Model.Data.Image, 393, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 411, "\"", 438, 3);
#nullable restore
#line 10 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\Detail.cshtml"
WriteAttributeValue("", 417, Model, 417, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 423, ".", 423, 1, true);
            WriteAttributeValue(" ", 424, "AlternateText", 425, 14, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n          <div class=\"card-body\">\r\n            <div class=\"text-center\">\r\n              <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\Detail.cshtml"
                                Write(Model.Data.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n            <div>\r\n              <div class=\"d-flex justify-content-between\">\r\n                <span>Quantity</span><span>");
#nullable restore
#line 17 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\Detail.cshtml"
                                      Write(Model.Data.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n              </div>\r\n              <div class=\"d-flex justify-content-between\">\r\n                <span>Price</span><span>#");
#nullable restore
#line 20 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\Detail.cshtml"
                                    Write(Model.Data.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n              </div>\r\n              <div class=\"d-flex justify-content-between\">\r\n                <span>Quality</span><span>");
#nullable restore
#line 23 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\Detail.cshtml"
                                     Write(Model.Data.Quality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n              </div>\r\n            </div>\r\n\r\n            <div class=\"d-flex justify-content-between total font-weight-bold mt-4\">\r\n              <span>Total</span><span>#");
#nullable restore
#line 28 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\Detail.cshtml"
                                  Write(Model.Data.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n           ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EcommerceMVC.Models.DTO.Product.ProductResponseModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
