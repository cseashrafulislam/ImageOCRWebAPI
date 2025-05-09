using Tesseract;

namespace ImageOCRWebAPI.Services
{
    public class OcrService
    {
        //Download Dataset : https://github.com/tesseract-ocr/tessdata
        public string ExtractTextFromImage(string imagePath)
        {
            var tessDataPath = Path.Combine(Directory.GetCurrentDirectory(), "Tesseract");

            using var engine = new TesseractEngine(tessDataPath, "ben+eng", EngineMode.Default);
            using var img = Pix.LoadFromFile(imagePath);
            using var page = engine.Process(img);
            return page.GetText();
        }


    }
}
