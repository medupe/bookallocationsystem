#pragma checksum "C:\Development\personal\bookallocationsystem\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1acfdbe74cdb9349d6b9a49d3939d7773badd1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1acfdbe74cdb9349d6b9a49d3939d7773badd1f", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fecc256cd7503edeafe076abb6fc1b4d7937a99f", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bookallocationsystem.Models.Books.BookViewIndex>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Allocate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Development\personal\bookallocationsystem\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Dashboard Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                   <div class=""page-breadcrumb bg-white"">
                <div class=""row align-items-center"">
                    <div class=""col-lg-3 col-md-4 col-sm-4 col-xs-12"">
                        <h4 class=""page-title text-uppercase font-medium font-14"">Book</h4>
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
                            <h3 class=""box-title"">Basic Table</h3>
                               <div class=""float-right"">
                                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1acfdbe74cdb9349d6b9a49d3939d7773badd1f6533", async() => {
                WriteLiteral("Add Book");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1acfdbe74cdb9349d6b9a49d3939d7773badd1f8020", async() => {
                WriteLiteral("Upload books");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                               </div>
                            <div class=""table-responsive"">

                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th class=""border-top-0"">#</th>
                                            <th class=""border-top-0"">Code</th>
                                            <th class=""border-top-0"">Title</th>
                                            <th class=""border-top-0"">ISBN</th>
                                              <th class=""border-top-0"">Subject</th>
                                                <th class=""border-top-0"">Condition</th>
                                                <th class=""border-top-0"">Grade</th>
                                                 <th class=""border-top-0"">Grade Class</th>
                                              <th class=""border-top-0"">Action</th>
                      ");
            WriteLiteral("                  </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n\r\n");
#nullable restore
#line 46 "C:\Development\personal\bookallocationsystem\Views\Book\Index.cshtml"
                                          
                                int c = 1;
                                foreach (var item in Model.BookList)

                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <tr>\r\n                                                                    <td>");
#nullable restore
#line 52 "C:\Development\personal\bookallocationsystem\Views\Book\Index.cshtml"
                                                                   Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 53 "C:\Development\personal\bookallocationsystem\Views\Book\Index.cshtml"
                                                               Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 54 "C:\Development\personal\bookallocationsystem\Views\Book\Index.cshtml"
                                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 55 "C:\Development\personal\bookallocationsystem\Views\Book\Index.cshtml"
                                                               Write(item.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                                                <td>");
#nullable restore
#line 57 "C:\Development\personal\bookallocationsystem\Views\Book\Index.cshtml"
                                                               Write(item.Subject.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                 <td>");
#nullable restore
#line 58 "C:\Development\personal\bookallocationsystem\Views\Book\Index.cshtml"
                                                                Write(item.Condition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 59 "C:\Development\personal\bookallocationsystem\Views\Book\Index.cshtml"
                                                               Write(item.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 60 "C:\Development\personal\bookallocationsystem\Views\Book\Index.cshtml"
                                                               Write(item.GradeClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1acfdbe74cdb9349d6b9a49d3939d7773badd1f13938", async() => {
                WriteLiteral("Allocate");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Development\personal\bookallocationsystem\Views\Book\Index.cshtml"
                                                                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                                                   </tr>\r\n");
#nullable restore
#line 63 "C:\Development\personal\bookallocationsystem\Views\Book\Index.cshtml"
                                    c = c + 1;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bookallocationsystem.Models.Books.BookViewIndex> Html { get; private set; }
    }
}
#pragma warning restore 1591
