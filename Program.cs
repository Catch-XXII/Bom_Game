using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bom_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HoşGeLDiniz!!!. Lütfen bir BOM sayısı giriniz.");
            string BOM = Console.ReadLine();
            int _BOM = Convert.ToInt32(BOM);
            Console.WriteLine("Yasaklı sayı=" + BOM + "!!!" + " bundan sonra " + BOM + " ve katlarını söylemek yasak. " +
                              "\nHadi başlayalım -(^_^)-");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    string sk = Console.ReadLine();
                    int x = 0;
                    if (int.TryParse(sk, out x))
                    {
                        if (x != i)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Sayı saymayı öğren!!!");
                            break;
                        }
                        if (x % _BOM == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Ta Ta Ta \nÖldün Çık");
                            for (int j = 0; j < 5; j++)
                            {
                                for (int k = 0; k < 5; k++)
                                {
                                    Console.Write("! ");
                                }
                                Console.WriteLine("");
                            }
                            Console.WriteLine("");
                            break;
                        }
                    }
                    else
                    {
                        if (!(sk == "BOM" || sk == "bom"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("düzgün BOM yaz!!! \nOyun burada biter dostum...");
                            break;
                        }
                    }
                }
                else
                {
                    if (i % _BOM == 0)
                    {
                        Console.WriteLine("BOM");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }

                }
                if (i == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bravo! iyi oynadın...");
                }
            }
            Console.ReadLine();
        }
    }
}

// ˜”*°•.˜”*°• cüneyd gültekin kaya •°*”˜.•°*”˜
//              Ödev 1 v.4.0