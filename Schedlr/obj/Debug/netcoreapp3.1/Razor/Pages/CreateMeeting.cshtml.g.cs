#pragma checksum "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a0bc50bbcca84ada8581101adad348dbb2032f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Schedlr.Pages.Pages_CreateMeeting), @"mvc.1.0.razor-page", @"/Pages/CreateMeeting.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a0bc50bbcca84ada8581101adad348dbb2032f2", @"/Pages/CreateMeeting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f765b63f098575ace431be989d5fe0aa0bb7712b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CreateMeeting : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
  
    ViewData["Title"] = "Create Meeting";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"form-horizontal\">\r\n    <div class=\"text-center\">\r\n\r\n        <h1 class=\"display-4\"> Create Meeting </h1>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a0bc50bbcca84ada8581101adad348dbb2032f24433", async() => {
                WriteLiteral("\r\n        <div class=\"justify-content-center align-items-center w-25\" style=\"margin-top: 100px\">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 18 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <!-- asp-for links the input text to a property of an object in the model-->\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
               Write(Html.LabelFor(model => model.Meeting.MeetingID, htmlAttributes: new { @class = "control-label col-md-10" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-12\">\r\n\r\n                        ");
#nullable restore
#line 24 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
                   Write(Html.EditorFor(model => model.Meeting.MeetingID, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 25 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Meeting.MeetingID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"justify-content-center align-items-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 1231, "\"", 1239, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 34 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <!-- asp-for links the input text to a property of an object in the model-->\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
               Write(Html.LabelFor(model => model.Meeting.MeetingDate, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-12\">\r\n\r\n                        ");
#nullable restore
#line 40 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
                   Write(Html.EditorFor(model => model.Meeting.MeetingDate, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 41 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Meeting.MeetingDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"justify-content-center align-items-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 2094, "\"", 2102, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 48 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <!-- asp-for links the input text to a property of an object in the model-->\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
               Write(Html.LabelFor(model => model.Meeting.MeetingTime, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-12\">\r\n\r\n                        ");
#nullable restore
#line 54 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
                   Write(Html.EditorFor(model => model.Meeting.MeetingTime, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 55 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Meeting.MeetingTime, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"justify-content-center align-items-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 2957, "\"", 2965, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 62 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <!-- asp-for links the input text to a property of an object in the model-->\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 65 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
               Write(Html.LabelFor(model => model.Meeting.EmployeeID, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-12\">\r\n\r\n                        ");
#nullable restore
#line 68 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
                   Write(Html.EditorFor(model => model.Meeting.EmployeeID, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 69 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Meeting.EmployeeID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"justify-content-center align-items-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 3817, "\"", 3825, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 76 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <!-- asp-for links the input text to a property of an object in the model-->\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 79 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
               Write(Html.LabelFor(model => model.Meeting.MeetingType, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-12\">\r\n\r\n                        ");
#nullable restore
#line 82 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
                   Write(Html.EditorFor(model => model.Meeting.MeetingType, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 83 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Meeting.MeetingType, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"justify-content-center align-items-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 4680, "\"", 4688, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 90 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <!-- asp-for links the input text to a property of an object in the model-->\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 93 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
               Write(Html.LabelFor(model => model.Meeting.MeetingLocation, htmlAttributes: new { @class = "control-label col-md-5" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-12\">\r\n\r\n                        ");
#nullable restore
#line 96 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
                   Write(Html.EditorFor(model => model.Meeting.MeetingLocation, new { htmlAttributes = new { @class = "form-control form" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 97 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Meeting.MeetingLocation, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"justify-content-center align-items-center w-50\"");
                BeginWriteAttribute("style", " style=\"", 5561, "\"", 5569, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <div class=\"form-group\">\r\n                <div class=\" col-5\">\r\n                    <input type=\"submit\" value=\"Create Meeting\" class=\"btn btn-block btn-outline-light\" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    ");
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
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 118 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\CreateMeeting.cshtml"
Write(Html.ActionLink("Back to Home", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a0bc50bbcca84ada8581101adad348dbb2032f218597", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Schedlr.Pages.CreateMeetingModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Schedlr.Pages.CreateMeetingModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Schedlr.Pages.CreateMeetingModel>)PageContext?.ViewData;
        public Schedlr.Pages.CreateMeetingModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
