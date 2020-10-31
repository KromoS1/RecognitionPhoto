using Vintasoft.Imaging.Ocr;
using Vintasoft.Imaging.Ocr.Tesseract;

namespace RecognitionText
{
    public class SettingsRecognition : ISettingsRecognition
    {
        TesseractOcrSettings ISettingsRecognition.Settings()
        {
            OcrLanguage language = OcrLanguage.Russian;
            TesseractOcrSettings setting = new TesseractOcrSettings(language);
            return setting;
        }
    }
}
