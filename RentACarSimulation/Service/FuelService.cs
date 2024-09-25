using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;
using RentACar.ConsoleUI.Repository;

namespace RentACar.ConsoleUI.Service;

public class FuelService : IFuelService
{
    private readonly IRepository<Fuel> fuelRepository;

   
    public void Add(Fuel fuel)
    {
        fuelRepository.Add(fuel);
    }

    public void Delete(int id)
    {
        Fuel fuel = GetById(id);  // GetById already throws exception if not found
        fuelRepository.Delete(fuel);
    }

    public List<Fuel> GetAll()
    {
        return fuelRepository.GetAll().ToList();
    }

    public Fuel GetById(int id)
    {
        Fuel fuel = fuelRepository.GetById(id);

        if (fuel is null)
        {
            throw new ArgumentException("Fuel not found!");
        }

        return fuel;
    }

    public void Update(int id, string name)
    {
        Fuel fuel = GetById(id);  // GetById already throws exception if not found

        fuel.Name = name;

        fuelRepository.Update(fuel);
    }

    public Fuel? GetFuelByName(string name)
    {
        return fuelRepository.GetAll()
            .FirstOrDefault(fuel => string.Equals(fuel.Name, name, StringComparison.InvariantCultureIgnoreCase));
    }
}
