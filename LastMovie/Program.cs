var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
pattern: "{controller=MyHomeMovie}/{action=HomePage}/{id?}");
//pattern: "{controller=Login}/{action=LoginPage}/{id?}");
//pattern: "{controller=User}/{action=User_ForgotPassword}/{id?}");
//pattern: "{controller=Master}/{action=Master_All_Message}/{id?}");
//pattern: "{controller=Seller}/{action=Seller_AddProduct}/{id?}");
//pattern: "{controller=MyMovieProduct}/{action=Product_Home}/{id?}");

app.Run();
