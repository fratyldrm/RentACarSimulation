using RentACar.ConsoleUI.Data;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;
using RentACarSimulation.ConsoleUI.Data;

namespace RentACar.ConsoleUI.Repository;


public class CarRepository : IRepository<Car>
{
    private readonly List<Car> cars;

    public CarRepository()
    {
        this.cars = new CarData().GetAll();
    }

    public void Add(Car data)
    {
        cars.Add(data);
    }

    public void Delete(Car data)
    {
        cars.Remove(data);
    }

    public IEnumerable<Car> GetAll()
    {
        return cars;
    }

    public Car? GetById(int id)
    {
        return cars.SingleOrDefault(x => x.Id == id);
    }

    public void Update(Car data)
    {
        Console.WriteLine(data);
    }
}