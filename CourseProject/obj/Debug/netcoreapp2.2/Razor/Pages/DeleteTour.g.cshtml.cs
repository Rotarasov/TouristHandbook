#pragma checksum "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d72a04fb1bda3c5a98a53f2d31439e1c57b698a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CourseProject.Pages.Pages_DeleteTour), @"mvc.1.0.razor-page", @"/Pages/DeleteTour.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/DeleteTour.cshtml", typeof(CourseProject.Pages.Pages_DeleteTour), @"{userId}/{tourId}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{userId}/{tourId}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d72a04fb1bda3c5a98a53f2d31439e1c57b698a", @"/Pages/DeleteTour.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57f4487080d64efe0949fc97e3eebf70152abacc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DeleteTour : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-lg btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-lg btn-secondary ml-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
  
    ViewData["Title"] = "DeleteTour";

#line default
#line hidden
            BeginContext(117, 24, true);
            WriteLiteral("\r\n<h1 class=\"display-4\">");
            EndContext();
            BeginContext(142, 16, false);
#line 7 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
                 Write(Model.Tour.Title);

#line default
#line hidden
            EndContext();
            BeginContext(158, 34, true);
            WriteLiteral("</h1> <br />\r\n<h3><u>Country</u>: ");
            EndContext();
            BeginContext(193, 23, false);
#line 8 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
               Write(Model.Converter.Country);

#line default
#line hidden
            EndContext();
            BeginContext(216, 31, true);
            WriteLiteral("</h3> <br />\r\n<h3><u>City</u>: ");
            EndContext();
            BeginContext(248, 20, false);
#line 9 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
            Write(Model.Converter.City);

#line default
#line hidden
            EndContext();
            BeginContext(268, 42, true);
            WriteLiteral("</h3> <br />\r\n<h3>\r\n    <u>Duration</u>:\r\n");
            EndContext();
#line 12 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
     if (Model.Tour.Duration == 1)
    {

#line default
#line hidden
            BeginContext(353, 14, true);
            WriteLiteral("        <span>");
            EndContext();
            BeginContext(368, 19, false);
#line 14 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
         Write(Model.Tour.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(387, 13, true);
            WriteLiteral(" day</span>\r\n");
            EndContext();
#line 15 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(424, 14, true);
            WriteLiteral("        <span>");
            EndContext();
            BeginContext(439, 19, false);
#line 18 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
         Write(Model.Tour.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(458, 14, true);
            WriteLiteral(" days</span>\r\n");
            EndContext();
#line 19 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
    }

#line default
#line hidden
            BeginContext(479, 32, true);
            WriteLiteral("</h3> <br />\r\n<h3><u>Start</u>: ");
            EndContext();
            BeginContext(513, 48, false);
#line 21 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
              Write(((DateTime)Model.Tour.Start).ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(562, 30, true);
            WriteLiteral("</h3> <br />\r\n<h3><u>End</u>: ");
            EndContext();
            BeginContext(594, 46, false);
#line 22 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
            Write(((DateTime)Model.Tour.End).ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(641, 49, true);
            WriteLiteral("</h3> <br />\r\n<h3><u>Price</u>: <span id=\"price\">");
            EndContext();
            BeginContext(691, 16, false);
#line 23 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
                              Write(Model.Tour.Price);

#line default
#line hidden
            EndContext();
            BeginContext(707, 48, true);
            WriteLiteral("</span> $</h3> <br />\r\n<h3><u>Accomodation</u>: ");
            EndContext();
            BeginContext(756, 28, false);
#line 24 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
                    Write(Model.Converter.Accomodation);

#line default
#line hidden
            EndContext();
            BeginContext(784, 39, true);
            WriteLiteral("</h3> <br />\r\n<h3><u>Travel Style</u>: ");
            EndContext();
            BeginContext(824, 22, false);
#line 25 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
                    Write(Model.Tour.TravelStyle);

#line default
#line hidden
            EndContext();
            BeginContext(846, 92, true);
            WriteLiteral("</h3> <br />\r\n<h3>Travel Agencies which provide current tour <span class=\"badge badge-info\">");
            EndContext();
            BeginContext(939, 24, false);
#line 26 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
                                                                         Write(Model.ChosenAgency.Count);

#line default
#line hidden
            EndContext();
            BeginContext(963, 169, true);
            WriteLiteral("</span></h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">Title</th>\r\n        </tr>\r\n    </thead>\r\n");
            EndContext();
#line 34 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
     for (int i = 0; i < Model.ChosenAgency.Count; i++)
    {

#line default
#line hidden
            BeginContext(1196, 42, true);
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
            EndContext();
            BeginContext(1240, 5, false);
#line 37 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
                        Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 23, true);
            WriteLiteral("</th>\r\n            <td>");
            EndContext();
            BeginContext(1270, 27, false);
#line 38 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
           Write(Model.ChosenAgency[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(1297, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 40 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
    }

#line default
#line hidden
            BeginContext(1326, 89, true);
            WriteLiteral("</table> <br />\r\n<h3>Available excursions in current tour <span class=\"badge badge-info\">");
            EndContext();
            BeginContext(1416, 28, false);
#line 42 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
                                                                   Write(Model.ChosenExcursions.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1444, 209, true);
            WriteLiteral("</span></h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">Title</th>\r\n            <th scope=\"col\">Price</th>\r\n        </tr>\r\n    </thead>\r\n");
            EndContext();
#line 51 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
     for (int i = 0; i < Model.ChosenExcursions.Count; i++)
    {

#line default
#line hidden
            BeginContext(1721, 42, true);
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
            EndContext();
            BeginContext(1765, 5, false);
#line 54 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
                        Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1771, 23, true);
            WriteLiteral("</th>\r\n            <td>");
            EndContext();
            BeginContext(1795, 31, false);
#line 55 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
           Write(Model.ChosenExcursions[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(1826, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1850, 31, false);
#line 56 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
           Write(Model.ChosenExcursions[i].Price);

#line default
#line hidden
            EndContext();
            BeginContext(1881, 24, true);
            WriteLiteral(" $</td>\r\n        </tr>\r\n");
            EndContext();
#line 58 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
    }

#line default
#line hidden
            BeginContext(1912, 17, true);
            WriteLiteral("</table> <br />\r\n");
            EndContext();
            BeginContext(1929, 485, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d72a04fb1bda3c5a98a53f2d31439e1c57b698a15531", async() => {
                BeginContext(1949, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1955, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7d72a04fb1bda3c5a98a53f2d31439e1c57b698a15914", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 61 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tour.Id);

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
                BeginContext(1989, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1995, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7d72a04fb1bda3c5a98a53f2d31439e1c57b698a17852", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 62 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
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
                BeginContext(2028, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2034, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d72a04fb1bda3c5a98a53f2d31439e1c57b698a19789", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 63 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tour.AgenciesId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 63 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.AgencySelectOptions;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2122, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2128, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d72a04fb1bda3c5a98a53f2d31439e1c57b698a22214", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 64 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tour.ExcursionsId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 64 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/DeleteTour.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ExcursionSelectOptions;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2221, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2227, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d72a04fb1bda3c5a98a53f2d31439e1c57b698a24644", async() => {
                    BeginContext(2287, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2302, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2308, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d72a04fb1bda3c5a98a53f2d31439e1c57b698a26199", async() => {
                    BeginContext(2390, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
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
                BeginContext(2405, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2414, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseProject.Pages.DeleteTourModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CourseProject.Pages.DeleteTourModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CourseProject.Pages.DeleteTourModel>)PageContext?.ViewData;
        public CourseProject.Pages.DeleteTourModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591