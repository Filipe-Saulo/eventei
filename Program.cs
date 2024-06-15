namespace eventei
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //adicionar services antes do biulder
            builder.Services.AddControllers();
            //adiciona permissao de politica de cors
            builder.Services.AddCors(options => 
            {
                options.AddPolicy("MyCors", builder => 
                {
                    builder
                    .WithOrigins("http://localhost:4200")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });


            var app = builder.Build();

            //utiliza a permissao
            app.UseCors("MyCors");

            //adicionar o mapping depois do biulder
            app.MapControllers();


            //ao iniciar a depuracao se tiver com /, redireciona para o /api/login
            app.MapGet("/", () =>
            {
                return Results.Redirect("/api/Login");

            });

            app.Run();
        }
    }
}
