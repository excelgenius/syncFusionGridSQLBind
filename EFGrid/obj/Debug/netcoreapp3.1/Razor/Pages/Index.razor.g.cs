#pragma checksum "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27cb7f0d732175a0cab12857a64c6cf84cec4ff7"
// <auto-generated/>
#pragma warning disable 1591
namespace EFGrid.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\_Imports.razor"
using EFGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\_Imports.razor"
using EFGrid.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Grids.SfGrid<Order>>(0);
            __builder.AddAttribute(1, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Width", "800");
            __builder.AddAttribute(3, "Toolbar", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
                                                                             new List<string>() { "Add","Edit","Delete","Update","Cancel"}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(6);
                __builder2.AddAttribute(7, "AllowAdding", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "AllowDeleting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "AllowEditing", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Data.SfDataManager>(11);
                __builder2.AddAttribute(12, "Adaptor", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Adaptors>(
#nullable restore
#line 10 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
                            Adaptors.CustomAdaptor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "\r\n        ");
                    __builder3.OpenElement(15, "CustomAdaptorComponent");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(16, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(18);
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(20, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(21);
                    __builder3.AddAttribute(22, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
                           nameof(Order.OrderID)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "HeaderText", "Order ID");
                    __builder3.AddAttribute(24, "IsIdentity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "IsPrimaryKey", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 14 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
                                                                                                                        TextAlign.Left

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "Width", "20");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(29);
                    __builder3.AddAttribute(30, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
                           nameof(Order.CustomerID)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "HeaderText", "Customer Name");
                    __builder3.AddAttribute(32, "Width", "150");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(35, (__value) => {
#nullable restore
#line 8 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
              Grid = (Syncfusion.Blazor.Grids.SfGrid<Order>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Files\OneDrive - Rivait Software Systems Inc\Programming\blazorTestProjs\blazor-grid-sqldatabinding\EFGrid\Pages\Index.razor"
      
    SfGrid<Order> Grid { get; set; }
    public static List<Order> Orders { get; set; }

    public class Order
    {
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
