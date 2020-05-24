using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CreationProject_RP.Business
{
    public class Project
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private string _projectName;
        public Project(IHostingEnvironment hostingEnvironment,string projectName) {
            _hostingEnvironment = hostingEnvironment;
            _projectName = projectName;
        }
        private void CreateRepositoryPaternFolderStructure()
        {          
            
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            // Root Folder Create
            var path = fileName + _projectName;
            Directory.CreateDirectory(path);
            // Business Folder Create
            var subpath = path + "\\Business";
            Directory.CreateDirectory(subpath);
            var businesssubpath = subpath + "\\Abstract";
            Directory.CreateDirectory(businesssubpath);
            businesssubpath = subpath + "\\Concrete";
            Directory.CreateDirectory(businesssubpath);
            businesssubpath = subpath + "\\Dto";
            Directory.CreateDirectory(businesssubpath);
            var dtopath = businesssubpath + "\\Request";
            Directory.CreateDirectory(dtopath);
            dtopath = businesssubpath + "\\Response";
            Directory.CreateDirectory(dtopath);
            businesssubpath = subpath + "\\IOC";
            Directory.CreateDirectory(businesssubpath);
            businesssubpath = subpath + "\\Language";
            Directory.CreateDirectory(businesssubpath);
            businesssubpath = subpath + "\\Utility";
            Directory.CreateDirectory(businesssubpath);
            // Core Folder Create
            subpath = path + "\\Core";
            Directory.CreateDirectory(subpath);
            var coresubpath = subpath + "\\DataAccess";
            Directory.CreateDirectory(coresubpath);
            coresubpath = subpath + "\\Entities";
            Directory.CreateDirectory(coresubpath);
            // DataAccess Folder Create
            subpath = path + "\\DataAccess";
            Directory.CreateDirectory(subpath);
            var dataaccesssubpath = subpath + "\\Abstract";
            Directory.CreateDirectory(dataaccesssubpath);
            dataaccesssubpath = subpath + "\\Concrete";
            Directory.CreateDirectory(dataaccesssubpath);
            // Entity Folder Create
            subpath = path + "\\Entity";
            Directory.CreateDirectory(subpath);
            var entitiessunpath = subpath + "\\Entities";
            Directory.CreateDirectory(entitiessunpath);
            // Web Project Folder Create
            subpath = path + "\\Web";
            Directory.CreateDirectory(subpath);
            var websubpath = subpath + "\\Areas";
            Directory.CreateDirectory(websubpath);
            websubpath = subpath + "\\Authentication";
            Directory.CreateDirectory(websubpath);
            websubpath = subpath + "\\Controllers";
            Directory.CreateDirectory(websubpath);
            websubpath = subpath + "\\Migrations";
            Directory.CreateDirectory(websubpath);
            websubpath = subpath + "\\Models";
            Directory.CreateDirectory(websubpath);
            websubpath = subpath + "\\Properties";
            Directory.CreateDirectory(websubpath);
            websubpath = subpath + "\\Utility";
            Directory.CreateDirectory(websubpath);
            websubpath = subpath + "\\ViewComponents";
            Directory.CreateDirectory(websubpath);
            websubpath = subpath + "\\Views";
            Directory.CreateDirectory(websubpath);
            var viewssubpath = websubpath + "\\Shared";
            Directory.CreateDirectory(viewssubpath);
            viewssubpath = websubpath + "\\Home";
            Directory.CreateDirectory(viewssubpath);
            websubpath = subpath + "\\wwwroot";
            Directory.CreateDirectory(websubpath);
            // Web Apis Folder Create
            subpath = path + "\\WebApi";
            Directory.CreateDirectory(subpath);
        }

        public void CreateRepositoryPaternRootSLN()
        {
            CreateRepositoryPaternFolderStructure();
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string path = fileName + "\\" + _projectName + "\\" + _projectName + ".sln";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Microsoft Visual Studio Solution File, Format Version 12.00");
                    sw.WriteLine("# Visual Studio Version 16");
                    sw.WriteLine("VisualStudioVersion = 16.0.30104.148");
                    sw.WriteLine("MinimumVisualStudioVersion = 10.0.40219.1");
                    sw.WriteLine("Project(\"{" + Guid.NewGuid() + "}\") = \"Web\"," +
                     "\"Web\\Web.csproj\", \"{" + Guid.NewGuid() + "}\"");

                    sw.WriteLine("Project(\"{" + Guid.NewGuid() + "}\") = \"Business\"," +
                        "\"Business\\Business.csproj\", \"{" + Guid.NewGuid() + "}\"");
                    sw.WriteLine("EndProject");
                    sw.WriteLine("Project(\"{" + Guid.NewGuid() + "}\") = \"Entity\"," +
                      "\"Entity\\Entity.csproj\", \"{" + Guid.NewGuid() + "}\"");
                    sw.WriteLine("EndProject");
                    sw.WriteLine("Project(\"{" + Guid.NewGuid() + "}\") = \"DataAccess\"," +
                      "\"DataAccess\\DataAccess.csproj\", \"{" + Guid.NewGuid() + "}\"");
                    sw.WriteLine("EndProject");
                    sw.WriteLine("Project(\"{" + Guid.NewGuid() + "}\") = \"Core\"," +
                      "\"Core\\Core.csproj\", \"{" + Guid.NewGuid() + "}\"");
                    sw.WriteLine("EndProject");
                    sw.WriteLine("Project(\"{" + Guid.NewGuid() + "}\") = \"WebApi\"," +
                      "\"WebApi\\WebApi.csproj\", \"{" + Guid.NewGuid() + "}\"");
                    sw.WriteLine("EndProject");
                    sw.WriteLine("EndProject");

                }
            }
        }

    }
}
