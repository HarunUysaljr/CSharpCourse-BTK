var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//Projenin ne tarz olacaðýný tanýmlar


var app = builder.Build();

//projeye uri üzerinden nasýl istek atýlacaðýný tanýmlanmasý gerekiyor

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}" //-> pattern bu projeye hangi formatta istek atýlacaðýný belirler
    // = index diyerek hiç bir controller ve index adý verilmezse otomatik atýlacak yeri gösterir.
        //Default Routing
    );

app.Run();
