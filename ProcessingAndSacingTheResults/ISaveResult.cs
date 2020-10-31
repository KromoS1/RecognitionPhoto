using Vintasoft.Imaging.Ocr.Results;

namespace ProcessingAndSavingTheResults
{
    public interface ISaveResult
    {
        void Save(OcrPage ocrResult);
    }
}
