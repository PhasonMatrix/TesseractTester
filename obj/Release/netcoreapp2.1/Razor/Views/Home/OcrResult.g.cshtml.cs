#pragma checksum "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "268f8221292083d040f612a03c127e9da00ba2d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OcrResult), @"mvc.1.0.view", @"/Views/Home/OcrResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/OcrResult.cshtml", typeof(AspNetCore.Views_Home_OcrResult))]
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
#line 1 "/home/bishop/dotnet-projects/TesseractTester/Views/_ViewImports.cshtml"
using TesseractTester;

#line default
#line hidden
#line 2 "/home/bishop/dotnet-projects/TesseractTester/Views/_ViewImports.cshtml"
using TesseractTester.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"268f8221292083d040f612a03c127e9da00ba2d8", @"/Views/Home/OcrResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2746686d05c156196c424ae17faf08637553fdc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OcrResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Ocr", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("docImage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tess.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
  
    ViewData["Title"] = "OCR Result";

#line default
#line hidden
            BeginContext(43, 60, true);
            WriteLiteral("<br />\n<div class=\"row\">\n    <div class=\"col-md-5\">\n        ");
            EndContext();
            BeginContext(103, 323, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "935b66761c6c47bf8c5a1a551324481f", async() => {
                BeginContext(202, 217, true);
                WriteLiteral("\n            <label>Choose another file</label>\n            <input id=\"file\" type=\"file\" name=\"file\" accept=\"image/*\" style=\"display:inline\" />\n            <h4 id=\"uploading-message\" hidden>uploading ...</h4>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(426, 1723, true);
            WriteLiteral(@"
        <br />

        <div class=""document-details"">
            <div class=""display-options"">
                <div>
                    <span>Display options:</span>
                </div>
                <div>
                    <input type=""checkbox"" id=""blocks"" name=""displayOption"" value=""blocks"" />
                    <label for=""blocks"">Blocks</label>
                </div>
                <div>
                    <input type=""checkbox"" id=""paragraphs"" name=""displayOption"" value=""paragraphs"" />
                    <label for=""paragraphs"">Paragraphs</label>
                </div>
                <div>
                    <input type=""checkbox"" id=""lines"" name=""displayOption"" value=""lines"" />
                    <label for=""lines"">Lines</label>
                </div>
                <div>
                    <input type=""checkbox"" id=""words"" name=""displayOption"" value=""words"" checked />
                    <label for=""words"">Words</label>
                </div>
            </div>

            <div cl");
            WriteLiteral(@"ass=""panel-group"" id=""accordion"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapse1"">OCR Details</a>
                        </h4>
                    </div>

                    <div id=""collapse1"" class=""panel-collapse collapse in"">
                        <div class=""panel-body"">
                            <table class=""table table-condensed table-bordered"">
                                <tr>
                                    <td>Total Word Objects</td>
                                    <td>");
            EndContext();
            BeginContext(2150, 21, false);
#line 50 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
                                   Write(ViewData["WordCount"]);

#line default
#line hidden
            EndContext();
            BeginContext(2171, 185, true);
            WriteLiteral("</td>\n                                </tr>\n                                <tr>\n                                    <td>Average confidence</td>\n                                    <td>");
            EndContext();
            BeginContext(2357, 29, false);
#line 54 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
                                   Write(ViewData["AverageConfidence"]);

#line default
#line hidden
            EndContext();
            BeginContext(2386, 183, true);
            WriteLiteral("</td>\n                                </tr>\n                                <tr>\n                                    <td>Image dimensions</td>\n                                    <td>");
            EndContext();
            BeginContext(2570, 27, false);
#line 58 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
                                   Write(ViewData["ImageDimensions"]);

#line default
#line hidden
            EndContext();
            BeginContext(2597, 183, true);
            WriteLiteral("</td>\n                                </tr>\n                                <tr>\n                                    <td>Image resolution</td>\n                                    <td>");
            EndContext();
            BeginContext(2781, 27, false);
#line 62 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
                                   Write(ViewData["ImageResolution"]);

#line default
#line hidden
            EndContext();
            BeginContext(2808, 796, true);
            WriteLiteral(@"</td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>

                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapse2"">Raw TSV output from Tesseract 4.0</a>
                        </h4>
                    </div>
                    <div id=""collapse2"" class=""panel-collapse collapse"">
                        <div class=""panel-body"">
                            <p><i>Note: result from commandline: tesseract stdout -c tessedit_create_tsv=1</i></p>
                            <pre style=""font-size: 10px"">");
            EndContext();
            BeginContext(3605, 18, false);
#line 78 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
                                                    Write(ViewData["RawTsv"]);

#line default
#line hidden
            EndContext();
            BeginContext(3623, 583, true);
            WriteLiteral(@"</pre>
                        </div>
                    </div>
                </div>

                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapse3"">Page Text</a>
                        </h4>
                    </div>
                    <div id=""collapse3"" class=""panel-collapse collapse"">
                        <div class=""panel-body"">
                            <pre style=""font-size: 12px"">");
            EndContext();
            BeginContext(4207, 20, false);
#line 91 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
                                                    Write(ViewData["PageText"]);

#line default
#line hidden
            EndContext();
            BeginContext(4227, 686, true);
            WriteLiteral(@"</pre>
                        </div>
                    </div>
                </div>

                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapse4"">Results as JSON</a>
                        </h4>
                    </div>
                    <div id=""collapse4"" class=""panel-collapse collapse"">
                        <div class=""panel-body"">
                            <p><i>Note: Tesseract does not directly output data as JSON </i></p>
                            <pre style=""font-size: 10px"">");
            EndContext();
            BeginContext(4914, 20, false);
#line 105 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
                                                    Write(ViewData["JsonText"]);

#line default
#line hidden
            EndContext();
            BeginContext(4934, 361, true);
            WriteLiteral(@"</pre>
                        </div>
                    </div>
                </div>

            </div>
        </div>

        <div>
            <p><i>Note: Result can vary based on language used and specific parameters like ""page segementation mode"".</i></p>
        </div>
    </div>

    <div class=""col-md-7"">
        <div class=""doc-image-container"">
");
            EndContext();
#line 120 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
             if (ViewData["SampleImageFile"] != null)
            {

#line default
#line hidden
            BeginContext(5363, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(5379, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "330516a34d0640378a31725e91060688", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5389, "~/images/OcrSamples/", 5389, 20, true);
#line 122 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
AddHtmlAttributeValue("", 5409, ViewData["SampleImageFile"], 5409, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5477, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 123 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(5523, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(5539, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b923440950d548fea1c92c3a1f853d7e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5549, "~/UserFiles/", 5549, 12, true);
#line 126 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
AddHtmlAttributeValue("", 5561, ViewData["ImageFileName"], 5561, 26, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5627, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 127 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
            }

#line default
#line hidden
            BeginContext(5642, 176, true);
            WriteLiteral("\n            <canvas id=\"overlayCanvas\"></canvas>\n            <canvas id=\"docCanvas\"></canvas>\n        </div>\n    </div>\n</div>\n\n\n\n\n<div id=\"hoverDiv\" hidden>\n    TEST\n</div>\n\n");
            EndContext();
            BeginContext(5818, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45cfbff89a3f40d48499d8d12ce71e80", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5854, 213, true);
            WriteLiteral("\n<script>\n    document.getElementById(\"file\").onchange = function () {\n        document.getElementById(\"uploading-message\").hidden = false;\n        document.getElementById(\"form\").submit();\n    };\n\n    let json = ");
            EndContext();
            BeginContext(6068, 26, false);
#line 149 "/home/bishop/dotnet-projects/TesseractTester/Views/Home/OcrResult.cshtml"
          Write(Html.Raw(ViewData["Json"]));

#line default
#line hidden
            EndContext();
            BeginContext(6094, 110, true);
            WriteLiteral(";\n\n    window.onload = function () {\n        var documentView = new DocumentView(json);\n    }\n\n</script>\n\n\n\n\n\n");
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