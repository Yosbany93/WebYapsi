#pragma checksum "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\Pages\Acciones.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86fac0f615b28c22348478411ede99ebd250568e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorYapsi.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\_Imports.razor"
using BlazorYapsi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\_Imports.razor"
using BlazorYapsi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class Acciones : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatButton>(0);
            __builder.AddAttribute(1, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\Pages\Acciones.razor"
                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Icon", "create");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\Pages\Acciones.razor"
                                                 Editar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, "Editar");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenComponent<MatBlazor.MatButton>(7);
            __builder.AddAttribute(8, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\Pages\Acciones.razor"
                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Icon", "view_list");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\Pages\Acciones.razor"
                                                    Movimientos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(12, "Consultar Movimientos");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenComponent<MatBlazor.MatButton>(14);
            __builder.AddAttribute(15, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\Pages\Acciones.razor"
                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Icon", "clear");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\Pages\Acciones.razor"
                                                ELiminar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(19, "ELiminar");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\Programing\000entrevistas tecnicas\Yapsi\BlazorYapsi\Pages\Acciones.razor"
       
    [Parameter] public int Id { get; set; }
    [Parameter] public EventCallback<Tuple<int, int>> onEdit { get; set; }


    private async Task Editar()
    {
        await onEdit.InvokeAsync(new Tuple<int, int>(item1: Id, item2: 1));
    }

    private async Task Movimientos()
    {
        await onEdit.InvokeAsync(new Tuple<int, int>(item1: Id, item2: 2));
    }

    private async Task ELiminar()
    {
        await onEdit.InvokeAsync(new Tuple<int, int>(item1: Id, item2: 3));
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
