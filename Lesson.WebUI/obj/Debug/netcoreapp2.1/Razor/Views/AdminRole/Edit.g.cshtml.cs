#pragma checksum "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc892e4da8ea34465fca9865849fd0f60ff12c1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminRole_Edit), @"mvc.1.0.view", @"/Views/AdminRole/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminRole/Edit.cshtml", typeof(AspNetCore.Views_AdminRole_Edit))]
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
#line 1 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\_ViewImports.cshtml"
using Lesson.Entity;

#line default
#line hidden
#line 2 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\_ViewImports.cshtml"
using Lesson.Models;

#line default
#line hidden
#line 3 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\_ViewImports.cshtml"
using Lesson.WebUI.Models;

#line default
#line hidden
#line 4 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc892e4da8ea34465fca9865849fd0f60ff12c1a", @"/Views/AdminRole/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20b996a169d94dd51b807143d325de3a023ba345", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminRole_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lesson.WebUI.Models.RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(80, 77, true);
            WriteLiteral("<div class=\"bg-primary text-white p-1 m-1\">\r\n    <h2>Edit Role</h2>\r\n</div>\r\n");
            EndContext();
            BeginContext(157, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40d0d260b1944a22900da4b78cae613c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 8 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(223, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(227, 1574, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eba323d0ff449b8b63511fdc2e31fae", async() => {
                BeginContext(265, 42, true);
                WriteLiteral("\r\n\r\n    <input type=\"hidden\" name=\"RoleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 307, "\"", 329, 1);
#line 12 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 315, Model.Role.Id, 315, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(330, 45, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"RoleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 375, "\"", 399, 1);
#line 13 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 383, Model.Role.Name, 383, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(400, 63, true);
                WriteLiteral(" />\r\n\r\n    <h6 class=\"bg-info p-1 text-white\">\r\n        Add to ");
                EndContext();
                BeginContext(464, 15, false);
#line 16 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
          Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(479, 64, true);
                WriteLiteral("\r\n    </h6>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 19 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
         if (Model.NonMembers.Count() == 0)
        {

#line default
#line hidden
                BeginContext(599, 64, true);
                WriteLiteral("            <tr><td colspan=\"2\">All User Are Members</td></tr>\r\n");
                EndContext();
#line 22 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 25 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
             foreach (var user in Model.NonMembers)
            {

#line default
#line hidden
                BeginContext(767, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(814, 13, false);
#line 28 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(827, 95, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"IdsToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 922, "\"", 938, 1);
#line 30 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 930, user.Id, 930, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(939, 55, true);
                WriteLiteral(" />\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 33 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
            }

#line default
#line hidden
#line 33 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
             
        }

#line default
#line hidden
                BeginContext(1020, 77, true);
                WriteLiteral("    </table>\r\n\r\n\r\n    <h6 class=\"bg-info p-1 text-white\">\r\n        Delete to ");
                EndContext();
                BeginContext(1098, 15, false);
#line 39 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
             Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1113, 64, true);
                WriteLiteral("\r\n    </h6>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 42 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
         if (Model.Members.Count() == 0)
        {

#line default
#line hidden
                BeginContext(1230, 64, true);
                WriteLiteral("            <tr><td colspan=\"2\">No Users Are Members</td></tr>\r\n");
                EndContext();
#line 45 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 48 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
             foreach (var user in Model.Members)
            {

#line default
#line hidden
                BeginContext(1395, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1442, 13, false);
#line 51 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1455, 98, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"IdsToDelete\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1553, "\"", 1569, 1);
#line 53 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 1561, user.Id, 1561, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1570, 55, true);
                WriteLiteral(" />\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 56 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
            }

#line default
#line hidden
#line 56 "C:\Users\asus\source\repos\Lesson\Lesson.WebUI\Views\AdminRole\Edit.cshtml"
             
        }

#line default
#line hidden
                BeginContext(1651, 83, true);
                WriteLiteral("    </table>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n    ");
                EndContext();
                BeginContext(1734, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42cfbd020de4423284e85cff364906bd", async() => {
                    BeginContext(1782, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                BeginContext(1792, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1801, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lesson.WebUI.Models.RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
