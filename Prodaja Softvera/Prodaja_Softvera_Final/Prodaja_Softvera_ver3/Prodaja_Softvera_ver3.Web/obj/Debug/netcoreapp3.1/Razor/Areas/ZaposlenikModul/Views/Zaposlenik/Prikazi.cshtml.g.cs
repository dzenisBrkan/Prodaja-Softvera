#pragma checksum "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c76bad358c982a9da173e928396b55078d4dc10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ZaposlenikModul_Views_Zaposlenik_Prikazi), @"mvc.1.0.view", @"/Areas/ZaposlenikModul/Views/Zaposlenik/Prikazi.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\_ViewImports.cshtml"
using Prodaja_Softvera_ver3.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
using Prodaja_Softvera_ver3.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c76bad358c982a9da173e928396b55078d4dc10", @"/Areas/ZaposlenikModul/Views/Zaposlenik/Prikazi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1c795925c50bfc8786bf60c15a71244b13b1c48", @"/Areas/ZaposlenikModul/Views/_ViewImports.cshtml")]
    public class Areas_ZaposlenikModul_Views_Zaposlenik_Prikazi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZaposlenikPrikaziVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Obrisi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Zaposlenik", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UrediForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DodajForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
  
    ViewData["Title"] = "Prikazi";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var porukaSuccess = (string)TempData["porukaSuccess"];
    var porukaWarning = (string)TempData["porukaWarning"];
    var porukaError = (string)TempData["porukaError"];
    Layout = "~/Areas/ZaposlenikModul/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
 if (porukaError != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\" id=\"porukaBox\">\r\n        ");
#nullable restore
#line 16 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
   Write(porukaError);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
 if (porukaWarning != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\" id=\"porukaBox\">\r\n        ");
#nullable restore
#line 23 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
   Write(porukaWarning);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
 if (porukaSuccess != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\" id=\"porukaBox\">\r\n        ");
#nullable restore
#line 30 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
   Write(porukaSuccess);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"content-wrapper p-2\">\r\n    <h1 class=\"display-4\">Prikaži zaposlenike</h1><br /><br />\r\n    <table class=\"table\" ");
            WriteLiteral(@">
        <thead class=""thead-dark"">
            <tr>
                <th>Naziv</th>
                <th>Email</th>
                <th>Kontakt broj</th>
                <th>Datum rođenja</th>
                <th>Spol</th>
                <th>Grad</th>
                <th>Fakultet</th>
                <th>Tip zaposlenika</th>
                <th>Broj softvera</th>
                <th>Akcija</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 54 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
             foreach (ZaposlenikPrikaziViewModel x in Model.podaciZaHtmlTabelu)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                   Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                   Write(x.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                   Write(x.Kontakt_br);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                   Write(x.Datum_rodjenja);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                   Write(x.Spol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 63 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                         if (x.Grad == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label> Nema zapisa</label>\r\n");
#nullable restore
#line 66 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>");
#nullable restore
#line 69 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                              Write(x.Grad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 70 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 73 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                         if (x.Fakultet == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>Nema zapisa</label>\r\n");
#nullable restore
#line 76 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>");
#nullable restore
#line 79 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                              Write(x.Fakultet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 80 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 83 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                         if (x.TipZaposlenika == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>Nema zapisa</label>\r\n");
#nullable restore
#line 86 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>");
#nullable restore
#line 89 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                              Write(x.TipZaposlenika);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 90 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>");
#nullable restore
#line 92 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                   Write(x.BrojSoftvera);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c76bad358c982a9da173e928396b55078d4dc1017582", async() => {
                WriteLiteral("Obriši");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                                                                             WriteLiteral(x.ZaposlenikID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c76bad358c982a9da173e928396b55078d4dc1020191", async() => {
                WriteLiteral("Uredi");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
                                                                                WriteLiteral(x.ZaposlenikID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 98 "C:\Users\User\OneDrive\Desktop\Prodaja Softvera\Prodaja_Softvera_verzija3 NOVO\Prodaja_Softvera_ver3\Prodaja_Softvera_ver3.Web\Areas\ZaposlenikModul\Views\Zaposlenik\Prikazi.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c76bad358c982a9da173e928396b55078d4dc1023184", async() => {
                WriteLiteral("Dodaj novog zaposlenika");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZaposlenikPrikaziVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
