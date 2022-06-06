using Microsoft.EntityFrameworkCore;

namespace backend.Models;

public class CharacterContext : DbContext
{
    public DbSet<CharacterModel> Characters { get; set; }

    public string DbPath { get; }

    public CharacterContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "finalfantasydb.sqlite3");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=FinalFantasy.db");
}

