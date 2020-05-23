using CreationProject_RP.Business.Utility;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CreationProject_RP.Business
{
    public class ProjectCreateCSPROJ
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private string projectName;
        public ProjectCreateCSPROJ(IHostingEnvironment hostingEnvironment,string _projectName)
        {
            _hostingEnvironment = hostingEnvironment;
            projectName = _projectName;
        }
        public void CreateBusinessCsProj(List<PackageReference> reference=null)
        {
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string path = fileName + "\\" + projectName + "\\Business\\Business.csproj";
            if (!System.IO.File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = System.IO.File.CreateText(path))
                {
                    sw.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
                    sw.WriteLine("");
                    sw.Write("  ");
                    sw.WriteLine("<PropertyGroup>");
                    sw.Write("      ");
                    sw.WriteLine("<TargetFramework>netcoreapp3.1</TargetFramework>");
                    sw.Write("  ");
                    sw.WriteLine("</PropertyGroup>");
                    sw.WriteLine("");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<PackageReference Include=\"Autofac\" Version=\"5.1.2\" />");
                    sw.WriteLine("");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<ProjectReference Include=\"..\\DataAccess\\DataAccess.csproj\" />");
                    sw.WriteLine("<ProjectReference Include=\"..\\Entity\\Entity.csproj\" />");
                    sw.WriteLine("");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<Folder Include=\"Dto\\Response\\\" />");
                    sw.WriteLine("<Folder Include=\"Dto\\Request\\\" />");
                    sw.WriteLine("<Folder Include=\"Abstract\\\" />");
                    sw.WriteLine("<Folder Include=\"Dto\\\" />");
                    sw.WriteLine("<Folder Include=\"Concrete\\\" />");
                    sw.WriteLine("<Folder Include=\"IOC\\\" />");
                    sw.WriteLine("<Folder Include=\"Language\\\" />");
                    sw.WriteLine("<Folder Include=\"Utility\\\" />");
                    sw.WriteLine("");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("</Project>");

                }
            }
        }
        public void CreateCoreCsProj( List<PackageReference> reference = null)
        {
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string path = fileName + "\\" + projectName + "\\Core\\Core.csproj";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
                    sw.WriteLine("");
                    sw.Write("  ");
                    sw.WriteLine("<PropertyGroup>");
                    sw.Write("      ");
                    sw.WriteLine("<TargetFramework>netcoreapp3.1</TargetFramework>");                 
                    sw.Write("  ");
                    sw.WriteLine("</PropertyGroup>");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.EntityFrameworkCore\" Version=\"3.1.4\" />");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<Folder Include=\"DataAccess\\\" />");
                    sw.WriteLine("<Folder Include=\"Entities\\\" />");
                    sw.WriteLine("");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("</Project>");

                }
            }
        }
        public void CreateDataAccessCsProj( List<PackageReference> reference = null)
        {
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string path = fileName + "\\" + projectName + "\\DataAccess\\DataAccess.csproj";
            if (!System.IO.File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = System.IO.File.CreateText(path))
                {
                    sw.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
                    sw.WriteLine("");
                    sw.Write("  ");
                    sw.WriteLine("<PropertyGroup>");
                    sw.Write("      ");
                    sw.WriteLine("<TargetFramework>netcoreapp3.1</TargetFramework>");
                    sw.Write("  ");
                    sw.WriteLine("</PropertyGroup>");
                    sw.WriteLine("");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.EntityFrameworkCore\" Version=\"3.1.4\" />");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.EntityFrameworkCore.SqlServer\" Version=\"3.1.4\" />");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.EntityFrameworkCore.Tools\" Version=\"3.1.4\">");
                    sw.WriteLine("<PrivateAssets>all</PrivateAssets>");
                    sw.WriteLine("<IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>");
                    sw.WriteLine("</PackageReference>");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<ProjectReference Include=\"..\\Core\\Core.csproj\" />");
                    sw.WriteLine("<ProjectReference Include=\"..\\Entity\\Entity.csproj\" />");
                    sw.WriteLine("");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<Folder Include=\"Abstract\\\" />");
                    sw.WriteLine("<Folder Include=\"Concrete\\\" />");
                    sw.WriteLine("");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("</Project>");

                }
            }
        }
        public void CreateEntityCsProj( List<PackageReference> reference = null)
        {
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string path = fileName + "\\" + projectName + "\\Entity\\Entity.csproj";
            if (!System.IO.File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = System.IO.File.CreateText(path))
                {
                    sw.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
                    sw.WriteLine("");
                    sw.Write("  ");
                    sw.WriteLine("<PropertyGroup>");
                    sw.Write("      ");
                    sw.WriteLine("<TargetFramework>netcoreapp3.1</TargetFramework>");
                    sw.Write("  ");
                    sw.WriteLine("</PropertyGroup>");
                    sw.WriteLine("");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.EntityFrameworkCore\" Version=\"3.1.4\" />");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.EntityFrameworkCore.SqlServer\" Version=\"3.1.4\" />");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.EntityFrameworkCore.Tools\" Version=\"3.1.4\">");
                    sw.WriteLine("<PrivateAssets>all</PrivateAssets>");
                    sw.WriteLine("<IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>");
                    sw.WriteLine("</PackageReference>");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<ProjectReference Include=\"..\\Core\\Core.csproj\" />");
                    sw.WriteLine("");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<Folder Include=\"Entities\\\" />");
                    sw.WriteLine("");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("</Project>");

                }
            }
        }
        public void CreateWebCsProj( List<PackageReference> reference = null)
        {
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string path = fileName + "\\" + projectName + "\\Web\\Web.csproj";
            if (!System.IO.File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = System.IO.File.CreateText(path))
                {
                    sw.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk.Web\">");
                    sw.WriteLine("");
                    sw.Write("  ");
                    sw.WriteLine("<PropertyGroup>");
                    sw.Write("      ");
                    sw.WriteLine("<TargetFramework>netcoreapp3.1</TargetFramework>");
                    sw.Write("  ");
                    sw.WriteLine("</PropertyGroup>");
                    sw.WriteLine("");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<PackageReference Include=\"Autofac\" Version=\"5.1.2\" />");
                    sw.WriteLine("<PackageReference Include=\"Autofac.Extensions.DependencyInjection\" Version=\"6.0.0\" />");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.AspNetCore.Identity.EntityFrameworkCore\" Version=\"3.1.4\" />");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation\" Version=\"3.1.4\" />");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.EntityFrameworkCore.Relational\" Version=\"3.1.4\" />");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.VisualStudio.Web.CodeGeneration.Design\" Version=\"3.1.2\" />");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.EntityFrameworkCore\" Version=\"3.1.4\" />");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.EntityFrameworkCore.SqlServer\" Version=\"3.1.4\" />");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.EntityFrameworkCore.Tools\" Version=\"3.1.4\">");
                    sw.WriteLine("<PrivateAssets>all</PrivateAssets>");
                    sw.WriteLine("<IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>");
                    sw.WriteLine("</PackageReference>");
                    sw.WriteLine("");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.TypeScript.MSBuild\" Version=\"3.8.3\">");
                    sw.WriteLine("<PrivateAssets>all</PrivateAssets>");
                    sw.WriteLine("<IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>");
                    sw.WriteLine("</PackageReference>");
                    sw.WriteLine("");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<ProjectReference Include=\"..\\Business\\Business.csproj\" />");
                    sw.WriteLine("");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<Folder Include=\"Areas\\\" />");
                    sw.WriteLine("<Folder Include=\"Authentication\\\" />");
                    sw.WriteLine("<Folder Include=\"Controllers\\\" />");
                    sw.WriteLine("<Folder Include=\"Migrations\\\" />");
                    sw.WriteLine("<Folder Include=\"Models\\\" />");
                    sw.WriteLine("<Folder Include=\"Properties\\\" />");
                    sw.WriteLine("<Folder Include=\"ViewComponents\\\" />");
                    sw.WriteLine("<Folder Include=\"Utility\\\" />");
                    sw.WriteLine("<Folder Include=\"wwwroot\\\" />");
                    sw.WriteLine("<Folder Include=\"Views\\\" />");
                    sw.WriteLine("<Folder Include=\"Views\\Shared\\\" />");

                    sw.WriteLine("");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("</Project>");

                }
            }
        }
        public void CreateWebApiCsProj( List<PackageReference> reference = null)
        {
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string path = fileName + "\\" + projectName + "\\WebApi\\WebApi.csproj";
            if (!System.IO.File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = System.IO.File.CreateText(path))
                {
                    sw.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk.Web\">");
                    sw.WriteLine("");
                    sw.Write("  ");
                    sw.WriteLine("<PropertyGroup>");
                    sw.Write("      ");
                    sw.WriteLine("<TargetFramework>netcoreapp3.1</TargetFramework>");
                    sw.Write("  ");
                    sw.WriteLine("</PropertyGroup>");
                    sw.WriteLine("");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<PackageReference Include=\"Autofac\" Version=\"5.1.2\" />");
                    sw.WriteLine("<PackageReference Include=\"Autofac.Extensions.DependencyInjection\" Version=\"6.0.0\" />");
                    sw.WriteLine("<PackageReference Include=\"Microsoft.VisualStudio.Web.CodeGeneration.Design\" Version=\"3.1.2\" />");

                    sw.WriteLine("");
                    sw.WriteLine("</ItemGroup>");
                    sw.WriteLine("<ItemGroup>");
                    sw.Write("  ");
                    sw.WriteLine("<ProjectReference Include=\"..\\Business\\Business.csproj\" />");

                    sw.WriteLine("");
                    sw.WriteLine("</ItemGroup>");

                    sw.WriteLine("</Project>");

                }
            }
        }

    }
}
