using Serilog;
using Serilog.Events;
using Serilog.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add Logger
builder.Host.UseSerilog((ctx, lc) => lc
    // Log everything thats ins't an automatic Log to the specified file.
    .WriteTo.Logger(logConfig => logConfig
        .Filter.ByExcluding(Matching.FromSource("Microsoft"))
        .WriteTo.File("C:\\Users\\tzuen\\Documents\\Privat\\logfile_no_Microsoft.txt")
    )
    // Log every waning to the specified file.
    .WriteTo.Logger(logConfig => logConfig
        .Filter.ByIncludingOnly(e => e.Level == LogEventLevel.Warning)
        .WriteTo.File("C:\\Users\\tzuen\\Documents\\Privat\\logfile_warnings.txt")
    )
    // Log everything to the specified file and to the console.
    .WriteTo.File("C:\\Users\\tzuen\\Documents\\Privat\\logfile.txt")
    .WriteTo.Console()
    .ReadFrom.Configuration(ctx.Configuration));

builder.Services.AddControllers();


// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
