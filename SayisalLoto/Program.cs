namespace SayisalLoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] Loto = new int[6];
            int j = 0, adet = 0;
            int GirilenSayi = 0;
            int[] tahmin = new int[6];

            #region Birbirinden farklı 6 adet Loto sayısını yazdırdık.

            while (j < 6)
            {
                int i = 0;
                Loto[j] = random.Next(1, 50);
                while (i < 6)
                {
                    if (i != j)
                    {
                        if (Loto[j] == Loto[i])
                        {
                            Loto[j] = random.Next(1, 50);
                            i = -1;
                        }
                    }
                    i++;
                }
                j++;
            }

            #endregion


            #region Kullanicinin tahminleri.

            for (int k = 0; k < 6; k++)
            {
                Console.Write($"1den 49a kadar sayı giriniz\n {k + 1}.tahmin  :");
                GirilenSayi = int.Parse(Console.ReadLine());

                if (GirilenSayi <= 0 || GirilenSayi >= 50)
                {
                    Console.WriteLine("Girilen Deger 1-49 arasinda olmalidir");
                    k--;
                }
                else
                {
                    tahmin[k] = GirilenSayi;
                }
            }
            #endregion


            #region Kac sayi tutturdu.


            for (j = 0; j < 6; j++)
            {
                for (int k = 0; k < 6; k++)
                {
                    if (Loto[j] == tahmin[k])
                    {
                        Console.Write("TutanSayi  :" + Loto[j] + "\t");
                        adet++;
                    }
                }
            }
            Console.WriteLine($"{adet} adet bildiniz.");
            foreach (var loto in Loto)
            {
                Console.WriteLine(loto);
            }
            #endregion
        }
    }
}