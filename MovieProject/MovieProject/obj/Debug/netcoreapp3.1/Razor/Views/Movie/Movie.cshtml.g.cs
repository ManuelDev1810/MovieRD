#pragma checksum "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/Movie/Movie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e413f496587aefc958b3fdff39935d8761e007ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Movie), @"mvc.1.0.view", @"/Views/Movie/Movie.cshtml")]
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
#line 1 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/_ViewImports.cshtml"
using MovieProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/_ViewImports.cshtml"
using MovieProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e413f496587aefc958b3fdff39935d8761e007ad", @"/Views/Movie/Movie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5444d2674df61fe787d5285d833f41ec6d7dd278", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Movie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"d-flex justify-content-between align-items-end\">\n    <h5 class=\"my-0 border-bottom border-dark mb-3\" style=\"font-style: italic; font-family: \'Kufam\';\">Movie: ");
#nullable restore
#line 4 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/Movie/Movie.cshtml"
                                                                                                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n    <h5 class=\"my-0 border-bottom border-dark mb-3\" style=\"font-style: italic; font-family: \'Kufam\';\">Views: ");
#nullable restore
#line 5 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/Movie/Movie.cshtml"
                                                                                                        Write(Model.Views.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n</div>\n\n<iframe width=\"1110\" height=\"700\" frameborder=\"0\"");
            BeginWriteAttribute("src", " src=\"", 396, "\"", 417, 1);
#nullable restore
#line 8 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/Movie/Movie.cshtml"
WriteAttributeValue("", 402, Model.UrlVideo, 402, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" allowfullscreen></iframe>\n\n<div class=\"row d-flex justify-content-between\">\n    <div class=\"col-6\">\n        <div class=\"card\">\n            <div class=\"card-body\">\n                <h5 class=\"card-title\">Sinopsis</h5>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e413f496587aefc958b3fdff39935d8761e007ad5680", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 15 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/Movie/Movie.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Sinopsis);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
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
    </div>
    <div class=""col-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Information of the movie</h5>
                <table class=""table table"">
                    <tbody>
                        <tr>
                            <td>Duration:</td>
                            <td>");
#nullable restore
#line 27 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/Movie/Movie.cshtml"
                           Write(Model.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <td>Rating:</td>\n                            <td>");
#nullable restore
#line 31 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/Movie/Movie.cshtml"
                           Write(Model.Rating.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <td>Release</td>\n                            <td>");
#nullable restore
#line 35 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/Movie/Movie.cshtml"
                           Write(Model.Release.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>


<div class=""card mt-2"">
    <h5 class=""card-header"">Comentarios</h5>
    <div class=""card-body"">
        <h5 class=""card-title"">Favor introduce tu comentario</h5>

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e413f496587aefc958b3fdff39935d8761e007ad9389", async() => {
                WriteLiteral(@"
            <div class=""form-row align-items-center"">
                <div class=""col-sm-2 my-1"">
                    <label class=""sr-only"" for=""inlineFormInputName"">Name</label>
                    <input type=""text"" class=""form-control"" id=""nameOfPersonComment"" placeholder=""Nombre"">
                </div>
                <div class=""col-sm-8 my-1"">
                    <label class=""sr-only"" for=""inlineFormInputName"">Name</label>
                    <input type=""text"" class=""form-control"" id=""comment"" placeholder=""Comentario"">
                </div>
                <div class=""col-auto my-1"">
                    <button type=""button"" onclick=""postComment('commentContainer')"" class=""btn btn-primary"">Postear</button>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n        <hr />\n\n        <div id=\"commentContainer\"");
            BeginWriteAttribute("class", " class=\"", 2628, "\"", 2636, 0);
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 69 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/Movie/Movie.cshtml"
             if(Model.Comments != null){
                foreach(var comment in Model.Comments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card col-auto mb-2\" style=\"width: 100%;\">\n                        <div class=\"card-body\">\n                            <h5 class=\"card-title\">");
#nullable restore
#line 74 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/Movie/Movie.cshtml"
                                              Write(comment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            <p class=\"card-text\">");
#nullable restore
#line 75 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/Movie/Movie.cshtml"
                                            Write(comment.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                    </div>\n");
#nullable restore
#line 78 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/Movie/Movie.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n\n    </div>\n</div>\n\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3164, "\"", 3181, 1);
#nullable restore
#line 85 "/Users/manueldejesusguerrerovasquez/Projects/MovieProject/MovieProject/Views/Movie/Movie.cshtml"
WriteAttributeValue("", 3172, Model.ID, 3172, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"movieID\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
