#pragma checksum "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50a38ad7be7dd8ebaee41a8ef2db5fc7197006dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_DisplayProducts), @"mvc.1.0.view", @"/Views/Product/DisplayProducts.cshtml")]
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
#nullable restore
#line 1 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50a38ad7be7dd8ebaee41a8ef2db5fc7197006dc", @"/Views/Product/DisplayProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e5b95bdb520a4101d64f735ad34f10dba324a4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_DisplayProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EcommerceMVC.Models.DTO.Product.ProductsReponseModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section style=\"background-color: #eee;\">\r\n");
#nullable restore
#line 4 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
       if(TempData["Message"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 6 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
          Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n  <div class=\"container py-5\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
         foreach (var item in Model.Data)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-12 col-lg-4 mb-4 mb-lg-0"">
                <div class=""card"">
                    <div class=""d-flex justify-content-between p-3"">
                        <p class=""lead mb-0"">Today's Offer</p>
                        <div class=""bg-info rounded-circle d-flex align-items-center justify-content-center shadow-1-strong"" style=""width: 35px; height: 35px;"">
                            <p class=""text-white mb-0 small""></p>
                        </div>
                    </div>
                    <img");
            BeginWriteAttribute("src", " src=\"", 982, "\"", 1029, 2);
            WriteAttributeValue("", 988, "https://localhost:5001/Images/", 988, 30, true);
#nullable restore
#line 25 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
WriteAttributeValue("", 1018, item.Image, 1018, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"150px\" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 1066, "\"", 1089, 1);
#nullable restore
#line 25 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
WriteAttributeValue("", 1072, item.ProductName, 1072, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"card-body\">\r\n                        <div class=\"d-flex justify-content-between\">\r\n                            <p class=\"small\"><a href=\"#!\" class=\"text-muted\">");
#nullable restore
#line 28 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
                                                                        Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                            <p class=\"small text-danger\">");
#nullable restore
#line 29 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
                                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<s></s></p>\r\n                        </div>\r\n\r\n                        <div class=\"d-flex justify-content-between mb-3\">\r\n                            <h5 class=\"mb-0\">");
#nullable restore
#line 33 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
                                        Write(item.Quality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <h5 class=\"text-dark mb-0\">");
#nullable restore
#line 34 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
                                                  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n\r\n                        <div class=\"d-flex justify-content-between mb-2\">\r\n                            <p class=\"text-muted mb-0\">Available: <span class=\"fw-bold\">");
#nullable restore
#line 38 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
                                                                                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                            <div class=""ms-auto text-warning"">
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                            </div>
                             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50a38ad7be7dd8ebaee41a8ef2db5fc7197006dc9924", async() => {
                WriteLiteral("Add to cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 51 "C:\Users\musta\OneDrive\Desktop\trans\Docker Tutorial\CLH Project\EcommerceMVC\Views\Product\DisplayProducts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n  </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EcommerceMVC.Models.DTO.Product.ProductsReponseModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591