#pragma checksum "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61ebdaddd47eea23b970d3a9b98f6001ba899e6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Posts_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Posts/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Posts/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_Posts_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61ebdaddd47eea23b970d3a9b98f6001ba899e6f", @"/Areas/Admin/Views/Posts/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4986fe2150a70d2b4cac2f97cd01da3ce5452da8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Posts_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(121, 698, true);
            WriteLiteral(@"
<div class=""page-header"">
    <div class=""container-fluid"">
        <h2 class=""h5 no-margin-bottom"">Silmek istediğinize emin misiniz?</h2>
    </div>
</div>

<div class=""col-lg-12"">
    <div class=""block"">

        <div class=""block-body"">
            <section class=""no-padding-top"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div>
                                <h4>Posts</h4>
                                <hr />
                                <dl class=""dl-horizontal"">
                                    <dt>
                                        ");
            EndContext();
            BeginContext(820, 43, false);
#line 27 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(863, 127, true);
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(991, 39, false);
#line 30 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
                                   Write(Html.DisplayFor(model => model.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 127, true);
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(1158, 40, false);
#line 33 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 127, true);
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(1326, 36, false);
#line 36 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
                                   Write(Html.DisplayFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 127, true);
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(1490, 41, false);
#line 39 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 127, true);
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(1659, 37, false);
#line 42 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
                                   Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1696, 127, true);
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(1824, 44, false);
#line 45 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
                                   Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1868, 127, true);
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(1996, 40, false);
#line 48 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
                                   Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 127, true);
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(2164, 43, false);
#line 51 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
                                   Write(Html.DisplayNameFor(model => model.CatName));

#line default
#line hidden
            EndContext();
            BeginContext(2207, 127, true);
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(2335, 39, false);
#line 54 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
                                   Write(Html.DisplayFor(model => model.CatName));

#line default
#line hidden
            EndContext();
            BeginContext(2374, 127, true);
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(2502, 45, false);
#line 57 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2547, 127, true);
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(2675, 41, false);
#line 60 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
                                   Write(Html.DisplayFor(model => model.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2716, 118, true);
            WriteLiteral("\r\n                                    </dd>\r\n                                </dl>\r\n\r\n                                ");
            EndContext();
            BeginContext(2834, 312, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "255c8c043d5f4bf08fed82c8b29f94cd", async() => {
                BeginContext(2860, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2898, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fe516680e504e1c98da3fafd3477c80", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "C:\Users\Gizem\Desktop\İrem\Documents\GitHub\WebProgramlama\Blogg\Blogg\Areas\Admin\Views\Posts\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2934, 137, true);
                WriteLiteral("\r\n                                    <input type=\"submit\" value=\"Sil\" class=\"btn btn-primary\" /> |\r\n                                    ");
                EndContext();
                BeginContext(3071, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb66e0bb35df4285baaf5cd377ca9d58", async() => {
                    BeginContext(3093, 8, true);
                    WriteLiteral("Geri Dön");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3105, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3146, 142, true);
            WriteLiteral("\r\n                            </div>\r\n                            </div>\r\n</div>\r\n</div>\r\n                </section>\r\n</div>\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
