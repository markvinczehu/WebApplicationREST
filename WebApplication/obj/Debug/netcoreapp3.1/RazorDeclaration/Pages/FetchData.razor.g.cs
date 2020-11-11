#pragma checksum "C:\Users\Felhasználó\source\repos\WebApplicationREST_DNP1_assignment2-3\WebApplication\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "229344e4e8c2f72c0559fc6822875d048afc10eb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Felhasználó\source\repos\WebApplicationREST_DNP1_assignment2-3\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Felhasználó\source\repos\WebApplicationREST_DNP1_assignment2-3\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Felhasználó\source\repos\WebApplicationREST_DNP1_assignment2-3\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Felhasználó\source\repos\WebApplicationREST_DNP1_assignment2-3\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Felhasználó\source\repos\WebApplicationREST_DNP1_assignment2-3\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Felhasználó\source\repos\WebApplicationREST_DNP1_assignment2-3\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Felhasználó\source\repos\WebApplicationREST_DNP1_assignment2-3\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Felhasználó\source\repos\WebApplicationREST_DNP1_assignment2-3\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Felhasználó\source\repos\WebApplicationREST_DNP1_assignment2-3\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Felhasználó\source\repos\WebApplicationREST_DNP1_assignment2-3\WebApplication\Pages\FetchData.razor"
using WebApplication.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Felhasználó\source\repos\WebApplicationREST_DNP1_assignment2-3\WebApplication\Pages\FetchData.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Felhasználó\source\repos\WebApplicationREST_DNP1_assignment2-3\WebApplication\Pages\FetchData.razor"
       
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
