#pragma checksum "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f6d1db5c018d519a57461101a361410b548b63a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_ShowNews), @"mvc.1.0.view", @"/Views/News/ShowNews.cshtml")]
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
#line 1 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
using Blogger.Core.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f6d1db5c018d519a57461101a361410b548b63a", @"/Views/News/ShowNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_News_ShowNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blogger.DataLayer.Entities.News.News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
  
    ViewData["Title"] = "ShowNews";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""post-wrapper pt-100"">
    <!-- Start post Area -->
    <section class=""post-area"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-lg-4 sidebar-area"" style=""direction: rtl"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f6d1db5c018d519a57461101a361410b548b63a3845", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  \r\n                    ");
#nullable restore
#line 16 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
               Write(await Component.InvokeAsync("CategoryComponent"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 17 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
               Write(await Component.InvokeAsync("RecentNewsInArchiveComponent"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n                    ");
#nullable restore
#line 19 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
               Write(await Component.InvokeAsync("TagsComponent"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-lg-8\" style=\"direction: rtl\">\r\n                    <div class=\"single-page-post\">\r\n                        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 877, "\"", 911, 2);
            WriteAttributeValue("", 883, "/NewsImages/", 883, 12, true);
#nullable restore
#line 23 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
WriteAttributeValue("", 895, Model.ImageName, 895, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 912, "\"", 918, 0);
            EndWriteAttribute();
            WriteLiteral(@" Class=""thumbnail"">
                        <div class=""top-wrapper "">
                            <div class=""row d-flex justify-content-between"">
                                <h2 class=""col-lg-8 col-md-12 text-uppercase"">
                                    ");
#nullable restore
#line 27 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h2>\r\n                                <div class=\"col-lg-4 col-md-12 right-side d-flex justify-content-end\">\r\n                                    <div class=\"desc\">\r\n                                        <h3>تاریخ : ");
#nullable restore
#line 31 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
                                               Write(Model.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    </div>\r\n                                    <div class=\"user-img\">\r\n                                        <img src=\"img/user.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1653, "\"", 1659, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"tags\">\r\n                            <ul>\r\n");
#nullable restore
#line 41 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
                                 foreach (var item in Model.Tags.Split('-'))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2048, "\"", 2075, 2);
            WriteAttributeValue("", 2055, "/Home/Search?q=", 2055, 15, true);
#nullable restore
#line 43 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
WriteAttributeValue("", 2070, item, 2070, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
                                                                  Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 44 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                        <div class=\"single-post-content\">\r\n                            <p>\r\n                                ");
#nullable restore
#line 49 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
                           Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <p>\r\n                                ");
#nullable restore
#line 52 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
                           Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"bottom-wrapper\">\r\n                            <div class=\"row\">\r\n");
#nullable restore
#line 57 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
                                if (User.Identity.IsAuthenticated)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <div class=\"col-lg-4 single-b-wrap col-md-12\">\r\n                                       <a");
            BeginWriteAttribute("href", " href=\"", 2849, "\"", 2897, 3);
            WriteAttributeValue("", 2856, "/News/Command/", 2856, 14, true);
#nullable restore
#line 60 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
WriteAttributeValue("", 2870, Model.NewsId, 2870, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2883, "?command=liked", 2883, 14, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-heart-o\" aria-hidden=\"true\"></i></a>\r\n                                       پسندیدم\r\n                                   </div>\r\n");
#nullable restore
#line 63 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
                               
                               }
                               else
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                   <div class=""col-lg-4 single-b-wrap col-md-12 disabled"">
                                       <a href=""#""><i class=""fa fa-heart-o disabled"" aria-hidden=""true""></i></a>
                                       پسندیدم
                                       <div type=""text"" class=""help-block"">برای رای دهی لطفا ابتدا <a href=""/Login"">وارد سایت</a> شوید</div>
                                   </div>
");
#nullable restore
#line 72 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
                               
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                               
                                <div class=""col-lg-4 single-b-wrap col-md-12"">
                                    <ul class=""social-icons"">
                                        <li><a href=""#""><i class=""fa fa-facebook"" aria-hidden=""true""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-twitter"" aria-hidden=""true""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-dribbble"" aria-hidden=""true""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-behance"" aria-hidden=""true""></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>


                        <!-- Start comment-sec Area -->
                        <section class=""comment-sec-area pt-80 pb-80"" id=""commentList"">
                            ");
#nullable restore
#line 89 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
                       Write(await Component.InvokeAsync("ShowCommentsComponent"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </section>
                        <!-- End comment-sec Area -->
                        <!-- Start commentform Area -->
                        <section class=""commentform-area  pb-120 pt-80 mb-100"">
                            <div class=""container"">
                                <h5 class=""text-uppercas pb-50"">نظرتان را بیان کنید</h5>
                                <div class=""row flex-row d-flex"">
                                    <div class=""col-lg-6"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f6d1db5c018d519a57461101a361410b548b63a14119", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 98 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <input name=\"name\" placeholder=\"نام خود را وارد کنید\" onfocus=\"this.placeholder = \'\'\" onblur=\"this.placeholder = \'نام خود را وارد کنید\'\" class=\"common-input mb-20 form-control\"");
            BeginWriteAttribute("required", " required=\"", 5507, "\"", 5518, 0);
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" id=\"txtName\">\r\n                                        <input name=\"email\" placeholder=\"ایمیل خود را وارد کنید\" onfocus=\"this.placeholder = \'\'\" onblur=\"this.placeholder = \'ایمیل خود را وارد کنید\'\" class=\"common-input mb-20 form-control\"");
            BeginWriteAttribute("required", " required=\"", 5768, "\"", 5779, 0);
            EndWriteAttribute();
            WriteLiteral(@" type=""email"" id=""txtEmail"">
                                    </div>
                                    <div class=""col-lg-6"">
                                        <textarea class=""form-control mb-10"" name=""message"" placeholder=""متن نظر"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'متن نظر'""");
            BeginWriteAttribute("required", " required=\"", 6097, "\"", 6108, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""txtComment""></textarea>
                                        <input type=""button"" class=""primary-btn mt-20"" onclick=""addComment()"" value=""ارسال نظر"">
                                    </div>
                                </div>
                            </div>
                        </section>
                        <!-- End commentform Area -->

                    </div>
                </div>

            </div>
        </div>
    </section>
    <!-- End post Area -->
</div>
<script>
    function addComment() {
        $.ajax({
            url: ""/News/AddComment/"" + ");
#nullable restore
#line 122 "F:\Blogger\Blogger\Blogger.Web\Views\News\ShowNews.cshtml"
                                  Write(Model.NewsId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            type: ""Get"",
            data: { name: $(""#txtName"").val(), email: $(""#txtEmail"").val(), comment: $(""#txtComment"").val() }
        }).done(function(result) {

            $(""#commentList"").html(result);
            $(""#txtName"").val("""");
            $(""#txtEmail"").val("""");
            $(""#txtComment"").val("""");

        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blogger.DataLayer.Entities.News.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
