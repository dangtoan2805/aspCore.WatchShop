#pragma checksum "C:\Users\Toan\Documents\SrcCode\aspCore.WatchShop\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37c6309b0bbcf60983734461c7b0c068fcb5b3ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Toan\Documents\SrcCode\aspCore.WatchShop\Areas\Admin\Views\_ViewImports.cshtml"
using aspCore.WatchShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Toan\Documents\SrcCode\aspCore.WatchShop\Areas\Admin\Views\_ViewImports.cshtml"
using aspCore.WatchShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37c6309b0bbcf60983734461c7b0c068fcb5b3ec", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aacb5a46eb39175e2ddb0d3270c53a9dbed94f0e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Toan\Documents\SrcCode\aspCore.WatchShop\Areas\Admin\Views\Home\Index.cshtml"
   
   ViewBag.Title="Dasd";
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <div class=""content-wrapper"">
    <div class=""content"">
      <!-- Top Statistics -->
      <div class=""row"">
        <div class=""col-md-6 col-lg-6 col-xl-3"">
          <div class=""media widget-media p-4 bg-white border"">
            <div class=""icon rounded-circle mr-4 bg-primary"">
              <i class=""mdi mdi-account-outline text-white ""></i>
            </div>
            <div class=""media-body align-self-center"">
              <h4 class=""text-primary mb-2"">5300</h4>
              <p>New Users</p>
            </div>
          </div>
        </div>
        <div class=""col-md-6 col-lg-6 col-xl-3"">
          <div class=""media widget-media p-4 bg-white border"">
            <div class=""icon rounded-circle bg-warning mr-4"">
              <i class=""mdi mdi-cart-outline text-white ""></i>
            </div>
            <div class=""media-body align-self-center"">
              <h4 class=""text-primary mb-2"">1953</h4>
              <p>Order Placed</p>
            </div>
          </div>
   ");
            WriteLiteral(@"     </div>
        <div class=""col-md-6 col-lg-6 col-xl-3"">
          <div class=""media widget-media p-4 bg-white border"">
            <div class=""icon rounded-circle mr-4 bg-danger"">
              <i class=""mdi mdi-cart-outline text-white ""></i>
            </div>
            <div class=""media-body align-self-center"">
              <h4 class=""text-primary mb-2"">1450</h4>
              <p>Total Sales</p>
            </div>
          </div>
        </div>
        <div class=""col-md-6 col-lg-6 col-xl-3"">
          <div class=""media widget-media p-4 bg-white border"">
            <div class=""icon bg-success rounded-circle mr-4"">
              <i class=""mdi mdi-diamond text-white ""></i>
            </div>
            <div class=""media-body align-self-center"">
              <h4 class=""text-primary mb-2"">9503</h4>
              <p>Monthly Revenue</p>
            </div>
          </div>
        </div>
      </div>
      <div class=""row"">
        <div class=""col-xl-8 col-md-12"">
          <!");
            WriteLiteral(@"-- Sales Graph -->
          <div class=""card card-default"" data-scroll-height=""675"">
            <div class=""card-header"">
              <h2>Sales Of The Year</h2>
            </div>
            <div class=""card-body"">
              <canvas id = ""linechart"" class=""chartjs""></canvas>
            </div>
            <div class=""card-footer d-flex flex-wrap bg-white p-0"">
              <div class=""col-6 px-0"">
                <div class=""text-center p-4"">
                  <h4>$6,308</h4>
                  <p class=""mt-2"">Total orders of this year</p>
                </div>
              </div>
              <div class=""col-6 px-0"">
                <div class=""text-center p-4 border-left"">
                  <h4>$70,506</h4>
                  <p class=""mt-2"">Total revenue of this year</p>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class=""col-xl-4 col-md-12"">
          <!-- Doughnut Chart -->
          <div class=""card card-");
            WriteLiteral(@"table-border-none"" style=""height: 675px;"">
            <div class=""card-header justify-content-between"">
              <h2>Sold by Units</h2>
            </div>
            <div class=""card-body py-0"">
              <table class=""table"">
                <tbody>
                  <tr>
                    <td class=""text-dark"">Backpack</td>
                    <td class=""text-center"">9</td>
                    <td class=""text-right"">
                      33%
                      <i
                        class=""mdi mdi-arrow-up-bold text-success pl-1 font-size-12""
                      ></i>
                    </td>
                  </tr>
                  <tr>
                    <td class=""text-dark"">T-Shirt</td>
                    <td class=""text-center"">6</td>
                    <td class=""text-right"">
                      150%
                      <i
                        class=""mdi mdi-arrow-up-bold text-success pl-1 font-size-12""
                      ></i>
           ");
            WriteLiteral(@"         </td>
                  </tr>
                  <tr>
                    <td class=""text-dark"">Coat</td>
                    <td class=""text-center"">3</td>
                    <td class=""text-right"">
                      50%
                      <i
                        class=""mdi mdi-arrow-up-bold text-success pl-1 font-size-12""
                      ></i>
                    </td>
                  </tr>
                  <tr>
                    <td class=""text-dark"">Necklace</td>
                    <td class=""text-center"">7</td>
                    <td class=""text-right"">
                      150%
                      <i
                        class=""mdi mdi-arrow-up-bold text-success pl-1 font-size-12""
                      ></i>
                    </td>
                  </tr>
                  <tr>
                    <td class=""text-dark"">Jeans Pant</td>
                    <td class=""text-center"">10</td>
                    <td class=""text-right"">
         ");
            WriteLiteral(@"             300%
                      <i
                        class=""mdi mdi-arrow-down-bold text-danger pl-1 font-size-12""
                      ></i>
                    </td>
                  </tr>
                  <tr>
                    <td class=""text-dark"">Shoes</td>
                    <td class=""text-center"">5</td>
                    <td class=""text-right"">
                      100%
                      <i
                        class=""mdi mdi-arrow-up-bold text-success pl-1 font-size-12""
                      ></i>
                    </td>
                  </tr>
                  <tr>
                    <td class=""text-dark"">T-Shirt</td>
                    <td class=""text-center"">6</td>
                    <td class=""text-right"">
                      150%
                      <i
                        class=""mdi mdi-arrow-up-bold text-success pl-1 font-size-12""
                      ></i>
                    </td>
                  </tr>
                 ");
            WriteLiteral(@" <tr>
                    <td class=""text-dark"">T-Shirt</td>
                    <td class=""text-center"">6</td>
                    <td class=""text-right"">
                      150%
                      <i
                        class=""mdi mdi-arrow-up-bold text-success pl-1 font-size-12""
                      ></i>
                    </td>
                  </tr>
                  <tr>
                    <td class=""text-dark"">T-Shirt</td>
                    <td class=""text-center"">6</td>
                    <td class=""text-right"">
                      150%
                      <i
                        class=""mdi mdi-arrow-up-bold text-success pl-1 font-size-12""
                      ></i>
                    </td>
                  </tr>
                </tbody>
              </table>      
            </div>
            <div class=""card-footer border-0 bg-white p-0"" style=""padding: 1.1rem, 1.25rem;""></div>
          </div>
        </div>
      </div>
    </div>
 </div>");
            WriteLiteral("\n ");
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
