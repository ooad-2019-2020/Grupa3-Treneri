#pragma checksum "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f71222e90713f2db17ffc43c01c6d5449e028ae3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clan_PrijavaTreninga), @"mvc.1.0.view", @"/Views/Clan/PrijavaTreninga.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f71222e90713f2db17ffc43c01c6d5449e028ae3", @"/Views/Clan/PrijavaTreninga.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7717b022d0fe55edeb4096ce954ec2625882ef08", @"/Views/_ViewImports.cshtml")]
    public class Views_Clan_PrijavaTreninga : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Clan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Clan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TreningDetalji", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n");
            WriteLiteral("<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f71222e90713f2db17ffc43c01c6d5449e028ae34410", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <link rel=""stylesheet"" href=""css/assets5/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""css/assets5/css/Data-Table-1.css"">
    <link rel=""stylesheet"" href=""css/assets5/css/Data-Table.css"">
    <link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"">
    <link rel=""stylesheet"" href=""css/assets5/css/sidebar-1.css"">
    <link rel=""stylesheet"" href=""css/assets5/css/Sidebar-Menu-1.css"">
    <link rel=""stylesheet"" href=""css/assets5/css/Sidebar-Menu.css"">
    <link rel=""stylesheet"" href=""css/assets5/css/sidebar.css"">
    <link rel=""stylesheet"" href=""css/assets5/css/styles.css"">
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
         ");
                WriteLiteral(@"   left: 0;
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f71222e90713f2db17ffc43c01c6d5449e028ae37150", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
      
        var treninzi = ViewData["treninzi"] as Dictionary<Trening, Trener>;
        var clan = ViewData["clan"] as DbClan;
        var username = ViewData["username"] as string;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6 col-lg-3\">\r\n                    <div class=\"sidenav\">\r\n                        <a class=\"sidebar-brand\"> <a class=\"text-white\">");
#nullable restore
#line 65 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
                                                                   Write(username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></a>\r\n                        <a <a");
                BeginWriteAttribute("href", " href=\"", 2241, "\"", 2274, 2);
                WriteAttributeValue("", 2248, "/Clan/Index/", 2248, 12, true);
#nullable restore
#line 66 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
WriteAttributeValue("", 2260, clan.DbClanID, 2260, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Novosti</a></a>\r\n                        <a> <a");
                BeginWriteAttribute("href", " href=\"", 2323, "\"", 2371, 2);
                WriteAttributeValue("", 2330, "/Clan/IznajmljivanjeOpreme/", 2330, 27, true);
#nullable restore
#line 67 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
WriteAttributeValue("", 2357, clan.DbClanID, 2357, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Iznajmi opremu</a></a>\r\n                        <a> <a");
                BeginWriteAttribute("href", " href=\"", 2427, "\"", 2471, 2);
                WriteAttributeValue("", 2434, "/Clan/ZauzimanjeOpreme/", 2434, 23, true);
#nullable restore
#line 68 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
WriteAttributeValue("", 2457, clan.DbClanID, 2457, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Zauzmi opremu</a></a>\r\n                        <a> <a");
                BeginWriteAttribute("href", " href=\"", 2526, "\"", 2569, 2);
                WriteAttributeValue("", 2533, "/Clan/PrijavaTreninga/", 2533, 22, true);
#nullable restore
#line 69 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
WriteAttributeValue("", 2555, clan.DbClanID, 2555, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Prijavi trening</a></a>\r\n                        <a> <a");
                BeginWriteAttribute("href", " href=\"", 2626, "\"", 2660, 2);
                WriteAttributeValue("", 2633, "/Clan/Profil/", 2633, 13, true);
#nullable restore
#line 70 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
WriteAttributeValue("", 2646, clan.DbClanID, 2646, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Posjeti profil</a></a>\r\n                        <a><a");
                BeginWriteAttribute("href", " href=\"", 2715, "\"", 2751, 2);
                WriteAttributeValue("", 2722, "/Clan/Postavke/", 2722, 15, true);
#nullable restore
#line 71 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
WriteAttributeValue("", 2737, clan.DbClanID, 2737, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Postavke profila</a></a>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-9 col-xl-9"">
                    <h1>Prijavi trening</h1>
                    <ul class=""list-group"">
                        <li class=""list-group-item"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <h4 class=""card-title"">Aktivni treninzi</h4><table id=""example"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                                        <thead>
                                            <tr>
                                                <th>Termin održavanja</th>
                                                <th>Kapacitet</th>
                                                <th>Trener</th>
                                                <th></th>
                                            </tr>
                                        </the");
                WriteLiteral("ad>\r\n                                        <tbody>\r\n");
#nullable restore
#line 90 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
                                               foreach (KeyValuePair<Trening, Trener> t in treninzi)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <tr>\r\n                                                        <td>");
#nullable restore
#line 93 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
                                                       Write(t.Key.DatumOdrzavanja);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 94 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
                                                       Write(t.Key.Kapacitet);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 95 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
                                                       Write(t.Value.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 95 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
                                                                    Write(t.Value.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                        <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f71222e90713f2db17ffc43c01c6d5449e028ae314726", async() => {
                    WriteLiteral("Pogledaj detalje");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
                                                                                                                              WriteLiteral(clan.DbClanID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
                                                                                                                                                                 WriteLiteral(t.Key.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["treningID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-treningID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["treningID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 98 "C:\Users\Hamid\Source\Repos\Grupa3-Treneriiiii\Implementacija\e-Teretana\Views\Clan\PrijavaTreninga.cshtml"
                                                }
                                            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </li>

                    </ul>
                </div>
            </div>
        </div>
    </div>
    <script src=""css/assets5/js/jquery.min.js""></script>
    <script src=""css/assets5/bootstrap/js/bootstrap.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.15/js/dataTables.bootstrap.min.js""></script>
    <script src=""css/assets5/js/Sidebar-Menu.js""></script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clan> Html { get; private set; }
    }
}
#pragma warning restore 1591
