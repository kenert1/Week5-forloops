using System;

namespace CalculatinSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kolm arvu;
            //programm kuvab nende arvude summat

            Console.WriteLine("Palun sisesta kolm arvu");
           

            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                sum = sum + userNumber;
            }

            Console.WriteLine($"Your result is {sum}.");


           

            
           
                
        

            
            
        }
    }
}
