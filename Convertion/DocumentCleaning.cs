using System;
using Vintasoft.Imaging;
using Vintasoft.Imaging.ImageProcessing;
using Vintasoft.Imaging.ImageProcessing.Document;

namespace Convertion
{
    public class DocumentCleaning
    {
        private string pathImage = "G:\trenningC#";

        public void Cleaning()
        {
            using (ImageCollection images = new ImageCollection())
            {
                images.Add(pathImage+"photo.jpg");

                try
                {
                    try
                    {
                        foreach (VintasoftImage image in images)
                        {
                            ExecuteCommand(new AutoInvertCommand(), image); //invert an image if image is inverted
                            ExecuteCommand(new BorderClearCommand(), image); //clear noise on a border of the image
                            ExecuteCommand(new HalftoneRemovalCommand(), image); //remove halftone from the image
                            ExecuteCommand(new DeskewCommand(), image); // detect the correct orientation of the image
                            ExecuteCommand(new HolePunchRemovalCommand(), image); // remove hole punches on image
                            ExecuteCommand(new LineRemovalCommand(LinesType.Tables), image); //remove tables on image
                            ExecuteCommand(new AutoTextInvertCommand(),
                                image); // invert inverted text regions on an image
                            ExecuteCommand(new DespeckleCommand(), image); // remove noise from the image
                            ExecuteCommand(new BorderRemovalCommand(), image); // remove border around the image
                        }
                    }
                    catch (ImageProcessingException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }

                    images.SaveAsync(pathImage + "image.tif");
                }
                finally
                {
                    images.ClearAndDisposeItems();
                }
            }
        }

        public void ExecuteCommand(ProcessingCommandBase command, VintasoftImage image)
        {
            command.Progress += new EventHandler<ImageProcessingProgressEventArgs>(command_Progress);
            command.ExecuteInPlace(image);
            command.Progress -= new EventHandler<ImageProcessingProgressEventArgs>(command_Progress);
        }

        private void command_Progress(object sender, ImageProcessingProgressEventArgs e)
        {
            throw new NotImplementedException();
        }


    }
}
