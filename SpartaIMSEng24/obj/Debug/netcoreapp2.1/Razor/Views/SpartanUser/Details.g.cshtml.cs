#pragma checksum "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "528c6a955aa4c61310f241d9943ea4f6011d7c75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SpartanUser_Details), @"mvc.1.0.view", @"/Views/SpartanUser/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SpartanUser/Details.cshtml", typeof(AspNetCore.Views_SpartanUser_Details))]
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
#line 1 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\_ViewImports.cshtml"
using SpartaIMSEng24;

#line default
#line hidden
#line 2 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\_ViewImports.cshtml"
using SpartaIMSEng24.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528c6a955aa4c61310f241d9943ea4f6011d7c75", @"/Views/SpartanUser/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9dbc55202262d776b14f617dd8b775e49ef5ddb", @"/Views/_ViewImports.cshtml")]
    public class Views_SpartanUser_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpartaIMSEng24.Models.SpartanUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 125, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>SpartanUser</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(213, 45, false);
#line 14 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(258, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(302, 41, false);
#line 17 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(343, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(387, 44, false);
#line 20 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(431, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(475, 40, false);
#line 23 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(515, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(559, 41, false);
#line 26 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(600, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(644, 37, false);
#line 29 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(681, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(725, 44, false);
#line 32 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(769, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(813, 40, false);
#line 35 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(853, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(897, 44, false);
#line 38 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(941, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(985, 40, false);
#line 41 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1069, 42, false);
#line 44 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cohort));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1155, 47, false);
#line 47 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cohort.CohortID));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1246, 43, false);
#line 50 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobRole));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1333, 49, false);
#line 53 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobRole.JobRoleID));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1429, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b78e2c0f0cd404aac44a231a587cb9a", async() => {
                BeginContext(1482, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\tech-w105a\Desktop\Final_Project\Sparta-IMS-Eng24\SpartaIMSEng24\Views\SpartanUser\Details.cshtml"
                           WriteLiteral(Model.SpartanID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1490, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1498, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55b02964be18446a8bcd0f41706be7a8", async() => {
                BeginContext(1520, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1536, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpartaIMSEng24.Models.SpartanUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
