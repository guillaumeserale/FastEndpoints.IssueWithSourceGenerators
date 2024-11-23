using FastEndpoints;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddFastEndpoints(
                options => options.SourceGeneratorDiscoveredTypes.AddRange(DiscoveredTypes.All)
                );

            var app = builder.Build();

            app.UseFastEndpoints();

            app.Run();
        }
    }
}
