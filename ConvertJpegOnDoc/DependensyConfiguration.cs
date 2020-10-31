using System;
using FilePreparation;
using Microsoft.Extensions.DependencyInjection;
using ProcessingAndSavingTheResults;
using RecognitionText;
using ThereWillBeSomethingLikeAWebForm;

namespace ConvertJpegOnXlsx
{
    public static class DependensyConfiguration
    {
        public static IServiceProvider BuildServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            return serviceCollection.BuildServiceProvider();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICleanupFile,CleanupFile>();
            services.AddSingleton<ISegmentationImages, SegmentationImages>();
            services.AddSingleton<IRecognition, Recognition>();
            services.AddSingleton<ISettingsRecognition, SettingsRecognition>();
            services.AddSingleton<IResultsEditor, ResultsEditor>();
            services.AddSingleton<ISaveResult, SaveResult>();
            services.AddSingleton<IInputImage, InputImage>();
        }

        private static void Configure()
        {

        }
    }
}
