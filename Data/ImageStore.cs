using System.Drawing;
using System.Drawing.Imaging;

namespace scholarship_Application.Data
{
    public static class ImageStore
    {
        public static byte[]? ToBytes(Image? image)
        {
            if (image is null)
            {
                return null;
            }

            using var stream = new MemoryStream();
            image.Save(stream, ImageFormat.Png);
            return stream.ToArray();
        }

        public static Image? ToImage(byte[]? bytes)
        {
            if (bytes is null || bytes.Length == 0)
            {
                return null;
            }

            MemoryStream stream = new(bytes);
            return Image.FromStream(stream);
        }
    }
}
