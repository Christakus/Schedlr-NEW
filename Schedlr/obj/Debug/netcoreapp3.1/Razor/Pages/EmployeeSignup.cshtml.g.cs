#pragma checksum "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb5f0060d4d114e2d387d0a8a377496bed96ff09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Schedlr.Pages.Pages_EmployeeSignup), @"mvc.1.0.razor-page", @"/Pages/EmployeeSignup.cshtml")]
namespace Schedlr.Pages
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
#line 1 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\_ViewImports.cshtml"
using Schedlr;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb5f0060d4d114e2d387d0a8a377496bed96ff09", @"/Pages/EmployeeSignup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f765b63f098575ace431be989d5fe0aa0bb7712b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EmployeeSignup : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
  
    ViewData["Title"] = "Sign Up";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- anti forgery tokens offers security against users attempting to bypass the form by \"pretending\" to enter values-->\r\n\r\n");
#nullable restore
#line 8 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <div class=\"form-horizontal justify-content-center\">\r\n        <div class=\"text-center\">\r\n\r\n            <h1 class=\"display-4\"> Create Account </h1>\r\n        </div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb5f0060d4d114e2d387d0a8a377496bed96ff094605", async() => {
                WriteLiteral("\r\n            <div class=\" w-25\" style=\"margin-top: 100px\">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 20 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <!-- asp-for links the input text to a property of an object in the model-->\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 23 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                   Write(Html.LabelFor(model => model.Employee.EmployeeId, htmlAttributes: new { @class = "control-label col-md-10" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-12\">\r\n\r\n                            ");
#nullable restore
#line 26 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.EditorFor(model => model.Employee.EmployeeId, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 27 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Employee.EmployeeId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n            <div class=\"justify-content-center align-items-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 1398, "\"", 1406, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <!-- asp-for links the input text to a property of an object in the model-->\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 39 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                   Write(Html.LabelFor(model => model.Employee.JobTitle, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-12\">\r\n\r\n                            ");
#nullable restore
#line 42 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.EditorFor(model => model.Employee.JobTitle, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 43 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Employee.JobTitle, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"justify-content-center align-items-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 2307, "\"", 2315, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <!-- asp-for links the input text to a property of an object in the model-->\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 53 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                   Write(Html.LabelFor(model => model.Employee.FirstName, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-12\">\r\n\r\n                            ");
#nullable restore
#line 56 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.EditorFor(model => model.Employee.FirstName, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 57 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Employee.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"justify-content-center align-items-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 3219, "\"", 3227, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 64 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <!-- asp-for links the input text to a property of an object in the model-->\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 67 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                   Write(Html.LabelFor(model => model.Employee.LastName, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-12\">\r\n\r\n                            ");
#nullable restore
#line 70 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.EditorFor(model => model.Employee.LastName, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 71 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Employee.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"justify-content-center align-items-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 4128, "\"", 4136, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 78 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <!-- asp-for links the input text to a property of an object in the model-->\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 81 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                   Write(Html.LabelFor(model => model.Employee.EmailAddress, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-12\">\r\n\r\n                            ");
#nullable restore
#line 84 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.EditorFor(model => model.Employee.EmailAddress, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 85 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Employee.EmailAddress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"justify-content-center align-items-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 5049, "\"", 5057, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 92 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <!-- asp-for links the input text to a property of an object in the model-->\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 95 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                   Write(Html.LabelFor(model => model.Employee.ConfirmEmail, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-12\">\r\n\r\n                            ");
#nullable restore
#line 98 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.EditorFor(model => model.Employee.ConfirmEmail, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 99 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Employee.ConfirmEmail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"justify-content-center align-items-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 5970, "\"", 5978, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 106 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <!-- asp-for links the input text to a property of an object in the model-->\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 109 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                   Write(Html.LabelFor(model => model.Employee.Password, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-12\">\r\n\r\n                            ");
#nullable restore
#line 112 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.EditorFor(model => model.Employee.Password, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 113 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Employee.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"justify-content-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 6860, "\"", 6868, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 120 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <!-- asp-for links the input text to a property of an object in the model-->\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 123 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                   Write(Html.LabelFor(model => model.Employee.ConfirmPassword, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-12\">\r\n\r\n                            ");
#nullable restore
#line 126 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.EditorFor(model => model.Employee.ConfirmPassword, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 127 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Employee.ConfirmPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n          \r\n            <div class=\"justify-content-center align-items-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 7802, "\"", 7810, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                <div class=""form-group"">
                    <div class="" col-5"">
                        <input type=""submit"" value=""Create Account"" class=""btn btn-block btn-outline-light"" />
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n\r\n\r\n<div>\r\n    ");
#nullable restore
#line 147 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\EmployeeSignup.cshtml"
Write(Html.ActionLink("Back to Home", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb5f0060d4d114e2d387d0a8a377496bed96ff0923302", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeSignupModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeeSignupModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeeSignupModel>)PageContext?.ViewData;
        public EmployeeSignupModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
