#pragma checksum "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "981eae00839aeabe23224e972e6bd50d1dda848f"
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
#line 1 "E:\Project\amusinghoS\src\amusinghoS.App\Views\_ViewImports.cshtml"
using amusinghoS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
using amusinghoS.EntityData.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
using amusinghoS.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"981eae00839aeabe23224e972e6bd50d1dda848f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6f3a858eb02eb79c196f661a0e6664bf77382bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<amusingArticle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/my.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"columns\">\r\n");
#nullable restore
#line 9 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
          
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""column col-4 col-md-6 col-sm-12"">
                    <article id=""post-669"" class=""card card-post"">
                        <div class=""card-image"">
                            <a class=""card-link"">
                                <div class=""post-card-image""");
            BeginWriteAttribute("style", " style=\"", 585, "\"", 629, 4);
            WriteAttributeValue("", 593, "background-image:", 593, 17, true);
            WriteAttributeValue(" ", 610, "url(\'", 611, 6, true);
#nullable restore
#line 16 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
WriteAttributeValue("", 616, item.Image, 616, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 627, "\')", 627, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                            </a>\r\n                        </div>\r\n                        <div class=\"card-header\">   \r\n                            <a class=\"card-link\"");
            BeginWriteAttribute("title", " title=\"", 807, "\"", 826, 1);
#nullable restore
#line 20 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
WriteAttributeValue("", 815, item.Title, 815, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <h2 class=\"post-card-title\"> ");
#nullable restore
#line 21 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
                                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n                                <p>");
#nullable restore
#line 22 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </a>\r\n                        </div>\r\n                        <footer class=\"card-footer\">\r\n                            <time class=\"post-card-date\">");
#nullable restore
#line 26 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
                                                    Write(item.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
                                                                     Write(Html.DisplayName(DatetimeHelper.GetPeriod(item.CreateTime)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</time>\r\n                        </footer>\r\n                    </article>\r\n                </div>\r\n");
#nullable restore
#line 30 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"columns\">\r\n        <div class=\"posts-nav-wrap\">\r\n            <ul class=\"posts-nav\">\r\n                <li class=\"previous\"><a");
            BeginWriteAttribute("href", " href=\"", 1500, "\"", 1586, 2);
            WriteAttributeValue("", 1507, "/index/", 1507, 7, true);
#nullable restore
#line 36 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
WriteAttributeValue("", 1514, Html.DisplayName((Convert.ToInt32(ViewData["Current"]) - 1).ToString()), 1514, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"previous\">←</a></li>\r\n");
#nullable restore
#line 37 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
                  
                    if (ViewData["NextIsNull"].ToString()  == "OK")
                    {

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"next\"><a");
            BeginWriteAttribute("href", " href=\"", 1846, "\"", 1932, 2);
            WriteAttributeValue("", 1853, "/index/", 1853, 7, true);
#nullable restore
#line 44 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
WriteAttributeValue("", 1860, Html.DisplayName((Convert.ToInt32(ViewData["Current"]) + 1).ToString()), 1860, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"next\">←</a></li>\r\n");
#nullable restore
#line 45 "E:\Project\amusinghoS\src\amusinghoS.App\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "981eae00839aeabe23224e972e6bd50d1dda848f9384", async() => {
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
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<amusingArticle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
