#pragma checksum "C:\Users\ravan\Documents\Learnings\Dot Net Core\Code\HangFire-MicroUI-Service\HangFire-MicroUI-Service.Web\Views\HangFireMicroUI\GetJobs - Copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b141e91c6c4d89f40192471c08bb89fe84297827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HangFireMicroUI_GetJobs___Copy), @"mvc.1.0.view", @"/Views/HangFireMicroUI/GetJobs - Copy.cshtml")]
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
#line 1 "C:\Users\ravan\Documents\Learnings\Dot Net Core\Code\HangFire-MicroUI-Service\HangFire-MicroUI-Service.Web\Views\_ViewImports.cshtml"
using HangFire_MicroUI_Service.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ravan\Documents\Learnings\Dot Net Core\Code\HangFire-MicroUI-Service\HangFire-MicroUI-Service.Web\Views\_ViewImports.cshtml"
using HangFire_MicroUI_Service.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ravan\Documents\Learnings\Dot Net Core\Code\HangFire-MicroUI-Service\HangFire-MicroUI-Service.Web\Views\HangFireMicroUI\GetJobs - Copy.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b141e91c6c4d89f40192471c08bb89fe84297827", @"/Views/HangFireMicroUI/GetJobs - Copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7b19d425e5452dec02eac138eb1ec717947e351", @"/Views/_ViewImports.cshtml")]
    public class Views_HangFireMicroUI_GetJobs___Copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HangFire_MicroUI_Service.Web.ViewModels.JobListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/angularJS/angular.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "male", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "female", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b141e91c6c4d89f40192471c08bb89fe842978274772", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    var hashApp = angular.module('hashApp', []);
    hashApp.controller(""hangFireMicroUI"", function ($scope, $http) {
        $scope.ButtonClick = function () {
            var hash = {
                Key: 'recurring - job: Debug.WriteLine',
                Value: '* * * * *'
            };

            console.log(hash);

            var post = $http({
                method: ""POST"",
                url: ""/HangFireMicroUI/UpdateJobDetails"",
                dataType: 'json',
                data: { hash: hash },
                headers: { ""Content-Type"": ""application/json"" }
            });
            //post.success(function (data, status) {
            //    alert('Job data saved successfully.');
            //});

            //post.error(function (data, status) {
            //    alert('Error occured.');
            //});

        };
    });
</script>

<div ng-app=""hashApp"">
    <div ng-controller=""hangFireMicroUI"" class=""container"">
        <div class=""row"">
");
            WriteLiteral("            <div class=\"col-4\">\r\n                <label>\r\n                    Job Name\r\n                </label>\r\n            </div>\r\n            <div class=\"col-8\">\r\n");
            WriteLiteral("                <select id=\"JobId\" ng-model=\"Key\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b141e91c6c4d89f40192471c08bb89fe842978277173", async() => {
                WriteLiteral("recurring-job:Debug.WriteLine");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b141e91c6c4d89f40192471c08bb89fe842978278375", async() => {
                WriteLiteral("recurring-job:HomeController.CallJobMethod");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </select>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-4"">
                <label>
                    Cron
                </label>
            </div>
            <div class=""col-8"">
                <input type=""text"" id=""cron"" ng-model=""Value"" />
            </div>
        </div>
        <div class=""row"">
            <div class=""col-4"">
                <input type=""button"" value=""Submit"" ng-click=""ButtonClick()"" />
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HangFire_MicroUI_Service.Web.ViewModels.JobListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591