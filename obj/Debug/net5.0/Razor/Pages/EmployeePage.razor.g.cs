#pragma checksum "C:\Front\UTS\Pages\EmployeePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7be498a0e7d5c51068b837e3be566e3e9654de71"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor344.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Front\UTS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Front\UTS\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Front\UTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Front\UTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Front\UTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Front\UTS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Front\UTS\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Front\UTS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Front\UTS\_Imports.razor"
using Blazor344;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Front\UTS\_Imports.razor"
using Blazor344.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeepage")]
    public partial class EmployeePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Daftar Employee</h3>\n");
            __builder.AddMarkupContent(1, "<p>By : Lenta Kristina Sianturi - 72190344</p>\n\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-striped");
            __builder.AddMarkupContent(4, "<thead><tr><th>Employee Id</th>\n            <th>First Name</th>\n            <th>Department Id</th>\n            <th></th></tr></thead>\n    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 16 "C:\Front\UTS\Pages\EmployeePage.razor"
         foreach (var emp in Employees) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 18 "C:\Front\UTS\Pages\EmployeePage.razor"
                     emp.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 19 "C:\Front\UTS\Pages\EmployeePage.razor"
                     emp.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 20 "C:\Front\UTS\Pages\EmployeePage.razor"
                     emp.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                ");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", 
#nullable restore
#line 21 "C:\Front\UTS\Pages\EmployeePage.razor"
                                $"employeedetail/{emp.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddContent(20, " Detail");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Front\UTS\Pages\EmployeePage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
