#pragma checksum "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a55fcc1bb17ef7c63ca27a386c19d2f32dc021b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Details), @"mvc.1.0.view", @"/Views/Pizza/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a55fcc1bb17ef7c63ca27a386c19d2f32dc021b", @"/Views/Pizza/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e21943f7dc9b676ec8732d15ddf3e7135ee0a10", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaOrderingSystemWebMVC.Models.ToppingList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a55fcc1bb17ef7c63ca27a386c19d2f32dc021b4991", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
   TempData["pizzaChoise"] = @ViewBag.thePizza.PizzaNumber;
    TempData["pizzaPrice"] = @ViewBag.thePizza.PizzaPrice;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Chose topping</h4>\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-4 mb-4\">\r\n            <div class=\"card\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 466, "\"", 521, 3);
            WriteAttributeValue("", 472, "/Images/Pizzas/", 472, 15, true);
#nullable restore
#line 17 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
WriteAttributeValue("", 487, ViewBag.thePizza.PizzaName, 487, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 516, ".jpeg", 516, 5, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\" style=\"height: 230px;\">\r\n                <div class=\"card-body\">\r\n\r\n                    <h5 class=\"card-title text-center\">");
#nullable restore
#line 20 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
                                                  Write(ViewBag.thePizza.PizzaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                    <h6 class=\"card-text\">Prise $");
#nullable restore
#line 22 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
                                            Write(ViewBag.thePizza.PizzaPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h6 class=\"card-text\">");
#nullable restore
#line 23 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
                                     Write(ViewBag.thePizza.PizzaType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                    <p class=\"card-text\">Some pizza descriptions on the card title and make up the bulk of the card\'s content.</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a55fcc1bb17ef7c63ca27a386c19d2f32dc021b8532", async() => {
                WriteLiteral("\r\n    <div class=\"col-lg-4 mb-4\">\r\n        <h2>Chose topping</h2>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
         using (Html.BeginForm())
        {
            for (int i = 0; i < Model.Toppingss.Count; i++)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
           Write(Html.CheckBoxFor(m => Model.Toppingss[i].IsChecked));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
           Write(Model.Toppingss[i].ToppingName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
           Write(Model.Toppingss[i].ToppingPrice);

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
           Write(Html.HiddenFor(m => Model.Toppingss[i].ToppingPrice));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
           Write(Html.HiddenFor(m => Model.Toppingss[i].ToppingNumber));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
           Write(Html.HiddenFor(m => Model.Toppingss[i].ToppingName));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 46 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Add to order\" class=\"btn btn-primary w-50\" />\r\n            </div>\r\n");
#nullable restore
#line 51 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
       Write(ViewBag.Loc);

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Administrator\Desktop\Pizzahut\PizzaOrderingSystemWebMVC\Views\Pizza\Details.cshtml"
                        
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaOrderingSystemWebMVC.Models.ToppingList> Html { get; private set; }
    }
}
#pragma warning restore 1591