#pragma checksum "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e52d14a3a5e9be19e796dced812d915fc8ef1fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_GymOwner_Views_GymOwner_MemberAccount), @"mvc.1.0.view", @"/Areas/GymOwner/Views/GymOwner/MemberAccount.cshtml")]
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
#line 1 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e52d14a3a5e9be19e796dced812d915fc8ef1fd", @"/Areas/GymOwner/Views/GymOwner/MemberAccount.cshtml")]
    public class Areas_GymOwner_Views_GymOwner_MemberAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Gymany.Models.Member>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GymOwner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMember", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #fff;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateMember", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
  
    ViewData["Title"] = "MemberAccount";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
  
    Layout = "GymOwnerLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<div class=""page-wrapper"">
    <div class=""page-breadcrumb bg-white"">
        <div class=""row align-items-center"">
            <div class=""col-lg-3 col-md-4 col-sm-4 col-xs-12"">
                <h4 class=""page-title"">Member Managements</h4>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">
");
#nullable restore
#line 24 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
            if (TempData["SuccessMessage"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\" role=\"alert\">\r\n            ");
#nullable restore
#line 27 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
       Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 29 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                <div class=\"white-box\">\r\n                    <h3 class=\"box-title\">Member Managements</h3>\r\n");
            WriteLiteral(@"                    <div class=""table-responsive"">
                        <table class=""table text-wrap"">
                            <thead>
                                <tr>
                                    <th class=""border-top-0"">MemberID</th>
                                    <th class=""border-top-0"">Date</th>
                                    <th class=""border-top-0"">Status</th>
                                    <th class=""border-top-0"">CustomerID</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 47 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 50 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                       Write(item.MemberID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 51 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 52 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                         if (item.Status.Equals("Accepted"))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"text-success\">");
#nullable restore
#line 54 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                                                Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 55 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                        }
                                        else if (item.Status.Equals("Waiting"))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"text-warning\">");
#nullable restore
#line 58 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                                                Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 59 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"text-danger\">");
#nullable restore
#line 62 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 63 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 64 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                       Write(item.CustomerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td>\r\n\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e52d14a3a5e9be19e796dced812d915fc8ef1fd11484", async() => {
                WriteLiteral("Delete this request");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                                  WriteLiteral(item.MemberID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e52d14a3a5e9be19e796dced812d915fc8ef1fd14102", async() => {
                WriteLiteral("Update member status");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                                  WriteLiteral(item.MemberID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 74 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        ");
#nullable restore
#line 82 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\GymOwner\Views\GymOwner\MemberAccount.cshtml"
   Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("MemberAccount", new { page = page }),
                 new X.PagedList.Web.Common.PagedListRenderOptionsBase
        {
            LiElementClasses = new string[] { "page-item" },
            PageClasses = new string[] { "page-link" }
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <footer class=\"footer text-center\"> 2024 © Gymany Admin by Group 05\r\n    </footer>\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Gymany.Models.Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591