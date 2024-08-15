
using System;
using System.IO;

namespace Chuong13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //vd
            Console.WriteLine("danh sach o dia tren may tinh: ");
            foreach (string iS in Directory.GetLogicalDrives())
            {
                Console.WriteLine("\t"+iS);
                
            }
            Console.WriteLine(@"su tontai cua thu muc C:\Temp: "+ Directory.Exists(@"C:\Temp"));

            StreamWriter sw = new StreamWriter("vidu.txt");
            sw.WriteLine("hello");
            sw.WriteLine(DateTime.Now);
            sw.Close();

            // mo stream
            FileStream fs = new FileStream("vidu.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string NoiDung = sr.ReadToEnd();
            Console.WriteLine(NoiDung);
            sr.Close();
            Console.ReadLine();

            //bt1
           
            //if (args.Length != 1)
            //{
            //    Console.WriteLine("Usage: FileCopy <destination_file_path>");
            //    return;
            //}

            //Console.Write("Enter the source file path: ");
            //string sourceFilePath = Console.ReadLine();
            //string destinationFilePath = args[0];

            //try
            //{
            //    File.Copy(sourceFilePath, destinationFilePath);
            //    Console.WriteLine($"File copied successfully from {sourceFilePath} to {destinationFilePath}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error copying file: {ex.Message}");
            //}


            //bt2
            string filePath = "sv.txt";
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Save to File");
                Console.WriteLine("2. Read File");
                Console.WriteLine("3. Exit");
                Console.Write("Your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SaveToFile(filePath);
                        break;
                    case "2":
                        ReadFile(filePath);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void SaveToFile(string filePath)
        {
            SinhVien sv = new SinhVien();

            Console.Write("Enter student name: ");
            sv.TenSV = Console.ReadLine();

            Console.Write("Enter student age: ");
            sv.TuoiSV = int.Parse(Console.ReadLine());

            Console.Write("Enter student score: ");
            sv.DiemSV = double.Parse(Console.ReadLine());

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(sv.ToString());
            }

            Console.WriteLine("Student information saved to file.");
        }

        static void ReadFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
