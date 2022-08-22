using System;
using System.IO;

namespace DriveInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with DriveInfo *****\n");
            // Получить информацию обо всех устройствах.
            DriveInfo[] myDrives = DriveInfo.GetDrives();
            // Вывести сведения об устройствах.
            foreach (DriveInfo drive in myDrives)
            {
                Console.WriteLine("Name: {0}", drive.Name);
                Console.WriteLine("Type: {0}", drive.DriveType);
                // Проверить смонтировано ли устройство.
                if (drive.IsReady)
                {
                    Console.WriteLine("Free space: {0}", drive.TotalFreeSpace);
                    Console.WriteLine("Format: {0}", drive.DriveFormat);
                    Console.WriteLine("Label: {0}", drive.VolumeLabel);
                }
                Console.WriteLine();
            }
        }
    }
}
