using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Data;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;
using RentACarSimulation.ConsoleUI.Data;

namespace RentACar.ConsoleUI.Repository;


public class ColorRepository : IRepository<Color>
{
    private readonly List<Color> colors;

    public ColorRepository()
    {
        this.colors = new ColorData().GetAll();
    }

    public void Add(Color data)
    {
        colors.Add(data);
    }

    public void Delete(Color data)
    {
        colors.Remove(data);
    }

    public IEnumerable<Color> GetAll()
    {
        return colors;
    }

    public Color? GetById(int id)
    {
        return colors.SingleOrDefault(x => x.Id == id);
    }

    public void Update(Color data)
    {
        Console.WriteLine(data);
    }
}