using bookshop;
using bookshop.Components;
using Syncfusion.Blazor;
using Microsoft.EntityFrameworkCore;
using System;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<BookshopDbContext>(options =>
        options.UseSqlite("Data Source=users.db"));

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        builder.Services.AddSyncfusionBlazor();
        builder.Services.AddSingleton<CartService>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();
        BooksAPI apiB = new BooksAPI();

        var genres = await apiB.GetAllBooks();
       //Console.WriteLine(genres.Take(5).ToString());
        genres.Take(5).ToList().ForEach(book => { Console.WriteLine($"Title : {book.Genre}"); });

        app.Run();
    }
}