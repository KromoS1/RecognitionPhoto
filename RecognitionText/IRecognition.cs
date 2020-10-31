using Vintasoft.Imaging.Ocr.Tesseract;
using Vintasoft.Imaging;

namespace RecognitionText
{
    public interface IRecognition
    {
        void Recognize(TesseractOcrSettings settings, VintasoftImage image);
    }
}
