using Project_Sun_1.Models;
using Microsoft.EntityFrameworkCore;
using Project_Sun_1.Repositorium.InterfaceRep;

namespace Project_Sun_1;

public class PetAppointment 
{
    public DateTime Date { get; set; }
    
    public void ConfigureServices(IServiceCollection services)
    {
        string con = "Server=(localdb)\\mssqllocaldb;Database=usersdbstore;Trusted_Connection=True;";
       
        // services.AddDbContext<PetAppointmentContex>(options => options.UseSqlServer(con));
        services.AddTransient<IService, Service>();
        services.AddTransient<InterfaceRep<MedicalReport>, BaseRepository<MedicalReport>>();
        services.AddTransient<InterfaceRep<Pet>, BaseRepository<Pet>>();
        services.AddTransient<InterfaceRep<Doctor>, BaseRepository<Doctor>>();
    }
    
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
 
        
        app.UseHttpsRedirection();
 
        app.UseRouting();
 
        app.UseAuthorization();
 
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}