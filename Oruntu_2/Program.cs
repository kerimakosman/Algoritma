namespace Oruntu_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ekrana 10 değeri yazdırıldığında aşağıdaki gibi görüntü gelsin..
            //       .         #
            //       .        ##
            //       .       ###
            //       .      ####
            //       .     #####
            //       .    ######
            //       .   #######
            //       .  ########
            //       . #########
            //       .##########


            Console.Write("Satır Sayini Giriniz  : ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                for (int k = 1; k < n - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}