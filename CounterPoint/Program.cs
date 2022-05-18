using CounterPoint.Extensions;
using CounterPoint.Middleware;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Repository.Persistence;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using System.Collections.ObjectModel;
using Utils;

public class Program
{
    public static void Main(string[] args)
    {
        SeriLogConfig();
        try
        {
            Builder(args);
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "API failed to start");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }

    private static void Builder(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<AffWeb_XYZContext>(x => x.UseSqlServer(Config.ConnectionString));
        builder.Services.AddDependency();
        builder.Services.AddControllersWithViews();
        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseMiddleware<SerilogMiddleware>();
        app.UseMiddleware<ErrorHandlerMiddleware>();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }

    private static void SeriLogConfig()
    {
        var columnOptions = new ColumnOptions()
        {
            AdditionalColumns = new Collection<SqlColumn>()
                    {
                        new SqlColumn("Endpoint",System.Data.SqlDbType.VarChar,dataLength:100),
                        new SqlColumn("Method",System.Data.SqlDbType.VarChar,dataLength:5),
                        new SqlColumn("QueryString",System.Data.SqlDbType.VarChar,dataLength:100),
                        new SqlColumn("RequestBody",System.Data.SqlDbType.VarChar),
                        new SqlColumn("User",System.Data.SqlDbType.VarChar)
                    }
        };
        columnOptions.Store.Remove(StandardColumn.Message);
        columnOptions.Store.Remove(StandardColumn.Properties);

        Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .WriteTo.MSSqlServer(
                connectionString: Utils.Config.ConnectionString,
                sinkOptions: new MSSqlServerSinkOptions()
                {
                    TableName = "Logs",
                    AutoCreateSqlTable = true,
                },
                columnOptions: columnOptions
                )
            .MinimumLevel.Override("Microsoft", LogEventLevel.Error)
            .CreateLogger();
    }
}



