var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Hello world");
app.MapGet("/api/lenguajes", () => 
    {
        var lenguaje1= new Lenguajes("JAVA", "Java es un tipo de lenguaje de programación y una plataforma informática.Se constituye como un lenguaje orientado a objetos", "1995");
        var lenguaje2= new Lenguajes("C", "Lenguaje de programacion multiparadigma", "1999");

        var lenguajes= new List<Lenguajes>();
        lenguajes.Add(lenguaje1);
        lenguajes.Add(lenguaje2);

        return lenguajes;
    });

app.Run();
