using HabitFlow.Api.Database;
using Microsoft.EntityFrameworkCore;

namespace HabitFlow.Api.Extensions;

public static class DatabaseExtentions
{
    public static async Task ApplyMigraionsAsync(this WebApplication app)
    {
        using IServiceScope scope = app.Services.CreateScope();

        await using ApplicationDbContext dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        try
        {
            await dbContext.Database.MigrateAsync();

            app.Logger.LogInformation("Database migrations applied successfully.");
        }
        catch (Exception ex)
        {
            app.Logger.LogError(ex, "An error occured while applying database migrations");

            throw;
        }
    }
}
