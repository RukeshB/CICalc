#pragma checksum "D:\dotnet\CICalc\Pages\CompoundInterest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55a18d6362fce33e4f890d488a8de74428554f41"
// <auto-generated/>
#pragma warning disable 1591
namespace CICalc.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\dotnet\CICalc\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotnet\CICalc\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotnet\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotnet\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dotnet\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotnet\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dotnet\CICalc\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dotnet\CICalc\_Imports.razor"
using CICalc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dotnet\CICalc\_Imports.razor"
using CICalc.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/compoundinterest")]
    public partial class CompoundInterest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Compound Intrest</h1>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<th>Initial Principal</th>\r\n        ");
            __builder.OpenElement(7, "th");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "D:\dotnet\CICalc\Pages\CompoundInterest.razor"
                          Principal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Principal = __value, Principal));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<th>Years</th>\r\n        ");
            __builder.OpenElement(16, "th");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "D:\dotnet\CICalc\Pages\CompoundInterest.razor"
                          Years

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Years = __value, Years));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<th>Annual Interest Rate (%)</th>\r\n        ");
            __builder.OpenElement(25, "th");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\dotnet\CICalc\Pages\CompoundInterest.razor"
                          InterestRate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InterestRate = __value, InterestRate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.AddMarkupContent(33, "<th>Total:</th>\r\n        ");
            __builder.OpenElement(34, "th");
            __builder.AddContent(35, 
#nullable restore
#line 20 "D:\dotnet\CICalc\Pages\CompoundInterest.razor"
             Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-primary");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\dotnet\CICalc\Pages\CompoundInterest.razor"
                                          Calculate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Calculate");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "D:\dotnet\CICalc\Pages\CompoundInterest.razor"
 
    private double Principal { get; set; } = 5000;
    private double InterestRate { get; set; } = 5;
    private int Years { get; set; } = 10;
    private double total { get; set; } = 0;
    private string Total { get; set; }

    private void Calculate()
    {
        var total = Principal * Math.Pow(1 + InterestRate / (1200.0), Years * 12);
        Total = total.ToString("C");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
