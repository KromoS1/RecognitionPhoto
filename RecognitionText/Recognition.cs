using ProcessingAndSavingTheResults;
using Vintasoft.Imaging;
using Vintasoft.Imaging.Ocr.Results;
using Vintasoft.Imaging.Ocr.Tesseract;

namespace RecognitionText
{
    public class Recognition : IRecognition
    {
        private readonly IResultsEditor _editor;

        public Recognition(IResultsEditor editor)
        {
            _editor = editor;
        }

        public void Recognize(TesseractOcrSettings settings, VintasoftImage image)
        {
            using (TesseractOcr tesseractOcr = new TesseractOcr())
            {
                tesseractOcr.Init(settings);
                tesseractOcr.SetImage(image);
                OcrPage ocrResult = tesseractOcr.Recognize();
                _editor.EditorResult(ocrResult);
            }
        }
    }
}
