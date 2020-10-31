using Vintasoft.Imaging;
using FilePreparation;

namespace ThereWillBeSomethingLikeAWebForm
{
    public class InputImage : IInputImage
    {
        private readonly ICleanupFile _cleanupFile;

        public InputImage()
        {
            
        }
        public InputImage(ICleanupFile cleanupFile)
        {
            _cleanupFile = cleanupFile;
        }

        public void Images()
        {
            string imagePath = @"G:\trenningC#\ConvertJpegOnDoc";
            ImageCollection collection = new ImageCollection();
            collection.Add(imagePath);
            _cleanupFile.CleaningImage(collection);
        }
    }
}
