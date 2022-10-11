#pragma checksum "C:\Users\Tismart\Desktop\TISMART\C# .NET\PopIn-PaymentForm-T1.Net\PopInPaymentForm\PopInPaymentForm\Views\Payment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50994482e0f589e1f096eb73f318431333c82bde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Index), @"mvc.1.0.view", @"/Views/Payment/Index.cshtml")]
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
#line 1 "C:\Users\Tismart\Desktop\TISMART\C# .NET\PopIn-PaymentForm-T1.Net\PopInPaymentForm\PopInPaymentForm\Views\_ViewImports.cshtml"
using PopInPaymentForm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tismart\Desktop\TISMART\C# .NET\PopIn-PaymentForm-T1.Net\PopInPaymentForm\PopInPaymentForm\Views\_ViewImports.cshtml"
using PopInPaymentForm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50994482e0f589e1f096eb73f318431333c82bde", @"/Views/Payment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b2eee040bda63a0e76e361547c7d7adc0feafa2", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Tismart\Desktop\TISMART\C# .NET\PopIn-PaymentForm-T1.Net\PopInPaymentForm\PopInPaymentForm\Views\Payment\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Tismart\Desktop\TISMART\C# .NET\PopIn-PaymentForm-T1.Net\PopInPaymentForm\PopInPaymentForm\Views\Payment\Index.cshtml"
  
    PaymentModel gm = new PaymentModel();
    ViewData["url"] = gm.URL_BASE;
    ViewData["js_token"] = gm.KEY_JS;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"form-izi\">\r\n    <h3>Formulario POP-IN</h3>\r\n    <div id=\"valdas\" class=\"kr-embedded\" kr-payment-button=\"PAGAR\"  kr-popin");
            BeginWriteAttribute("kr-form-token", " kr-form-token=\"", 304, "\"", 334, 1);
#nullable restore
#line 14 "C:\Users\Tismart\Desktop\TISMART\C# .NET\PopIn-PaymentForm-T1.Net\PopInPaymentForm\PopInPaymentForm\Views\Payment\Index.cshtml"
WriteAttributeValue("", 320, ViewBag.token, 320, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""kr-pan""></div>
        <div class=""kr-expiry""></div>
        <div class=""kr-security-code""></div>
        <!-- payment form submit button -->
        <button class=""kr-popin-button"" style=""background-color: #00A09D;""></button>
        <!-- error zone -->
        <div class=""kr-form-error""></div>
    </div>
</div>
<script>
    var cont = 0;
    KR.onError(function (event) {
        var code = event.errorCode;
        if (code != null) {
            cont = cont + 1;
        }

        if (cont > 1) {
            document.getElementById(""valdas"").style.display = ""none"";
        }
    });
    KR.onSubmit(function (event) {
        $.ajax({
            url: '/Payment/validate/',
            data: {
                kr_hash_algorithm: event.hashAlgorithm.toString(),
                kr_answer: event.rawClientAnswer,
                kr_hash_key: event.hashKey.toString(),
                kr_hash: event.hash.toString()
            },
            type: 'POST',
       ");
            WriteLiteral(@"     dataType: 'json',
            success: function (json) {
                if (json == 'true') {
                    Swal.fire(
                        'Resultado',
                        'Autorizacion Exitosa!',
                        'success'
                    )
                }
            },
            error: function (xhr, status) {
                console.log(xhr);
                console.log(json.parse(xhr));
                console.log(xhr + ' ' + status);
                alert('Disculpe, existió un problema');
            }
        });
        return false;
    });
</script>");
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
