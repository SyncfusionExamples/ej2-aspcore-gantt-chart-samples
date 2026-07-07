var builder = WebApplication.CreateBuilder(args);

// ✅ Add services
builder.Services.AddRazorPages();

var app = builder.Build();

// ✅ Error handling
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

// ✅ Middleware
app.UseHttpsRedirection();

// ✅ REQUIRED for static files (JS/CSS/CDN fallback)
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ✅ Map Razor Pages
app.MapRazorPages();

app.Run();
