#pragma checksum "C:\Users\mateu\source\repos\Food\Food\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b88a22a7c67c9450ca83e23c1c3a65d5b5cb837"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b88a22a7c67c9450ca83e23c1c3a65d5b5cb837", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div>
    <h1>Logowanie</h1>

    <form method=""post"">

        <div>
            <label for=""inputEmail"">Email</label>
            <input type=""email"" id=""inputEmail"" name=""email"" placeholder=""Email"" />
        </div>
        <div>
            <label for=""inputPassword"">Hasło</label>
            <input type=""password"" id=""inputPassword"" name=""password"" placeholder=""Hasło"" />
        </div>
        <div>
            <label>
                <input type=""checkbox"" name=""remember_me"" checked=""checked"" /> Zapamiętaj mnie
            </label>
        </div>

        <button type=""submit"">Zaloguj</button>
        <a>Zapomniałeś hasła?</a>

    </form>
</div>

<div>
    <h1>Rejestracja</h1>

    <form method=""post"">

        <div>
            <label for=""inputName"">Imię</label>
            <input id=""inputName"" name=""name"" placeholder=""Imię"" autofocus required />
        </div>
        <div>
            <label for=""inputEmail"">Email</label>
            <input id=""inputEmail"" name=");
            WriteLiteral(@"""email"" placeholder=""Emal"" required type=""email"" />
        </div>
        <div>
            <label for=""inputPassword"">Hasło</label>
            <input type=""password"" id=""inputPassword"" name=""password"" placeholder=""Hasło"" required />
        </div>

        <button type=""submit"">Zarejestruj</button>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
