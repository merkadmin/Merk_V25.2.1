using EntitiesBL.ModelEntities.GeneratedEnitities;
using InventoryWebAPI.Controllers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services
	.AddCors(options =>
	{
		options.AddPolicy("AllowAll", policy =>
		{
			policy.AllowAnyOrigin()
				.WithHeaders(
					"Content-Type",
					"Accept",
					"Authorization"
				)
				.AllowAnyMethod()
				.AllowAnyOrigin();
		});
	});

builder.Services
	.AddControllers(options =>
	{
		options.Filters.Add<GlobalExceptionFilter>();
	})
	.AddJsonOptions(options =>
	{
		options.JsonSerializerOptions.PropertyNamingPolicy = null;
	});

builder.Services.AddDbContext<InventoryDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

//var patientDataPath = Path.Combine(app.Environment.ContentRootPath, "PatientData");
//app.UseStaticFiles(new StaticFileOptions
//{
//	FileProvider = new PhysicalFileProvider(patientDataPath),
//	RequestPath = "/PatientData"
//});s

app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();