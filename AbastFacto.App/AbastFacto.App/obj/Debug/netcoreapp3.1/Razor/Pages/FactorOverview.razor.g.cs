#pragma checksum "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\Pages\FactorOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baeba34baa368075d3fd914903aed68580038ca3"
// <auto-generated/>
#pragma warning disable 1591
namespace AbastFacto.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\_Imports.razor"
using AbastFacto.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\_Imports.razor"
using AbastFacto.App.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/factoroverview")]
    public partial class FactorOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"page-title\">Supply Factor List</h1>\r\n\r\n");
#nullable restore
#line 5 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\Pages\FactorOverview.razor"
 if (Factors == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 8 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\Pages\FactorOverview.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                \r\n                <th>ID Factor</th>\r\n                <th>Short Name</th>\r\n                <th>Measure</th>\r\n                <th></th>\r\n              \r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 23 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\Pages\FactorOverview.razor"
             foreach (var factor in Factors)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 26 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\Pages\FactorOverview.razor"
                         factor.FactorId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 27 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\Pages\FactorOverview.razor"
                         factor.ShortName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 28 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\Pages\FactorOverview.razor"
                         factor.Metric

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", 
#nullable restore
#line 30 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\Pages\FactorOverview.razor"
                                   $"factordetail/{factor.FactorId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(27, "\r\n                            <i class=\"fas fa-info-circle\"></i>\r\n                            Factor Detail\r\n                     \r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 37 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\Pages\FactorOverview.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 40 "D:\CaracterizacionUC\AbastFacto.App\AbastFacto.App\Pages\FactorOverview.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
