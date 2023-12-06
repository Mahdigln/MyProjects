using Block_IP.Action_Filter;
using Block_IP.MiddleWare;
using Block_IP.Services;
using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region IOC
builder.Services.AddTransient<IIPBlockingService, IPBlockingService>();

//inject it for action filter
builder.Services.AddScoped<IPBlockActionFilter>();
#endregion

var app = builder.Build();
//To ensure we receive the correct IP address in our middleware we use UseForwardedHeaders
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});
app.UseMiddleware<IPBlockMiddelware>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
