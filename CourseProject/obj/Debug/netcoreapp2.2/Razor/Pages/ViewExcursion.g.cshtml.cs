#pragma checksum "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adb7fa59b292375f046ed3e8ba6bf92d064958df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CourseProject.Pages.Pages_ViewExcursion), @"mvc.1.0.razor-page", @"/Pages/ViewExcursion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ViewExcursion.cshtml", typeof(CourseProject.Pages.Pages_ViewExcursion), @"{initPage}/{userId}/{excId}")]
namespace CourseProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/_ViewImports.cshtml"
using CourseProject;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{initPage}/{userId}/{excId}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adb7fa59b292375f046ed3e8ba6bf92d064958df", @"/Pages/ViewExcursion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57f4487080d64efe0949fc97e3eebf70152abacc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ViewExcursion : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
  
    ViewData["Title"] = "ViewExcursion";

#line default
#line hidden
            BeginContext(133, 24, true);
            WriteLiteral("\r\n<h1 class=\"display-4\">");
            EndContext();
            BeginContext(158, 21, false);
#line 7 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
                 Write(Model.Excursion.Title);

#line default
#line hidden
            EndContext();
            BeginContext(179, 32, true);
            WriteLiteral("</h1> <br />\r\n<h3><u>Price</u>: ");
            EndContext();
            BeginContext(212, 21, false);
#line 8 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
             Write(Model.Excursion.Price);

#line default
#line hidden
            EndContext();
            BeginContext(233, 90, true);
            WriteLiteral(" $</h3> <br />\r\n<h3>Tours, which include current excursion <span class=\"badge badge-info\">");
            EndContext();
            BeginContext(324, 23, false);
#line 9 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
                                                                     Write(Model.ChosenTours.Count);

#line default
#line hidden
            EndContext();
            BeginContext(347, 290, true);
            WriteLiteral(@"</span></h3>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Title</th>
            <th scope=""col"">Duration</th>
            <th scope=""col"">Start</th>
            <th scope=""col"">End</th>
        </tr>
    </thead>
");
            EndContext();
#line 20 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
     for (int i = 0; i < Model.ChosenTours.Count; i++)
    {

#line default
#line hidden
            BeginContext(700, 42, true);
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
            EndContext();
            BeginContext(744, 5, false);
#line 23 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
                        Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(750, 23, true);
            WriteLiteral("</th>\r\n            <td>");
            EndContext();
            BeginContext(774, 26, false);
#line 24 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
           Write(Model.ChosenTours[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(800, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(824, 29, false);
#line 25 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
           Write(Model.ChosenTours[i].Duration);

#line default
#line hidden
            EndContext();
            BeginContext(853, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(878, 58, false);
#line 26 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
            Write(((DateTime)Model.ChosenTours[i].Start).ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(937, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(962, 56, false);
#line 27 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
            Write(((DateTime)Model.ChosenTours[i].End).ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1019, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 29 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
    }

#line default
#line hidden
            BeginContext(1048, 17, true);
            WriteLiteral("</table> <br />\r\n");
            EndContext();
            BeginContext(1065, 228, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adb7fa59b292375f046ed3e8ba6bf92d064958df8307", async() => {
                BeginContext(1085, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1091, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "adb7fa59b292375f046ed3e8ba6bf92d064958df8689", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 32 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1123, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1129, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "adb7fa59b292375f046ed3e8ba6bf92d064958df10628", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 33 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Excursion.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1168, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1174, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "adb7fa59b292375f046ed3e8ba6bf92d064958df12574", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 34 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/ViewExcursion.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.InitialPage);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1212, 74, true);
                WriteLiteral("\r\n    <button type=\"submit\" class=\"btn-lg btn-secondary\">Return</button>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1293, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseProject.Pages.ViewExcursionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CourseProject.Pages.ViewExcursionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CourseProject.Pages.ViewExcursionModel>)PageContext?.ViewData;
        public CourseProject.Pages.ViewExcursionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591