using ThereWillBeSomethingLikeAWebForm;


namespace ConvertJpegOnXlsx
   
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = DependensyConfiguration.BuildServiceProvider();

            InputImage image = new InputImage();
            image.Images();

        }
    }
}
