#pragma checksum "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3d7bbb4e00ffec761100574e5ce0b927e019ac4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
#line 1 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\_ViewImports.cshtml"
using MybookWeb;

#line default
#line hidden
#line 2 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\_ViewImports.cshtml"
using MybookWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d7bbb4e00ffec761100574e5ce0b927e019ac4", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff18cda3607c06ebc710d53d43315c6216d98a0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MybookWeb.Entities.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn float-right hidden-sm-down btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ft-edit-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-hidden", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ft-trash-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Books";

#line default
#line hidden
            BeginContext(86, 2247, true);
            WriteLiteral(@"<div class=""app-content content"">
    <div class=""content-wrapper"">
        <div class=""content-wrapper-before""></div>
        <div class=""content-header row"">
            <div class=""content-header-left col-md-4 col-12 mb-2"">
                <h3 class=""content-header-title"">Tables</h3>
            </div>
            <div class=""content-header-right col-md-8 col-12"">
                <div class=""breadcrumbs-top float-md-right"">
                    <div class=""breadcrumb-wrapper mr-1"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item"">
                                <a href=""index.html"">Home</a>
                            </li>
                            <li class=""breadcrumb-item active"">
                                Tables
                            </li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        <div class=""content-body"">
            <!-- Basic Ta");
            WriteLiteral(@"bles start -->
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4 class=""card-title"">Books</h4>
                            <a class=""heading-elements-toggle""><i class=""la la-ellipsis-v font-medium-3""></i></a>
                            <div class=""heading-elements"">
                                <ul class=""list-inline mb-0"">
                                    <li><a data-action=""collapse""><i class=""ft-minus""></i></a></li>
                                    <li><a data-action=""reload""><i class=""ft-rotate-cw""></i></a></li>
                                    <li><a data-action=""expand""><i class=""ft-maximize""></i></a></li>
                                    <li><a data-action=""close""><i class=""ft-x""></i></a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""card");
            WriteLiteral("-content collapse show\">\r\n                            <div class=\"card-body\">\r\n                                <div class=\"col-md-12 col-12 align-self-center\">\r\n\r\n                                    ");
            EndContext();
            BeginContext(2333, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d6edfe2d0c04ce9aafdc9bdf6e0805d", async() => {
                BeginContext(2429, 43, true);
                WriteLiteral("<i class=\"mdi mdi-plus-circle\"></i>New Book");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2476, 1255, true);
            WriteLiteral(@"
                                </div>
                                <div class=""table-responsive"">
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th>#</th>
                                                <th>Title</th>
                                                <th>Author</th>
                                                <th>Genre</th>
                                                <th>Publisher</th>
                                                <th>ISBN</th>
                                                <th>YearPublish</th>
                                                <th>Rating</th>
                                                <th>Summary</th>
                                                <th>CreatedBy</th>
                                                <th>DateCreated</th>
                                     ");
            WriteLiteral("           <th></th>\r\n                                                <th></th>\r\n                                            </tr>\r\n                                        </thead>\r\n                                        <tbody>\r\n");
            EndContext();
#line 70 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                             foreach (var book in Model)
                                            {

#line default
#line hidden
            BeginContext(3852, 114, true);
            WriteLiteral("                                            <tr>\r\n                                                <td scope=\"row\">");
            EndContext();
            BeginContext(3967, 7, false);
#line 73 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                                           Write(book.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3974, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4034, 10, false);
#line 74 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                               Write(book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4044, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4104, 16, false);
#line 75 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                               Write(book.Author.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4120, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4180, 15, false);
#line 76 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                               Write(book.Genre.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4195, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4255, 19, false);
#line 77 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                               Write(book.Publisher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4274, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4334, 9, false);
#line 78 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                               Write(book.ISBN);

#line default
#line hidden
            EndContext();
            BeginContext(4343, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4403, 16, false);
#line 79 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                               Write(book.YearPublish);

#line default
#line hidden
            EndContext();
            BeginContext(4419, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4479, 11, false);
#line 80 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                               Write(book.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(4490, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4550, 12, false);
#line 81 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                               Write(book.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(4562, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4622, 14, false);
#line 82 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                               Write(book.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(4636, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4696, 16, false);
#line 83 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                               Write(book.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(4712, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4771, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4d6aa59a39f48219365fcd9c42e6aab", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                                                                             WriteLiteral(book.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4858, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4917, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c3205d53b5847fe8fb586710017960e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                                                                                WriteLiteral(book.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5007, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 87 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Book\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(5112, 310, true);
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MybookWeb.Entities.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
