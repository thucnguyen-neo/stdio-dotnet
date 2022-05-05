#pragma checksum "D:\Software Engineering\Training\STDIO\dotNet - student\dotNet\STDIO_dotNet\STDIO_dotNet\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7a690f09f2a9367414cd3d52140f4e1648803af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "D:\Software Engineering\Training\STDIO\dotNet - student\dotNet\STDIO_dotNet\STDIO_dotNet\Views\_ViewImports.cshtml"
using STDIO_dotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Software Engineering\Training\STDIO\dotNet - student\dotNet\STDIO_dotNet\STDIO_dotNet\Views\_ViewImports.cshtml"
using STDIO_dotNet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7a690f09f2a9367414cd3d52140f4e1648803af", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99e9f49970e181eaa18db725a0a7658270bb3932", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentHandler>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"">

    <h1 class=""display-4""> Student Info </h1>

    <div class=""function-container"">
            <div class=""add-student"">
                <i class=""bi bi-plus-circle""></i>
                <span>Add Student</span>
            </div>
            <div class=""search"">
                <i class=""bi bi-search""></i>
                <input type=""search"" id=""search"" name=""search"" placeholder=""Search student..."">
            </div>
    </div>

       


    <table class=""table"">
      <thead class=""table-dark"">
        <tr>
          <th scope=""col"">ID</th>
          <th scope=""col"">Name</th>
          <th scope=""col"">Gender</th>
          <th scope=""col"">Birthdate</th>
          <th scope=""col"">MajorID</th>
          <th scope=""col"">UniversityID</th>
          <th scope=""col"">Options</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 39 "D:\Software Engineering\Training\STDIO\dotNet - student\dotNet\STDIO_dotNet\STDIO_dotNet\Views\Student\Index.cshtml"
         foreach(var student in Model.GetStudentList())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 42 "D:\Software Engineering\Training\STDIO\dotNet - student\dotNet\STDIO_dotNet\STDIO_dotNet\Views\Student\Index.cshtml"
               Write(student.StudentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "D:\Software Engineering\Training\STDIO\dotNet - student\dotNet\STDIO_dotNet\STDIO_dotNet\Views\Student\Index.cshtml"
               Write(student.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "D:\Software Engineering\Training\STDIO\dotNet - student\dotNet\STDIO_dotNet\STDIO_dotNet\Views\Student\Index.cshtml"
               Write(student.GetGender());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "D:\Software Engineering\Training\STDIO\dotNet - student\dotNet\STDIO_dotNet\STDIO_dotNet\Views\Student\Index.cshtml"
               Write(student.StudentBirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "D:\Software Engineering\Training\STDIO\dotNet - student\dotNet\STDIO_dotNet\STDIO_dotNet\Views\Student\Index.cshtml"
               Write(student.MajorID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "D:\Software Engineering\Training\STDIO\dotNet - student\dotNet\STDIO_dotNet\STDIO_dotNet\Views\Student\Index.cshtml"
               Write(student.UniversityID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                <td>
                    <span class=""option"">
                        <i class=""bi bi-pencil""></i>
                    </span>
                    <span class=""option"">
                        <i class=""bi bi-trash3""></i>
                    </span>                    
                </td>
            </tr>
");
#nullable restore
#line 57 "D:\Software Engineering\Training\STDIO\dotNet - student\dotNet\STDIO_dotNet\STDIO_dotNet\Views\Student\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tbody>\r\n    </table>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentHandler> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
