#pragma checksum "C:\Users\holde\Documents\GitHub\RetroNet\RetroNet\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7f619192bdc0a23955babc951cda957f18c3489"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\holde\Documents\GitHub\RetroNet\RetroNet\Views\_ViewImports.cshtml"
using _90sTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\holde\Documents\GitHub\RetroNet\RetroNet\Views\_ViewImports.cshtml"
using _90sTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7f619192bdc0a23955babc951cda957f18c3489", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f23d317e5621e829cfa32d2b9e4a61c59e9e00b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FeedModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Submit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\holde\Documents\GitHub\RetroNet\RetroNet\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" style=""margin-top:30px;"">
    <div class=""row"">
        <div class=""col-sm-3"" id=""sidenav"">
            <a href=""#"">
                <button class=""btn mr-2 mb-2 btn-primary border-dark sidenavbutton"" type=""button"">
                    <span class=""btn-text"">Feed</span>
                </button>
            </a>
            <br>
            <a href=""#"">
                <button class=""btn mr-2 mb-2 btn-primary border-dark sidenavbutton"" type=""button"">
                    <span class=""btn-text"">Friends</span>
                </button>
            </a>
            <br>
            <a href=""#"">
                <button class=""btn mr-2 mb-2 btn-primary border-dark sidenavbutton"" type=""button"">
                    <span class=""btn-text"">Profile</span>
                </button>
            </a>
            <br>
            <a href=""#"">
                <button class=""btn mr-2 mb-2 btn-primary border-dark sidenavbutton"" type=""button"">
                    <span class=""btn-");
            WriteLiteral(@"text"">Settings</span>
                </button>
            </a>
        </div>
        <div class=""col-sm-9 mb-4 mb-lg-0 feed"">
            <div class=""card"">
                <div class=""card-header"">
                    New Post
                </div>
                <div class=""card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7f619192bdc0a23955babc951cda957f18c34895419", async() => {
                WriteLiteral("\r\n                        <div class=\"card-text\">\r\n                            ");
#nullable restore
#line 41 "C:\Users\holde\Documents\GitHub\RetroNet\RetroNet\Views\Home\Index.cshtml"
                       Write(Html.TextAreaFor(model => model.NewPost.Content, new { @class = "form-control", @rows = 4 }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                        <div class=""d-flex justify-content-end mt-3"">
                            <input class=""btn btn-sm mr-2 btn-primary border-dark"" type=""submit"" value=""Post""/>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 50 "C:\Users\holde\Documents\GitHub\RetroNet\RetroNet\Views\Home\Index.cshtml"
             foreach (_90sTest.Entities.Post post in Model.Posts)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\">\r\n                    <div class=\"card-header\">\r\n                        ");
#nullable restore
#line 55 "C:\Users\holde\Documents\GitHub\RetroNet\RetroNet\Views\Home\Index.cshtml"
                   Write(post.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (<a href=\"profileRat\">");
            WriteLiteral("@");
#nullable restore
#line 55 "C:\Users\holde\Documents\GitHub\RetroNet\RetroNet\Views\Home\Index.cshtml"
                                                           Write(post.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>)\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <p class=\"card-text\">\r\n                            ");
#nullable restore
#line 59 "C:\Users\holde\Documents\GitHub\RetroNet\RetroNet\Views\Home\Index.cshtml"
                       Write(post.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <div class=\"d-flex justify-content-end mt-3\">\r\n                            <div>");
#nullable restore
#line 62 "C:\Users\holde\Documents\GitHub\RetroNet\RetroNet\Views\Home\Index.cshtml"
                            Write(post.Date.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            &nbsp;\r\n                            <div>");
#nullable restore
#line 64 "C:\Users\holde\Documents\GitHub\RetroNet\RetroNet\Views\Home\Index.cshtml"
                            Write(post.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Likes</div>
                            &nbsp;
                            <button class=""btn btn-sm mr-2 btn-primary border-dark"" type=""button"">
                                <span class=""btn-text"">Like</span>
                            </button>
                        </div>
                    </div>
                </div>
                <br>
");
#nullable restore
#line 73 "C:\Users\holde\Documents\GitHub\RetroNet\RetroNet\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FeedModel> Html { get; private set; }
    }
}
#pragma warning restore 1591