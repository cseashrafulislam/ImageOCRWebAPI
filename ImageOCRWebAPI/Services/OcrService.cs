using Tesseract;

namespace ImageOCRWebAPI.Services
{
    public class OcrService
    {
        public string ExtractTextFromImage(string imagePath)
        {
            var tessDataPath = Path.Combine(Directory.GetCurrentDirectory(), "Tesseract");

            using var engine = new TesseractEngine(tessDataPath, "eng", EngineMode.Default);
            using var img = Pix.LoadFromFile(imagePath);
            using var page = engine.Process(img);
            return page.GetText();
        }

    }
}
