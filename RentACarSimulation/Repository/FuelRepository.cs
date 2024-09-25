using RentACar.ConsoleUI.Data;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;
using RentACarSimulation.ConsoleUI.Data;

namespace RentACar.ConsoleUI.Repository;


public class FuelRepository : IRepository<Fuel>
{
    private readonly List<Fuel> fuels;

    public FuelRepository()
    {
        this.fuels = new FuelData().GetAll();
    }

    public void Add(Fuel data)
    {
        fuels.Add(data);
    }

    public void Delete(Fuel data)
    {
        fuels.Remove(data);
    }

    public IEnumerable<Fuel> GetAll()
    {
        return fuels;
    }

    public Fuel? GetById(int id)
    {
        return fuels.SingleOrDefault(x => x.Id == id);
    }

    public void Update(Fuel data)
    {
        Console.WriteLine(data);
    }
}