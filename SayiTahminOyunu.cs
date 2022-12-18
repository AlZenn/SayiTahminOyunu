using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace SayiTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi tahmin oyununa hoş geldiniz.");
            Console.WriteLine("* *\n***\n *\n\n");
            Thread.Sleep(1000);
            
            int hak = 5;
            Random random = new Random();
            int sayi = random.Next(1,100);
            while (true)
            {
                while (hak>0)
                {
                    Console.WriteLine("Tuttuğum sayıyı TAHMİN ET!\nİPUCU: Tuttuğum sayı 1 ile 100 arasında.");
                    int tahmin = Convert.ToInt32(Console.ReadLine());
                    if (tahmin > sayi)
                    {
                        hak--;
                        Console.WriteLine("Yanlış tahmin! Yazdığın sayıdan daha küçük bir sayı tuttum.\n" + hak + " hakkın kaldı.");
                    }
                    else if (tahmin < sayi)
                    {
                        hak--;
                        Console.WriteLine("Yanlış tahmin! Yazdığın sayıdan daha büyük bir sayı tuttum.\n" + hak + " hakkın kaldı.");
                    }

                    else
                    {
                        Console.WriteLine("Doğru bildin! Tekrar oynayalım mı? evet ise 1 hayır ise 0 yaz");
                        int a = Convert.ToInt32(Console.ReadLine());
                        if (a == 1)
                        {
                            hak = 5; sayi = random.Next(1, 100);
                        }
                        else if (a == 0)
                        {
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                while(hak == 0)
                {
                    Console.WriteLine("Hakkın kalmadı tekrar oynayalım mı?");
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (b == 1)
                    {
                        hak = 5; sayi = random.Next(1, 100);
                    }
                    else if (b == 0)
                    {
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                if (hak == 0) { break; }
            }


            Console.ReadKey();
        }
    }
}
