#pragma checksum "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/Shared/_SearchTourPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c006788fc64ec7a66bb1f00c6293e40e1086971"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CourseProject.Pages.Shared.Pages_Shared__SearchTourPartial), @"mvc.1.0.view", @"/Pages/Shared/_SearchTourPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_SearchTourPartial.cshtml", typeof(CourseProject.Pages.Shared.Pages_Shared__SearchTourPartial))]
namespace CourseProject.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c006788fc64ec7a66bb1f00c6293e40e1086971", @"/Pages/Shared/_SearchTourPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57f4487080d64efe0949fc97e3eebf70152abacc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__SearchTourPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CourseProject.Models.Tour>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 242, true);
            WriteLiteral("<h2>Search for tours</h2>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Title</th>\r\n            <th scope=\"col\">Duration</th>\r\n            <th scope=\"col\">Price</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 12 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/Shared/_SearchTourPartial.cshtml"
         foreach (var tour in Model)
        {

#line default
#line hidden
            BeginContext(331, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(370, 10, false);
#line 15 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/Shared/_SearchTourPartial.cshtml"
               Write(tour.Title);

#line default
#line hidden
            EndContext();
            BeginContext(380, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 16 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/Shared/_SearchTourPartial.cshtml"
                 if (tour.Duration == 1)
                {

#line default
#line hidden
            BeginContext(448, 36, true);
            WriteLiteral("                    <td>1 day</td>\r\n");
            EndContext();
#line 19 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/Shared/_SearchTourPartial.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(544, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(569, 13, false);
#line 22 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/Shared/_SearchTourPartial.cshtml"
                   Write(tour.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(582, 12, true);
            WriteLiteral(" days</td>\r\n");
            EndContext();
#line 23 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/Shared/_SearchTourPartial.cshtml"
                }

#line default
#line hidden
            BeginContext(613, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(634, 10, false);
#line 24 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/Shared/_SearchTourPartial.cshtml"
               Write(tour.Price);

#line default
#line hidden
            EndContext();
            BeginContext(644, 28, true);
            WriteLiteral(" $</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "/Users/romantarasov/Desktop/NURE/Course 1/II term/OOP/CourseProject/Project/CourseProject/Pages/Shared/_SearchTourPartial.cshtml"
        }

#line default
#line hidden
            BeginContext(683, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CourseProject.Models.Tour>> Html { get; private set; }
    }
}
#pragma warning restore 1591