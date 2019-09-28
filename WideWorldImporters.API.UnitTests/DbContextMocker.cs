using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WideWorldImporters.API.Models;

namespace WideWorldImporters.API.UnitTests
{
    namespace WideWorldImporters.API.UnitTests
    {
        public static class DbContextMocker
        {
            public static WideWorldImportersDbContext GetWideWorldImportersDbContext(string dbName)
            {
                // Create options for DbContext instance
                var options = new DbContextOptionsBuilder<WideWorldImportersDbContext>()
                    .UseInMemoryDatabase(databaseName: dbName)
                    .Options;

                // Create instance of DbContext
                var dbContext = new WideWorldImportersDbContext(options);

                // Add entities in memory
                dbContext.Seed();

                return dbContext;
            }
        }
    }
}
