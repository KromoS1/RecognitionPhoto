using RecognitionText;
using Vintasoft.Imaging;
using Vintasoft.Imaging.ImageProcessing.Info;

namespace FilePreparation
{
    public class SegmentationImages :ISegmentationImages
    {
        private readonly IRecognition _recognition;
        private readonly ISettingsRecognition _settings;

        public SegmentationImages(IRecognition recognition, ISettingsRecognition settings)
        {
            _recognition = recognition;
            _settings = settings;
        }

        public void Segmentation(ImageCollection images)
        {
            foreach (VintasoftImage image in images)
            {
                DocumentSegmentationCommand segments = new DocumentSegmentationCommand();
                segments.ExecuteInPlace(image);
                var setting = _settings.Settings();
                _recognition.Recognize(setting, image);
            }//TODO: Сделать для колекции фото
        }
    }
}
