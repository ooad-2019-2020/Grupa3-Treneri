#pragma checksum "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2776e80a1033c9f969f0a1ebc6f21d7c489610b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2776e80a1033c9f969f0a1ebc6f21d7c489610b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7717b022d0fe55edeb4096ce954ec2625882ef08", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2776e80a1033c9f969f0a1ebc6f21d7c489610b3514", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>Untitled</title>
    <link rel=""stylesheet"" href=""css/assets/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""css/assets/fonts/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""css/assets/fonts/ionicons.min.css"">
    <link rel=""stylesheet"" href=""css/assets/css/Article-List.css"">
    <link rel=""stylesheet"" href=""css/assets/css/Footer-Basic.css"">
    <link rel=""stylesheet"" href=""css/assets/css/Map-Clean.css"">
    <link rel=""stylesheet"" href=""css/assets/css/Navigation-with-Button.css"">
    <link rel=""stylesheet"" href=""css/assets/css/Navigation-with-Search.css"">
    <link rel=""stylesheet"" href=""css/assets/css/styles.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2776e80a1033c9f969f0a1ebc6f21d7c489610b5318", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
       
        var n1 = ViewData["Novost1"] as Novost;
        var n2 = ViewData["Novost2"] as Novost;
        var n3 = ViewData["Novost3"] as Novost;
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div class=""article-list"">
        <div class=""container"">
            <div class=""intro"">
                <h1 class=""text-center"">Novosti</h1>
                <p class=""text-center""></p>
            </div>
            <div class=""row articles"">
                <div class=""col-sm-6 col-md-4 item"">
                    <a href=""#""><img class=""img-fluid"" src=""css/assets/img/default.jpg""></a>
                    <h3 class=""name"">");
#nullable restore
#line 38 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
                                Write(n1.Naslov);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h3>\r\n                    <p class=\"description\">");
#nullable restore
#line 39 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
                                      Write(n1.Tekst);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p><a class=""action"" href=""#""><i class=""fa fa-arrow-circle-right""></i></a>
                </div>
                <div class=""col-sm-6 col-md-4 item"">
                    <a href=""#""><img class=""img-fluid"" src=""data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxISEBAQEhAPEBAQEA8PDxAQEA8PEA0PFREWFhURFRUYHSggGBolGxUVITEhJSkrLi4uFx8zODMtNygtLisBCgoKDg0OGhAQFysdHR0rKy0tKy0tLSstLS0rLS0rLS0tLS0tLS0tLS0tLTc3LS0tLS0tLTc3KystNy0rLS0tK//AABEIAN8A4gMBIgACEQEDEQH/xAAbAAABBQEBAAAAAAAAAAAAAAACAAEDBAUGB//EADoQAAEEAQIEBAQFAwMDBQAAAAEAAgMRBBIhBTFBURMiYXEGMoGRFEJSobEjYsFTctEVkvAHFiREgv/EABoBAAIDAQEAAAAAAAAAAAAAAAECAAMEBQb/xAAkEQACAgIDAQACAwEBAAAAAAAAAQIRAwQSITETBUEiMlEVFP/aAAwDAQACEQMRAD8A87STWlaxUd+wHc0wKJ6YIisIJwhCNQiHQFGhQQ1gEJqUhTIiiTIrTGlCWCUinSUQkvCu4bqXGdTggelG7cK9Lo5ObqRtRuVqJ2x9lShKtwFVeMifRjTCnH3QqfiDaeVAuji8OblXbCCIIAjarTOGAjaECkagxGIowhSUsUJOEIRBNEIVJ0KSaxSgmSanXFaPb8gHpJ3BAChQWwwU5KFOFGBMMJiU7TsmcgPfQ1prQlK0RGw7TJBC5QFj2mLkKRKYSQMijBRuKiKuXhzs67NbGftad2eb0sYXkdgaWd4jqDWrqOEYYY0E/MQCfdUy6YMcHIx5sPJk8/");
                WriteLiteral(@"gjb+7f7KqNQJDmlpHMFdtG5QcXwRIwuAAe0EihzVuPO/AZdDq0cjakaoy0gow5bU7RyJw4ugwpGqJqlBRRUwkkkyIoSIIEQTIgSSZJEBTLaTLqTw2M82/VVZfh8H5Xn6rG9dnfh+Sxt9nOOcqpn7c1qcS4W+NwbYJdyrstThfDWsFOa0mgTYtZpx4+mxZPorgc9C1z+T2X+kg2lMyRnNorqRey6/I4dFIK0Nb2LRRtYzwWuMUgvmAT1CCoSUskTMjfaclRTt0ProeSMFBo0QyWuxikSk5CUyiNyVh2mJTWhtCgchyhJStNaIspdCKif6InFCw+Ye6tiYczRqcNxQZGjnQty6ZjaWTw6P8AqE9KH8LYcNlRP0066VWSBylifusvHyg4uH6TSutcq16aXbRzfGGaJnCqB8w+qqNKufEJ/rf/AJCoMK6mP+p57cVTJwjBQMRBOYGSApIQkCiANOmBSTACtJMkiA7XwFLDCPoNyp9IQZbg2GV3Zp/hJzF+d+HKF3iTvkO4BLWegV0lVsFlDfmVYJXNzS5SPUaUOMAmuVfiuMJGahQcyyD1KkleGizsAixpA7luCqo9M2NJ+nLZY1M1V5goIeS0Z4NL5GdASB/Kn+GsJsoIcKIcQr4rkzn5MqxGM++yErspvhsHlsfdZ+V8NPAtps9le8LK4bsG/TnCUrWlLwSZvNh/n+FA7h0g/IfsUrxNF6zRfjKRKElTyYzv0n7FJuDIeTHe5FKLGxZZUiq4qLV5m+4/laR4Q/m9zGD/AHWf2Tu4ZFVCR8jrvyigPqn40jM8ikzVx5wx1nkQAtHJz2Rx6y4egBskrEhxSQA4nT0B5qtl4jWg+Uk8wSSQ1Y36bcU6Rc4E5x1OP5nOI9rXQY6y+CV4baHRaksgZG9/ZpP1S+s0x6i2Yudhumnk0m6ob8gjj+HZd92/daXwvAdBe7fW8nf9l0UTKq11McbijzG3nvK0cBLCWGjzCjtaXGGVI4eqzLTtFKdj2nCG06FBCtHajRBOANMkki");
                WriteLiteral(@"Kd62ZVuOS//FlquiC1X4obx5B6LM10DC7mijj8gpCosV1tCltc6fp6zW/oV89mqJ461sqHw9mggMJ8wsLWIXOcQwnRSeIwaRubHS/RRDzbRby3XM4g+n1TcD4mIJJQ5rngvsaVTwgfMSdRJslQwPqZ3Y8ldCXHs5+xj+io7X/3ZD/oT/ZV5Pixn5cWY+9D/Cymck+6v/8AXRkj+NiXj8Tym6xQO2pwH+FAeNZLuTIGdr86rpgq5bbZfDTUf2E6XId80rR6MjaFBJil3zSSOHYu2U/iJ2uVT2JM0LDFFZuDGDYaL781O1oHRM4qpJxKNppxI+hKX6SY3zhfheQyMsEdwUMUzXC2mwiCRD9Lwbg8o01YGk0b6Js6Y5D2wx25jTcjm7ix0VJ+IHThrnPax4F6TW9912WBgRxNDWADbnzJ91pxYr7MG1uuEeKD4dBoYBVAK9Gf2USYBdKHSOHKdys574iip9n8ywSu34vjeIwbbt391xuTGQVJFsHZCSntCUglHoMI2qMFE1EBImStMiCjtCExj1At7ghK0UTt1naZnxyqSZzfD3Fpex3NriCFo2qvHIDHKZ2jyPrV/ae6PHlDgCufljTPV6eVSjVk9KRrAQdQttboQFFxCbRE7oTsFVF2zbJKjHnLdTtAAFqjksotPqrcCHLbbCnsxMngcp1Qw32AroKSSGXgiqedOR5WmnHt0VsrPxI9T3OO+9BSKRGRRY0zSD4heDzB6LSjJUganpGTAgHg0VBBhCjqAJPPZXAnQT6DRmwwGNxAvSVbBUpah0o2RIq5hosf+lwJ9Aupwpg5oIPRc5NHqaW99ld+HMi2lh5sNe46LbrT6o42/h7s6MFSAqCN6kDlsizltEi5njmFR1Dkf2XSqDIgDwWnry9Fb6houmcHI3fmhWpxPBMbj2Wa4JHGjQpWIIwo7RBQAadBaSgLO0TpUnAVNmOwXsD2ljt2nYhYDuDyxOJhdrYTsw8wV0VImbKqWPka8O5LH4c2c6djtL8SYn+0agqPEs");
                WriteLiteral(@"ySR4YYnxgb07mV37ckhuq/l3K4TMl8SV7+7j1vqqsmFRVo6et+RnlfGRG3kiPJKk6yHTop4uzyPstAFUZ6DwVdadlABFDDGAiTtQCSpiUMrqaTV0s7wpnDxA1ob3c/TfoBaPFsVySNNpUeRNpCix32pdGq+4aSPcIqJOaK+PxAOvblzRfirNAX6rEjlcSWl1Os+wFq9HkBvkDS9x6iq+pRcRY5DUA77KvBkMhnDtQ0vq6UUbJXDzGhy0jY/dDk4DQ2wNxvfNWYpcWV7MOcDpIuLg7RxySeobt91cxp3uO8RaO5Kp8CytUbarYdFrtda6EXZ52SpkgSpJoR6VfFiFTMxg8UVyXEMMscR06Lty1VuIYTZGEV5uhVjVlsWcHpThWs2AsJaQqqpl0W9CSStJAFHbhEFGErVJhJUxOyAFKlGFRtkXE8wRwOBG79gP8AK5aMK/xzJ1SaB8rf5tUQFlzT/R2tHDXY4KdQSO8wClaslHWRDmR2L7KbGktoTvaCK7qjE9+7WiqJ5oohqFRZElDylo/3HZVvwJO7nuPpyCkZgM/TfuoBsrTzuAsZEZ2+UC0HEMqKTEhZ4n9eJzi5oFA2ea02wMGwY37BZk7IzKWnS1tAmgAVbHwokm2WOFxyTN/psI07OeTsFXzsmJj9Mkj3VsRFY9912PCseJ+O+GFksWqv6nQ/dYjv/TiZ0gcZmGPVuTz9k6olOjMl4QHBs0LZBERuXkE/dWcWONgrU0HrZXWHgsTHsgdqcA1thrtIpc/xrgWMyYta1wrf5jdqSSZFEibOOhv23UzSDsqX/Ta+SRzR22KGp2/pdXXuqaNFdUW+ETmOZ0f5TuF1cD1wuVO4FkzmUWEXXKuS67h2U1zGkEbhb8ErRwNvHxmaYKNrlA14RtetSRiJbTWgtOrFKiWUOKYQkaaG65HKhLTRC7wrO4hhCQHbfolki2MjjUlfdwyS+RSScS3kdM0okAKfUqTCFSUrtLS48gLStUeOS6YS293kAIS6Rbii3JGCZNTi49");
                WriteLiteral(@"U6jjFBSFwAtYJu2ejwQ4wKrHW8qy1qqYvMn1V26BKql0aEBq/ZVnGpAeVosZ1klFlt2vtuiiF1pSc6lFiyAtBQZcx+UDn1UZCnlZ8m4Yz0Ju69l0vCvhNkkG0lzSecyGjW2wWRFB5aPULZ+F+J6HeC/Y/lvqEykK42XsKZ+M4QzU39Lx8rgpOM8fZHJEIiZaaXObH59yOvZbGfGyRlFgkNbN+n7LmIMSRuuODB8LUSHSah+1p12Dwu8Ec+R0mRJbS48nbUAOZWBmz+JM93MajX3WzxjN/DwCAAeK8ebkavqudx2UEJOiL0sBNScFIlVWWgSx6mlvcIeEQgtIBLZGHnZN/RStVUP8OZruj6B91q1506OdvYuUbR0+IXV5q+iuNKrwHZSrpcjhkqIKNrkVqWKEUBCMJ0xE6It0lJSSg3IxcTMDvQjmD0VpWfi/hYhc3JjADHH+oANmkqnE6wubrbCzRtF+1qvDMmZzpYHG8gul09GbfVb42DndgVyGsuc5x6uKtzOkPpQ5TJFFlPppUr5A0WTQVEOMh/tH7rnnff+EuCNlPkSU0/ZE1gVGfU5+noiyE+KNlO7cEd0zGUKRhBMJUxZKsXyNAK3CzqVSyW1ID0P8q/GUWREqiniDt7pw5EcwjTpRv0TYnHMmHy6BM2vLvRHuVPJ8V5jxpZEyGx8xcSR+ypWmKdS6EojaxznGSR2uR3NylSSSsaKHSTJ0Bx7UGYy22Bu3cKZPSaDpleWHKNGvwjID42uHt9VoLnOBv8OUxu+V3mauo8LqF1sbuJ5jNHhKmA0IrUM2Qxnzvaz/cQE0MrXjUxzXDuHBNZXTauifUiBUXJE1yKYA7STJJrFs6HPxfGiki/U016ELg+G3RYT5mEtP3Xo7dlwXE4vDzJByDvOAvL/istdM9J+Sw8lZV49MWRBoPz1felgx0B6q7xybXKB0a0betqnpXVzzsz6OKlZnyuGoktc838vRWcLIBFaCz0PJLMcQOtdaVdkl0GNI7uOyo/R0PDUCq5gF");
                WriteLiteral(@"3q0nv2VenNdQJO12SnjiD93boUS7I2SkOA8XV3A6LRBUUWM1vJoU9IMZEOUy232UuM+2hIiwR3UGGaJb1RIy8nSSCUYdJJJAIySSSILHAT6UwKK0BkxUmTkpUoSyDJBFPB8zf3XQQcdDMdsn53bNbz8yxw0HmsqPGuQ0fKDsFrxZ3FHN2dNZZFzLcchzny+Yn6Aei598RbKWNe5g6FrnCitmbH1OoEtHWuqjzsFrWAAEvJ2PUlK8zbLI60McKLXw/xKXWYXuLwyxZXWxO2WB8P8GMQ1OIc5259F0DW0t2Nto4meuboO06G0k5no69/Jcl8WsDZ4pCOcbwfourdIuW+PnVBG7rqI+lLxuhJpnsNiPJUcMJC9znHqTXoOyMBQY//AArAXcm7M+GHFUOWpABOShJVdlzRTy43X5QpMWItburBKVpnLoFDBOkAkAgEQVaUU7V06qTIlqgBZKrZgkrz1oPQDdPESTLn4pn62/dTMdfqst0cGnbY7c+dqzw7ZtfZRokZF5OmKSrZaJJJK1FbAJPaAuCAypuLByS/ZOCiKrGcKTHt5oOAHcnZH5yYryxStseR1AqtifK53utlvAy7/wCxFZ6A2q+X8OzRt8hDx1TLHJFD28d9Mp4O/mKjLjJO1jRYHmd9NwEBgnb5XMI7HpfqtjgPB/DJe9wc92+3T7p8eJ2VbWzDh0zRi8VoH9JpFfldujjncfmYW/urYTkLoR6OA3bItSSlTI2wWdRsue+NYtcDOwk/wt5wWP8AF8JdiOI30ODiPS14zSf8z2OeXGNnn+Rglg1AgjsOajDjV04fRb+IwUDVq9TSN2g/Reo+KlFM4P8A0nCVM5AyhG1w7rqjCw82N9dgo38NhcCCwC6Ft5ikjwF0fyKZzQKdaOTwZzd2EuHY81mygtNOBB9VQ8bTNsNiMl6GHDqq7sjemiyiJCNtAckKZdzj/pUhcTJTlNkvMlMrYKIn+qCOvspY3U/33RToVtMsf9PYW0Wg7KtiCrHY0tNjlRDT4rgBZJ");
                WriteLiteral(@"vZH0kmodstJg4XVqT8JLQ8horRw8RjN3bn+5p2+qeGG2Zc27CMf4soRYkj6DR9TyWhHwXbzP8AcDZacZB5ckVrXHAjlz3Zy/ZUj4XEK8gsdTZtTNxI/wDTZ/2hSgpwVb8omf75P9Gbis/02f8AaEjix/oZ9gpA9MXI/NAeSbK0nD4yPlr2sFKHF0/K51dibCneUmlSkJ2x3CxRAPuFEMNt2Nj6HmpLRBylBcWIMpOU4FpxGoTiwKSUvgn0TqE4s3wUZiD2uYdw4EFRsKmhabBXgoy4Oz2vHkqOA4hgvxJDG4eTYsPcHop45AV6DxTh8c8RZI0WRTXdQem68xcwxTPiJvQSF6fQ2/pGmee/I6ag+SNPUFHJJSEFOaXSRx2B4ziBp/cUgfjNJuUtP8JpcknYbeqUeMTzNouKYVklHxjN8AfkB9gSpPFiO3gW3/YQf5RtiA6I9YG6HzQ8diRjcUwYyNUcT2vB28pWFOXNIJjfd7jquzOQXbN/4RRYfV3mPrRVUsNm3HvSX6OVhmkfs2N32Vrh2PMyQvMZNjbuuqZjHo0D2pSsw3/+FCGFJhy7GTIjJj4hRpzHtPqBSn/FMfY5jsVrM4aTzcB9LtM/gkZ3I37jZaPPDH8mzHjxjdtNN7Kw1hWtHw9rRQ6KUQNHQJ1IsWAzI4CpPw3v9lohgHRPYQssWApNxfQp/wAJ6K7rTF6llqwIrDE9kX4EKVz0hIhY3xiQjhzepKL8Cz1+6l8RLxFA/JANgaOiMRt7IdSQeoMscQvDb2ToPESS0H5xP//Z""></a>
                    <h3 class=""name"">");
#nullable restore
#line 43 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
                                Write(n2.Naslov);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    <p class=\"description\">");
#nullable restore
#line 44 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
                                      Write(n2.Tekst);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p><a class=""action"" href=""#""><i class=""fa fa-arrow-circle-right""></i></a>
                </div>
                <div class=""col-sm-6 col-md-4 item"">
                    <a href=""#""><img class=""img-fluid"" src=""css/assets/img/default.jpg""></a>
                    <h3 class=""name"">");
#nullable restore
#line 48 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
                                Write(n3.Naslov);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    <p class=\"description\">");
#nullable restore
#line 49 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
                                      Write(n3.Tekst);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p><a class=""action"" href=""#""><i class=""fa fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <div class=""row articles"">
                <div class=""col-sm-6 col-md-4 item"">
                    <a href=""#""><img class=""img-fluid"" src=""css/assets/img/default.jpg""></a>
                    <h3 class=""name"">");
#nullable restore
#line 55 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
                                Write(n1.Naslov);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h3>\r\n                    <p class=\"description\">");
#nullable restore
#line 56 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
                                      Write(n1.Tekst);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p><a class=\"action\" href=\"#\"><i class=\"fa fa-arrow-circle-right\"></i></a>\r\n                </div>\r\n                <div class=\"col-sm-6 col-md-4 item\">\r\n                    <a href=\"#\"><img class=\"img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 9597, "\"", 9633, 1);
#nullable restore
#line 59 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
WriteAttributeValue("", 9603, Url.Content("~/css/news.jpg"), 9603, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("</a>\r\n                    <h3 class=\"name\">");
#nullable restore
#line 60 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
                                Write(n2.Naslov);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    <p class=\"description\">");
#nullable restore
#line 61 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
                                      Write(n2.Tekst);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p><a class=""action"" href=""#""><i class=""fa fa-arrow-circle-right""></i></a>
                </div>
                <div class=""col-sm-6 col-md-4 item"">
                    <a href=""#""><img class=""img-fluid"" src=""css/assets/img/default.jpg""></a>
                    <h3 class=""name"">");
#nullable restore
#line 65 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
                                Write(n3.Naslov);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    <p class=\"description\">");
#nullable restore
#line 66 "C:\Users\Hamid\Source\Repos\Grupa3-Treneri000\Implementacija\e-Teretana\Views\Home\Index.cshtml"
                                      Write(n3.Tekst);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p><a class=""action"" href=""#""><i class=""fa fa-arrow-circle-right""></i></a>
                </div>
            </div>
        </div>
    </div>
    <div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <h1>O nama:</h1>
                    <p>
                        Adresa: Naša adresa 31<br>E-mail: nasemail@email.ba<br>Broj telefona: 060/060-0600<br>Radno vrijeme: <br>Pon-Pet: 09:00 - 17:00<br>
                        Sub-Ned: Zatvoreno
                    </p>
                </div>
                <div id=""map"" class=""map"" style=""width:100%; height:400px""></div>
                <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/gh/openlayers/openlayers.github.io@master/en/v6.3.0/css/ol.css"" type=""text/css"">
                <script src=""https://cdn.jsdelivr.net/gh/openlayers/openlayers.github.io@master/en/v6.3.0/build/ol.js""></script>
                <script type=""text/javascript"">
                    var map = ne");
                WriteLiteral(@"w ol.Map({
                        target: 'map',
                        layers: [
                            new ol.layer.Tile({
                                source: new ol.source.OSM()
                            })
                        ],
                        view: new ol.View({
                            center: ol.proj.fromLonLat([18.2775913,43.849621]),
                            zoom: 18
                        })
                    });
                </script>
            </div>
        </div>
    </div>
    <div class=""map-clean"">
        <div class=""container"">
            <div class=""intro""></div>
        </div>
    </div>
    <div class=""footer-basic"">
        <footer>
            <div class=""social""><a href=""#""><i class=""icon ion-social-instagram""></i></a><a href=""#""><i class=""icon ion-social-snapchat""></i></a><a href=""#""><i class=""icon ion-social-twitter""></i></a><a href=""#""><i class=""icon ion-social-facebook""></i></a></div>
        </footer>
    </div>
 ");
                WriteLiteral("   <script src=\"css/assets/js/jquery.min.js\"></script>\r\n    <script src=\"css/assets/bootstrap/js/bootstrap.min.js\"></script>\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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
