#pragma checksum "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4d11900a006d86943c26372c90b2483b522f462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_Index), @"mvc.1.0.view", @"/Views/NhanVien/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NhanVien/Index.cshtml", typeof(AspNetCore.Views_NhanVien_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4d11900a006d86943c26372c90b2483b522f462", @"/Views/NhanVien/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a0cbbb9bc49e060a61bbf9750d63a1feede449", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyThuVien.ViewModels.viewNhanVien>>
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cb6814b1cc549e684e0bd9ee4db1c14", async() => {
                BeginContext(154, 10, true);
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
            BeginContext(168, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(261, 46, false);
#line 16 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IDNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(307, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(363, 44, false);
#line 19 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(407, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(463, 43, false);
#line 22 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(506, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(562, 41, false);
#line 25 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(603, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(659, 44, false);
#line 28 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(703, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(759, 48, false);
#line 31 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LoaiNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(807, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(863, 42, false);
#line 34 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(905, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(961, 47, false);
#line 37 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 88, true);
            WriteLiteral("\r\n\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1128, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1177, 45, false);
#line 47 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IDNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(1222, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1278, 43, false);
#line 50 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1377, 42, false);
#line 53 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1475, 40, false);
#line 56 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1571, 43, false);
#line 59 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1614, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 62 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
                 if (item.LoaiNhanVien == 0)
                {

#line default
#line hidden
            BeginContext(1718, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1740, 9, true);
            WriteLiteral("Quản lý\r\n");
            EndContext();
#line 65 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1768, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 66 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
                 if (item.LoaiNhanVien == 1)
                {

#line default
#line hidden
            BeginContext(1833, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1855, 10, true);
            WriteLiteral("Bán hàng\r\n");
            EndContext();
#line 69 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1884, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1938, 41, false);
#line 72 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1979, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2035, 46, false);
#line 75 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(2081, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2137, 58, false);
#line 78 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.IDNhanVien}));

#line default
#line hidden
            EndContext();
            BeginContext(2195, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2216, 64, false);
#line 79 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.IDNhanVien}));

#line default
#line hidden
            EndContext();
            BeginContext(2280, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2301, 62, false);
#line 80 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.IDNhanVien}));

#line default
#line hidden
            EndContext();
            BeginContext(2363, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 83 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2402, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyThuVien.ViewModels.viewNhanVien>> Html { get; private set; }
    }
}
#pragma warning restore 1591
