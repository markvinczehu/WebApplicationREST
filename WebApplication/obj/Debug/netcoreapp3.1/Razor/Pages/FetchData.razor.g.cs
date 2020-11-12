#pragma checksum "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "229344e4e8c2f72c0559fc6822875d048afc10eb"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
using WebApplication.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
using WebApplication.Data.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adult")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Searching for adults</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by User Id: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
                                                        (arg) => FilterById(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:100px");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
 if (_allAdults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.AddMarkupContent(10, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 16 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
} else if (!_filteredAdults.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.AddMarkupContent(12, "<p>\r\n        <em>There is no adult to show.</em>\r\n    </p>\r\n");
#nullable restore
#line 21 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.AddMarkupContent(17, @"<thead>
        <tr>
            <th>Job title</th>
            <th>ID</th>
            <th>First name</th>
            <th>Last name</th>
            <th>Hair color</th>
            <th>Eye color</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
        </tr>
        </thead>
        ");
            __builder.OpenElement(18, "tbody");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 40 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
         foreach (var adult in _filteredAdults)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "            ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 43 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
                     adult.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 44 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
                     adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 45 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
                     adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 46 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
                     adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 47 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
                     adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 48 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
                     adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 49 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
                     adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 50 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
                     adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 51 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
                     adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 52 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
                     adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 54 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 57 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Felhasználó\source\repos\DNP1_assign2-3\WebApplication\Pages\FetchData.razor"
       
    private IList<Adult> _allAdults;
    private IList<Adult> _filteredAdults;
    private IService Service = new CloudService();
    
    private int? filterById;

    private void FilterById(ChangeEventArgs changeEventArgs) {
        filterById = null;
        try {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        } catch (Exception e) { }
        ExecuteFilter();
    }
    
    private void ExecuteFilter() {
        _filteredAdults = _allAdults.Where(t => 
            (filterById != null && t.Id == filterById || filterById == null)
            ).ToList();
    }
    
    protected override async Task OnInitializedAsync()
    {
        _filteredAdults = await Service.GetAsync();
        _allAdults = _filteredAdults;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
