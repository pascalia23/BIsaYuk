#pragma checksum "C:\Front\UTS\Pages\DetailDepartment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78f669e4b2abc1e83a2958fadbfb175920462054"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/departmentdetail/{id}")]
    public partial class DetailDepartment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Detail Data Department</h3>\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, " Id : ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\Front\UTS\Pages\DetailDepartment.razor"
          Department.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, " Name : ");
            __builder.AddContent(7, 
#nullable restore
#line 5 "C:\Front\UTS\Pages\DetailDepartment.razor"
            Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
