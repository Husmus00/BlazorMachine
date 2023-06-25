using BlazorMachine;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorMachine
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }

    public class Console
    {
        public static void WriteLine()
        {
            Pages.Machine.outputText += Environment.NewLine;
        }

        public static void WriteLine(string output)
        {
            Pages.Machine.outputText += (output + Environment.NewLine);
        }

        public static void Write(string output)
        {
        }

        public static void Clear()
        {
        }

        public static void ReadKey()
        {

        }

        public static string ReadLine()
        {
            return "";
        }
    }
}