var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
else
{
    // using https
    app.UseHsts();
}

app.UseRouting();

    // all request https
app.UseHttpsRedirection();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapRazorPages();

//app.MapGet("/", () => "Hello World!");
app.UseEndpoints(endpoint => {
    //endpoint.MapRazorPages();
});

app.Run();
