#pragma checksum "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3924ed2969478dc8fd4ee95416dec94bafa282d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Details.cshtml", typeof(AspNetCore.Views_Admin_Details))]
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
#line 1 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\_ViewImports.cshtml"
using ASP.NETMVCCORE;

#line default
#line hidden
#line 2 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\_ViewImports.cshtml"
using ASP.NETMVCCORE.Models;

#line default
#line hidden
#line 3 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\_ViewImports.cshtml"
using ASP.NETMVCCORE.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3924ed2969478dc8fd4ee95416dec94bafa282d8", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1addd1cf62acf541432f23fc8be3d152cae36242", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP.NETMVCCORE.ViewModels.ViewUserDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive center-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/bootStrapImageHolder.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px; height:250px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddorEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
  
    ViewBag.Title = "User's details";

#line default
#line hidden
            BeginContext(106, 390, true);
            WriteLiteral(@"
<h1 class=""text-center"">User Details</h1>
<hr />

<!--
    <div class=""container-fluid text-center"">
        <div class=""row center-block m-4"">
            <div class=""card m-4"">
                <div class=""col-sm-6"">
                    <div class=""card"" style=""width: 35rem;"">
                        <div class=""card-body"">
                            <h3 class=""card-title"">");
            EndContext();
            BeginContext(497, 15, false);
#line 16 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                              Write(Model.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(512, 292, true);
            WriteLiteral(@"</h3>
                            <div class=""row"">
                                <img class=""card-img-top"" src=""~/images/bootStrapImageHolder.jpg"" width=""300px"" height=""250px"" />
                            </div>
                            <p class=""card-text""><b>Date Of Birth</b>- ");
            EndContext();
            BeginContext(805, 14, false);
#line 20 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                                  Write(Model.User.DOB);

#line default
#line hidden
            EndContext();
            BeginContext(819, 70, true);
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Gender</b>- ");
            EndContext();
            BeginContext(890, 17, false);
#line 21 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                           Write(Model.User.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(907, 69, true);
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Email</b>- ");
            EndContext();
            BeginContext(977, 16, false);
#line 22 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                          Write(Model.User.Email);

#line default
#line hidden
            EndContext();
            BeginContext(993, 78, true);
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Contact Number</b>- ");
            EndContext();
            BeginContext(1072, 19, false);
#line 23 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                                   Write(Model.User.MobileNo);

#line default
#line hidden
            EndContext();
            BeginContext(1091, 71, true);
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Address</b>- ");
            EndContext();
            BeginContext(1163, 18, false);
#line 24 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                            Write(Model.User.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1181, 72, true);
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>PostCode</b>- ");
            EndContext();
            BeginContext(1254, 19, false);
#line 25 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                             Write(Model.User.PostCode);

#line default
#line hidden
            EndContext();
            BeginContext(1273, 80, true);
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Location Of Work</b>- ");
            EndContext();
            BeginContext(1354, 25, false);
#line 26 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                                     Write(Model.User.LocationOfWork);

#line default
#line hidden
            EndContext();
            BeginContext(1379, 73, true);
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Biography</b>- ");
            EndContext();
            BeginContext(1453, 20, false);
#line 27 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                              Write(Model.User.Biography);

#line default
#line hidden
            EndContext();
            BeginContext(1473, 70, true);
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Skills</b>- ");
            EndContext();
            BeginContext(1544, 27, false);
#line 28 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                           Write(Model.User.KeyWordsForSkill);

#line default
#line hidden
            EndContext();
            BeginContext(1571, 133, true);
            WriteLiteral("</p>\r\n                            <div class=\"text-center\">\r\n                                <form asp-action=\"Delete\" asp-route-id=\"");
            EndContext();
            BeginContext(1705, 13, false);
#line 30 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                                   Write(Model.User.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1718, 232, true);
            WriteLiteral("\" method=\"post\">\r\n                                    <a asp-controller=\"Admin\" asp-action=\"Index\" class=\"btn btn-default\">Back</a>\r\n                                    <a asp-controller=\"Admin\" asp-action=\"AddorEdit\" asp-route-id=\"");
            EndContext();
            BeginContext(1951, 13, false);
#line 32 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                                                              Write(Model.User.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1964, 163, true);
            WriteLiteral("\" class=\"btn btn-primary\">Edit</a>\r\n                                    <button type=\"submit\" onclick=\"return confirm(\'Are you sure you want to delete records for ");
            EndContext();
            BeginContext(2128, 15, false);
#line 33 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                                                                                          Write(Model.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2143, 62, true);
            WriteLiteral("?\')\" asp-controller=\"Admin\" asp-action=\"Delete\" asp-route-id=\"");
            EndContext();
            BeginContext(2206, 13, false);
#line 33 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                                                                                                                                                                        Write(Model.User.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2219, 416, true);
            WriteLiteral(@""" class=""btn btn-danger"">Delete</button>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    -->

<div class=""row center-block"">
    <div class=""card text-center"">
        <div class=""card-header"">
            <h3 class=""card-title text-primary""><b>");
            EndContext();
            BeginContext(2636, 15, false);
#line 47 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                              Write(Model.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2651, 88, true);
            WriteLiteral("</b></h3>\r\n        </div>\r\n        <hr />\r\n        <div class=\"card-body\">\r\n            ");
            EndContext();
            BeginContext(2739, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a3dcaf5a883486681f3a235c4936ea9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2857, 112, true);
            WriteLiteral("\r\n            <br />\r\n            <div class=\"card-text text-info\">\r\n                <p><b>Sports Category</b>- ");
            EndContext();
            BeginContext(2970, 19, false);
#line 54 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                      Write(Model.User.Category);

#line default
#line hidden
            EndContext();
            BeginContext(2989, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 55 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                 if (Model.User.DOB == null)
                {

#line default
#line hidden
            BeginContext(3060, 79, true);
            WriteLiteral("                    <p class=\"card-text\"><b>Date Of Birth</b>- <b>N/A</b></p>\r\n");
            EndContext();
#line 58 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3199, 63, true);
            WriteLiteral("                    <p class=\"card-text\"><b>Date Of Birth</b>- ");
            EndContext();
            BeginContext(3263, 14, false);
#line 61 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                          Write(Model.User.DOB);

#line default
#line hidden
            EndContext();
            BeginContext(3277, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 62 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(3302, 34, true);
            WriteLiteral("                <p><b>Gender</b>- ");
            EndContext();
            BeginContext(3337, 17, false);
#line 63 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                             Write(Model.User.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(3354, 39, true);
            WriteLiteral("</p>\r\n                <p><b>Email</b>- ");
            EndContext();
            BeginContext(3394, 16, false);
#line 64 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                            Write(Model.User.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3410, 50, true);
            WriteLiteral("</p>\r\n                <p><b>Telephone Number</b>- ");
            EndContext();
            BeginContext(3461, 19, false);
#line 65 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                       Write(Model.User.MobileNo);

#line default
#line hidden
            EndContext();
            BeginContext(3480, 41, true);
            WriteLiteral("</p>\r\n                <p><b>Address</b>- ");
            EndContext();
            BeginContext(3522, 18, false);
#line 66 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                              Write(Model.User.Address);

#line default
#line hidden
            EndContext();
            BeginContext(3540, 42, true);
            WriteLiteral("</p>\r\n                <p><b>PostCode</b>- ");
            EndContext();
            BeginContext(3583, 19, false);
#line 67 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                               Write(Model.User.PostCode);

#line default
#line hidden
            EndContext();
            BeginContext(3602, 50, true);
            WriteLiteral("</p>\r\n                <p><b>Location Of Work</b>- ");
            EndContext();
            BeginContext(3653, 25, false);
#line 68 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                       Write(Model.User.LocationOfWork);

#line default
#line hidden
            EndContext();
            BeginContext(3678, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 69 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                 if (Model.User.Biography == null)
                {

#line default
#line hidden
            BeginContext(3755, 57, true);
            WriteLiteral("                    <p><b>Biography</b>- <b>N/A</b></p>\r\n");
            EndContext();
#line 72 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3872, 41, true);
            WriteLiteral("                    <p><b>Biography</b>- ");
            EndContext();
            BeginContext(3914, 20, false);
#line 75 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                    Write(Model.User.Biography);

#line default
#line hidden
            EndContext();
            BeginContext(3934, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 76 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(3959, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 77 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                 if (Model.User.KeyWordsForSkill == null)
                {

#line default
#line hidden
            BeginContext(4037, 64, true);
            WriteLiteral("                    <p><b>Skills Mentioned</b>- <b>N/A</b></p>\r\n");
            EndContext();
#line 80 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(4161, 38, true);
            WriteLiteral("                    <p><b>Skills</b>- ");
            EndContext();
            BeginContext(4200, 27, false);
#line 83 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                 Write(Model.User.KeyWordsForSkill);

#line default
#line hidden
            EndContext();
            BeginContext(4227, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 84 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(4252, 75, true);
            WriteLiteral("            </div>\r\n            <div class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(4327, 572, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae3e70b2f6214ce78d15b907eff910b8", async() => {
                BeginContext(4397, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(4419, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a4a61ca9de946aebff7e148524a1508", async() => {
                    BeginContext(4488, 4, true);
                    WriteLiteral("Back");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4496, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(4518, 111, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da0978cbd63e4bfab9e81024927b2d81", async() => {
                    BeginContext(4621, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 89 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                                       WriteLiteral(Model.User.ID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4629, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(4651, 223, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0d63649cac54546a6f774854d8153e5", async() => {
                    BeginContext(4859, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 12, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4682, "return", 4682, 6, true);
                AddHtmlAttributeValue(" ", 4688, "confirm(\'Are", 4689, 13, true);
                AddHtmlAttributeValue(" ", 4701, "you", 4702, 4, true);
                AddHtmlAttributeValue(" ", 4705, "sure", 4706, 5, true);
                AddHtmlAttributeValue(" ", 4710, "you", 4711, 4, true);
                AddHtmlAttributeValue(" ", 4714, "want", 4715, 5, true);
                AddHtmlAttributeValue(" ", 4719, "to", 4720, 3, true);
                AddHtmlAttributeValue(" ", 4722, "delete", 4723, 7, true);
                AddHtmlAttributeValue(" ", 4729, "records", 4730, 8, true);
                AddHtmlAttributeValue(" ", 4737, "for", 4738, 4, true);
#line 90 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
AddHtmlAttributeValue(" ", 4741, Model.User.Name, 4742, 16, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 4758, "?\')", 4758, 3, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 90 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                                                                                                                                                                 WriteLiteral(Model.User.ID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4874, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 87 "C:\Users\agarf\Desktop\.NETMVCCORE\ASP.NETMVCCORE\ASP.NETMVCCORE\Views\Admin\Details.cshtml"
                                            WriteLiteral(Model.User.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4899, 158, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <hr />\r\n        <div class=\"card-footer text-muted\">\r\n            2 days ago\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP.NETMVCCORE.ViewModels.ViewUserDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591