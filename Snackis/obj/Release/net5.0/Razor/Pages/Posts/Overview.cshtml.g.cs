#pragma checksum "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc56f694f196e6afa1ae100f96c9b32a34b89e6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Snackis.Pages.Posts.Pages_Posts_Overview), @"mvc.1.0.razor-page", @"/Pages/Posts/Overview.cshtml")]
namespace Snackis.Pages.Posts
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
#line 1 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\_ViewImports.cshtml"
using Snackis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
using Snackis.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc56f694f196e6afa1ae100f96c9b32a34b89e6b", @"/Pages/Posts/Overview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9839838c40d7b4a0078cbdd8d77bf3814aaed32e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Posts_Overview : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "OverView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "PostsView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
  
    ViewData["Title"] = "Overview";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-3\">\r\n            <h1>Översikt</h1>\r\n        </div>\r\n        <div class=\"col-sm-9\">\r\n");
#nullable restore
#line 18 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
             if (Model.SubCategory != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1>Underkategori: ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc56f694f196e6afa1ae100f96c9b32a34b89e6b4668", async() => {
#nullable restore
#line 20 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                                                                          Write(Model.SubCategory.SubCatName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                                            WriteLiteral(Model.SubCategory.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 21 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-3"">
        </div>
        <div class=""col-sm-9"">
            <p><a href=""#"">Skapa nytt inlägg</a></p>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-3"">
            <table class=""table-borderless"">
                <thead>
                    <tr>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 39 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                     foreach (var item in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <div class=\"dropdown-menu-right dropdown\">\r\n                                    <button class=\"dropbtn\">");
#nullable restore
#line 44 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                    <div class=\"dropdown-content\">\r\n");
#nullable restore
#line 46 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                         foreach (var subcat in Model.SubCategories)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                             if (subcat.CategoryID == item.Id)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc56f694f196e6afa1ae100f96c9b32a34b89e6b9422", async() => {
#nullable restore
#line 50 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                                                                            Write(subcat.SubCatName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                                                         WriteLiteral(subcat.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"col-sm-9\">\r\n");
#nullable restore
#line 62 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
             if (Model.SubCategory != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">Datum</th>
                            <th scope=""col"">Ämne</th>
                            <th scope=""col"">Skapat av</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
");
#nullable restore
#line 74 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                             foreach (var post in Model.Posts)
                            {
                                if (post.SubCategoryId == Model.SubCategory.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td> ");
#nullable restore
#line 78 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                    Write(post.PostedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc56f694f196e6afa1ae100f96c9b32a34b89e6b14307", async() => {
#nullable restore
#line 79 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                                                                   Write(post.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                                                  WriteLiteral(post.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 80 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                   Write(post.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 81 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 86 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 91 "C:\Users\jabba\OneDrive\Dokument\NET20\Projekt\Snackis\Snackis\Pages\Posts\Overview.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<SnackisUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<SnackisUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Snackis.Pages.Posts.OverviewModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Snackis.Pages.Posts.OverviewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Snackis.Pages.Posts.OverviewModel>)PageContext?.ViewData;
        public Snackis.Pages.Posts.OverviewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
