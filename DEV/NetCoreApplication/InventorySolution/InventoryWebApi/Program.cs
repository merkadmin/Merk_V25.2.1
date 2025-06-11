using InventoryWebAPI.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

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

var app = builder.Build();

var patientDataPath = Path.Combine(app.Environment.ContentRootPath, "PatientData");
app.UseStaticFiles(new StaticFileOptions
{
	FileProvider = new PhysicalFileProvider(patientDataPath),
	RequestPath = "/PatientData"
});

app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();