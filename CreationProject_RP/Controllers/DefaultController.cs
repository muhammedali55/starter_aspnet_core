using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using CreationProject_RP.Business;
using CreationProject_RP.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace CreationProject_RP.Controllers
{
    public class DefaultController : Controller
    {


        private Project _Project;
        private ProjectCreateCSPROJ _CreateCSPROJ;
        private ProjectCompressionAndDownload _CompressionAndDownload;
        private ProjectRespositoryPatern _ProjectRespository;

        private readonly IHostingEnvironment _hostingEnvironment;
        public DefaultController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public  async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ModelIndex model) {
            if (model.project_name.Equals(""))
                return View();
            else
               return await StartProcess(model.project_name,model);
        }

        private async Task<IActionResult> StartProcess(string projectName, ModelIndex modelIndex) {

            _Project = new Project(_hostingEnvironment,projectName);
            _CreateCSPROJ = new ProjectCreateCSPROJ(_hostingEnvironment,projectName);
            _CompressionAndDownload = new ProjectCompressionAndDownload(_hostingEnvironment,projectName);
            _ProjectRespository = new ProjectRespositoryPatern(_hostingEnvironment,projectName,modelIndex);
            _Project.CreateRepositoryPaternRootSLN();
            _CreateCSPROJ.CreateBusinessCsProj();
            _CreateCSPROJ.CreateCoreCsProj();
            _CreateCSPROJ.CreateDataAccessCsProj();
            _CreateCSPROJ.CreateEntityCsProj();
            _CreateCSPROJ.CreateWebApiCsProj();
            _CreateCSPROJ.CreateWebCsProj();
            _ProjectRespository.CreateCoreClassess();
            _ProjectRespository.CraeteEntityClassess();
            _ProjectRespository.CreateBussinessClassess();
            _ProjectRespository.CreateDataAccessClassess();
            _ProjectRespository.CreateWebApiClassess();
            _ProjectRespository.CreateWebClassess();

            string projectId = _CompressionAndDownload.CompressZipfile();

            string filename = projectId + ".zip";
            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot", filename);
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, _CompressionAndDownload.GetContentType(path), Path.GetFileName(path));
        }

      

    }
}