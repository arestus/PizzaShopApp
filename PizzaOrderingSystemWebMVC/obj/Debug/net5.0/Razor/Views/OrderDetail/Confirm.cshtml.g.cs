#pragma checksum "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\OrderDetail\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fa9b8fb7942a378ee2de7c4524bb27b8c67e1f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetail_Confirm), @"mvc.1.0.view", @"/Views/OrderDetail/Confirm.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\_ViewImports.cshtml"
using PizzaOrderingSystemWebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\_ViewImports.cshtml"
using PizzaOrderingSystemWebMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa9b8fb7942a378ee2de7c4524bb27b8c67e1f3", @"/Views/OrderDetail/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e21943f7dc9b676ec8732d15ddf3e7135ee0a10", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderDetail_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\OrderDetail\Confirm.cshtml"
  
    ViewData["Title"] = "Order Confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Order Confirmation</h1>\r\n\r\n<div class=\"jumbotron\" style=\"background-color:rgba(8,163,65,0.6);\">\r\n    <h1 class=\"display-4\">Order Confimed Successfully!!!!</h1>\r\n    <p class=\"lead\">Please pay by Cash</p>\r\n    <hr class=\"my-4\">\r\n</div>\r\n<a");
            BeginWriteAttribute("href", " href=\'", 298, "\'", 332, 1);
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\OrderDetail\Confirm.cshtml"
WriteAttributeValue("", 305, Url.Action("Index","Home"), 305, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input type=\"button\" value=\"Back to Home\" class=\"btn btn-primary\" />\r\n</a>\r\n");
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
