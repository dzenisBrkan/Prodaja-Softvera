#pragma checksum "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa1c127c72d458095523d69f462365feb17d642"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdministratorModul_Views_TipZaposlenika_Dodaj), @"mvc.1.0.view", @"/Areas/AdministratorModul/Views/TipZaposlenika/Dodaj.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\_ViewImports.cshtml"
using Prodaja_Softvera_ver3.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\_ViewImports.cshtml"
using Prodaja_Softvera_ver3.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
using Prodaja_Softvera_ver3.Web.Areas.AdministratorModul.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa1c127c72d458095523d69f462365feb17d642", @"/Areas/AdministratorModul/Views/TipZaposlenika/Dodaj.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1020a9d58bfb8df98d3c5a402938537697a2c9c", @"/Areas/AdministratorModul/Views/_ViewImports.cshtml")]
    public class Areas_AdministratorModul_Views_TipZaposlenika_Dodaj : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Prodaja_Softvera_ver3.Web.Areas.AdministratorModul.ViewModels.TipZaposlenikaDodajVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Snimi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
  
    ViewData["Title"] = "Dodaj";
    var porukaSuccess = (string)TempData["porukaSuccess"];
    var porukaWarning = (string)TempData["porukaWarning"];
    var porukaError = (string)TempData["porukaError"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Dodaj</h1>\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
 if (porukaError != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\" id=\"porukaBox\">\r\n        ");
#nullable restore
#line 18 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
   Write(porukaError);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
 if (porukaWarning != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\" id=\"porukaBox\">\r\n        ");
#nullable restore
#line 25 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
   Write(porukaWarning);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 27 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
 if (porukaSuccess != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\" id=\"porukaBox\">\r\n        ");
#nullable restore
#line 32 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
   Write(porukaSuccess);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa1c127c72d458095523d69f462365feb17d6428799", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "baa1c127c72d458095523d69f462365feb17d6429061", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 39 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TipZaposlenikaID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n\r\n");
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label>TipZaposlenikaID:</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa1c127c72d458095523d69f462365feb17d64211158", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 48 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TipZaposlenikaID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 48 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.TipZaposlenika;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Fakultet:</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa1c127c72d458095523d69f462365feb17d64213553", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 54 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FakultetID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 54 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Fakultet;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            <label>Grad:</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa1c127c72d458095523d69f462365feb17d64215936", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 61 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GradID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 61 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Grad;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Drzava:</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa1c127c72d458095523d69f462365feb17d64218309", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 67 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DrzavaID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 67 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\AdministratorModul\Views\TipZaposlenika\Dodaj.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Drzava;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n\r\n\r\n        <input type=\"submit\" class=\"btn btn-success btn-lg\" value=\"Snimi\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Prodaja_Softvera_ver3.Web.Areas.AdministratorModul.ViewModels.TipZaposlenikaDodajVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
