namespace RentACar.ConsoleUI.Model;

public class Car
{
    public int Id { get; set; }
    public int ColorId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string CarState { get; set; }
    public int? KiloMeter { get; set; }
    public short? ModelYear { get; set; }
    public string? Plate { get; set; }
    public string? BrandName { get; set; }
    public string? ModelName { get; set; }
    public double? DailyPrice { get; set; }

    public override string ToString()
    {
        return $"Araç Detayları:\n" +
       $"- ID: {Id}\n" +
       $"- Marka: {BrandName ?? "Bilinmiyor"}\n" +
       $"- Model: {ModelName ?? "Bilinmiyor"}\n" +
       $"- Renk ID: {ColorId}\n" +
       $"- Yakıt Türü ID: {FuelId}\n" +
       $"- Vites Türü ID: {TransmissionId}\n" +
       $"- Durum: {CarState}\n" +
       $"- Kilometre: {KiloMeter?.ToString() ?? "Belirtilmedi"}\n" +
       $"- Model Yılı: {ModelYear?.ToString() ?? "Belirtilmedi"}\n" +
       $"- Plaka: {Plate ?? "Belirtilmedi"}\n" +
       $"- Günlük Fiyat: {DailyPrice?.ToString("C") ?? "Belirtilmedi"}";

    }
}