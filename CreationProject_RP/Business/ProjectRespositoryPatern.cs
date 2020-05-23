using CreationProject_RP.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreationProject_RP.Business
{
    public class ProjectRespositoryPatern
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private string _projectName;
        private ModelIndex _ModelIndex;
        public ProjectRespositoryPatern(IHostingEnvironment hostingEnvironment, 
                                        string projectName, ModelIndex modelIndex) {
            _hostingEnvironment = hostingEnvironment;
            _projectName = projectName;
            _ModelIndex = modelIndex;
        }

        public void CreateWebApiClassess() {
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string path;
        }
        public void CreateWebClassess() {
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string path;

            #region Web>Views>Shared>_Layout
            foreach (var item in _ModelIndex.entity_list)
            {
                path = fileName + "\\" + _projectName + "\\Web\\Views\\Shared\\_Layout.cshtml";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("<!DOCTYPE html>");                        
                        sw.WriteLine("<html>");
                        sw.WriteLine("<head>");
                        sw.Write("  ");
                        sw.WriteLine("<meta charset=\"utf - 8\">");
                        sw.Write("  ");
                        sw.WriteLine(" <title>"+_ModelIndex.project_name+"</title>");
                        sw.WriteLine("</head>");
                        sw.WriteLine("<body>");
                        sw.Write("  ");
                        sw.WriteLine("@RenderBody()");
                        sw.WriteLine("</body>");
                        sw.WriteLine("</html>");
                    }
                }
            }
            #endregion

            #region Web>Views>_ViewImports
            foreach (var item in _ModelIndex.entity_list)
            {
                path = fileName + "\\" + _projectName + "\\Web\\Views\\_ViewImports.cshtml";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                                            
                        sw.WriteLine("@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers");     

                    }
                }
            }
            #endregion

            #region Web>Views>_ViewStart
            foreach (var item in _ModelIndex.entity_list)
            {
                path = fileName + "\\" + _projectName + "\\Web\\Views\\_ViewStart.cshtml";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("@{");
                        sw.Write("  ");
                        sw.WriteLine("Layout = \"_Layout\";");
                        sw.WriteLine("}");                     

                    }
                }
            }
            #endregion

            #region Web>Views>Home>Index
            foreach (var item in _ModelIndex.entity_list)
            {
                path = fileName + "\\" + _projectName + "\\Web\\Views\\Home\\Index.cshtml";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("@{");
                        sw.Write("  ");
                        sw.WriteLine("ViewData[\"Title\"] = \"Index\";");
                        sw.WriteLine("}");
                        sw.WriteLine("");                        
                        sw.WriteLine("<h1>Welcome to my world</h1>");                       

                    }
                }
            }
            #endregion

            #region Web>Controllers>HomeController
            foreach (var item in _ModelIndex.entity_list)
            {
                path = fileName + "\\" + _projectName + "\\Web\\Controllers\\HomeController.cs";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("using System.Linq;");
                        sw.WriteLine("using Microsoft.AspNetCore.Mvc;");                      
                        sw.WriteLine("namespace Web.Controllers");
                        sw.WriteLine("{");
                        sw.Write("  ");
                        sw.WriteLine(" public class HomeController : Controller");
                        sw.Write("  ");
                        sw.WriteLine("{");

                        sw.Write("      ");
                        sw.WriteLine(" public IActionResult Index(int id)");
                        sw.Write("      ");
                        sw.WriteLine("{");
                        sw.Write("          ");
                        sw.WriteLine("return View();");
                        sw.Write("      ");
                        sw.WriteLine("}");  

                        sw.Write("  ");
                        sw.WriteLine("}");
                        sw.WriteLine("}");
                    }
                }
            }
            #endregion

            #region Web>appsetting
            foreach (var item in _ModelIndex.entity_list)
            {
                path = fileName + "\\" + _projectName + "\\Web\\appsetting.json";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("{");
                        sw.Write("  ");
                        sw.WriteLine("\"Logging\": {");
                        sw.Write("      ");
                        sw.WriteLine("\"LogLevel\": {");
                        sw.Write("          ");
                        sw.WriteLine("\"Default\": \"Information\",");
                        sw.Write("          ");
                        sw.WriteLine("\"Microsoft\": \"Warning\",");
                        sw.Write("          ");
                        sw.WriteLine("\"Microsoft.Hosting.Lifetime\": \"Information\" ");
                        sw.Write("      ");
                        sw.WriteLine("}");
                        sw.Write("  ");
                        sw.WriteLine("},");
                        sw.Write("  ");
                        sw.WriteLine("\"AllowedHosts\": \" * \"");
                        sw.WriteLine("}");                 
                      
                    }
                }
            }
            #endregion

            #region Web>Startup
            foreach (var item in _ModelIndex.entity_list)
            {
                path = fileName + "\\" + _projectName + "\\Web\\Startup.cs";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                       
                        sw.WriteLine("using Microsoft.AspNetCore.Builder;");
                        sw.WriteLine("using Microsoft.AspNetCore.Hosting;");
                        sw.WriteLine("using Microsoft.AspNetCore.Identity;");
                        sw.WriteLine("using Microsoft.Extensions.Configuration;");
                        sw.WriteLine("using Microsoft.Extensions.DependencyInjection;");
                        sw.WriteLine("using Microsoft.Extensions.Hosting;");
                        sw.WriteLine("namespace Web");
                        sw.WriteLine("{");
                        sw.Write("  ");
                        sw.WriteLine("public class Startup");
                        sw.Write("  ");
                        sw.WriteLine("{");

                        sw.Write("      ");
                        sw.WriteLine("IConfiguration Configuration;");
                        sw.Write("      ");
                        sw.WriteLine("public Startup(IConfiguration configuration) {");
                        sw.Write("          ");
                        sw.WriteLine("Configuration = configuration;");
                        sw.Write("      ");
                        sw.WriteLine("}");

                      
                        sw.Write("      ");
                        sw.WriteLine("public void ConfigureServices(IServiceCollection services){");
                        sw.Write("          ");
                        sw.WriteLine("services.AddControllersWithViews();");
                        sw.Write("      ");
                        sw.WriteLine("}");

                        sw.Write("      ");
                        sw.WriteLine("public void Configure(IApplicationBuilder app, IWebHostEnvironment env){");
                        sw.Write("          ");
                        sw.WriteLine("if (env.IsDevelopment())");
                        sw.Write("          ");
                        sw.WriteLine("{");
                        sw.Write("          ");
                        sw.WriteLine("app.UseDeveloperExceptionPage();");
                        sw.Write("          ");
                        sw.WriteLine("}");

                        sw.Write("          ");
                        sw.WriteLine("app.UseRouting();");
                        sw.Write("          ");
                        sw.WriteLine("app.UseStaticFiles();");

                        sw.Write("          ");
                        sw.WriteLine("app.UseEndpoints(endpoints =>");
                        sw.Write("          ");
                        sw.WriteLine("{");
                        sw.Write("              ");
                        sw.WriteLine("endpoints.MapControllerRoute(");
                        sw.Write("                  ");
                        sw.WriteLine("name: \"default\",");
                        sw.Write("                  ");
                        sw.WriteLine("pattern:\"{controller=Home}/{action=Index}/{id?}\"");
                        sw.Write("                  ");
                        sw.WriteLine(");");
                        sw.Write("          ");
                        sw.WriteLine("});");


                        sw.Write("      ");
                        sw.WriteLine("}");


                        sw.Write("  ");
                        sw.WriteLine("}");
                        sw.WriteLine("}");
                    }
                }
            }
            #endregion

            #region Web>Program
            foreach (var item in _ModelIndex.entity_list)
            {
                path = fileName + "\\" + _projectName + "\\Web\\Program.cs";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("using Autofac;");
                        sw.WriteLine("using Autofac.Extensions.DependencyInjection;");
                        sw.WriteLine("using Business.IOC;");
                        sw.WriteLine("using Microsoft.AspNetCore.Hosting;");
                        sw.WriteLine("using Microsoft.Extensions.Hosting;");
                        sw.WriteLine("namespace Web");
                        sw.WriteLine("{");
                        sw.Write("  ");
                        sw.WriteLine("public class Program");
                        sw.Write("  ");
                        sw.WriteLine("{");

                        sw.Write("      ");
                        sw.WriteLine("public static void Main(string[] args)");
                        sw.Write("      ");
                        sw.WriteLine("{");
                        sw.Write("          ");
                        sw.WriteLine("CreateHostBuilder(args).Build().Run();");
                        sw.Write("      ");
                        sw.WriteLine("}");

                        sw.Write("      ");
                        sw.WriteLine("public static IHostBuilder CreateHostBuilder(string[] args) =>");
                        sw.Write("          ");
                        sw.WriteLine("Host.CreateDefaultBuilder(args)");
                        sw.Write("          ");
                        sw.WriteLine(".UseServiceProviderFactory(new AutofacServiceProviderFactory())");
                        sw.Write("          ");
                        sw.WriteLine(".ConfigureContainer<ContainerBuilder>(builder =>{");
                        sw.Write("          ");
                        sw.WriteLine("builder.RegisterModule(new AutofacBusinessModule());");
                        sw.Write("          ");
                        sw.WriteLine("})");
                        sw.Write("              ");
                        sw.WriteLine(".ConfigureWebHostDefaults(webBuilder =>");
                        sw.Write("              ");
                        sw.WriteLine("{");
                        sw.Write("                  ");
                        sw.WriteLine("webBuilder.UseStartup<Startup>();");
                        sw.Write("              ");
                        sw.WriteLine("});");


                        sw.Write("  ");
                        sw.WriteLine("}");
                        sw.WriteLine("}");
                    }
                }
            }
            #endregion

        }
        public void CreateBussinessClassess() {
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string path;

            #region Business>IOC>AutofacBusinessModule
                path = fileName + "\\" + _projectName + "\\Business\\IOC\\AutofacBusinessModule.cs";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("using Autofac;");
                        sw.WriteLine("using Business.Abstract;");
                        sw.WriteLine("using Business.Concrete;");
                        sw.WriteLine("using DataAccess.Abstract;");
                        sw.WriteLine("using DataAccess.Concrete;");
                        sw.WriteLine("namespace Business.IOC");
                        sw.WriteLine("{");
                        sw.Write("  ");
                        sw.WriteLine("public class AutofacBusinessModule: Module");
                        sw.Write("  ");
                        sw.WriteLine("{");

                        sw.Write("      ");
                        sw.WriteLine("protected override void Load(ContainerBuilder builder)");
                        sw.Write("      ");
                        sw.WriteLine("{");
                        foreach (var item in _ModelIndex.entity_list)
                        {
                            sw.Write("          ");
                            sw.WriteLine(" builder.RegisterType<"+item+"Manager>().As<I"+item+"Service>();");
                            sw.Write("          ");
                            sw.WriteLine(" builder.RegisterType<Ef"+item+"Dal>().As<I"+item+"Dal>();");
                        }
                        sw.Write("      ");
                        sw.WriteLine("}");

                        sw.Write("  ");
                        sw.WriteLine("}");
                        sw.WriteLine("}");
                    }               
                }
            #endregion

            #region Business>Concrete>AllEntities
            foreach (var item in _ModelIndex.entity_list)
            {
                path = fileName + "\\" + _projectName + "\\Business\\Concrete\\" + item + "Manager.cs";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("using System.Collections.Generic;");
                        sw.WriteLine("using Entity.Entities;");
                        sw.WriteLine("using Business.Abstract;");
                        sw.WriteLine("using DataAccess.Abstract;");
                        sw.WriteLine("namespace Business.Concrete");
                        sw.WriteLine("{");
                        sw.Write("  ");
                        sw.WriteLine("public class "+item+"Manager : I"+item+"Service");
                        sw.Write("  ");
                        sw.WriteLine("{");
                       
                        sw.Write("      ");
                        sw.WriteLine("I"+item+"Dal _"+item+"Dal;");

                        sw.Write("      ");
                        sw.WriteLine("public "+item+"Manager(I"+item+"Dal "+item+"Service)");
                        sw.Write("      ");
                        sw.WriteLine("{");
                        sw.Write("          ");
                        sw.WriteLine("_"+item+"Dal = "+item+"Service;");
                        sw.Write("      ");
                        sw.WriteLine("}");

                        sw.Write("      ");
                        sw.WriteLine("public void Add("+item+" entity)");
                        sw.Write("      ");
                        sw.WriteLine("{");
                        sw.Write("          ");
                        sw.WriteLine(" _"+item+"Dal.Insert(entity);");
                        sw.Write("      ");
                        sw.WriteLine("}");

                        sw.Write("      ");
                        sw.WriteLine(" public void Delete("+item+" entity)");
                        sw.Write("      ");
                        sw.WriteLine("{");
                        sw.Write("          ");
                        sw.WriteLine(" _"+item+"Dal.Delete(entity);");
                        sw.Write("      ");
                        sw.WriteLine("}");

                        sw.Write("      ");
                        sw.WriteLine("public List<"+item+"> GetAll()");
                        sw.Write("      ");
                        sw.WriteLine("{");
                        sw.Write("          ");
                        sw.WriteLine("return _"+item+"Dal.GetList();");
                        sw.Write("      ");
                        sw.WriteLine("}");

                        sw.Write("      ");
                        sw.WriteLine("public "+item+" GetById(int id)");
                        sw.Write("      ");
                        sw.WriteLine("{");
                        sw.Write("          ");
                        sw.WriteLine("return _"+item+"Dal.Get(x => x.Id == id);");
                        sw.Write("      ");
                        sw.WriteLine("}");

                        sw.Write("      ");
                        sw.WriteLine("public void Update("+item+" entity)");
                        sw.Write("      ");
                        sw.WriteLine("{");
                        sw.Write("          ");
                        sw.WriteLine("_"+item+"Dal.Update(entity);");
                        sw.Write("      ");
                        sw.WriteLine("}");
                        sw.Write("  ");
                        sw.WriteLine("}");
                        sw.WriteLine("}");
                    }
                }
            }
            #endregion

            #region Business>Abstract>AllEntities
            foreach (var item in _ModelIndex.entity_list)
            {
                path = fileName + "\\" + _projectName + "\\Business\\Abstract\\I" + item + "Service.cs";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("using System.Collections.Generic;");
                        sw.WriteLine("using Entity.Entities;");
                        sw.WriteLine("namespace Business.Abstract");
                        sw.WriteLine("{");
                        sw.Write("  ");
                        sw.WriteLine("public interface I"+item+"Service");
                        sw.Write("  ");
                        sw.WriteLine("{");
                        sw.Write("      ");
                        sw.WriteLine("List<"+item+"> GetAll();");
                        sw.Write("      ");
                        sw.WriteLine(""+item+" GetById(int id);");
                        sw.Write("      ");
                        sw.WriteLine("void Add("+item+" entity);");
                        sw.Write("      ");
                        sw.WriteLine("void Update("+item+" entity);");
                        sw.Write("      ");
                        sw.WriteLine("void Delete("+item+" entity);");                        
                        sw.Write("  ");
                        sw.WriteLine("}");
                        sw.WriteLine("}");
                    }
                }
            }
            #endregion

        }
        public void CreateDataAccessClassess() {
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string path;

            #region DataAccess>Concrete>AllEntities
            foreach (var item in _ModelIndex.entity_list)
            {
                path = fileName + "\\" + _projectName + "\\DataAccess\\Concrete\\Ef" + item + "Dal.cs";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("using Core.DataAccess;");
                        sw.WriteLine("using Entity.Entities;");
                        sw.WriteLine("using DataAccess.Abstract;");
                        sw.WriteLine("namespace DataAccess.Concrete");
                        sw.WriteLine("{");
                        sw.Write("  ");
                        sw.WriteLine("public class Ef" + item + "Dal : EfEntityRepositoryBase<" + item + ", " + _ModelIndex.context_name + "Context>, I" + item + "Dal");
                        sw.Write("  ");
                        sw.WriteLine("{");
                        sw.Write("  ");
                        sw.WriteLine("}");
                        sw.WriteLine("}");
                    }
                }
            }
            #endregion

            #region DataAccess>Abstract>AllEntities
            foreach (var item in _ModelIndex.entity_list)
            {
                path = fileName + "\\" + _projectName + "\\DataAccess\\Abstract\\I" + item + "Dal.cs";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("using Core.DataAccess;");
                        sw.WriteLine("using Entity.Entities;");
                        sw.WriteLine("namespace DataAccess.Abstract");
                        sw.WriteLine("{");
                        sw.Write("  ");
                        sw.WriteLine("public interface I"+item+"Dal : IEntityRepository<"+item+">");
                        sw.Write("  ");
                        sw.WriteLine("{");                        
                        sw.Write("  ");
                        sw.WriteLine("}");
                        sw.WriteLine("}");
                    }
                }
            }
            #endregion
        }
        public void CraeteEntityClassess() {
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string path;

            // ENTITY Katmanını Kodlanması Başlangıç

            #region Entity>Entities>AllEntities
            foreach (var item in _ModelIndex.entity_list)
            {
                path = fileName + "\\" + _projectName + "\\Entity\\Entities\\" + item + ".cs";
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("using Core.Entities;");
                        sw.WriteLine("namespace Entity.Entities");
                        sw.WriteLine("{");
                        sw.Write("  ");
                        sw.WriteLine("public partial class " + item + ":IEntity");
                        sw.Write("  ");
                        sw.WriteLine("{");
                        sw.Write("      ");
                        sw.WriteLine(" public int Id { get; set; }");
                        sw.Write("  ");
                        sw.WriteLine("}");
                        sw.WriteLine("}");
                    }
                }
            }

            #endregion

            #region Entity>Entities>Context
            path = fileName + "\\" + _projectName + "\\Entity\\Entities\\" + _ModelIndex.context_name + "Context.cs";
            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("using Microsoft.EntityFrameworkCore;");
                    sw.WriteLine("namespace Entity.Entities");
                    sw.WriteLine("{");
                    sw.Write("  ");
                    sw.WriteLine("public partial class " + _ModelIndex.context_name + "Context : DbContext");
                    sw.Write("  ");
                    sw.WriteLine("{");
                    sw.Write("      ");
                    sw.WriteLine("public " + _ModelIndex.context_name + "Context()");
                    sw.Write("      ");
                    sw.WriteLine("{");
                    sw.Write("      ");
                    sw.WriteLine("}");
                    sw.Write("      ");
                    sw.WriteLine("public " + _ModelIndex.context_name + "Context(DbContextOptions<"+_ModelIndex.context_name+"Context> options): base(options)");
                    sw.Write("      ");
                    sw.WriteLine("{");
                    sw.Write("      ");
                    sw.WriteLine("}");
                    sw.WriteLine("");
                    foreach (var item in _ModelIndex.entity_list)
                    {
                        sw.Write("      ");
                        sw.WriteLine(" public virtual DbSet<" + item + "> " + item + " { get; set; }");
                    }
                    sw.WriteLine("");
                    sw.Write("      ");
                    sw.WriteLine("protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)");
                    sw.Write("      ");
                    sw.WriteLine("{");
                    sw.Write("          ");
                    sw.WriteLine("if (!optionsBuilder.IsConfigured)");
                    sw.Write("          ");
                    sw.WriteLine("{");
                    sw.Write("              ");
                    sw.WriteLine("optionsBuilder.UseSqlServer(\"Server=" + _ModelIndex.server_name + "; Database=" + _ModelIndex.database_name + "; Trusted_Connection = True; \");");
                    sw.Write("          ");
                    sw.WriteLine("}");
                    sw.Write("      ");
                    sw.WriteLine("}");

                    sw.Write("  ");
                    sw.WriteLine("}");
                    sw.WriteLine("}");
                }
            }
            #endregion

            // Entity Katmanı Son.
        }
        public void CreateCoreClassess() {
            var fileName = _hostingEnvironment.WebRootPath + @"\tmp\";
            string path;



            // CORE Katmanının Kodlanması Başlangıç

            #region Core>DataAccess>EfEntityRepositoryBase
            path = fileName + "\\" + _projectName + "\\Core\\DataAccess\\EfEntityRepositoryBase.cs";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("using Core.Entities;");
                    sw.WriteLine("using Microsoft.EntityFrameworkCore;");
                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Collections.Generic;");
                    sw.WriteLine("using System.Linq;");
                    sw.WriteLine("using System.Linq.Expressions;");
                    sw.WriteLine("namespace Core.DataAccess");
                    sw.WriteLine("{");
                    sw.Write("  ");
                    sw.WriteLine("public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()");
                    sw.Write("  ");
                    sw.WriteLine("{");
                    // Delete Start
                    sw.Write("      ");
                    sw.WriteLine("public void Delete(TEntity entity)");
                    sw.Write("      ");
                    sw.WriteLine("{");
                    sw.Write("          ");
                    sw.WriteLine("using (var context = new TContext() ) {");
                    sw.Write("              ");
                    sw.WriteLine("var delete = context.Entry(entity);");
                    sw.Write("              ");
                    sw.WriteLine("delete.State = EntityState.Deleted;");
                    sw.Write("              ");
                    sw.WriteLine("context.SaveChanges();");
                    sw.Write("          ");
                    sw.WriteLine("}");
                    sw.Write("      ");
                    sw.WriteLine("}");
                    // Delete End

                    // Get Start
                    sw.Write("      ");
                    sw.WriteLine("public TEntity Get(Expression<Func<TEntity, bool>> filter)");
                    sw.Write("      ");
                    sw.WriteLine("{");
                    sw.Write("          ");
                    sw.WriteLine("using (var context = new TContext()) {");
                    sw.Write("              ");
                    sw.WriteLine("return context.Set<TEntity>().SingleOrDefaultAsync(filter).Result;");                    
                    sw.Write("          ");
                    sw.WriteLine("}");
                    sw.Write("      ");
                    sw.WriteLine("}");
                    // Get End

                    // GetList Start
                    sw.Write("      ");
                    sw.WriteLine("public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)");
                    sw.Write("      ");
                    sw.WriteLine("{");
                    sw.Write("          ");
                    sw.WriteLine("using (var context = new TContext()) {");
                    sw.Write("              ");
                    sw.WriteLine("return filter == null");
                    sw.Write("                  ");
                    sw.WriteLine("? context.Set<TEntity>().ToListAsync().Result");
                    sw.Write("                  ");
                    sw.WriteLine(": context.Set<TEntity>().Where(filter).ToList();");
                    sw.Write("          ");
                    sw.WriteLine("}");
                    sw.Write("      ");
                    sw.WriteLine("}");
                    // GetList End

                    // Insert Start
                    sw.Write("      ");
                    sw.WriteLine("public void Insert(TEntity entity)");
                    sw.Write("      ");
                    sw.WriteLine("{");
                    sw.Write("          ");
                    sw.WriteLine("using (var context = new TContext() ) {");
                    sw.Write("              ");
                    sw.WriteLine("var insert = context.Entry(entity);");
                    sw.Write("              ");
                    sw.WriteLine("insert.State = EntityState.Added;");
                    sw.Write("              ");
                    sw.WriteLine("context.SaveChanges();");
                    sw.Write("          ");
                    sw.WriteLine("}");
                    sw.Write("      ");
                    sw.WriteLine("}");
                    // Insert End

                    // Update Start
                    sw.Write("      ");
                    sw.WriteLine("public void Update(TEntity entity)");
                    sw.Write("      ");
                    sw.WriteLine("{");
                    sw.Write("          ");
                    sw.WriteLine("using (var context = new TContext() ) {");
                    sw.Write("              ");
                    sw.WriteLine("var update = context.Entry(entity);");
                    sw.Write("              ");
                    sw.WriteLine("update.State = EntityState.Modified;");
                    sw.Write("              ");
                    sw.WriteLine("context.SaveChanges();");
                    sw.Write("          ");
                    sw.WriteLine("}");
                    sw.Write("      ");
                    sw.WriteLine("}");
                    // Update End
                    sw.Write("  "); 
                    sw.WriteLine("}");
                    sw.WriteLine("}");
                }
            }
            #endregion

            #region Core>DataAccess>IEntityRepository
            path = fileName + "\\" + _projectName + "\\Core\\DataAccess\\IEntityRepository.cs";
            if (!File.Exists(path))
            {
                
                using (StreamWriter sw = System.IO.File.CreateText(path))
                {
                    sw.WriteLine("using Core.Entities;");
                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Collections.Generic;");
                    sw.WriteLine("using System.Linq.Expressions;");
                    sw.WriteLine("namespace Core.DataAccess");
                    sw.WriteLine("{");
                    sw.Write("  ");
                    sw.WriteLine("public interface IEntityRepository<T> where T:class, IEntity,new()");
                    sw.Write("  ");
                    sw.WriteLine("{");
                    sw.Write("      ");
                    sw.WriteLine("T Get(Expression<Func<T,bool>> filter);");
                    sw.Write("      ");
                    sw.WriteLine("List<T> GetList(Expression<Func<T,bool>> filter=null);");
                    sw.Write("      ");
                    sw.WriteLine("void Insert(T entity);");
                    sw.Write("      ");
                    sw.WriteLine("void Update(T entity);");
                    sw.Write("      ");
                    sw.WriteLine("void Delete(T entity);");
                    sw.Write("  ");
                    sw.WriteLine("}");
                    sw.WriteLine("}");
                }
            }
            #endregion

            #region Core>Entities>IEntity
            path = fileName + "\\" + _projectName + "\\Core\\Entities\\IEntity.cs";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = System.IO.File.CreateText(path))
                {
                    sw.WriteLine("namespace Core.Entities");
                    sw.WriteLine("{");
                    sw.Write("  ");
                    sw.WriteLine("public interface IEntity");
                    sw.Write("  ");
                    sw.WriteLine("{");
                    sw.Write("  ");
                    sw.WriteLine("}");
                    sw.WriteLine("}");
                }
            }
            #endregion
        
            // CORE Katmanı End
        }
    }
}
