using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using part1.Model;

namespace part1.DAL
{
    public static class DB_init
    {
        public static void Init(IApplicationBuilder app)
        {
            using (var sScope = app.ApplicationServices.CreateScope())
            {
                var context = sScope.ServiceProvider.GetService<InfoContext>();

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var info1 = new Info { Date = "9/8/2022", Country = "USA/Gatlinburg", Shape = "Disk", Duration = "15 min", Describtion = "Bright round light appeared and disappeared shot into atmosphere then a bolt of lightning lit up sky. Aircraft appeared then disappeared light would get bright then dim would move quickly disappear then it shot straight up into atmosphere immediately following a bolt of lightning lit up sky then torrential downpour of rain and cell phone screen was affected" };
                var info2 = new Info { Date = "9/5/2022", Country = "United Kingdom/Wadebridge Cornwall", Shape = "Circle", Duration = "1 min", Describtion = "Wadebridge, Cornwall. Star like objects traveling at speed behind a circular shaped cloud. The cloud quickly morphed into a circular, hole shaped cloud and 1 of the points of light shot into it. Couldn't track it any further as it disappeared over the roof line. Whole experience/sighting was about one minute in length. BLOWN away by this. Happened about 5 a.m. in the morning of 6/102002 . 2nd sighting in about 2 months though last sighting very different. THIS was almost spooky. Something told me to go outside and last time the same happened. I think I may have some connection with The Phenomena." };
                context.Infoer.Add(info1);
                context.Infoer.Add(info2);
                context.SaveChanges();
            }
        }
    }
}
