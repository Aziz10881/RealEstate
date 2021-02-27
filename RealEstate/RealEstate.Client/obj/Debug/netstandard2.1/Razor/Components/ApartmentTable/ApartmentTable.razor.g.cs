#pragma checksum "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "771a3b31defdc9afe5603b5c54959ad38150fe15"
// <auto-generated/>
#pragma warning disable 1591
namespace RealEstate.Client.Components.ApartmentTable
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using RealEstate.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using RealEstate.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Entities.Models;

#line default
#line hidden
#nullable disable
    public partial class ApartmentTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
 if (Apartments.Count > 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, @"<thead>
            <tr>
                <th scope=""col""></th>
                <th scope=""col"">NoRooms</th>
                <th scope=""col"">FloorNo</th>
                <th scope=""col"">Area</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Status</th>
                <th scope=""col"">City</th>
                <th scope=""col"">Price</th>
                <th scope=""col"">Edit</th>
                <th scope=""col"">Delete</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 20 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
             foreach (var apartment in Apartments)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 24 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
                               apartment.ImageURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "alt", "apartment image");
            __builder.AddAttribute(15, "style", "width:150px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "class", "align-middle");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.AddContent(21, 
#nullable restore
#line 27 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
                     apartment.NumOfRooms

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "class", "align-middle");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.AddContent(27, 
#nullable restore
#line 30 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
                     apartment.FloorNo

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "class", "align-middle");
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.AddContent(33, 
#nullable restore
#line 33 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
                     apartment.Square

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, " m²\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.AddAttribute(37, "class", "align-middle");
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.AddContent(39, 
#nullable restore
#line 36 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
                     apartment.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "class", "align-middle");
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.AddContent(45, 
#nullable restore
#line 39 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
                     apartment.Status

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "td");
            __builder.AddAttribute(49, "class", "align-middle");
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.AddContent(51, 
#nullable restore
#line 43 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
                     apartment.RegionId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n                ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "class", "align-middle");
            __builder.AddMarkupContent(56, "\r\n                    $");
            __builder.AddContent(57, 
#nullable restore
#line 47 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
                      apartment.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n                ");
            __builder.OpenElement(60, "td");
            __builder.AddAttribute(61, "class", "align-middle");
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "class", "btn btn-info");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
                                                                         () => RedirectToUpdate(apartment.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.OpenElement(70, "td");
            __builder.AddAttribute(71, "class", "align-middle");
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "type", "button");
            __builder.AddAttribute(75, "class", "btn btn-danger");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
                                                                           () => Delete(apartment.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(77, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 57 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 60 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "    ");
            __builder.AddMarkupContent(85, "<span>\r\n        Loading Apartments...\r\n    </span>\r\n");
#nullable restore
#line 66 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\ApartmentTable\ApartmentTable.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
