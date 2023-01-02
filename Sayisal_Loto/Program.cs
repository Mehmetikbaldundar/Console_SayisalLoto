using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayisal_Loto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sayısal loto uygulaması  **1-49 arası **rastgele 6 sayı hicbiri birbine aynı olmasın **kücükten büyüge sırala

            Random rnd = new Random();
            int[] sayisal = new int[6];


            Console.WriteLine("Kaç Kolon Oynamak istersiniz = ");
            int kolon = int.Parse(Console.ReadLine());

            for (int l = 0; l < kolon; l++)
            {
                for (int i = 0; i < sayisal.Length; i++)
                {
                    sayisal[i] = rnd.Next(1, 50);
                }

                for (int j = 0; j < sayisal.Length; j++)
                {
                    for (int k = 0; k < sayisal.Length; k++)
                    {
                        if (j != k && sayisal[j] == sayisal[k])
                        {
                            sayisal[j] = rnd.Next(1, 50);
                        }
                    }
                    Array.Sort(sayisal);
                    Console.Write(sayisal[j] + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Kolonlar başarıyla oluşturuldu. ");
            Console.ReadKey();
        }
    }
}
