#pragma checksum "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bcca2a3306957c4d086e4bdf55f525323db9a26"
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
#line 1 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\_ViewImports.cshtml"
using e_Teretana;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\_ViewImports.cshtml"
using e_Teretana.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bcca2a3306957c4d086e4bdf55f525323db9a26", @"/Views/Clan/Postavke.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bcca2a3306957c4d086e4bdf55f525323db9a264234", async() => {
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
                    color: #f1f1f1;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bcca2a3306957c4d086e4bdf55f525323db9a267020", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
      
        var clan = ViewData["clan"] as DbClan;
        int idClana = clan.DbClanID;
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 col-lg-3"">
                    <div class=""sidenav"">
                        <a class=""sidebar-brand""> <a class=""text-dark"" href=""#"">Korisničko ime</a></a>
                        <a <a");
                BeginWriteAttribute("href", " href=\"", 2203, "\"", 2236, 2);
                WriteAttributeValue("", 2210, "/Clan/Index/", 2210, 12, true);
#nullable restore
#line 67 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 2222, clan.DbClanID, 2222, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Novosti</a></a>\r\n                        <a> <a class=\"text-dark\" href=\"#\">Iznajmi opremu</a></a>\r\n                        <a> <a class=\"text-dark\" href=\"#\">Zauzmi opremu</a></a>\r\n                        <a> <a");
                BeginWriteAttribute("href", " href=\"", 2448, "\"", 2491, 2);
                WriteAttributeValue("", 2455, "/Clan/PrijavaTreninga/", 2455, 22, true);
#nullable restore
#line 70 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 2477, clan.DbClanID, 2477, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Prijavi trening</a></a>\r\n                        <a> <a");
                BeginWriteAttribute("href", " href=\"", 2548, "\"", 2582, 2);
                WriteAttributeValue("", 2555, "/Clan/Profil/", 2555, 13, true);
#nullable restore
#line 71 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 2568, clan.DbClanID, 2568, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Posjeti profil</a></a>\r\n                        <a><a");
                BeginWriteAttribute("href", " href=\"", 2637, "\"", 2673, 2);
                WriteAttributeValue("", 2644, "/Clan/Postavke/", 2644, 15, true);
#nullable restore
#line 72 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 2659, clan.DbClanID, 2659, 14, false);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bcca2a3306957c4d086e4bdf55f525323db9a2610466", async() => {
                    WriteLiteral("\r\n                                <input class=\"form-control\" type=\"hidden\" name=\"id\"");
                    BeginWriteAttribute("value", " value=\"", 3082, "\"", 3098, 1);
#nullable restore
#line 80 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 3090, idClana, 3090, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <label>Ime:</label><input class=\"form-control\" type=\"text\" name=\"ime\"");
                    BeginWriteAttribute("value", " value=\"", 3203, "\"", 3221, 1);
#nullable restore
#line 81 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 3211, Model.Ime, 3211, 10, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <label>Prezime:</label><input class=\"form-control\" type=\"text\" name=\"prezime\"");
                    BeginWriteAttribute("value", " value=\"", 3334, "\"", 3356, 1);
#nullable restore
#line 82 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 3342, Model.Prezime, 3342, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <label>E-mail:</label><input class=\"form-control\" type=\"email\" name=\"email\"");
                    BeginWriteAttribute("value", " value=\"", 3467, "\"", 3487, 1);
#nullable restore
#line 83 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 3475, Model.EMail, 3475, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <label>Šifra:</label><input class=\"form-control\" type=\"password\" name=\"sifra\"");
                    BeginWriteAttribute("value", " value=\"", 3600, "\"", 3620, 1);
#nullable restore
#line 84 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 3608, Model.Sifra, 3608, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <label>Potvrdi šifru:</label><input class=\"form-control\" type=\"password\" name=\"ponovljenaSifra\"");
                    BeginWriteAttribute("value", " value=\"", 3751, "\"", 3771, 1);
#nullable restore
#line 85 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 3759, Model.Sifra, 3759, 12, false);

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
                                    <h1 class=""text-center text-danger"">Članarina traje do dd.mm.yyyy.!!!</h1>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col"">
                                    <h3>Produži članarinu</h3>
                                    <p>Odaberi vrstu članarine:</p>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bcca2a3306957c4d086e4bdf55f525323db9a2615907", async() => {
                    WriteLiteral("\r\n                                        <input class=\"form-control\" type=\"hidden\" name=\"id\"");
                    BeginWriteAttribute("value", " value=\"", 4688, "\"", 4704, 1);
#nullable restore
#line 101 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
WriteAttributeValue("", 4696, idClana, 4696, 8, false);

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
#line 123 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
 if (ViewBag.Podaci != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>\r\n        ");
#nullable restore
#line 126 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
   Write(ViewBag.Podaci);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h4>\r\n");
#nullable restore
#line 128 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Clan\Postavke.cshtml"
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
