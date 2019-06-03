using OopLearning.BL.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CustomFileInfo> AlistOfFiles = new List<CustomFileInfo>();
            AlistOfFiles = Factory.CreateFileInfos(35);

            int numberOfDocuments = 0;
            int numberOfImages = 0;
            int numberOfVideos = 0;

            foreach (CustomFileInfo file in AlistOfFiles)
            {
                switch (file)
                {
                    case DocumentFileInfo d:
                        numberOfDocuments++;
                        break;
                    case VideoFileInfo v:
                        numberOfVideos++;
                        break;
                    case ImageFileInfo i:
                        numberOfImages++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Number of documents: {numberOfDocuments}");
            Console.WriteLine($"Number of images: {numberOfImages}");
            Console.WriteLine($"Number of videos: {numberOfVideos}");
        }
    }
}
