using RentACar.ConsoleUI.Model;

namespace RentACar.ConsoleUI.Data;

    public class TransmissionData
    {
        List<Transmission> transmissions = new List<Transmission>()
        {
            new Transmission(1, "Manuel"),
            new Transmission(2, "Otomatik"),
            new Transmission(3, "Yarı Otomatik"),
        };

        public List<Transmission> GetAll()
        {
            return transmissions;
        }
    }

