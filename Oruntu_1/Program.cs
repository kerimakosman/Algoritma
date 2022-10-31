namespace Oruntu_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3ve5in katı=KerimAkosman, 3ün katı Kerim, 5in katı=Akosman, harici i nin kendisini console yazdır

            Console.WriteLine("Lütfen Bir Sayi Giriniz :");
            int girilensayi = int.Parse(Console.ReadLine());
            for (int i = 1; i <= girilensayi; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("KerimAkosman");
                else if (i % 3 == 0)
                    Console.WriteLine("Kerim");
                else if (i % 5 == 0)
                    Console.WriteLine("Akosman");
                else
                    Console.WriteLine(i);
            }

        }
    }
}