#pragma checksum "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Genre\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d3357ee88710d9ea6ec37fdc24b62b462112ed6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Genre_Index), @"mvc.1.0.view", @"/Views/Genre/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Genre/Index.cshtml", typeof(AspNetCore.Views_Genre_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d3357ee88710d9ea6ec37fdc24b62b462112ed6", @"/Views/Genre/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff18cda3607c06ebc710d53d43315c6216d98a0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Genre_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MybookWeb.Entities.Genre>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Genre", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn float-right hidden-sm-down btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ft-edit-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-hidden", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ft-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Genre\Index.cshtml"
  
    ViewData["Title"] = "Genre";

#line default
#line hidden
            BeginContext(87, 2247, true);
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
                            <h4 class=""card-title"">Genre</h4>
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
            BeginContext(2334, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b92cd68d64d74070b6e62b91000db7a8", async() => {
                BeginContext(2431, 44, true);
                WriteLiteral("<i class=\"mdi mdi-plus-circle\"></i>New Genre");
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
            BeginContext(2479, 842, true);
            WriteLiteral(@"
                                </div>
                                <div class=""table-responsive"">
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th>#</th>
                                                <th>Name</th>
                                                <th>CreatedBy</th>
                                                <th>DateCreated</th>
                                               
                                                <th></th>
                                                <th></th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
            EndContext();
#line 64 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Genre\Index.cshtml"
                                             foreach (var g in Model)
                                            {

#line default
#line hidden
            BeginContext(3439, 122, true);
            WriteLiteral("                                                <tr>\r\n                                                    <td scope=\"row\">");
            EndContext();
            BeginContext(3562, 4, false);
#line 67 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Genre\Index.cshtml"
                                                               Write(g.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3566, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(3630, 6, false);
#line 68 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Genre\Index.cshtml"
                                                   Write(g.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3636, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(3700, 11, false);
#line 69 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Genre\Index.cshtml"
                                                   Write(g.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(3711, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(3775, 13, false);
#line 70 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Genre\Index.cshtml"
                                                   Write(g.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(3788, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(3851, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b50b1c6971ce48ad81fa1f996974ec70", async() => {
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
#line 71 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Genre\Index.cshtml"
                                                                                                 WriteLiteral(g.Id);

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
            BeginContext(3935, 63, true);
            WriteLiteral("</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(3998, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87e491e7426a426d8606efac65442404", async() => {
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
#line 72 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Genre\Index.cshtml"
                                                                                                   WriteLiteral(g.Id);

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
            BeginContext(4084, 62, true);
            WriteLiteral("</td>\r\n                                                </tr>\r\n");
            EndContext();
#line 74 "C:\Users\Ekpokpobe Davidson\source\repos\DavidsonHW5\MybookAPI\MybookWeb\Views\Genre\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(4193, 312, true);
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
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MybookWeb.Entities.Genre>> Html { get; private set; }
    }
}
#pragma warning restore 1591
