using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace VemDeZap.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //permitindo requesiçoes usando header, method e origem (Qualquer site)

            app.UseCors(x =>
           {
               x.AllowAnyHeader();
               x.AllowAnyMethod();
               x.AllowAnyOrigin();
           });


            //configura para usar o mvc
            app.UseMvc();

            //cria a documentacao da api

            app.UseSwagger();
            //app.UseSwaggerUI(c =>
            //{
            //    c.Swa
            //})

        }
    }
}
