using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReflectionPractice
{
    public class FileStreamer
    {
        public static string PathDirectoryDataFigure = Path.Combine("D:", "Степапка", "DEX", "Практические занятие", "ReflectionPractice", "ReflectionPractice", "ReflectionPractice", "DataBaseFigure");
        public static string PathFileDataFigure = Path.Combine("D:", "Степапка", "DEX", "Практические занятие", "ReflectionPractice", "ReflectionPractice", "ReflectionPractice", "DataBaseFigure", "DataBaseFigure.txt");
        public DirectoryInfo FigureDirectoryInfo = new DirectoryInfo(PathDirectoryDataFigure);

        public FileStreamer()
        {
            if (!FigureDirectoryInfo.Exists)
            {
                FigureDirectoryInfo.Create();
            }
        }

        public void WriteInFile(string dataForWrite)
        {
            using (FileStream fileStream = new FileStream(PathFileDataFigure, FileMode.Create))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(dataForWrite);
                fileStream.Write(array, 0, array.Length);
            }
        }
    }
}
