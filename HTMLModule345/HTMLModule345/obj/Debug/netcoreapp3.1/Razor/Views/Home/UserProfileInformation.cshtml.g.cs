#pragma checksum "/Users/moisesgolez/Desktop/HTML Modules/HTMLModule345/HTMLModule345/Views/Home/UserProfileInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2bd72c2ac64dadd9be9c46b3117cd3f8d5bd6f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserProfileInformation), @"mvc.1.0.view", @"/Views/Home/UserProfileInformation.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/moisesgolez/Desktop/HTML Modules/HTMLModule345/HTMLModule345/Views/_ViewImports.cshtml"
using HTMLModule345;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/moisesgolez/Desktop/HTML Modules/HTMLModule345/HTMLModule345/Views/_ViewImports.cshtml"
using HTMLModule345.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2bd72c2ac64dadd9be9c46b3117cd3f8d5bd6f6", @"/Views/Home/UserProfileInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbf7926e71a2f3abc26cdfcd0a9bd1a9966d3a32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserProfileInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "United States", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("size", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2bd72c2ac64dadd9be9c46b3117cd3f8d5bd6f64025", async() => {
                WriteLiteral(@"

    <table>

        <tbody>

            <tr>
                <td>

                    <h5>User Personal Information</h5>
                </td>

            </tr>
            <tr>
                <td>

                    <label for=""FirstName"">First Name:</label>

                </td>


                <td>

                    <input id=""FirstName"" name=""FirstName""
                           type=""text"" value=""Add your FirstName""
                           size=""18"" maxlength=""18""
                           placeholder=""Add your FirstName"" autofocus />

                    <label for=""LastName"">Last Name:</label>

                    <input id=""LastName"" name=""LastName""
                           type=""text"" value=""Add your LastName""
                           size=""18"" maxlength=""18""
                           placeholder=""Add your LastName"" autofocus />

                </td>

            </tr>

            <tr>

                <td>

                    <label>Gender:</label>



                </td");
                WriteLiteral(@">

                <td colspan=""3"">

                    <input type=""radio"" id=""MaleGender"" name=""gender"" />

                    <label for=""MaleGender"">Male</label>



                    <input type=""radio"" id=""FemaleGender"" name=""gender"" />

                    <label for=""FemaleGender"">Female</label>



                    <input type=""radio"" id=""NoResponseGender"" name=""gender"" />

                    <label for=""NoResponseGender"">Prefer not to respond</label>

                </td>
            <tr>
                <td colspan=""1"">
                    <label for=""FavoriteColor"">Choose favorite color</label>
                    <input type=""color"" id=""FavoriteColor"" />
                </td>

            
         
                <td>
                    <label for=""Birthday"">Birthday</label>

                    <input type=""date"" id=""Birthday"" min=""1970-05-01""
                           max=""2025-11-07"" />

                </td>
            </tr>
            <tr>
                <td>
                  ");
                WriteLiteral(@"  <label for=""Email"">Email:</label>
                </td>
                <td colspan=""3"">
                    <input type=""email"" id=""Email""
                           size=""50"" maxlength=""50"" placeholder=""Add your Email Address"" autofocus/>
                </td>

            </tr>

            <tr>
                <td>


                    <label for=""country"">Country of Residence:</label>

                </td>
                <td colspan=""1"">


                    <select id=""countries"" name=""countries"" >


                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2bd72c2ac64dadd9be9c46b3117cd3f8d5bd6f67036", async() => {
                    WriteLiteral("USA");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                    </select>
                </td>



            </tr>
            <tr>

                <td colspan=""1"">
                    <label for=""ProfileImage"">Select profile image:</label>
                </td>
                <td>
                    <input type=""file"" id=""ProfileImage"" multiple />

                </td>

            </tr>
            <tr>

                <td colspan=""3"">

                    <button>Update User Information</button>

                </td>

            </tr>
        </tbody>







    </table>







");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
