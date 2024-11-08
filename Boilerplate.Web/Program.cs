using Boilerplate.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.AddNpgsqlDbContext<BoilerplateDbContext>(connectionName: "postgresdb");

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();