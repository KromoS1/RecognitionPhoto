using System.IO;
using System.Text;
using Vintasoft.Imaging.Ocr.Results;

namespace ProcessingAndSavingTheResults
{
    public class SaveResult :ISaveResult
    {
        public void Save(OcrPage ocrResult)
        {
            string ocrResultAsFormattedContent = ocrResult.GetFormattedText();
            var filePath = CreateFilePath();
            File.WriteAllText(filePath,ocrResultAsFormattedContent,Encoding.UTF8);
        }

        private string CreateFilePath()
        {
            var location = Directory.GetCurrentDirectory();
            var dirPath = Path.Combine(location, "dataFillings");
            Directory.CreateDirectory(dirPath);
            var filePath = Path.Combine(dirPath, "fillings.txt");
            return filePath;
        }
    }
}
