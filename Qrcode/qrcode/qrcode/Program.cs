using System;
using System.Drawing;
using System.IO;
using QRCoder;

namespace qrcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Силка для генерації QR-кода:");
            string url = Console.ReadLine();

            // Генерация QR-кода
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Сохранение изображения в папке
            string folderPath = @"C:\QRCodeImages";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, "qrcode.png");
            qrCodeImage.Save(filePath);

            Console.WriteLine($"QR-код збережений: {filePath}");
        }
    }
}
