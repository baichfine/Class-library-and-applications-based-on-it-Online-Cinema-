using System.Data.Entity;

namespace ClassLibrary2
{
    public class Cinema
    {
        public int Id { get; set; }
        public string NameFilm { get; set; }
        public string duration { get; set; }
        public string genre { get; set; }
    }
    public class ChoiceHallAndDate
    {
        public int Id { get; set; }
        public string Hall { get; set; }
    }
    public class PriceFilm
    {
        public int Id { get; set; }
        public string PriceFilmSelect { get; set; }
    }
    public class Date
    {
        public int Id { get; set; }
        public string DateSelect { get; set; }
    }
    public class Place
    {
        public int Id { get; set; }
        public string PlaceSelect { get; set; }
    }
    public class Ticket
    {
        public int Id { get; set; }
        public string NameFilm { get; set; }
        public string PriceFilm { get; set; }
        public string Date { get; set; }
        public string Hall { get; set; }
        public string Place { get; set; }
        public string duration { get; set; }
        public string genre { get; set; }

    }
    public class UserContext : DbContext
    {
        public UserContext() : base("bd3") // имя будущей строки подключения к базе данных
        { }
 
        public DbSet<Cinema> Films { get; set; }
        public DbSet<ChoiceHallAndDate> Select { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<PriceFilm> Prices { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Place> Places { get; set; }
    }
}
