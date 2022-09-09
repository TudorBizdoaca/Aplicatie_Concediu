using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_Concediu.Utils
{
    public static class ImgConvert
    {
        public static byte[] ConvertImageToByteArray(string imagePath)
        {
            byte[] imageByteArray = null;
            imageByteArray = File.ReadAllBytes(imagePath);
            return imageByteArray;
        }
    }
}
