internal class Program {
    private static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);
        //config cac service ma ung dung se dung
        //1.
        builder.Services.AddControllersWithViews();
        //2. Dich vu gi khac nua thi add vao

        //Khoi dong app theo cac services da dang ky
        var app = builder.Build();
        //Config middleware pipeline
        //Config routing
        app.MapControllerRoute(
            name: "default",
            pattern: "/{controller=Product}/{action=Index}"
            );//Dinh nghia 1 pattern URL

        app.MapControllerRoute(
            name: "default1",
            pattern: "/{controller=Product}/{action=Index}/{id}/{name}"
            );//Dinh nghia 1 pattern URL

        app.MapControllerRoute(
            name: "orderRoute",
            pattern: "/{controller}/{action}/{id}"
            );

        app.MapControllerRoute(
            name: "orderRoute",
            pattern: "/{controller}/{action}/{from}/{to}"
            );

        app.Run();
    }
}