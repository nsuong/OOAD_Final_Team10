#pragma checksum "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db1a5987eec2ff6b43b126e91a561c4b6bc40689"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChiNhanh_Index), @"mvc.1.0.view", @"/Views/ChiNhanh/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ChiNhanh/Index.cshtml", typeof(AspNetCore.Views_ChiNhanh_Index))]
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
#line 1 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\_ViewImports.cshtml"
using QuanLyThuVien;

#line default
#line hidden
#line 2 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\_ViewImports.cshtml"
using QuanLyThuVien.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1a5987eec2ff6b43b126e91a561c4b6bc40689", @"/Views/ChiNhanh/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a0cbbb9bc49e060a61bbf9750d63a1feede449", @"/Views/_ViewImports.cshtml")]
    public class Views_ChiNhanh_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyThuVien.Models.ChiNhanh>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(123, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da4bbfea82694132abbd835b619d331a", async() => {
                BeginContext(146, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(160, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(253, 46, false);
#line 16 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IDChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(299, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(355, 47, false);
#line 19 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(402, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(458, 42, false);
#line 22 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(500, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(556, 48, false);
#line 25 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NgayThanhLap));

#line default
#line hidden
            EndContext();
            BeginContext(604, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(660, 44, false);
#line 28 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IDQuanLy));

#line default
#line hidden
            EndContext();
            BeginContext(704, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(760, 46, false);
#line 31 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IDNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(806, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(924, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(973, 45, false);
#line 40 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IDChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1074, 46, false);
#line 43 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1176, 41, false);
#line 46 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1273, 47, false);
#line 49 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NgayThanhLap));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1376, 43, false);
#line 52 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IDQuanLy));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1475, 45, false);
#line 55 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IDNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1576, 59, false);
#line 58 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.IDChiNhanh }));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1656, 64, false);
#line 59 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.IDChiNhanh}));

#line default
#line hidden
            EndContext();
            BeginContext(1720, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1741, 62, false);
#line 60 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.IDChiNhanh}));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 63 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\ChiNhanh\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1842, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyThuVien.Models.ChiNhanh>> Html { get; private set; }
    }
}
#pragma warning restore 1591
