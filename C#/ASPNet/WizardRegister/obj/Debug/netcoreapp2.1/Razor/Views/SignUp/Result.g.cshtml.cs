#pragma checksum "C:\Users\Daenatal\Desktop\FullStack\C#\ASPNet\WizardRegister\Views\SignUp\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48357877a4d9b870cc271144b63a7e231b7f01a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SignUp_Result), @"mvc.1.0.view", @"/Views/SignUp/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SignUp/Result.cshtml", typeof(AspNetCore.Views_SignUp_Result))]
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
#line 1 "C:\Users\Daenatal\Desktop\FullStack\C#\ASPNet\WizardRegister\Views\SignUp\Result.cshtml"
using WizardRegister.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48357877a4d9b870cc271144b63a7e231b7f01a4", @"/Views/SignUp/Result.cshtml")]
    public class Views_SignUp_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wizard>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 29, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    ");
            EndContext();
            BeginContext(74, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25259b747a0d4640af72c3a70f77ece2", async() => {
                BeginContext(80, 77, true);
                WriteLiteral("\r\n        <title>Wizard Display</title>\r\n        <meta charset=\'utc-8\'>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(164, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(170, 227, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b4f785836d54cdea2864db0c38bf07e", async() => {
                BeginContext(176, 105, true);
                WriteLiteral("\r\n        <h1>Welcome to Wizard Display</h1>\r\n        <h2>Student details below: </h2>\r\n        <p>Name: ");
                EndContext();
                BeginContext(282, 10, false);
#line 12 "C:\Users\Daenatal\Desktop\FullStack\C#\ASPNet\WizardRegister\Views\SignUp\Result.cshtml"
            Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(292, 24, true);
                WriteLiteral("</p>\r\n        <p>House: ");
                EndContext();
                BeginContext(317, 11, false);
#line 13 "C:\Users\Daenatal\Desktop\FullStack\C#\ASPNet\WizardRegister\Views\SignUp\Result.cshtml"
             Write(Model.House);

#line default
#line hidden
                EndContext();
                BeginContext(328, 31, true);
                WriteLiteral("</p>\r\n        <p>Current Year: ");
                EndContext();
                BeginContext(360, 17, false);
#line 14 "C:\Users\Daenatal\Desktop\FullStack\C#\ASPNet\WizardRegister\Views\SignUp\Result.cshtml"
                    Write(Model.CurrentYear);

#line default
#line hidden
                EndContext();
                BeginContext(377, 13, true);
                WriteLiteral("</p>   \r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(397, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wizard> Html { get; private set; }
    }
}
#pragma warning restore 1591