var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Use(async (context, next) =>
{
    // 1. Adicionar o Access-Controle-Allow-Origin para a requisição preflight e requisição normal
    context.Response.Headers.Append("Access-Control-Allow-Origin", "*");
    
    // 2. tratar a requisição preflight
    if (HttpMethods.IsOptions(context.Request.Method))
    {
        // 3. Permitir métodos ou headers não padrões
        context.Response.Headers.Append("Access-Control-Allow-Methods", "*");
        context.Response.Headers.Append("Access-Control-Allow-Headers", "*");
        
        context.Response.StatusCode = StatusCodes.Status204NoContent;
        await context.Response.CompleteAsync();
        return;
    }
    await next.Invoke();
});

// Exemplo de configuração do CORS através do middleware padrão do ASP.NET Core
// app.UseCors(cfg =>
// {
//     cfg.AllowAnyOrigin();
//     cfg.AllowAnyMethod();
//     cfg.AllowAnyHeader();
// });

app.MapGet("/", () => "Hello World!");
app.MapPost("/", () => "Hello World!");
app.MapPut("/", () => "Hello World!");

app.Run();
