#pragma checksum "C:\Users\Toan\Documents\SrcCode\aspCore.WatchShop\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ff96635c960532eb14e16467ed633264a3d5b96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\Toan\Documents\SrcCode\aspCore.WatchShop\Views\_ViewImports.cshtml"
using aspCore.WatchShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Toan\Documents\SrcCode\aspCore.WatchShop\Views\_ViewImports.cshtml"
using aspCore.WatchShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ff96635c960532eb14e16467ed633264a3d5b96", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aacb5a46eb39175e2ddb0d3270c53a9dbed94f0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/product.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("vt-photo-show"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/product/img_watch_1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Toan\Documents\SrcCode\aspCore.WatchShop\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ff96635c960532eb14e16467ed633264a3d5b965472", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container-fluid bg-dark text-center"">
    <h3 class=""m-0 py-2 text-white"">Giỏ hàng</h3>
</div>
<div>
    <!--***** Breadcrumb *****-->
    <nav class=""container"">
        <ol class=""vt-breadcrumb"">
            <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 424, "\"", 431, 0);
            EndWriteAttribute();
            WriteLiteral(@">Home</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Library</li>
        </ol>
    </nav>
    <!--***** Shopping bag *****-->
    <div class=""container"">
        <!--***** Header Table *****-->
        <div class=""row vt-header-table"">
            <div class=""col-md-6 col-4 h5"">Sản phẩm</div >
            <div class=""col-md-2 col-2 text-center h5"">SL</div>
            <div class=""col-md-2 col-4 text-center h5"">Thành tiền</div>
            <div class=""col-md-2 col-2 text-center h5""></div>
        </div>
        <hr class=""pb-3"">
         <!--***** Body Table *****-->
        <div class=""row align-items-center pb-3"">
            <div class=""col-md-6 col-4"">
                <a href=""#"">
                    <div class=""row align-items-center"">
                        <div class=""col-md-4 col-xs-12"">
                            <div class=""vt-img"" style=""width:100px"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3ff96635c960532eb14e16467ed633264a3d5b968106", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-8 col-xs-12 text-left""s>
                            <p class=""mb-1"">Daniel Wellington DW00100164</p>
                            <p class=""mb-1"">Giá: <span class=""vt-price"">899.000</span><sup>đ</sup> </p>
                        </div>
                    </div>    
                </a>
            </div>
            <div class=""col-md-2 col-2 text-center"">
                        <div class=""row"">
                            <div class=""col-md-4 col-xs-12"">
                                <button type=""button"" class=""btn btn-dark fa fa-angle-up""></button>
                            </div>
                            <div class=""col-md-4 col-xs-12 "">
                                1
                            </div>
                            <div class=""col-md-4 col-xs-12 "">
                                <button type=""button"" class=""btn btn-dark fa fa-angle-down""></button>
");
            WriteLiteral(@"                            </div>
                        </div>
            </div>
            <div class=""col-md-2 col-4 text-center m-0"">
                <p>899.000 <sup>đ</sup></p>
            </div>
            <div class=""col-md-2 col-2 text-center"">
                <button type=""button"" class=""btn btn-danger fa fa-trash-o"" aria-hidden=""true""></button>    
            </div>
        </div>
        <div class=""row align-items-center pb-3"">
            <div class=""col-md-6 col-4"">
                <a href=""#"">
                    <div class=""row align-items-center"">
                        <div class=""col-md-4 col-xs-12"">
                            <div class=""vt-img"" style=""width:100px"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3ff96635c960532eb14e16467ed633264a3d5b9611157", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-8 col-xs-12 text-left""s>
                            <p class=""mb-1"">Daniel Wellington DW00100164</p>
                            <p class=""mb-1"">Giá: <span class=""vt-price"">899.000</span><sup>đ</sup> </p>
                        </div>
                    </div>    
                </a>
            </div>
            <div class=""col-md-2 col-2 text-center"">
                        <div class=""row"">
                            <div class=""col-md-4 col-xs-12"">
                                <button type=""button"" class=""btn btn-dark fa fa-angle-up""></button>
                            </div>
                            <div class=""col-md-4 col-xs-12 "">
                                1
                            </div>
                            <div class=""col-md-4 col-xs-12 "">
                                <button type=""button"" class=""btn btn-dark fa fa-angle-down""></button>
");
            WriteLiteral(@"                            </div>
                        </div>
            </div>
            <div class=""col-md-2 col-4 text-center m-0"">
                <p>899.000 <sup>đ</sup></p>
            </div>
            <div class=""col-md-2 col-2 text-center"">
                <button type=""button"" class=""btn btn-danger fa fa-trash-o"" aria-hidden=""true""></button>    
            </div>
        </div>
    </div>
    <hr class=""pb-3"">
    <!--***** Recipient *****-->
    <div class=""container"">
        <div class=""row pb-5"">
            <div class=""col-md-6 co-12 order-sm-2"">
                <h4 class=""vt-title"">Tổng cộng</h4>
                <div class=""row"">
                    <div class=""col-6"">
                        <p>Tông Đơn hàng</p>
                        <p>Giảm giá theo bill</p>
                        <p>Phí vận chuyển</p>
                        <p>Số tiền thanh toán</p>
                    </div>
                     <div class=""col-6 text-right"">
                        <p");
            WriteLiteral(@">899.0000 đ</p>
                        <p>-10%</p>
                        <p>9.0000 đ</p>
                        <p>899.0000 đ</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 co-12"">
                <h4 class=""vt-title"">Thông tin giao hàng</h4>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff96635c960532eb14e16467ed633264a3d5b9614851", async() => {
                WriteLiteral(@"
                     <div class=""form-group"">
                        <input type=""text"" class=""form-control"" id=""phone"" placeholder=""Số điện thoại""/>
                    </div>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" id=""name"" placeholder=""Họ tên""/>
                    </div>
                    <div class=""form-group"">
                        <textarea class=""form-control"" id=""address"" rows=""3"" placeholder=""Địa chỉ giao hàng""></textarea>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <button class=\"btn btn-dark w-100\" type=\"button\" >Đặt hàng</button>\r\n    </div>\r\n</div>\r\n");
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