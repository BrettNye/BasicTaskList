#pragma checksum "G:\PersonalProjects\To-Do_WebApplication\TaskList\Nye_TaskList\Pages\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "815850a09e65d6d1ffa0bd2907f0f3469293fd66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nye_TaskList.Pages.Pages_Register), @"mvc.1.0.razor-page", @"/Pages/Register.cshtml")]
namespace Nye_TaskList.Pages
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
#line 1 "G:\PersonalProjects\To-Do_WebApplication\TaskList\Nye_TaskList\Pages\_ViewImports.cshtml"
using Nye_TaskList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815850a09e65d6d1ffa0bd2907f0f3469293fd66", @"/Pages/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f50b6a9bd26da88bce30038bd1102e23870128b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Register : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Register"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "G:\PersonalProjects\To-Do_WebApplication\TaskList\Nye_TaskList\Pages\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<div id=""registerpage"" class=""row d-flex vh-100 mt-5"">
    <div class=""container col-md-2"">
        <section>
            <h2>Register</h2>
            <hr />
            <div id=""Problem""></div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "815850a09e65d6d1ffa0bd2907f0f3469293fd664563", async() => {
                WriteLiteral(@"
                <div class=""text-danger""></div>
                <div class=""form-group"">
                    <label for=""username"">Username</label>
                    <input id=""username"" name=""username"" class=""form-control"" />
                    <div for=""username"" class=""text-danger""></div>
                </div>
                <div class=""form-group"">
                    <label for=""email"">Email</label>
                    <input id=""email"" name=""email"" type=""email"" class=""form-control"" runat=""server"" />
                    <div for=""email"" class=""text-danger""></div>
                </div>
                <div class=""form-group"">
                    <label for=""password"">Password</label>
                    <input id=""password"" type=""password"" name=""Password""
                           class=""form-control"" runat=""server"" />
                    <div for=""password"" class=""text-danger""></div>
                </div>
                <div class=""form-group"">
                    <label for=");
                WriteLiteral(@"""password2"">Confirm Password</label>
                    <input id=""password2"" type=""password"" name=""Password2""
                           class=""form-control"" />
                    <div for=""password2"" class=""text-danger""></div>
                </div>
                <div id=""message"" class=""mt-1 mb-2""></div>
                <div class=""form-group"">
                    <button id=""subReg"" type=""submit"" class=""btn btn-light"" disabled>
                        Register
                    </button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </section>
    </div>
</div>
<script>
    $(document).ready(function () {
        $(""#password2"").keyup(function () {
            if ($(""#password"").val() != $(""#password2"").val()) {
                $(""#message"").text(""Passwords do not match"").css(""color"", ""red"");
            } else {
                $(""#message"").text(""Passords match"").css(""color"", ""green"");
                $(""#subReg"").removeAttr(""disabled"");
            }
        });
    });

    function RegisterUser() {
        $.ajax({
            type: ""POST"",
            url: '/Register?handler=Register',
            beforeSend: function (xhr) {
                xhr.setRequestHeader(""XSRF-TOKEN"",
                    $('input:hidden""[name=""__RequestVerficationToken""]').val());
            }
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nye_TaskList.Pages.RegisterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nye_TaskList.Pages.RegisterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nye_TaskList.Pages.RegisterModel>)PageContext?.ViewData;
        public Nye_TaskList.Pages.RegisterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591