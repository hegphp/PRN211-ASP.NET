var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "Category Route",
    pattern: "/{controller=category}",
    defaults: new { action = "Index"}
    );

//app.MapControllerRoute(
//    name: "Product Route",
//    pattern: "/product/{action=list}/{cateId}"
//    );

//app.MapControllerRoute(
//    name: "Product Details Route",
//    pattern: "/product/{action=detail}/{productId}"
//    );

app.Run();
