using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderAndFileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------- KLASÖR OLUŞTURMA ------------- 

            //string path = @"C:\Users\LENOVO\Desktop\C# Uygulamaları\KT\";
            //string FolderName = "kt1";
            //Console.WriteLine("Klasör Oluşturmak İçin Bir Tuşa Basınız.");
            //Console.ReadLine();

            //if (!Directory.Exists(path+FolderName)) {
            //Directory.CreateDirectory(path+FolderName);
            //    Console.WriteLine(FolderName + " Adlı Klasör Oluştu");
            //}
            //else
            //{
            //    Console.WriteLine(FolderName + " Adlı Klasör Var Olduğundan Dolayı Klasör Oluşturma İşlemi Gerçekleştirilemedi.");
            //}
            //Console.ReadLine() ;

            // ------------- DOSYA OLUŞTURMA VE YAZMA ------------- 

            //string path = @"C:\Users\LENOVO\Desktop\C# Uygulamaları\KT\";
            //string FileName = "Writes.txt";

            //File.WriteAllText(path+FileName, " Merhaba Dünya");

            //if (!File.Exists(path+FileName)) //Dosya yoksa dosya oluştur ve yaz
            //{
            //    File.WriteAllText(path+FileName, " Merhaba Arkadaşlar");
            //}
            //Console.ReadLine();


            // ------------- DOSYA OKUMA ------------- 

            string path = @"C:\Users\LENOVO\Desktop\C# Uygulamaları\KT\";
            string FileName = "Writes.txt";

            if (File.Exists(path + FileName)) { 
            string OkunanVeri = File.ReadAllText(path + FileName);
            Console.WriteLine(OkunanVeri);
            }
            else
            {
                Console.WriteLine("Dosya Bulunamadı.");
            }













            //
            Console.ReadLine();
        }
    }
}
