using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UniversityManager.Views;
using System.Windows;

namespace UniversityManager.Converters
{
    public class ImageConverter
    {
        string _imagePath;

        public ImageConverter(string imagePath)
        {
            _imagePath = imagePath;
        }

        public string GetRelativePath()
        {
            return $@"..\Resources\{Path.GetFileName(_imagePath)}";
        }

        public void LoadImage()
        {
            var currentDir = Environment.CurrentDirectory;
            var fileName = DateTime.Now.Ticks + "_" + Path.GetFileName(_imagePath);
            var cloneFilePath = Path.Combine(currentDir, "Resources", fileName);

            File.Copy(_imagePath, cloneFilePath);
        }
    }
}
