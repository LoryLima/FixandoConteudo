



using Interface.Entities;
using Interface.Services;
using System.Globalization;

Console.WriteLine("Enter rental data");
Console.Write("Car model: ");
string carModel = Console.ReadLine();
Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Return (dd/MM/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
CarRental carRental = new CarRental(start, finish, new Vehicle(carModel));
Console.Write("Enter price per hour: ");
double priceHour = double.Parse(Console.ReadLine());
Console.Write("Enter price per day: ");
double priceDay = double.Parse(Console.ReadLine());

RentalService rentalService = new RentalService(priceHour, priceDay, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine(carRental.Invoice);
