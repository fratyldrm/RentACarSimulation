using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Data;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;
using RentACarSimulation.ConsoleUI.Data;

namespace RentACar.ConsoleUI.Repository;

public class TransmissionRepository : IRepository<Transmission>
{
    private readonly List<Transmission> transmissions;

    public TransmissionRepository()
    {
        this.transmissions = new TransmissionData().GetAll();
    }

    public void Add(Transmission data)
    {
        transmissions.Add(data);
    }

    public void Delete(Transmission data)
    {
        transmissions.Remove(data);
    }

    public IEnumerable<Transmission> GetAll()
    {
        return transmissions;
    }

    public Transmission? GetById(int id)
    {
        return transmissions.SingleOrDefault(x => x.Id == id);
    }

    public void Update(Transmission data)
    {
        Console.WriteLine(data);
    }
}