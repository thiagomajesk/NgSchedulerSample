#pragma checksum "C:\Users\thiag\Source\Repos\Scheduler\Scheduler.Web\Views\Home\_FormCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55c2980538fd73cf2bd40a8390baa8c366028b3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__FormCard), @"mvc.1.0.view", @"/Views/Home/_FormCard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_FormCard.cshtml", typeof(AspNetCore.Views_Home__FormCard))]
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
#line 1 "C:\Users\thiag\Source\Repos\Scheduler\Scheduler.Web\Views\_ViewImports.cshtml"
using Scheduler.Web;

#line default
#line hidden
#line 2 "C:\Users\thiag\Source\Repos\Scheduler\Scheduler.Web\Views\_ViewImports.cshtml"
using Scheduler.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c2980538fd73cf2bd40a8390baa8c366028b3a", @"/Views/Home/_FormCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2067d04338bc6408be4b91e26ae8231168d2041c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__FormCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-repeat", new global::Microsoft.AspNetCore.Html.HtmlString("name in patientNames"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "{{name}}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-submit", new global::Microsoft.AspNetCore.Html.HtmlString("form.$valid && manageAppointment(appointment)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 494, true);
            WriteLiteral(@"<div class=""card"" ng-class=""{'border-success': !isEditing(appointment), 'border-warning': isEditing(appointment)}"">
    <h5 class=""card-header text-white"" ng-class=""{'bg-success': !isEditing(appointment), 'bg-warning': isEditing(appointment)}"">
        <i class=""fa"" ng-class=""{'fa-plus-circle': !isEditing(appointment), 'fa-pencil': isEditing(appointment)}""></i>
        {{ !isEditing(appointment) ? 'New Appointment' : 'Edit Appointment'}}
    </h5>
    <div class=""card-body"">
        ");
            EndContext();
            BeginContext(494, 3356, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b772afe6b70342679b4e3ba6495f76c2", async() => {
                BeginContext(581, 213, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label>Patient: </label>\r\n                <select ng-model=\"appointment.patientName\" name=\"patientName\" class=\"custom-select\" required>\r\n                    ");
                EndContext();
                BeginContext(794, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05497dd13ae04b68b18d5d77d499ae2b", async() => {
                    BeginContext(832, 14, true);
                    WriteLiteral("Select Patient");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(855, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(877, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b6c88b327f746d599e88a0f2825f8a7", async() => {
                    BeginContext(935, 8, true);
                    WriteLiteral("{{name}}");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(952, 2891, true);
                WriteLiteral(@"
                </select>
                <div ng-messages=""form.patientName.$error"" ng-show=""form.patientName.$touched"">
                    <p class=""text-danger"" ng-message=""required"">The name of the patient is required</p>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""d-block"">Birthdate: </label>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">
                            <i class=""fa fa-calendar""></i>
                        </span>
                    </div>
                    <input class=""form-control"" ng-model=""appointment.patientBirthdate"" type=""date"" name=""patientBirthdate"" required />
                </div>
                <div ng-messages=""form.patientBirthdate.$error"" ng-show=""form.patientBirthdate.$touched"">
                    <p class=""text-danger"" ng-message=""required"">Is required</p>
                </div>
");
                WriteLiteral(@"            </div>
            <div class=""form-group"">
                <label for=""startDate"">Time: </label>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"">
                            <i class=""fa fa-clock-o""></i>
                        </span>
                    </div>
                    <input class=""form-control"" ng-model=""appointment.time"" name=""time"" placeholder=""HH:mm"" min=""09:00"" max=""18:00"" type=""time"" required />
                </div>
                <small>Office hours from 09:00 to 18:00</small>
                <div ng-messages=""form.time.$error"" ng-show=""form.time.$touched"">
                    <p class=""text-danger"" ng-message=""required"">Is required</p>
                    <p class=""text-danger"" ng-message=""min"">09:00 is the minimum</p>
                    <p class=""text-danger"" ng-message=""max"">18:00 is the maximum</p>
                </div>
            </div>
         ");
                WriteLiteral(@"   <div class=""form-group"">
                <label for=""remarks"">Remarks: </label>
                <textarea class=""form-control"" ng-model=""appointment.remarks"" name=""remarks"" maxlength=""50""></textarea>
                <div ng-messages=""form.remarks.$error"" ng-show=""form.remarks.$touched"">
                    <p class=""text-danger"" ng-message=""maxlength"">Please keep it simple, no more than 50 characters</p>
                </div>
            </div>
            <button class=""btn"" type=""submit"" ng-class=""{'btn-success btn-block': !isEditing(appointment), 'btn-warning': isEditing(appointment)}"">
                {{ !isEditing(appointment) ? 'Schedule' : 'Update   '}}
            </button>
            <button class=""btn btn-link"" ng-show=""isEditing(appointment)"" ng-click=""cancelEditing(appointment)""> Cancel</button>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3850, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
