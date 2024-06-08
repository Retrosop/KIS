using System;
using System.Linq;

namespace AirlineTicketSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AirlineDbContext db = new AirlineDbContext())
            {
                // Добавление записей в таблицу Passengers
                Passenger passenger1 = new Passenger
                {
                    FirstName = "Иван",
                    LastName = "Иванов",
                    Age = 30,
                    PassportNumber = "AB123456"
                };

                db.Passengers.Add(passenger1);
                db.SaveChanges();

                // Изменение имени пассажира
                Passenger passengerToUpdate = db.Passengers.SingleOrDefault(p => p.PassengerId == 1);
                if (passengerToUpdate != null)
                {
                    passengerToUpdate.FirstName = "Петр";
                    db.SaveChanges();
                }

                // Удаление пассажира с PassengerId = 1
                Passenger passengerToDelete = db.Passengers.SingleOrDefault(p => p.PassengerId == 1);
                if (passengerToDelete != null)
                {
                    db.Passengers.Remove(passengerToDelete);
                    db.SaveChanges();
                }

                // Вывод всех пассажиров
                var allPassengers = db.Passengers;
                foreach (var passenger in allPassengers)
                {
                    Console.WriteLine($"{passenger.FirstName} {passenger.LastName} - {passenger.Age} years old");
                }

                // Добавление записей в таблицу Flights
                Flight flight1 = new Flight
                {
                    FlightNumber = "AA123",
                    DepartureCity = "New York",
                    DestinationCity = "Los Angeles",
                    DepartureTime = DateTime.Now,
                    ArrivalTime = DateTime.Now.AddHours(5),
                    TicketPrice = 250
                };

                db.Flights.Add(flight1);
                db.SaveChanges();

                // Добавление записей в таблицу Tickets
                Ticket ticket1 = new Ticket
                {
                    PassengerId = 2, // предположим, что у пассажира с Id = 2 был куплен билет на рейс
                    FlightId = 1,    // предположим, что рейс с Id = 1
                    BookingTime = DateTime.Now
                };

                db.Tickets.Add(ticket1);
                db.SaveChanges();

                // Вывод всех билетов
                var allTickets = db.Tickets;
                foreach (var ticket in allTickets)
                {
                    Console.WriteLine($"Passenger: {ticket.Passenger.FirstName} {ticket.Passenger.LastName}, Flight: {ticket.Flight.FlightNumber}, Booking Time: {ticket.BookingTime}");
                }
            }
        }
    }
}
