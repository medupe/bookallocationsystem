#pragma checksum "C:\Development\personal\bookallocationsystem\Views\Allocate\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d05ccc1dc596fdd9cc04a370d0f08609d8a67a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Allocate_Index), @"mvc.1.0.view", @"/Views/Allocate/Index.cshtml")]
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
#line 1 "C:\Development\personal\bookallocationsystem\Views\_ViewImports.cshtml"
using bookallocationsystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\personal\bookallocationsystem\Views\_ViewImports.cshtml"
using bookallocationsystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d05ccc1dc596fdd9cc04a370d0f08609d8a67a2", @"/Views/Allocate/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fecc256cd7503edeafe076abb6fc1b4d7937a99f", @"/Views/_ViewImports.cshtml")]
    public class Views_Allocate_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bookallocationsystem.Models.Allocation.AllocateViewIndex>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Development\personal\bookallocationsystem\Views\Allocate\Index.cshtml"
  
    ViewData["Title"] = "Dashboard Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                   <div class=""page-breadcrumb bg-white"">
                <div class=""row align-items-center"">
                    <div class=""col-lg-3 col-md-4 col-sm-4 col-xs-12"">
                        <h4 class=""page-title text-uppercase font-medium font-14"">Allocate</h4>
                    </div>

                </div>
                <!-- /.col-lg-12 -->
            </div>

              <div class=""container-fluid"">
                <!-- ============================================================== -->
                <!-- Start Page Content -->
                <!-- ============================================================== -->
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <div class=""white-box"">
                            <h3 class=""box-title"">List</h3>
                             <!--  <div class=""float-right"">
                                   <a class=""btn btn-success""     asp-action=""Create"" asp-controller=""Book");
            WriteLiteral(@"""      >Add Book</button>
                                         <a class=""btn btn-primary""     asp-action=""Upload"" asp-controller=""Book""      >Upload books</a>
                               </div>-->
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th class=""border-top-0"">#</th>
                                            <th class=""border-top-0"">Book Name</th>
                                            <th class=""border-top-0"">Allocate Date</th>
                                            <th class=""border-top-0"">Allocate Condition</th>
                                            <th class=""border-top-0"">Current Condition </th>
                                             <th class=""border-top-0"">Learner</th>
                                            <th class=""border-top-0"">Grade</th>
       ");
            WriteLiteral(@"                                     <th class=""border-top-0"">Audit</th>
                                            <th class=""border-top-0"">Return</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 44 "C:\Development\personal\bookallocationsystem\Views\Allocate\Index.cshtml"
                                         foreach (var item in Model.AllocationList)

                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                                <td>1</td>\r\n                                                            <td>");
#nullable restore
#line 49 "C:\Development\personal\bookallocationsystem\Views\Allocate\Index.cshtml"
                                                           Write(item.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 50 "C:\Development\personal\bookallocationsystem\Views\Allocate\Index.cshtml"
                                                               Write(item.AddedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 51 "C:\Development\personal\bookallocationsystem\Views\Allocate\Index.cshtml"
                                                           Write(item.AllocationCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                                            <td>");
#nullable restore
#line 53 "C:\Development\personal\bookallocationsystem\Views\Allocate\Index.cshtml"
                                                           Write(item.Book.Condition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 54 "C:\Development\personal\bookallocationsystem\Views\Allocate\Index.cshtml"
                                                           Write(item.Learner.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 55 "C:\Development\personal\bookallocationsystem\Views\Allocate\Index.cshtml"
                                                           Write(item.Book.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                                  <td><a>Audit</a></td>
                                                                          <td><a>Return</a></td>
                                                               </tr>
");
#nullable restore
#line 59 "C:\Development\personal\bookallocationsystem\Views\Allocate\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                        </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- ============================================================== -->

            </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bookallocationsystem.Models.Allocation.AllocateViewIndex> Html { get; private set; }
    }
}
#pragma warning restore 1591
