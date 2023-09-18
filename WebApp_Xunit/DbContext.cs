using Microsoft.EntityFrameworkCore;
using System.Runtime;
using WebApp_Xunit.Models;

namespace WebApp_Xunit
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts) { }



        public DbSet<AirportInfo> airportinfo { get; set; }
        public DbSet<CityInfo> cityInfo { get; set; }
        public DbSet<FeedBack> FeedBack { get; set; }
        public DbSet<StateImg> StateImg { get; set; }
    }
}
