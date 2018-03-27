using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.HttpOverrides;
using System.IO;

namespace webapp
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
    }
    
    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
    {
      loggerFactory.AddFile($"{Directory.GetCurrentDirectory()}\\"+"Logs/myapp-{Date}.txt");
      if (env.IsDevelopment()) 
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseForwardedHeaders(new ForwardedHeadersOptions
      {
        ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
      });

      app.UseAuthentication();

      app.UseCors(builder =>
      {
        builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
      });
      app.UseStaticFiles();

      //app.UseCors("AllowAllOrigins");
      app.UseMvc();
    }
  }
}