#pragma checksum "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a0c0140be1fc0410dedea0ff1c6defd764d3eb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Posts_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Posts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Posts/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Posts_Index))]
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
#line 1 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\_ViewImports.cshtml"
using Blogg;

#line default
#line hidden
#line 2 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\_ViewImports.cshtml"
using Blogg.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a0c0140be1fc0410dedea0ff1c6defd764d3eb8", @"/Areas/Admin/Views/Posts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4986fe2150a70d2b4cac2f97cd01da3ce5452da8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Posts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(133, 602, true);
            WriteLiteral(@"
<div class=""page-header"">
    <div class=""container-fluid"">
        <h2 class=""h5 no-margin-bottom"">Postlarımıza Hoş Geldiniz</h2>
    </div>
</div>

<div class=""col-lg-12"">
    <div class=""block"">

        <div class=""block-body"">
            <section class=""no-padding-top"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-lg-5"">
                            <div class=""block"">

                            </div>
                        </div>

                        <p>
                            ");
            EndContext();
            BeginContext(735, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98f3ed3b2a4f441f82f750cff0b33b06", async() => {
                BeginContext(758, 11, true);
                WriteLiteral("Yeni Post +");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(773, 236, true);
            WriteLiteral("\r\n                        </p>\r\n                        <table class=\"table\">\r\n                            <thead>\r\n                                <tr>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(1010, 43, false);
#line 34 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 129, true);
            WriteLiteral("\r\n                                    </th>\r\n\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(1183, 41, false);
#line 38 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(1352, 44, false);
#line 41 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(1524, 43, false);
#line 44 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.CatName));

#line default
#line hidden
            EndContext();
            BeginContext(1567, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(1695, 45, false);
#line 47 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 206, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
            EndContext();
#line 53 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(2043, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2176, 42, false);
#line 57 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(2218, 141, true);
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2359, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8da60407152f407198f1b200d465cec9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2392, "~/img/post/", 2392, 11, true);
#line 61 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 2403, item.Image, 2403, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2418, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2558, 43, false);
#line 64 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(2601, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2741, 42, false);
#line 67 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.CatName));

#line default
#line hidden
            EndContext();
            BeginContext(2783, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2923, 44, false);
#line 70 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2967, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3106, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c261e922c1d4b02a835bb2aa44d1d4c", async() => {
                BeginContext(3151, 7, true);
                WriteLiteral("Düzenle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3162, 48, true);
            WriteLiteral(" |\r\n                                            ");
            EndContext();
            BeginContext(3210, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39301cad19734b47920dc2890ed64778", async() => {
                BeginContext(3246, 9, true);
                WriteLiteral("Görüntüle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3219, "~/Posts/Details/", 3219, 16, true);
#line 74 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 3235, item.Id, 3235, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3259, 48, true);
            WriteLiteral(" |\r\n                                            ");
            EndContext();
            BeginContext(3307, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0db2d77dee041afbfc7fcb597f391c5", async() => {
                BeginContext(3354, 3, true);
                WriteLiteral("Sil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3361, 134, true);
            WriteLiteral("\r\n                                        \r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 79 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3530, 164, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                        </div>\r\n</div>\r\n                </section>\r\n</div>\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591