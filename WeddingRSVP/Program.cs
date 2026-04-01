using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Supabase;
using WeddingRSVP;
using WeddingRSVP.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var supabaseClient = new Client("https://giehgmtavjwnjwvckjbp.supabase.co", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImdpZWhnbXRhdmp3bmp3dmNramJwIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NzQ4MjQ3ODMsImV4cCI6MjA5MDQwMDc4M30.cJ-UFwWgUo-Z_68EKXEkz0e93UJFCdRZ7wohbBOlrdU");
await supabaseClient.InitializeAsync();

builder.Services.AddSingleton(supabaseClient);

builder.Services.AddScoped<GuestService>();


await builder.Build().RunAsync();
