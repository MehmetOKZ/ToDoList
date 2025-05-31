using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapılacaklar listesine hoşgeldin.");
            List<string> görevlistesi = new List<string>();
            string secenek = "";

            while(secenek!="ç")
            {
                Console.WriteLine("Ne yapmak istersin?");
                Console.WriteLine("Listenize görev eklemek için 1 yazınız.");
                Console.WriteLine("Listeden görev çıkartmak için 2 yazınız.");
                Console.WriteLine("Listeyi görüntülemek için 3 yazınız.");
                Console.WriteLine("Çıkış yapmak için ç yazınız.");

                    secenek=Console.ReadLine();

                if (secenek == "1")
                {
                    Console.WriteLine("Lütfen eklemek istediğiniz görevin ismini giriniz.");
                    string görev = Console.ReadLine();

                    görevlistesi.Add(görev);
                    Console.WriteLine("Görev liseteye eklendi.");

                }
                else if (secenek == "2") {
                    for (int i = 0; i < görevlistesi.Count; i++)
                    {
                        Console.WriteLine(i + " : " + görevlistesi[i]);
                    }
                    Console.WriteLine("Lütfen listeden çıkartmak istediğini görevin numarasını seçiniz.");
                    int görevNumarası = Convert.ToInt32(Console.ReadLine());
                    görevlistesi.RemoveAt(görevNumarası);

                }
                else if (secenek == "3") {
                    Console.WriteLine("Listedeki mevcut görevleriniz : ");
                    for (int i = 0; i < görevlistesi.Count; i++)
                    {
                        Console.WriteLine(görevlistesi[i]);
                    }
                }
                else if (secenek == "ç")
                {
                    Console.WriteLine("Programdan çıkılıyor");
                }
                else
                {
                    Console.WriteLine("Geçersiz işlem, lütfen tekrar deneyin.");
                }

            }
        }
    }
}
