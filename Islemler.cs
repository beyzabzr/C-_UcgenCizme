using System;
namespace UcgenCizme
{
    struct Islemler
    {
        internal bool GirdiAl()
        {
            try
            {
                int uzunluk = Convert.ToInt32(Console.ReadLine());
                if (uzunluk < 1)
                {
                    throw new Exception();
                }

                new Ucgen(uzunluk);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Ucgenin uzunlugu için pozitif tam sayi giriniz.");
                System.Threading.Thread.Sleep(2000);
                return false;
            }
        }

        internal int TekrarMi()
        {
        Soru:
            Console.WriteLine("\nBaska bir ucegn cizdirmek istermisiniz?");
            Console.WriteLine("[E]Evet/[H]Hayir");
            switch (Console.ReadLine().ToLower())
            {
                case "e":
                    return 1;
                case "h":
                    return 2;
                default:
                    Console.WriteLine("Hatali secim yaptiniz lutfen tekrar deneyin.");
                    goto Soru;
            }


        }
    }
}