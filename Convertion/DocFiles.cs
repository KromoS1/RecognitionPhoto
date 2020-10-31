using System.Data;
using System.IO;
using Data;
using ExcelLibrary;

namespace Convertion
{
    public class DocFiles : IDocFiles
    {

        public void SaveDoc(Fillings filling)
        {
            var filePath = CreatePath();
            if (File.Exists(filePath))
            {
                var content = File.ReadAllText(filePath);
                using (var stream = File.Open(filePath,FileMode.Append,FileAccess.ReadWrite))
                {
                    var tableFillings = ReadFiles();
                    
                }
            }
        }

        public DataTable ReadFiles()
        {
            var filePath = CreatePath();
            return null;
        }

        private string CreatePath()
        {
            var location = Directory.GetCurrentDirectory();
            var dirPath = Path.Combine(location, "Fillings");
            Directory.CreateDirectory(dirPath);
            var filePath = Path.Combine(dirPath, "fillings.xlsx");
            return filePath;
        }

    }
}
