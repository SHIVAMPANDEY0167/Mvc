#pragma checksum "C:\Users\shivam.pandey\source\repos\EmployeeCrudMvc\EmployeeCrudMvc\Views\Employee\Department.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9e39eee0641d0677f578340cbce8f75bcdef9ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Department), @"mvc.1.0.view", @"/Views/Employee/Department.cshtml")]
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
#line 1 "C:\Users\shivam.pandey\source\repos\EmployeeCrudMvc\EmployeeCrudMvc\Views\_ViewImports.cshtml"
using EmployeeCrudMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shivam.pandey\source\repos\EmployeeCrudMvc\EmployeeCrudMvc\Views\_ViewImports.cshtml"
using EmployeeCrudMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e39eee0641d0677f578340cbce8f75bcdef9ea", @"/Views/Employee/Department.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2fec48c338f9a4bfbd1237d61fcc5dc175f0af", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Department : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\shivam.pandey\source\repos\EmployeeCrudMvc\EmployeeCrudMvc\Views\Employee\Department.cshtml"
  
    ViewData["Title"] = "Department";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""d-flex flex-column"">
    <div class=""d-flex flex-grow-1>
        <aside>
        </aside>
        <main>
            <div class=""col-12"">
                <div class=""bg-light rounded h-100 p-4"">
                    <div class=""d-flex align-items-center justify-content-between mb-4"">
                        <h6>Department Details</h6>
                        
                    </div>

                    <table class=""table table-dark"">
                        <thead>
                            <tr> 
                                <th scope=""col"">Department</th> 
                            </tr>
                        </thead>
                        <tbody>

                            <tr>
                                <td>.Net</td>
                            </tr>
                            <tr>
                                <td>Front End</td>
                            </tr>
                            <tr>
                                <td>Uit</td>
  ");
            WriteLiteral(@"                          </tr>
                            <tr>
                                <td>ML</td>
                            </tr>
                            <tr>
                                <td>Database</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </main>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
