#pragma checksum "D:\GECP Frontend C#\GECP\GECP\Views\Home\ContactUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc85718710b91148e2b2e8a32f095527eae6a4b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactUs), @"mvc.1.0.view", @"/Views/Home/ContactUs.cshtml")]
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
#line 1 "D:\GECP Frontend C#\GECP\GECP\Views\_ViewImports.cshtml"
using GECP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GECP Frontend C#\GECP\GECP\Views\_ViewImports.cshtml"
using GECP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc85718710b91148e2b2e8a32f095527eae6a4b6", @"/Views/Home/ContactUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ef4423e6f56f81b0c8a8f9e526f6ce382dd6d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("gsr-contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onSubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return valid_datas( this );"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\GECP Frontend C#\GECP\GECP\Views\Home\ContactUs.cshtml"
  
    ViewBag.Title = "ContactUs";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page_title3"">
    <div class=""container"">

        <h1>
            Contact Us<em>Government Engineering College</em>

        </h1>
        <div class=""line""></div>
    </div>
</div>

<div class=""content_fullwidth less2"">
    <div class=""container"">
        <div class=""one_half"">
            <p>Feel free to talk to our online representative at any time you please using our Live Chat system on our website or one of the below instant messaging programs.</p>
            <br />
            <br /><br />

            <div class=""cforms"">
                <div id=""form_status""></div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc85718710b91148e2b2e8a32f095527eae6a4b65029", async() => {
                WriteLiteral(@"
                    <label class=""label"">Name <em>*</em></label>
                    <label class=""input"">
                        <input type=""text"" name=""name"" id=""name"">
                    </label>
                    <div class=""clearfix""></div>
                    <label class=""label"">E-mail <em>*</em></label>
                    <label class=""input"">
                        <input type=""email"" name=""email"" id=""email"">
                    </label>

                    <div class=""clearfix""></div>

                    <label class=""label"">Phone <em>*</em></label>
                    <label class=""input"">
                        <input type=""text"" name=""phone"" id=""phone"">
                    </label>

                    <div class=""clearfix""></div>

                    <label class=""label cforms input"">Message <em>*</em></label>
                    <label class=""textarea"">
                        <textarea rows=""5"" name=""message"" id=""message""></textarea>
                    </labe");
                WriteLiteral("l>\r\n\r\n                    <div class=\"clearfix\"></div>\r\n                    <input type=\"hidden\" name=\"token\"");
                BeginWriteAttribute("value", " value=\"", 1880, "\"", 1888, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <button type=\"submit\" class=\"button\">Send Message</button>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            WriteLiteral(@"
            </div>
        </div>

        <div class=""one_half last"">

            <div class=""address_info"">

                <h4><strong>CONTACT INFO</strong></h4>
                <ul>
                    <li>
                        <strong>GOVERNMENT ENGINEERING COLLEGE,AT. KATPUR, PATAN</strong>
                        <br /> phone: 2766291560<br /> E-mail:
                        <a href=""http://www.gecpt.cteguj.in/"">principalgecpatan@gmail.com</a><br /> Website: <a href=""index.html"">www.yoursitename.com</a>
                    </li>
                </ul>
            </div>
            <div class=""clearfix""></div>
            <h4>Find the <strong>Address</strong></h4>
");
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</div>\r\n<!-- end content area -->\r\n\r\n<div class=\"clearfix margin_top12\"></div>\r\n\r\n\r\n\r\n<a href=\"#\" class=\"scrollup\">Scroll</a>\r\n<!-- end scroll to top of the page-->\r\n");
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
