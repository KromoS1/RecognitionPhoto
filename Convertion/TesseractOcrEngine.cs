using Vintasoft.Imaging.Ocr;
using Vintasoft.Imaging.Ocr.Tesseract;

namespace Convertion
{
    public class TesseractOcrEngine
    {
        
        public void CreateTesseractEngine()
        {
         string tesseractOcrDllPath = @"G:\Programm\vintasoft\Bin\TesseractOCR";

         using (TesseractOcr tesseractOcr = new TesseractOcr(tesseractOcrDllPath))
         {
             OcrLanguage language = OcrLanguage.Russian;
             TesseractOcrSettings settings = new TesseractOcrSettings(language);
             tesseractOcr.Init(settings);

             tesseractOcr.Shutdown();
         }
        }
    }
}
