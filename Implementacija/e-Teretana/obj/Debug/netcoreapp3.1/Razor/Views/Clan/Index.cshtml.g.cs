#pragma checksum "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8984224e2709b56d1a280841b088a6e9e9e38b98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clan_Index), @"mvc.1.0.view", @"/Views/Clan/Index.cshtml")]
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
#line 1 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\_ViewImports.cshtml"
using e_Teretana;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\_ViewImports.cshtml"
using e_Teretana.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8984224e2709b56d1a280841b088a6e9e9e38b98", @"/Views/Clan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7717b022d0fe55edeb4096ce954ec2625882ef08", @"/Views/_ViewImports.cshtml")]
    public class Views_Clan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DbKorisnik>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n");
            WriteLiteral("<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8984224e2709b56d1a280841b088a6e9e9e38b983557", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>Naslovna clan</title>
    <link rel=""stylesheet"" href=""css/assets3/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""css/assets3/css/Sidebar-Menu.css"">
    <link rel=""stylesheet"" href=""css/assets3/css/sidebar.css"">
    <link rel=""stylesheet"" href=""css/assets3/css/styles.css"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <style>
body {
  font-family: ""Lato"", sans-serif;
}

        .sidenav {
            height: 100%;
            width: 180px;
            position: fixed;
            z-index: 1;
            top: 0;
            left: 0;
            background-color: #B2B2FF;
            overflow-x: hidden;
            padding-top: 20px;
        }

.sidenav a {
  padding: 6px 8px 6px 16px;
  text-decoration: none;
  font-size: 25px;
  color: #000000;
  display: block;
}

        .sidenav a:hover {
   ");
                WriteLiteral("         color: #ffc9c9;\r\n        }\r\n\r\n.main {\r\n  margin-left: 180px; /* Same as the width of the sidenav */\r\n  font-size: 20px; /* Increased text to enable scrolling */\r\n  padding: 0px 10px;\r\n}\r\n\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8984224e2709b56d1a280841b088a6e9e9e38b985843", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
      
        var novosti = ViewData["novosti"] as List<Novost>;
        var username = ViewData["username"] as string;

    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 col-lg-3"">
                            <div class=""sidenav"">
                                <a class=""sidebar-brand""> <a class=""text-white"" >");
#nullable restore
#line 66 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
                                                                            Write(username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></a>\r\n                                <a <a");
                BeginWriteAttribute("href", " href=\"", 1806, "\"", 1844, 2);
                WriteAttributeValue("", 1813, "/Clan/Index/", 1813, 12, true);
#nullable restore
#line 67 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
WriteAttributeValue("", 1825, Model.DbKorisnikID, 1825, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Novosti</a></a>\r\n                                <a> <a");
                BeginWriteAttribute("href", " href=\"", 1901, "\"", 1954, 2);
                WriteAttributeValue("", 1908, "/Clan/IznajmljivanjeOpreme/", 1908, 27, true);
#nullable restore
#line 68 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
WriteAttributeValue("", 1935, Model.DbKorisnikID, 1935, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Iznajmi opremu</a></a>\r\n                                <a> <a");
                BeginWriteAttribute("href", " href=\"", 2018, "\"", 2067, 2);
                WriteAttributeValue("", 2025, "/Clan/ZauzimanjeOpreme/", 2025, 23, true);
#nullable restore
#line 69 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
WriteAttributeValue("", 2048, Model.DbKorisnikID, 2048, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Zauzmi opremu</a></a>\r\n                                <a> <a");
                BeginWriteAttribute("href", " href=\"", 2130, "\"", 2178, 2);
                WriteAttributeValue("", 2137, "/Clan/PrijavaTreninga/", 2137, 22, true);
#nullable restore
#line 70 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
WriteAttributeValue("", 2159, Model.DbKorisnikID, 2159, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Prijavi trening</a></a>\r\n                                <a> <a");
                BeginWriteAttribute("href", " href=\"", 2243, "\"", 2282, 2);
                WriteAttributeValue("", 2250, "/Clan/Profil/", 2250, 13, true);
#nullable restore
#line 71 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
WriteAttributeValue("", 2263, Model.DbKorisnikID, 2263, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Posjeti profil</a></a>\r\n                                <a><a");
                BeginWriteAttribute("href", " href=\"", 2345, "\"", 2386, 2);
                WriteAttributeValue("", 2352, "/Clan/Postavke/", 2352, 15, true);
#nullable restore
#line 72 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
WriteAttributeValue("", 2367, Model.DbKorisnikID, 2367, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Postavke profila</a></a>\r\n                            </div>\r\n                </div>\r\n                <div class=\"col-md-6 col-lg-9 col-xl-9\">\r\n                    <ul class=\"list-group\">\r\n");
#nullable restore
#line 77 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
                           for (int i = novosti.Count-1; i >=0; i--)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <div class=\"card\">\r\n                                <div class=\"card-body\">\r\n                                    <a href=\"#\"><img class=\"img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 2907, "\"", 2944, 1);
#nullable restore
#line 82 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
WriteAttributeValue("", 2913, Url.Content("~/css/jerry.png"), 2913, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                                    <h3 class=\"name\">");
#nullable restore
#line 83 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
                                                Write(novosti[i].Naslov);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h3>\r\n                                    <p class=\"description\">");
#nullable restore
#line 84 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
                                                      Write(novosti[i].Tekst);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p><a class=\"action\" href=\"#\"><i class=\"fa fa-arrow-circle-right\"></i></a>\r\n                                </div>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 88 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <script src=""css/assets3/js/jquery.min.js""></script>
    <script src=""css/assets3/bootstrap/js/bootstrap.min.js""></script>
    <script src=""css/assets3/js/Sidebar-Menu.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DbKorisnik> Html { get; private set; }
    }
}
#pragma warning restore 1591
