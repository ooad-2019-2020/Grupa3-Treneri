#pragma checksum "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e7e19a4273a849460fbcedcc6cdc64a380ccd97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clan_Postavke), @"mvc.1.0.view", @"/Views/Clan/Postavke.cshtml")]
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
#line 1 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\_ViewImports.cshtml"
using e_Teretana;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\_ViewImports.cshtml"
using e_Teretana.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e7e19a4273a849460fbcedcc6cdc64a380ccd97", @"/Views/Clan/Postavke.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7717b022d0fe55edeb4096ce954ec2625882ef08", @"/Views/_ViewImports.cshtml")]
    public class Views_Clan_Postavke : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Clan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Promijeni", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PromijeniClanarinu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n");
            WriteLiteral("<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e7e19a4273a849460fbcedcc6cdc64a380ccd974228", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>Postavke profila clan</title>
    <link rel=""stylesheet"" href=""css/assets3/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""css/assets4/css/Data-Table-1.css"">
    <link rel=""stylesheet"" href=""css/assets4/css/Data-Table.css"">
    <link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"">
    <link rel=""stylesheet"" href=""css/assets3/css/sidebar-1.css"">
    <link rel=""stylesheet"" href=""css/assets3/css/Sidebar-Menu-1.css"">
    <link rel=""stylesheet"" href=""css/assets3/css/Sidebar-Menu.css"">
    <link rel=""stylesheet"" href=""css/assets3/css/sidebar.css"">
    <link rel=""stylesheet"" href=""css/assets3/css/styles.css"">
    <style>
        body {
            font-family: ""Lato"", sans-serif;
        }

        .sidenav {
            height: 100%;
            width: 180px;
            position: fixed;
            z");
                WriteLiteral(@"-index: 1;
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
                    color: #ffc9c9;
                }

        .main {
            margin-left: 180px; /* Same as the width of the sidenav */
            font-size: 20px; /* Increased text to enable scrolling */
            padding: 0px 10px;
        }
    </style>
");
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
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e7e19a4273a849460fbcedcc6cdc64a380ccd977014", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
      
        var clan = ViewData["clan"] as DbClan;
        int idClana = clan.DbClanID;
        var username = ViewData["username"] as string;
        var date = ViewData["date"] as string;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6 col-lg-3\">\r\n                    <div class=\"sidenav\">\r\n                        <a class=\"sidebar-brand\"> <a class=\"text-white\">");
#nullable restore
#line 68 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
                                                                   Write(username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></a>\r\n                        <a <a");
                BeginWriteAttribute("href", " href=\"", 2294, "\"", 2327, 2);
                WriteAttributeValue("", 2301, "/Clan/Index/", 2301, 12, true);
#nullable restore
#line 69 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 2313, clan.DbClanID, 2313, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Novosti</a></a>\r\n                        <a> <a");
                BeginWriteAttribute("href", " href=\"", 2376, "\"", 2424, 2);
                WriteAttributeValue("", 2383, "/Clan/IznajmljivanjeOpreme/", 2383, 27, true);
#nullable restore
#line 70 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 2410, clan.DbClanID, 2410, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Iznajmi opremu</a></a>\r\n                        <a> <a");
                BeginWriteAttribute("href", " href=\"", 2480, "\"", 2524, 2);
                WriteAttributeValue("", 2487, "/Clan/ZauzimanjeOpreme/", 2487, 23, true);
#nullable restore
#line 71 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 2510, clan.DbClanID, 2510, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Zauzmi opremu</a></a>\r\n                        <a> <a");
                BeginWriteAttribute("href", " href=\"", 2579, "\"", 2622, 2);
                WriteAttributeValue("", 2586, "/Clan/PrijavaTreninga/", 2586, 22, true);
#nullable restore
#line 72 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 2608, clan.DbClanID, 2608, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Prijavi trening</a></a>\r\n                        <a> <a");
                BeginWriteAttribute("href", " href=\"", 2679, "\"", 2713, 2);
                WriteAttributeValue("", 2686, "/Clan/Profil/", 2686, 13, true);
#nullable restore
#line 73 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 2699, clan.DbClanID, 2699, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Posjeti profil</a></a>\r\n                        <a><a");
                BeginWriteAttribute("href", " href=\"", 2768, "\"", 2804, 2);
                WriteAttributeValue("", 2775, "/Clan/Postavke/", 2775, 15, true);
#nullable restore
#line 74 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 2790, clan.DbClanID, 2790, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Postavke profila</a></a>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-9 col-xl-9"">
                    <h1>Postavke profila</h1>
                    <div class=""row"">
                        <div class=""col"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e7e19a4273a849460fbcedcc6cdc64a380ccd9711751", async() => {
                    WriteLiteral("\r\n                                <input class=\"form-control\" type=\"hidden\" name=\"id\"");
                    BeginWriteAttribute("value", " value=\"", 3213, "\"", 3229, 1);
#nullable restore
#line 82 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 3221, idClana, 3221, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <label>Ime:</label><input class=\"form-control\" type=\"text\" name=\"ime\"");
                    BeginWriteAttribute("value", " value=\"", 3334, "\"", 3352, 1);
#nullable restore
#line 83 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 3342, Model.Ime, 3342, 10, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <label>Prezime:</label><input class=\"form-control\" type=\"text\" name=\"prezime\"");
                    BeginWriteAttribute("value", " value=\"", 3465, "\"", 3487, 1);
#nullable restore
#line 84 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 3473, Model.Prezime, 3473, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <label>E-mail:</label><input class=\"form-control\" type=\"email\" name=\"email\"");
                    BeginWriteAttribute("value", " value=\"", 3598, "\"", 3618, 1);
#nullable restore
#line 85 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 3606, Model.EMail, 3606, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <label>Šifra:</label><input class=\"form-control\" type=\"password\" name=\"sifra\"");
                    BeginWriteAttribute("value", " value=\"", 3731, "\"", 3751, 1);
#nullable restore
#line 86 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 3739, Model.Sifra, 3739, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <label>Potvrdi šifru:</label><input class=\"form-control\" type=\"password\" name=\"ponovljenaSifra\"");
                    BeginWriteAttribute("value", " value=\"", 3882, "\"", 3902, 1);
#nullable restore
#line 87 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 3890, Model.Sifra, 3890, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <button class=\"btn btn-primary btn-block\" type=\"submit\">Sačuvaj promjene</button>\r\n\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <div class=""col"">
                            <div class=""row"">
                                <div class=""col"">
                                    <h1 class=""text-center text-danger"">Članarina traje do ");
#nullable restore
#line 95 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
                                                                                      Write(date);

#line default
#line hidden
#nullable disable
                WriteLiteral(@".!!!</h1>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col"">
                                    <h3>Produži članarinu</h3>
                                    <p>Odaberi vrstu članarine:</p>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e7e19a4273a849460fbcedcc6cdc64a380ccd9717484", async() => {
                    WriteLiteral("\r\n                                        <input class=\"form-control\" type=\"hidden\" name=\"id\"");
                    BeginWriteAttribute("value", " value=\"", 4814, "\"", 4830, 1);
#nullable restore
#line 103 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 4822, idClana, 4822, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                                        <div class=""form-group"">
                                            <input type=""radio"" name=""clanarina"" value=""jednomjesecna"" >Jednomjesečna članarina<br>
                                            <input type=""radio"" name=""clanarina"" value=""tromjesecna"" >Tromjesečna članarina<br>
                                            <input type=""radio"" name=""clanarina"" value=""sestomjesecna"" >Šestomjesečna članarina<br>
                                        </div><button class=""btn btn-primary bg-info"" type=""submit"">Nastavi dalje na plaćanje</button>
                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src=""css/assets4/js/jquery.min.js""></script>
    <script src=""css/assets3/bootstrap/js/bootstrap.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.15/js/dataTables.bootstrap.min.js""></script>
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 125 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
 if (ViewBag.Podaci != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>\r\n        ");
#nullable restore
#line 128 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
   Write(ViewBag.Podaci);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n");
#nullable restore
#line 130 "C:\Users\Nermin\Source\Repos\Grupa3-Treneri\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clan> Html { get; private set; }
    }
}
#pragma warning restore 1591
