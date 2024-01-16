using System;
namespace UcgenCizme
{
    class Program
    {
        public static void Main(string[] args)
        {
            Islemler islemler;

        Basla:
            Console.WriteLine("***Girilen bouta gore ucgen cizme***");
            Console.WriteLine("Girmek istediginiz ucgen boyutunun uzunlugunu giriniz");
            Console.WriteLine("**************");

            if (!islemler.GirdiAl())
            {
                goto Basla;
            }

            switch (islemler.TekrarMi())
            {
                case 1:
                    goto Basla;
                case 0:
                    break;
            }
        }
    }
}