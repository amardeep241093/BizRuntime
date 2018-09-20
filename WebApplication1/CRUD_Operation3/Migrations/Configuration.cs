namespace CRUD_Operation3.Migrations
{
    using CRUD_Operation3.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CRUD_Operation3.Models.RecordContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CRUD_Operation3.Models.RecordContext context)
        {
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var players = new List<Players>
          {
              new Players{Id= 201, Name= "Sachin Tendulkar", Country= "India", Sport= "Cricket", MedalWon = 200, MatchPlayed= 400 },
               new Players{Id= 202, Name= "Ricky Pointing", Country= "Australia", Sport= "Cricket", MedalWon = 100, MatchPlayed= 300 },
                new Players{Id= 203, Name= "Greame Smith", Country= "SouthAfrica", Sport= "Cricket", MedalWon = 80, MatchPlayed= 200 },
                 new Players{Id= 204, Name= "Sania Mirza", Country= "India", Sport= "Lawn Tennis", MedalWon = 30, MatchPlayed= 90 },
                  new Players{Id= 205, Name= "Dipika Pallikal", Country= "India", Sport= "Squash", MedalWon = 35, MatchPlayed= 55 },
                   new Players{Id= 206, Name= "Le chong", Country= "Malaysia", Sport= "Badminton", MedalWon = 65, MatchPlayed= 80 },
                   new Players{Id= 207, Name= "PV Sindhu", Country= "India", Sport= "Badminton", MedalWon = 20, MatchPlayed= 47 },
                  new Players{Id= 208, Name= "Deepika kumari", Country= "India", Sport= "Archery", MedalWon = 25, MatchPlayed= 35 },
                   new Players{Id= 209, Name= "Abhinav Bindra", Country= "India", Sport= "Shooting", MedalWon = 77, MatchPlayed= 100 },
                   new Players{Id= 209, Name= "Eoin Morgan", Country= "England", Sport= "Cricket", MedalWon = 12, MatchPlayed= 20 },

          };
            players.ForEach(list => context.players.Add(list));
            context.SaveChanges();
            //PM> add-migration initial   //Run this
            //update-database (Run this also in the package Manager Console)
        }
    }
}
