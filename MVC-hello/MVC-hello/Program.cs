var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//Projenin ne tarz olaca��n� tan�mlar


var app = builder.Build();

//projeye uri �zerinden nas�l istek at�laca��n� tan�mlanmas� gerekiyor

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}" //-> pattern bu projeye hangi formatta istek at�laca��n� belirler
    // = index diyerek hi� bir controller ve index ad� verilmezse otomatik at�lacak yeri g�sterir.
        //Default Routing
    );

app.Run();
