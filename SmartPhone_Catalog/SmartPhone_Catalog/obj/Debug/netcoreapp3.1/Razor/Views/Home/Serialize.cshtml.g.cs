#pragma checksum "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\Home\Serialize.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dab0ec6072831871baff88304d78eb4b31baa46a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Serialize), @"mvc.1.0.view", @"/Views/Home/Serialize.cshtml")]
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
#line 1 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\_ViewImports.cshtml"
using BookShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\_ViewImports.cshtml"
using BookShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\Home\Serialize.cshtml"
using System.Runtime.InteropServices.ComTypes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dab0ec6072831871baff88304d78eb4b31baa46a", @"/Views/Home/Serialize.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133d7eedfb0c459bb718f0b1ef2c074f1079acf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Serialize : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewComponent>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div style=\"background: lightgray; text-align: center;\">\n    <strong>\n\n");
#nullable restore
#line 7 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\Home\Serialize.cshtml"
         if (ViewBag.Success != null)
        {
            if (ViewBag.Success)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <i style=\"color: darkred\">Unknown problem occured when adding the data to the database.</i>\n");
#nullable restore
#line 12 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\Home\Serialize.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 15 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\Home\Serialize.cshtml"
         if (ViewBag.IncorrectFormat != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <i style=\"color: darkred\">Unknown problem occured.</i>\n");
#nullable restore
#line 18 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\Home\Serialize.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 20 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\Home\Serialize.cshtml"
         if (ViewBag.FilesInfo != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<h4>Xml File Validation</h4>\n");
#nullable restore
#line 23 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\Home\Serialize.cshtml"
            foreach (var file in ViewBag.FilesInfo)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("<div>\n");
#nullable restore
#line 26 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\Home\Serialize.cshtml"
           Write(file.Key);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\Home\Serialize.cshtml"
                         ;
                
                if (file.Value)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            WriteLiteral("<i style=\"color: forestgreen\"> YES </i>\n");
#nullable restore
#line 31 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\Home\Serialize.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            WriteLiteral("<i style=\"color: red\"> NO </i>\n");
#nullable restore
#line 35 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\Home\Serialize.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("</div>\n");
#nullable restore
#line 37 "C:\Users\Dan4inatora\Desktop\Kris_proj\SmartPhone_Catalog\SmartPhone_Catalog\Views\Home\Serialize.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </strong >\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewComponent> Html { get; private set; }
    }
}
#pragma warning restore 1591
