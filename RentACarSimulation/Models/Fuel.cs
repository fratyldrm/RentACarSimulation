

namespace RentACar.ConsoleUI.Model;

public class Fuel
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"Yakıt Detay:\n" +
               $"- ID: {Id}\n" +
               $"- Isim: {Name ?? "Bilinmiyor"}";
    }
}