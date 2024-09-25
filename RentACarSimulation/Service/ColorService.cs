using RentACarSimulation.ConsoleUI.Data;
using System.Xml.Linq;
using RentACar.ConsoleUI.Model;

namespace RentACar.ConsoleUI.Service
{
    internal class ColorService
    {
        private readonly ColorData _colorData = new ColorData();

        public void GetAllColors()
        {
            List<Color> colors = _colorData.GetAll();

            if (colors == null || colors.Count == 0)
            {
                Console.WriteLine("Hiçbir renk bulunamadı.");
                return;
            }

            foreach (Color color in colors)
            {
                Console.WriteLine(color);
            }
        }

        public void GetColorById(int id)
        {
            Color? color = _colorData.GetAll().FirstOrDefault(c => c.Id == id);

            if (color is null)
            {
                Console.WriteLine($"Aradığınız Id'ye göre renk bulunamadı: {id}");
                return;
            }

            Console.WriteLine(color);
        }

        public void DeleteColor(int id)
        {
            List<Color> colors = _colorData.GetAll();

            if (colors == null || colors.Count == 0)
            {
                Console.WriteLine("Hiçbir renk bulunamadı.");
                return;
            }

            Color? colorToDelete = colors.FirstOrDefault(c => c.Id == id);

            if (colorToDelete is null)
            {
                Console.WriteLine($"Renk Bulunamadı: Id= {id}");
                return;
            }

            // Renk silme işlemi burada yapılacak
            colors.Remove(colorToDelete);
            Console.WriteLine("Renk Silindi.");
            Console.WriteLine(colorToDelete);
        }
    }
}
