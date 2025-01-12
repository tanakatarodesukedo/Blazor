#pragma checksum "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5806c3583b68ca0185b08af105c34499f3df28ba8c6b1d3cd5f0a3bb2e9388ea"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Client.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 24 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 27 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
__builder.AddContent(15, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 28 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
__builder.AddContent(18, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 29 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
__builder.AddContent(21, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 30 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
__builder.AddContent(24, forecast.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 32 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.AddContent(30, "    ");
            __builder.OpenElement(31, "table");
            __builder.AddAttribute(32, "class", "table");
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.AddMarkupContent(34, "<thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Name</th>\r\n                <th>Price</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(35, "tbody");
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 45 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                ");
            __builder.OpenElement(38, "tr");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "td");
#nullable restore
#line 48 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
__builder.AddContent(41, product.ProductID);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
#nullable restore
#line 49 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
__builder.AddContent(44, product.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
#nullable restore
#line 50 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
__builder.AddContent(47, product.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 52 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 55 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\cic44\source\repos\BlazorApp\BlazorApp\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    private Product[] products;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        products = await Http.GetFromJsonAsync<Product[]>("WeatherForecast/Test");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
