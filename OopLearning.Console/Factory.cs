using OopLearning.BL.Inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.ConsoleProject
{
    class Factory
    {
        static Random rngNum = new Random();
        public static DocumentFileInfo CreateDocumentFileInfo()
        {
            return CreateDocumentFileInfo(CreateRandomFileSize());
        }

        public static DocumentFileInfo CreateDocumentFileInfo(int fileSize)
        {
            return CreateDocumentFileInfo(fileSize, CreateRandomDate());
        }

        public static DocumentFileInfo CreateDocumentFileInfo(int fileSize, DateTime creationTime)
        {
            return new DocumentFileInfo(CreateRandomFilename(), fileSize, creationTime);
        }

        public static ImageFileInfo CreateImageFileInfo()
        {
            return new ImageFileInfo("documentNumber" + rngNum.Next(1, 1000), rngNum.Next(1,40), new DateTime(2019, 05, 29), rngNum.Next(1,1900),rngNum.Next(1,1000));
        }

        public static ImageFileInfo CreateImageFileInfo(int fileSize)
        {
            return new ImageFileInfo("documentNumber" + rngNum.Next(1, 1000), fileSize, new DateTime(2019, 05, 29), rngNum.Next(1, 1900), rngNum.Next(1, 1000));
        }

        public static ImageFileInfo CreateImageFileInfo(int fileSize, DateTime createTime)
        {
            return new ImageFileInfo("documentNumber" + rngNum.Next(1, 1000), fileSize, createTime, rngNum.Next(1, 1900), rngNum.Next(1, 1000));
        }

        public static VideoFileInfo CreateVideoFileInfo()
        {
            return new VideoFileInfo("documentNumber" + rngNum.Next(1, 1000), rngNum.Next(1,40) ,new DateTime(2019,05,18), rngNum.Next(1, 1900), rngNum.Next(1, 1000),rngNum.Next(1,1000));
        }

        public static VideoFileInfo CreateVideoFileInfo(int duration)
        {
            return new VideoFileInfo("documentNumber" + rngNum.Next(1, 1000), rngNum.Next(1, 40), new DateTime(2019, 05, 18), rngNum.Next(1, 1900), rngNum.Next(1, 1000), duration);
        }
        public static VideoFileInfo CreateVideoFileInfo(int duration, int fileSize)
        {
            return new VideoFileInfo("documentNumber" + rngNum.Next(1, 1000), fileSize, new DateTime(2019, 05, 18), rngNum.Next(1, 1900), rngNum.Next(1, 1000), duration);
        }

        public static List<CustomFileInfo> CreateFileInfos(int number)
        {
            List<CustomFileInfo> listOfRandomFiles = new List<CustomFileInfo>();
            for (int i = 0; i < number; i++)
            {
                switch (rngNum.Next(1,4))
                {
                    case 1:
                        listOfRandomFiles.Add(CreateImageFileInfo());
                        break;
                    case 2:
                        listOfRandomFiles.Add(CreateDocumentFileInfo());
                        break;
                    case 3:
                        listOfRandomFiles.Add(CreateVideoFileInfo());
                        break; 
                    default:
                        break;
                }
            }
            return listOfRandomFiles;
        }

        private static DateTime CreateRandomDate()
        {
            return DateTime.Now;
        }

        private static string CreateRandomFilename()
        {
            return "Random";
        }

        private static int CreateRandomFileSize()
        {
            return 15;
        }
    }
}
