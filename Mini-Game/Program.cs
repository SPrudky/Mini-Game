using System;

namespace Mini_Game
{
    class Program
    {
        static void Main(string[] args)
         
        {
            int tipcislo;
            bool neuhodl = true;
            Random random = new Random();
            int nahcislo = random.Next( 1, 1000 );
            Console.WriteLine(" Hádání čísel");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Vyber si režim");
            Console.WriteLine("1.(1-10)");
            Console.WriteLine("2.(1-100");
            Console.WriteLine("3.(1-1000");

                
                
           
            
            
            
            
            
            
            
            Console.WriteLine($"Myslím si číslo od 1 do 1000");
            

           
            while (neuhodl)
            {
                Console.Write("Typni hodnotu:");
                tipcislo = int.Parse(Console.ReadLine());
                if (tipcislo > nahcislo)
                {
                    Console.WriteLine("To je moc");
                }
                else if (tipcislo < nahcislo)
                {
                    Console.WriteLine("To je málo");
                }
                else
                {
                    Console.WriteLine("Trefa");
                    neuhodl = false;
                
                }

               
            }
        }
    }
}
