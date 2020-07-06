using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVC.Data;
using CoreMVC.Data.Interfaces;
using CoreMVC.Data.Mocks;
using CoreMVC.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreMVC
{
	public class Startup
	{
		private IConfigurationRoot _confString;

		public Startup (IHostingEnvironment hostEnv)
		{
			_confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
			//services.AddTransient<IAllCars, MockCar>();
			//services.AddTransient<ICarsCategory, MockCategory
			services.AddTransient<IAllCars, CarRepository>();
			services.AddTransient<ICarsCategory, CategoryRepository>();
			services.AddMvc();			
		}
		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{

			if (app == null) throw new ArgumentNullException(nameof(app));
			if (env == null) throw new ArgumentNullException(nameof(env));

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseStatusCodePages();
				app.UseStaticFiles();
				app.UseMvcWithDefaultRoute();
			}
			else
			{
				app.UseHsts();
			}

			using (var scope = app.ApplicationServices.CreateScope())
			{
				AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
				DBObjects.Initial(content);
			}
		}
	}
}
