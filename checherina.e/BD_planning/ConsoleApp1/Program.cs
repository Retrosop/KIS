using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace AirlineTicketSystem
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string PassportNumber { get; set; }
    }

    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal TicketPrice { get; set; }
    }

    public class Ticket
    {
        public int TicketId { get; set; }
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public DateTime BookingTime { get; set; }
    }

    public class AirlineDbContext : DbContext
    {
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=airline.db");
        }
    }
}
