using BankMilleniumTask.Service.REST;
using BankMilleniumTask.Services.SOAP;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ISummerCityService, SummerCityService>();
builder.Services.AddSingleton<ISummerActivityService, SummerActivityService>();

var app = builder.Build();

((IApplicationBuilder)app).UseSoapEndpoint<ISummerActivityService>(
    path: "/SummerActivities.svc",
    encoder: new SoapEncoderOptions(),
    serializer: SoapSerializer.DataContractSerializer
);

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
