#pragma checksum "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ea3b4227e39b6589ae9050fe4d6d6d917fda0f2"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP_Assignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\_Imports.razor"
using DNP_Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\_Imports.razor"
using DNP_Assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
using DNP_Assignment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class AdultList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>List of Adults</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by User input: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                         (arg) => ExecuteFilter(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:200px");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddMarkupContent(10, "\r\n    Filter by:\r\n\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-group");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "select");
            __builder.AddAttribute(15, "style", "width:200px");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                       Selection

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Selection = __value, Selection));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "option");
            __builder.AddContent(20, "Id");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "option");
            __builder.AddContent(23, "First name");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "option");
            __builder.AddContent(26, "Last name");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "option");
            __builder.AddContent(29, "Hair color");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "option");
            __builder.AddContent(32, "Eye color");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "option");
            __builder.AddContent(35, "Age");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "option");
            __builder.AddContent(38, "Weight");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "option");
            __builder.AddContent(41, "Height");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "option");
            __builder.AddContent(44, "Sex");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n\r\n");
#nullable restore
#line 34 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
 if (adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "    ");
            __builder.AddMarkupContent(50, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 39 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
}
else if (!adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "    ");
            __builder.AddMarkupContent(52, "<p>\r\n        <em>No adults like this exist.</em>\r\n    </p>\r\n");
#nullable restore
#line 45 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "    ");
            __builder.OpenElement(54, "table");
            __builder.AddAttribute(55, "class", "table");
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.AddMarkupContent(57, @"<thead>
        <tr>
            <th>User ID</th>
            <th>Jobtitle</th>
            <th>First name</th>
            <th>Last name</th>
            <th>Hair Color</th>
            <th>Eye color</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>

        </tr>
        </thead>
        ");
            __builder.OpenElement(58, "tbody");
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 65 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
         foreach (Adult adult in adultsToShow)
        {
            if (adult.IsEditing)   //adult.IsEditing
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                ");
            __builder.OpenElement(61, "tr");
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "td");
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "type", "text");
            __builder.AddAttribute(67, "class", "form-control");
            __builder.AddAttribute(68, "placeholder", 
#nullable restore
#line 71 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                              adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                                                       adult.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adult.FirstName = __value, adult.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n                    ");
            __builder.OpenElement(73, "td");
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "type", "text");
            __builder.AddAttribute(77, "class", "form-control");
            __builder.AddAttribute(78, "placeholder", 
#nullable restore
#line 75 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                              adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                                                      adult.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adult.LastName = __value, adult.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n                    ");
            __builder.OpenElement(83, "td");
            __builder.AddMarkupContent(84, "\r\n                        ");
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "type", "text");
            __builder.AddAttribute(87, "class", "form-control");
            __builder.AddAttribute(88, "placeholder", 
#nullable restore
#line 79 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                              adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                                                       adult.HairColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adult.HairColor = __value, adult.HairColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n                    ");
            __builder.OpenElement(93, "td");
            __builder.AddMarkupContent(94, "\r\n                        ");
            __builder.OpenElement(95, "input");
            __builder.AddAttribute(96, "type", "text");
            __builder.AddAttribute(97, "class", "form-control");
            __builder.AddAttribute(98, "placeholder", 
#nullable restore
#line 83 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                              adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(99, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                                                      adult.EyeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(100, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adult.EyeColor = __value, adult.EyeColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n\r\n                    ");
            __builder.OpenElement(103, "td");
            __builder.AddMarkupContent(104, "\r\n                        ");
            __builder.OpenElement(105, "input");
            __builder.AddAttribute(106, "type", "text");
            __builder.AddAttribute(107, "class", "form-control");
            __builder.AddAttribute(108, "placeholder", 
#nullable restore
#line 87 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                              adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(109, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                                                 adult.Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adult.Age = __value, adult.Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n\r\n                    ");
            __builder.OpenElement(113, "td");
            __builder.AddMarkupContent(114, "\r\n                        ");
            __builder.OpenElement(115, "input");
            __builder.AddAttribute(116, "type", "text");
            __builder.AddAttribute(117, "class", "form-control");
            __builder.AddAttribute(118, "placeholder", 
#nullable restore
#line 91 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                              adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(119, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                                                    adult.Weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adult.Weight = __value, adult.Weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n\r\n                    ");
            __builder.OpenElement(123, "td");
            __builder.AddMarkupContent(124, "\r\n                        ");
            __builder.OpenElement(125, "input");
            __builder.AddAttribute(126, "type", "text");
            __builder.AddAttribute(127, "class", "form-control");
            __builder.AddAttribute(128, "placeholder", 
#nullable restore
#line 95 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                              adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(129, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 95 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                                                    adult.Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(130, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adult.Height = __value, adult.Height));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n\r\n                    ");
            __builder.OpenElement(133, "td");
            __builder.AddMarkupContent(134, "\r\n                        ");
            __builder.OpenElement(135, "input");
            __builder.AddAttribute(136, "type", "text");
            __builder.AddAttribute(137, "class", "form-control");
            __builder.AddAttribute(138, "placeholder", 
#nullable restore
#line 99 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                              adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(139, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                                                                 adult.Sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(140, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adult.Sex = __value, adult.Sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n\r\n                    ");
            __builder.OpenElement(143, "td");
            __builder.AddMarkupContent(144, "\r\n                        ");
            __builder.OpenElement(145, "button");
            __builder.AddAttribute(146, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                            () => initiateEdit(adult.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(147, "\r\n                            <i class=\"oi oi-file\" style=\"color:blue\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n");
#nullable restore
#line 108 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(151, "                ");
            __builder.OpenElement(152, "tr");
            __builder.AddMarkupContent(153, "\r\n                    ");
            __builder.OpenElement(154, "td");
            __builder.AddContent(155, 
#nullable restore
#line 112 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                         adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n                    ");
            __builder.OpenElement(157, "td");
            __builder.AddContent(158, 
#nullable restore
#line 113 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                         adult.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                    ");
            __builder.OpenElement(160, "td");
            __builder.AddContent(161, 
#nullable restore
#line 114 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                         adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n                    ");
            __builder.OpenElement(163, "td");
            __builder.AddContent(164, 
#nullable restore
#line 115 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                         adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                    ");
            __builder.OpenElement(166, "td");
            __builder.AddContent(167, 
#nullable restore
#line 116 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                         adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n                    ");
            __builder.OpenElement(169, "td");
            __builder.AddContent(170, 
#nullable restore
#line 117 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                         adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n                    ");
            __builder.OpenElement(172, "td");
            __builder.AddContent(173, 
#nullable restore
#line 118 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                         adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n                    ");
            __builder.OpenElement(175, "td");
            __builder.AddContent(176, 
#nullable restore
#line 119 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                         adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n                    ");
            __builder.OpenElement(178, "td");
            __builder.AddContent(179, 
#nullable restore
#line 120 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                         adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n                    ");
            __builder.OpenElement(181, "td");
            __builder.AddContent(182, 
#nullable restore
#line 121 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                         adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(184);
            __builder.AddAttribute(185, "Policy", "MustBeAdmin");
            __builder.AddAttribute(186, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(187, "\r\n                            ");
                __builder2.OpenElement(188, "td");
                __builder2.AddMarkupContent(189, "\r\n                                ");
                __builder2.OpenElement(190, "button");
                __builder2.AddAttribute(191, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 126 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                    () => EnableEditing(true, adult.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(192, "\r\n                                    <i class=\"oi oi-wrench\" style=\"color:cyan\"></i>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(193, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(194, "\r\n\r\n                            ");
                __builder2.OpenElement(195, "td");
                __builder2.AddMarkupContent(196, "\r\n                                ");
                __builder2.OpenElement(197, "button");
                __builder2.AddAttribute(198, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 132 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
                                                    () => RemoveAdult(adult.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(199, "\r\n                                    <i class=\"oi oi-trash\" style=\"color:red\"></i>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(200, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(201, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(202, "\r\n\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\r\n");
#nullable restore
#line 141 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(204, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(206, "\r\n");
#nullable restore
#line 145 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 147 "C:\Users\kawaz\Google Drev\Uni Uddannelse\3 Semester\C#\DNP_Assignment\DNP_Assignment\Pages\AdultList.razor"
       

    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;

    private string Selection = "";
    private string filterOptions;

    private string updatedFirstName = "";
    private string updatedLastName = "";
    private string updatedHairColor;
    private string updatedEyeColor;
    private int updatedAge = 0;
    private float updatedWeight;
    private int updatedHeight;
    private string updatedSex;


    /*Filter by chosen input*/

    private void ExecuteFilter(ChangeEventArgs changeEventArgs)
    {
        filterOptions = changeEventArgs.Value.ToString();

        try
        {
            switch (Selection)
            {
                case "Id":
                    adultsToShow = allAdults.Where(t => (filterOptions != null && t.Id == int.Parse(filterOptions) || string.IsNullOrEmpty(filterOptions))).ToList();
                    break;

                case "First name":
                    adultsToShow = allAdults.Where(t => (filterOptions != null && t.FirstName.Contains(filterOptions) || string.IsNullOrEmpty(filterOptions))).ToList();
                    break;

                case "Last name":
                    adultsToShow = allAdults.Where(t => (filterOptions != null && t.LastName.Contains(filterOptions) || string.IsNullOrEmpty(filterOptions))).ToList();
                    break;

                case "Hair color":
                    adultsToShow = allAdults.Where(t => (filterOptions != null && t.HairColor.Contains(filterOptions) || string.IsNullOrEmpty(filterOptions))).ToList();
                    break;

                case "Eye color":
                    adultsToShow = allAdults.Where(t => (filterOptions != null && t.EyeColor.Contains(filterOptions) || string.IsNullOrEmpty(filterOptions))).ToList();
                    break;

                case "Age":
                    adultsToShow = allAdults.Where(t => (filterOptions != null && t.Age == int.Parse(filterOptions) || string.IsNullOrEmpty(filterOptions))).ToList();
                    break;

                case "Weight":
                    adultsToShow = allAdults.Where(t => (filterOptions != null && t.Weight == float.Parse(filterOptions) || string.IsNullOrEmpty(filterOptions))).ToList();
                    break;

                case "Height":
                    adultsToShow = allAdults.Where(t => (filterOptions != null && t.Height == int.Parse(filterOptions) || string.IsNullOrEmpty(filterOptions))).ToList();
                    break;

                case "Sex":
                    adultsToShow = allAdults.Where(t => (filterOptions != null && t.Sex.Contains(filterOptions) || string.IsNullOrEmpty(filterOptions))).ToList();
                    break;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e);
            adultsToShow = allAdults;
        }
    }


    protected override async Task OnInitializedAsync()
    {
        allAdults = await CloudService.getAdultsAsync();
        adultsToShow = allAdults;
    }

    /*Remove Adult from list by id*/

    private void RemoveAdult(int id)
    {
        Adult adultToRemove = adultsToShow.First(i => i.Id == id);
        CloudService.removeAdultAsync(id);
        adultsToShow.Remove(adultToRemove);

        adultsToShow = allAdults;
    }


    /*Edit adult information*/

    private void EnableEditing(bool flag, int id)
    {
        Adult adultToBeUpdated = adultsToShow.First(i => i.Id == id);
        adultToBeUpdated.IsEditing = flag;
    }

    private void initiateEdit(int id)
    {
        Adult adultToBeUpdated = adultsToShow.First(i => i.Id == id);
        updatedFirstName = adultToBeUpdated.FirstName;
        updatedLastName = adultToBeUpdated.LastName;
        updatedHairColor = adultToBeUpdated.HairColor;
        updatedEyeColor = adultToBeUpdated.EyeColor;
        updatedAge = adultToBeUpdated.Age;
        updatedWeight = adultToBeUpdated.Weight;
        updatedHeight = adultToBeUpdated.Height;
        updatedSex = adultToBeUpdated.Sex;
        EditAdult(id);
        
        /*
        if (String.IsNullOrEmpty(adultToBeUpdated.FirstName) || !adultToBeUpdated.FirstName.Equals(updatedFirstName))
        {
            updatedFirstName = adultToBeUpdated.FirstName;
            EditFirstname(id, updatedFirstName);
        }

        if (String.IsNullOrEmpty(adultToBeUpdated.LastName) || !adultToBeUpdated.LastName.Equals(updatedLastname))
        {
            updatedLastname = adultToBeUpdated.LastName;
            EditLastname(id, updatedLastname);
        }

        if (String.IsNullOrEmpty(adultToBeUpdated.LastName) || String.IsNullOrEmpty(adultToBeUpdated.LastName))
        {
            updatedLastname = adultToBeUpdated.LastName;
            EditHairColor(id, updatedLastname);
        }

        if (String.IsNullOrEmpty(adultToBeUpdated.HairColor) || String.IsNullOrEmpty(adultToBeUpdated.HairColor))
        {
            updatedHairColor = adultToBeUpdated.HairColor;
            EditHairColor(id, updatedHairColor);
        }

        if (String.IsNullOrEmpty(adultToBeUpdated.EyeColor) || String.IsNullOrEmpty(adultToBeUpdated.EyeColor))
        {
            updatedEyeColor = adultToBeUpdated.EyeColor;
            EditHairColor(id, updatedEyeColor);
        }

        if (adultToBeUpdated.Age == 0 || adultToBeUpdated.Age != updatedAge)
        {
            updatedAge = adultToBeUpdated.Age;
            EditAge(id, updatedAge);
        }

        if (adultToBeUpdated.Weight == 0 || adultToBeUpdated.Weight != updatedWeight)
        {
            updatedWeight = adultToBeUpdated.Weight;
            EditWeight(id, updatedWeight);
        }

        if (adultToBeUpdated.Height == 0 || adultToBeUpdated.Height != updatedHeight)
        {
            updatedHeight = adultToBeUpdated.Height;
            EditHeight(id, updatedHeight);
        }

        if (String.IsNullOrEmpty(adultToBeUpdated.Sex) || String.IsNullOrEmpty(adultToBeUpdated.Sex))
        {
            updatedSex = adultToBeUpdated.Sex;
            EditSex(id, updatedSex);
        }

        else
        {
            adultToBeUpdated.IsEditing = false;
        }
        */
        
    }


    /* Code for specific editing/ updates */
    private void EditAdult(int id)
    {
        Adult adultToBeUpdated = adultsToShow.First(i => i.Id == id);
        CloudService.updateAdult(adultToBeUpdated, updatedFirstName, updatedLastName, updatedHairColor, updatedEyeColor, updatedAge, updatedWeight, updatedHeight, updatedSex);
        adultToBeUpdated.IsEditing = false;

    }
    
    /*
    private void EditFirstname(int id, string firstName)
    {
        //TODO The updateMethod can be used with PUT? Which creates/ updates data, can't it be used for both things then?
        Adult adultToBeUpdated = adultsToShow.First(i => i.Id == id);
        CloudService.updateFirstNameAsync(adultToBeUpdated, updatedFirstName);
        adultToBeUpdated.IsEditing = false;
    }

    private void EditLastname(int id, string lastName)
    {
        Adult adultToBeUpdated = adultsToShow.First(i => i.Id == id);
        CloudService.updateLastNameAsync(adultToBeUpdated, updatedLastname);
        adultToBeUpdated.IsEditing = false;
    }

    private void EditHairColor(int id, string hairColor)
    {
        Adult adultToBeUpdated = adultsToShow.First(i => i.Id == id);
        CloudService.updateHairColorAsync(adultToBeUpdated, updatedHairColor);
        adultToBeUpdated.IsEditing = false;
    }

    private void EditEyeColor(int id, string eyeColor)
    {
        Adult adultToBeUpdated = adultsToShow.First(i => i.Id == id);
        CloudService.updateEyeColorAsync(adultToBeUpdated, updatedEyeColor);
        adultToBeUpdated.IsEditing = false;
    }

    private void EditAge(int id, int age)
    {
        Adult adultToBeUpdated = adultsToShow.First(i => i.Id == id);
        CloudService.updateAgeAsync(adultToBeUpdated, updatedAge);
        adultToBeUpdated.IsEditing = false;
    }


    private void EditWeight(int id, float weight)
    {
        Adult adultToBeUpdated = adultsToShow.First(i => i.Id == id);
        CloudService.updateWeightAsync(adultToBeUpdated, updatedWeight);
        adultToBeUpdated.IsEditing = false;
    }


    private void EditHeight(int id, int height)
    {
        Adult adultToBeUpdated = adultsToShow.First(i => i.Id == id);
        CloudService.updateHeightAsync(adultToBeUpdated, updatedHeight);
        adultToBeUpdated.IsEditing = false;
    }

    private void EditSex(int id, string sex)
    {
        Adult adultToBeUpdated = adultsToShow.First(i => i.Id == id);
        CloudService.updateSexAsync(adultToBeUpdated, updatedSex);
        adultToBeUpdated.IsEditing = false;
    }

*/


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudService CloudService { get; set; }
    }
}
#pragma warning restore 1591
