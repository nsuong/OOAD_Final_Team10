#pragma checksum "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0c81f25f9b8476d9c93c517b5321c76ada8a044"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_timSach), @"mvc.1.0.view", @"/Views/Home/timSach.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/timSach.cshtml", typeof(AspNetCore.Views_Home_timSach))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c81f25f9b8476d9c93c517b5321c76ada8a044", @"/Views/Home/timSach.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a0cbbb9bc49e060a61bbf9750d63a1feede449", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_timSach : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyThuVien.ViewModels.ttSach>>
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
  
    ViewData["Title"] = "timSach";

#line default
#line hidden
            BeginContext(98, 31, true);
            WriteLiteral("\r\n<h2>timSach</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dce8a0a569d4433aa7bba6c26c08d88e", async() => {
                BeginContext(152, 10, true);
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
            BeginContext(166, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(259, 43, false);
#line 16 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayNameFor(model => model.TenLoai));

#line default
#line hidden
            EndContext();
            BeginContext(302, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(358, 43, false);
#line 19 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayNameFor(model => model.TenSach));

#line default
#line hidden
            EndContext();
            BeginContext(401, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(457, 42, false);
#line 22 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayNameFor(model => model.TacGia));

#line default
#line hidden
            EndContext();
            BeginContext(499, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(555, 46, false);
#line 25 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayNameFor(model => model.NhaXuatBan));

#line default
#line hidden
            EndContext();
            BeginContext(601, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(657, 46, false);
#line 28 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayNameFor(model => model.NamXuatBan));

#line default
#line hidden
            EndContext();
            BeginContext(703, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(759, 40, false);
#line 31 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(799, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(855, 45, false);
#line 34 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayNameFor(model => model.XepHangTb));

#line default
#line hidden
            EndContext();
            BeginContext(900, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(956, 45, false);
#line 37 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayNameFor(model => model.SoDanhGia));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1119, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1168, 42, false);
#line 46 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1266, 42, false);
#line 49 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenSach));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1364, 41, false);
#line 52 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayFor(modelItem => item.TacGia));

#line default
#line hidden
            EndContext();
            BeginContext(1405, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1461, 45, false);
#line 55 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayFor(modelItem => item.NhaXuatBan));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1562, 45, false);
#line 58 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayFor(modelItem => item.NamXuatBan));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1663, 39, false);
#line 61 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayFor(modelItem => item.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(1702, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1758, 44, false);
#line 64 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayFor(modelItem => item.XepHangTb));

#line default
#line hidden
            EndContext();
            BeginContext(1802, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1858, 44, false);
#line 67 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoDanhGia));

#line default
#line hidden
            EndContext();
            BeginContext(1902, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1958, 65, false);
#line 70 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2023, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2044, 71, false);
#line 71 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2115, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2136, 69, false);
#line 72 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2205, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 75 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\Home\timSach.cshtml"
}

#line default
#line hidden
            BeginContext(2244, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyThuVien.ViewModels.ttSach>> Html { get; private set; }
    }
}
#pragma warning restore 1591
