#pragma checksum "C:\Work\Git\BlazorGQL\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bd34e9b29ef447a2b07e24d61aec1399e92c6ac"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorGQL.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Work\Git\BlazorGQL\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Work\Git\BlazorGQL\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Work\Git\BlazorGQL\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Work\Git\BlazorGQL\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Work\Git\BlazorGQL\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Work\Git\BlazorGQL\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Work\Git\BlazorGQL\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Work\Git\BlazorGQL\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Work\Git\BlazorGQL\_Imports.razor"
using BlazorGQL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Work\Git\BlazorGQL\_Imports.razor"
using BlazorGQL.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Work\Git\BlazorGQL\_Imports.razor"
using BlazorGQL.GraphQL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<BlazorGQL.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "ul");
#nullable restore
#line 11 "C:\Work\Git\BlazorGQL\Pages\Index.razor"
   foreach (string title in titles) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "li");
            __builder.AddContent(6, 
#nullable restore
#line 12 "C:\Work\Git\BlazorGQL\Pages\Index.razor"
         title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Work\Git\BlazorGQL\Pages\Index.razor"
  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Work\Git\BlazorGQL\Pages\Index.razor"
       
    private string[] titles = Array.Empty<string>(); 
    protected override async Task OnInitializedAsync() 
    {
        var result = await Commands.GetPlatforms.ExecuteAsync(); 
        titles = result.Data.Platform.Select(t => t.Name).ToArray();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Commands Commands { get; set; }
    }
}
#pragma warning restore 1591
