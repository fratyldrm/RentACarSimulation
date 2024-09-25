namespace RentACar.ConsoleUI.Model;

public class Transmission
{
    public Transmission(int v1, string v2)
    {
    }

    public int Id { get; set; }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"vites Detay:\n" +
               $"- ID: {Id}\n" +
               $"- Isim: {Name ?? "Bilinmiyor"}";
    }
}