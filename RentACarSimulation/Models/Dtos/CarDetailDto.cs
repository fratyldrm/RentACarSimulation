using System.Numerics;

namespace RentACar.ConsoleUI.Model.Dto;

public class CarDetailDto
{
    public int Id { get; set; }
    public string? FuelName { get; set; }
    public string? TransmissionName { get; set; }
    public string? ColorName { get; set; }
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
              $"- Marka: {FuelName ?? "Bilinmiyor"}\n" +
              $"- Model: {ModelName ?? "Bilinmiyor"}\n" +
              $"- Renk: {ColorName ?? "Bilinmiyor"}\n" +
              $"- Yakıt: {FuelName ?? "Bilinmiyor"}\n" +
              $"- Vites: {TransmissionName ?? "Bilinmiyor"}\n" +
              $"- Durum: {CarState}\n" +
              $"- Kilometre: {KiloMeter?.ToString() ?? "Belirtilmedi"}\n" +
              $"- Model Yılı: {ModelYear?.ToString() ?? "Belirtilmedi"}\n" +
              $"- Plaka: {Plate ?? "Belirtilmedi"}\n" +
              $"- Günlük Fiyat: {DailyPrice?.ToString("C") ?? "Belirtilmedi"}";
    }












        

}