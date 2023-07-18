using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _66666
{
    internal class Program
    {
        static void Shuffle(List<string> list)
        {
            Random rnd = new Random();

            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);

                string temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

            static void Main(string[] args)
        {
                List<string> personel = new List<string>() { "furkan", "oguz", "can", "ayşe", "ali", "berk" };
                List<string> isler = new List<string>() { "alış", "satış", "listeleme", "temizlik", "geliştirme", "pazarlama" };

                Dictionary<string, string> sonuc = new Dictionary<string, string>();

                Dictionary<string, List<string>> gecmis = new Dictionary<string, List<string>>();

                foreach (string p in personel)
                {
                    gecmis.Add(p, new List<string>());
                }

                for (int gun = 1; gun <= 6; gun++)
                {
                    Shuffle(isler);

                    for (int i = 0; i < personel.Count; i++)
                    {
                        while (gecmis[personel[i]].Contains(isler[i]))
                        {
                            Shuffle(isler);
                        }

                        sonuc.Add(personel[i], isler[i]);

                        gecmis[personel[i]].Add(isler[i]);
                    }

                    Console.WriteLine($"{gun}. Gün ");
                    foreach (var pair in sonuc)
                    {
                        Console.WriteLine($"{pair.Key} - {pair.Value}");
                    }
                    Console.WriteLine();

                    sonuc.Clear();
                }
            Console.ReadLine();
        }
    }
}
