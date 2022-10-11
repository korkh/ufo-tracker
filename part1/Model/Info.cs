using System;
namespace part1.Model
{
    public class Info
    {
        public int Id { get; set; }  // med Id som variabel blir dette en autoincrement i databasen (pr. default).
        public string Date { get; set; }
        public string Country { get; set; }
        public string Shape { get; set; }
        public string Duration { get; set; }
        public string Describtion { get; set; }

    }
}
