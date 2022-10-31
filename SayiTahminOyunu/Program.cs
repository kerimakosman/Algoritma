namespace SayiTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bilgisayar 4 basamakli rastgele rakamlari farkli sayi tutuyor.
            //kullanicinin ekrana girdiği sayinin içerisinde kaç tane basamğın doğru ve yerinlerin doğru olduğunu söylüyor.
            //Örneğin pc:1234 tuttu 
            //Kullanici :1456 olarak sayi girdi
            //2 tane basamak doğru(1ve4),  1 tanesininde yeri doğru(1)







            Random random = new Random();
            int rastgeleSayi = random.Next(1000, 10000);
            int girilensayi = 0, KacTane = 0, Yeri = 0, Deneme = 0;

            while (girilensayi != rastgeleSayi)
            {
                Console.WriteLine("Sayıyı Tahmin Et");
                girilensayi = Convert.ToInt16(Console.ReadLine());

                while (girilensayi.ToString().Length != 4)
                {
                    Console.WriteLine("Lütfen 4 Basamakli Sayi Giriniz");
                    girilensayi = Convert.ToInt16(Console.ReadLine());
                }

                for (int i = 0; i < rastgeleSayi.ToString().Length; i++)
                {
                    for (int j = 0; j < rastgeleSayi.ToString().Length; j++)
                    {
                        if (rastgeleSayi.ToString()[i] == girilensayi.ToString()[j])
                        {
                            KacTane++;
                            if (i == j)
                            {
                                Yeri++;
                            }
                        }
                    }
                }
                Deneme++;
                if (girilensayi != rastgeleSayi)
                {
                    Console.WriteLine($"{KacTane} adet rakamı dogru bildin bunlardan da \n{Yeri} tanesinin yeri doğru\n");
                }
                KacTane = 0;
                Yeri = 0;
            }

            Console.WriteLine($"TEBRİKLER {Deneme}. denemede buldunuz");
        }
    }
}