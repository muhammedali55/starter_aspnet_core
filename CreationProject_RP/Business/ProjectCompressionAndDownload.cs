using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace CreationProject_RP.Business
{
    public class ProjectCompressionAndDownload
    {

        private readonly IHostingEnvironment _hostingEnvironment;
        private string _projectName;
        public ProjectCompressionAndDownload(IHostingEnvironment hostingEnvironment, string projectName)
        {
            _hostingEnvironment = hostingEnvironment;
            _projectName = projectName;
        }
        public string CompressZipfile()
        {
            string projectId = Guid.NewGuid().ToString();
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string startPath = fileName + "\\" + _projectName;
            string zipPath = _hostingEnvironment.WebRootPath + "\\" + projectId + ".zip";

            ZipFile.CreateFromDirectory(startPath, zipPath, CompressionLevel.Fastest, true);
            return projectId;
        }
        public string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }
        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformatsofficedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"} ,
                {".zip", "application/zip"}
            };
        }

    }
}
