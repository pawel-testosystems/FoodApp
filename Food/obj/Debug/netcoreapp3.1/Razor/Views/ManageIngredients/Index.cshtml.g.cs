#pragma checksum "C:\Users\mateu\source\repos\Food\Food\Views\ManageIngredients\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b44b9dd53cc08f0ec1a0c549ab8ab7d533515d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageIngredients_Index), @"mvc.1.0.view", @"/Views/ManageIngredients/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b44b9dd53cc08f0ec1a0c549ab8ab7d533515d1", @"/Views/ManageIngredients/Index.cshtml")]
    public class Views_ManageIngredients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Food.Data.Models.Ingredient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"main\">\r\n\r\n    <div id=\"title\">Twoje składniki:</div>\r\n\r\n    <form>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\mateu\source\repos\Food\Food\Views\ManageIngredients\Index.cshtml"
        foreach (var ingredient in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label>\r\n                    <input");
            BeginWriteAttribute("id", " id=\"", 239, "\"", 260, 1);
#nullable restore
#line 12 "C:\Users\mateu\source\repos\Food\Food\Views\ManageIngredients\Index.cshtml"
WriteAttributeValue("", 244, ingredient.Name, 244, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\" required> ");
#nullable restore
#line 12 "C:\Users\mateu\source\repos\Food\Food\Views\ManageIngredients\Index.cshtml"
                                                                   Write(ingredient.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n");
#nullable restore
#line 14 "C:\Users\mateu\source\repos\Food\Food\Views\ManageIngredients\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <input id=""modal_window"" type=""button"" value=""Edytuj"">
        <input type=""submit"" value=""Usuń"">

    </form>

    <form>

        <div>

            <input type=""text"" class=""inputfield"" placeholder=""Nazwa nowego składnika"" onfocus=""this.placeholder=''"" onblur=""this.placeholder='Nazwa nowego składnika'"" name=""new_category"" required>
            <input type=""submit"" class=""pushbutton ok_pushbutton"" value=""Dodaj"">

        </div>

    </form>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Food.Data.Models.Ingredient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
