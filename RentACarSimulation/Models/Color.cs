
namespace RentACar.ConsoleUI.Model;

public class Color
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"Renk Detay:\n" +
               $"- ID: {Id}\n" +
               $"- Isim: {Name ?? "Bilinmiyor"}";
    }
}