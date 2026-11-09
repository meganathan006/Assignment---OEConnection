using Microsoft.EntityFrameworkCore;
using RL.Data;

namespace RL.Backend.UnitTests;

public static class DbContextHelper
{
    public static RLContext CreateContext(string name = "")
    {
        if (string.IsNullOrWhiteSpace(name))
            name = Guid.NewGuid().ToString();

        var dbContextOptions = new DbContextOptionsBuilder<RLContext>()
            .UseInMemoryDatabase(databaseName: name)
            .Options;

        return new RLContext(dbContextOptions);
    }
}