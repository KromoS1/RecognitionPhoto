using Vintasoft.Imaging;

namespace FilePreparation
{
    public interface ICleanupFile
    {
        void CleaningImage(ImageCollection images);
        void DeleteImageFromCollection(ImageCollection imageCollection);
    }
}
