using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Common.Classes;

namespace Car_Rental.Data.Classes;
public class CollectionData : IData
{
    readonly List<IPerson> _persons = new List<IPerson>();
    readonly List<IVehicle> _vehicles = new List<IVehicle>();
    readonly List<IBooking> _bookings = new List<IBooking>();

    public CollectionData() => SeedData();

    void SeedData()
    {
        Customer customer1 = new("Alex", "Smith", 12345);
        Customer customer2 = new("Sandra", "Smith", 98765);
        Car car1 = new("ABC123", "Volvo", 10000, VehicleTypes.Combi, 1, 200);
        Car car2 = new("DEF456", "Saab", 22000, VehicleTypes.Combi, 1, 100);
        Car car3 = new("GHI789", "Tesla", 2000, VehicleTypes.Sedan, 3, 300);
        Car car4 = new("JKL321", "Jeep", 5000, VehicleTypes.Van, 1.5, 200);
        Motorcycle motorcycle = new("MNO654", "Yamaha", 6000, VehicleTypes.Combi, 1, 200);
        Bookning bookning1 = new(customer2, car4);
        Bookning bookning2 = new(customer1, car3);

        _persons.Add(customer1);
        _persons.Add(customer2);
        _vehicles.Add(car1);
        _vehicles.Add(car2);
        _vehicles.Add(car3);
        _vehicles.Add(car4);
        _vehicles.Add(motorcycle);
        _bookings.Add(bookning1);
        _bookings.Add(bookning2);

        bookning1.ReturnVehicle(car4, 100);


    }
    public IEnumerable<IBooking> GetBooking() => _bookings;

    public IEnumerable<IPerson> GetPersons() => _persons;

    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) => _vehicles;
}
