namespace Vize_Final_Ort_Hesabi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen not 0 - 30 arasind ise "FF" 30 - 50 arasinda ise "DD" 50 - 70 ise "BB" 70 - 100 arasinda ise "AA" yazdirin.


            byte vize1, vize2, final;
            float ortalama;
            Console.WriteLine("1. Vize Notunu giriniz:");
            vize1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("2. Vize Notunu giriniz:");
            vize2 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Final Notunu giriniz:");
            final = Convert.ToByte(Console.ReadLine());

            ortalama = ((vize1 + vize2) / 2) * 0.3f + final * 0.7f;
            Console.WriteLine("Ortalama  :  " + ortalama);
            if (ortalama <= 30)
                Console.WriteLine("FF");
            else if (ortalama <= 50)
                Console.WriteLine("DD");
            else if (ortalama <= 70)
                Console.WriteLine("CC");
            else if (ortalama <= 85)
                Console.WriteLine("BB");
            else if (ortalama <= 100)
                Console.WriteLine("AA");
        }
    }
}