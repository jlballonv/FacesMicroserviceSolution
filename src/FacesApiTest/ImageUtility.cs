using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacesApiTest
{
    public  class ImageUtility
    {
        public byte[] ConvertToBytes(string imagePath) 
        {
            MemoryStream ms = new MemoryStream();
            using (FileStream stream = new FileStream(imagePath, FileMode.Open)) 
            {
                stream.CopyTo(ms);
            }
            var bytes = ms.ToArray();
            return bytes;   
        }

        public void FromByteToImage(byte[] imagebytes, string fileName) 
        {
            using (var ms = new MemoryStream(imagebytes))
            {
                Image img = Image.FromStream(ms);
                img.Save(fileName + ".jpg", ImageFormat.Jpeg);
            }

        }
    }
}
