#pragma checksum "C:\Users\ASUS\Desktop\BookList\BookList.WebUI\Views\Shop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "221e529c1facf564c8e8821d1d60b22f1c7cbc94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Details), @"mvc.1.0.view", @"/Views/Shop/Details.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\BookList\BookList.WebUI\Views\_ViewImports.cshtml"
using BookList.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\BookList\BookList.WebUI\Views\_ViewImports.cshtml"
using BookList.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"221e529c1facf564c8e8821d1d60b22f1c7cbc94", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c940b6e7e19d93f1b36d14ef87ed73c733bb9d09", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\BookList\BookList.WebUI\Views\Shop\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section>
    <div class=""container"">
        <div class=""row"">


            <div class=""col-sm-9 padding-right"">
                <div class=""product-details"">
                    <!--product-details-->
                    <div class=""col-sm-5"">
                        <div class=""view-product"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 413, "\"", 447, 2);
            WriteAttributeValue("", 419, "/img/", 419, 5, true);
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\BookList\BookList.WebUI\Views\Shop\Details.cshtml"
WriteAttributeValue("", 424, Model.Product.ImageUrl, 424, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 448, "\"", 473, 1);
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\BookList\BookList.WebUI\Views\Shop\Details.cshtml"
WriteAttributeValue("", 454, Model.Product.Name, 454, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid""/>

                        </div>

                    </div>
                    <div class=""col-sm-7"">
                        <div class=""product-information"">
                            <!--/product-information-->
                            <img");
            BeginWriteAttribute("src", " src=\"", 752, "\"", 758, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"newarrival\"");
            BeginWriteAttribute("alt", " alt=\"", 778, "\"", 784, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <h2>");
#nullable restore
#line 25 "C:\Users\ASUS\Desktop\BookList\BookList.WebUI\Views\Shop\Details.cshtml"
                           Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <hr/>\r\n");
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\BookList\BookList.WebUI\Views\Shop\Details.cshtml"
                         foreach (var category in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"#\" class=\"btn btn-link p-0 mb-3\">");
#nullable restore
#line 29 "C:\Users\ASUS\Desktop\BookList\BookList.WebUI\Views\Shop\Details.cshtml"
                                                                 Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 30 "C:\Users\ASUS\Desktop\BookList\BookList.WebUI\Views\Shop\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <span>\r\n                                <span>");
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\BookList\BookList.WebUI\Views\Shop\Details.cshtml"
                                 Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

                                <button type=""button"" class=""btn btn-fefault cart"">
                                    <i class=""fa fa-shopping-cart""></i>
                                    Sepete Ekle
                                </button>
                            </span>
                            <p><b>Yazar:</b> Yılmaz Özdil </p>
                            <p><b>Çevirmen:</b> - </p>
                            <p><b>Yayınevi:</b> Kırmızı Kedi </p>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1707, "\"", 1714, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"images/product-details/share.png\" class=\"share img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 1788, "\"", 1794, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                        </div><!--/product-information-->
                    </div>
                </div><!--/product-details-->

                <div class=""category-tab shop-details-tab"">
                    <!--category-tab-->
                    <div class=""col-sm-12"">
                        <ul class=""nav nav-tabs"">
                            <li class=""active""><a href=""#details"" data-toggle=""tab"">Detay</a></li>

                            <li><a href=""#reviews"" data-toggle=""tab"">Yorumlar</a></li>
                        </ul>
                    </div>
                    <div class=""tab-content"">
                        <div class=""tab-pane fade active in"" id=""details"">
                            <div class=""col-sm-3"">
                                <p style=""width: 650px"">
                                   ");
#nullable restore
#line 61 "C:\Users\ASUS\Desktop\BookList\BookList.WebUI\Views\Shop\Details.cshtml"
                              Write(Html.Raw(Model.Product.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                        </div>
                        <div class=tab-pane fade"" id=""reviews"">
                            <div class=""col-sm-12"">
                                <ul>
                                </ul>

                                <p><b>Yorumunuzu Yazın:</b></p>

                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "221e529c1facf564c8e8821d1d60b22f1c7cbc949362", async() => {
                WriteLiteral("\r\n\r\n                                    <textarea");
                BeginWriteAttribute("name", " name=\"", 3161, "\"", 3168, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n\r\n                                    <button type=\"button\" class=\"btn btn-default pull-right\">\r\n                                        Yorum Yap\r\n                                    </button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div><!--/category-tab-->\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
